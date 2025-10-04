using AlphaUtil.Core;
using AlphaUtil.Core.Models;
using Microsoft.AspNetCore.Mvc;
using ComplyCrafter_BL;
using ComplyCrafter_Data;

namespace ComplyCrafter_API.Controllers
{
    [ApiController]
    //[Authorize]
    [Route("api/[controller]")]
    public class UserController : ApiController
    {
        private readonly IUser _user;

        public UserController(IUser user)
        {
            this._user = user;
        }

        [HttpGet]
        public IEnumerable<AppUserView> Get()
        {
            return _user.Get();
        }

        [HttpGet("{id}")]
        public AppUserView? GetById(int id = 0)
        {
            return _user.GetById(id);
        }

        [Authorize]
        [HttpGet("GetSubUser")]
        public IEnumerable<AppUserView> GetSubUserList(int id)
        {
            return _user.GetSubUserByParentId(User!.Id);
        }

        [Authorize(CompanyAdmin: true)]
        [HttpPost]
        public Response Save(AppUser obj)
        {
            var u = _user.GetByEmail(obj.Email);
            if (u != null && u.Id != obj.Id) return new Response(false, "Email already exists");
            u = _user.GetByMobile(obj.Mobile);
            if (u != null && u.Id != obj.Id) return new Response(false, "Mobile already exists");
            obj.Password = obj.Password?.A_Hash_SHA256().ToLower().Trim();
            obj.PreInsert(User!);
            if (obj._Role == AppRole.CompanyAdmin)
                obj.Password = "Pass@1234".A_Hash_SHA256();
            var r = _user.Save(obj);
            if (r.IsNull())
                return new Response(false, CONST.SaveError);

            if (CONST.SaveSuccess == "Saved Successfully" && obj.SignUpBy == "GoogleAuth")
            {
                var user = _user.GetByEmail(obj.Email);
                return new Response(true, "Authentication Successful", Auth.CreateSession(user.WithoutPassword()).Token());
            }

            return new Response(true, CONST.SaveSuccess, r!);
        }

        [HttpPost("RegisterUser")]
        public Response RegisterUser(AppUser obj)
        {
            var uE = _user.GetByEmail(obj.Email);
            if (uE != null) return new Response(false, "Email already exists");

            var uM = _user.GetByMobile(obj.Mobile);
            if (uM != null) return new Response(false, "Mobile already exists");

            if (string.IsNullOrEmpty(obj.Password))
                obj.Password = "Pass@1234";

            obj.Password=obj.Password.A_Hash_SHA256();
            obj.IsActive= true;
            obj.Name= string.IsNullOrEmpty(obj.Name)?obj.FirstName + " " + obj.LastName : obj.Name;
            obj.Role = obj.ParentUserId > 0 ? (int)AppRole.SubUser : (int)AppRole.CompanyAdmin;
            obj.CreatedOn = DateTime.Now;

            var r = _user.Save(obj);
            if (r.IsNull())
                return new Response(false, CONST.SaveError);

            return new Response(true, "Your account has been created successfully. Please check your email inbox and verify your email address to activate your account.");
        }

        [Authorize]
        [HttpPost("RegisterSubUser")]
        public Response RegisterSubUser(AppUser obj)
        {
            //Validating Email address
            if (!CustomValidations.IsValidEmail(obj.Email))
                return new Response(false, "Invalid email address. Please enter valid email address.");

            //Validating Mobile Number
            if (!CustomValidations.IsValidMobile(obj.Mobile))
                return new Response(false, "Invalid email address. Please enter valid email address.");

            var u = _user.GetByEmail(obj.Email);
            if (u != null) return new Response(false, "Email already exists");
            u = _user.GetByMobile(obj.Mobile);
            if (u != null) return new Response(false, "Mobile already exists");

            if (string.IsNullOrEmpty(obj.Password))
                obj.Password = "Pass@1234";
            obj.PreInsert(User!);
            obj.Password = obj.Password.A_Hash_SHA256();
            obj.IsActive = true;
            obj.Name = string.IsNullOrEmpty(obj.Name) ? obj.FirstName + " " + obj.LastName : obj.Name;
            obj.ParentUserId = obj.ParentUserId > 0 ? User!.Id : 0;
            obj.Role = (int)AppRole.SubUser;
            obj.ParentUserId = User!.Id;
            obj.IsSubUser = true;


            var r = _user.Save(obj);
            if (r.IsNull())
                return new Response(false, CONST.SaveError);

            return new Response(true, "Sub user account has been created successfully. Login details are sent to email address");
        }

        [HttpPost("SetCCPIN")]
        public Response SetCCPIN(AppUser obj)
        {
            if (string.IsNullOrEmpty(obj.CCPIN)) return new Response(false, "CCPIN not found.");

            //Check user exists
            var u = _user.GetByEmail(obj.Email);
            if (u == null) return new Response(false, "User not found.");

            //Check CCPIN is same as previous CCPIN
            if (u.CCPIN == obj.CCPIN.A_Hash_SHA256()) return new Response(false, "You cannot reuse your previous PIN.");

            if (string.IsNullOrEmpty(obj.CCPIN)) return new Response(false, "CCPIN not found.");

            obj.CCPIN = obj.CCPIN.A_Hash_SHA256();
            obj.Id = u.Id;
            var r = _user.UpdateCCPIN(u.Id, obj.CCPIN);

            if (r.IsNull())
                return new Response(false, CONST.SaveError);

            var user = _user.GetByEmail(obj.Email);
            return new Response(true, "CCPIN set successfully.");
        }

        [HttpPost("SetPassword")]
        public Response SetPassword(AppUser obj)
        {
            if (string.IsNullOrEmpty(obj.Password)) return new Response(false, "Password not found.");

            //Check user exists
            var u = _user.GetByEmail(obj.Email);
            if (u == null) return new Response(false, "User not found.");

            //obj.Password = obj.Password.A_Hash_SHA256();
            obj.Id = u.Id;
            var r = _user.UpdatePassword(u.Id, obj.Password);

            if (r.IsNull())
                return new Response(false, CONST.SaveError);

            var user = _user.GetByEmail(obj.Email);
            return new Response(true, "Password set successfully.");
        }

        // User OTP
        [HttpGet("OTP/{mobile}/{emailid}")]
        public Response GenerateUserOtp(string mobile, string emailid)
        {
            // Check user is exist by email id
            var user = _user.GetByEmail(emailid);
            if (user == null) return new Response(false, "User not found.");

            //check mobile number exists
            var uMobExists = _user.GetByMobile(mobile);
            if (uMobExists != null)
            {
                if (uMobExists.Mobile == mobile && user.Id != uMobExists.Id)// && user.SignUpBy == "GoogleAuth"
                    return new Response(false, "Mobile number already exists.");
            }

            //Saving mobile number to user when it is null
            if (string.IsNullOrEmpty(user.Mobile))
                _user.SaveDataQuery(user.Id, "mobile_number", mobile);
            else
            {
                //if passed mobile number not same as account mobile number
                if(user.Mobile != mobile)
                    return new Response(false, "Mobile number is not found.");
            }

            //generating OTP
            var isOTP = _user.GenerateOtp(user.Id);
            return new Response(isOTP, isOTP ? "OTP Generated Successfully" : "An error occurred");
        }

        [HttpGet("ValidateOTP/{mobile}/{otp}")]
        public Response ValidateOtp(string mobile, string otp)
        {
            // Check mobiler number is exist
            var _u = _user.GetByMobile(mobile);
            if (_u == null) return new Response(false, "User not found");

            //Validating OTP
            var isValidOTP = _user.ValidateOtp(_u.Id, otp);
            if (!isValidOTP) return new Response(isValidOTP, "Invalid OTP. Please try again.");

            return new Response(true, "OTP validated successfully!");
        }

        [HttpGet("OTPExpired/{mobile}")]
        public Response OTPExpired(string mobile)
        {
            //Validating OTP
            var isValidOTP = _user.UpdateOTPExpired(mobile);
            if (!isValidOTP) return new Response(isValidOTP, "No recent OTPs found.");

            return new Response(true, "OTP has been updated as expired successfully!");
        }

        [HttpGet("OTPCount/{mobile}")]
        public Response OTPCount(string mobile)
        {
            //Validating OTP
            var isValidOTP = _user.OTPCount(mobile);
            return new Response(true, isValidOTP.ToString());
        }

        [Authorize(CompanyAdmin: true)]
        [HttpPost("DeleteSubUser")]
        public Response DeleteSubUser(AppUser obj)
        {
            var u = _user.GetById(obj.Id);
            if (u == null) return new Response(false, "Sub user not found.");

            obj.ParentUserId = User!.Id;

            bool isSuccess = _user.DeleteSubUserById(obj.Id, obj.ParentUserId);
            return new Response(isSuccess, isSuccess ? CONST.DeleteSuccess : CONST.DeleteError);
        }

        [Authorize(CompanyAdmin: true)]
        [HttpPost("MakeSubUserAdmin")]
        public Response MakeSubUserAdmin(AppUser obj)
        {
            var u = _user.GetById(obj.Id);
            if (u == null) return new Response(false, "Sub user not found.");

            obj.ParentUserId = User!.Id;

            bool isSuccess = _user.MakeAdminToSubUser(obj.Id, obj.ParentUserId);
            return new Response(isSuccess, isSuccess ? "You have successfully switched admin privileges with " + u.Name : CONST.SaveError);
        }
    }

}