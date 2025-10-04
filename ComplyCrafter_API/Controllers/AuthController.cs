using AlphaUtil.Core;
using AlphaUtil.Core.Models;
using Microsoft.AspNetCore.Mvc;
using ComplyCrafter_API.Models; 
using ComplyCrafter_BL;
using ComplyCrafter_Data;
using System.Diagnostics;
using System.Web;
using static QRCoder.PayloadGenerator;
using System.Text.RegularExpressions;

namespace ComplyCrafter_API.Controllers
{
    [Route("api/[controller]")] 
    [ApiController]
    public class AuthController : ApiController
    {
        private readonly IUser _user;
        private readonly ILoginTracker _loginTracker;
        private readonly ICompany _company;

        public AuthController(IUser user, ICompany company, ILoginTracker loginTracker)
        {
            _user = user;
            _company = company;
            _loginTracker = loginTracker;

        }

        [HttpPost("Authenticate")]
        public Response AuthenticateUser(AuthModel auth)
        {
            var valid = auth.Validate(); if (!valid.IsBlank()) return new Response(false, valid!);
            var userPassword = auth.Password?.A_Hash_SHA256().ToLower().Trim();
            var userPIN = auth.Password?.A_Hash_SHA256().ToLower().Trim();
            var user = _user.GetByEmail(auth.Email);
            if (user == null) return new Response(false, "User not found.");

            //check email verified
            if (!user.IsEmailVerified) return new Response(false, "Please verify your email.");

            //check mobile verified
            if (!user.IsMobileVerified) return new Response(false, "Please verify your mobile.");

            //check ccpin verified
            if (!user.IsCCPINSet) return new Response(false, "Please set your CCPIN.");

            //check logged in by password or ccpin
            if (auth.Password.Length == 4)
            {
                if(user.CCPIN != userPIN) return new Response(false, "Incorrect CCPIN.");
                return new Response(true, "Authentication Successful", Auth.CreateSession(user.WithoutPassword()).Token());
            }

            if (!R.AppSet<bool>("BypassAuthentication") && user!.Password?.ToLower().Trim() != auth.Password?.A_Hash_SHA256().ToLower())
                return new Response(false, "Authentication Failed");
            return new Response(true, "Authentication Successful", Auth.CreateSession(user.WithoutPassword()).Token());
        }

        [HttpPost("AuthenticateUserByGmail")]
        public Response AuthenticateUserByGmail(string emailId)
        {
            var user = _user.GetByEmail(emailId);
            if (user == null) return new Response(false, "User not found.");

            if (!user.IsEmailVerified)
                return new Response(false, "Verify email first.");

            //check mobile verified
            if (!user.IsMobileVerified) return new Response(false, "Please verify your mobile.");

            return new Response(true, "Authentication Successful", Auth.CreateSession(user.WithoutPassword()).Token());
        }

        [Authorize]
        [HttpPost("SaveLoginTracker")]
        public Response SaveLoginTracker(LoginTracker obj)
        {
            if (obj == null) return new Response(false, "Request body empty.");

            var user = _user.GetByEmail(obj.EmailId);
            if (user == null) return new Response(false, "");

            obj.UserId = user.Id;
            obj.IsValid = true;
            obj.CreatedOn = DateTime.Now;
            var vLT = _loginTracker.Save(obj);

            return new Response(vLT == null ? false : true, "Valid");
        }

        [Authorize]
        [HttpPost("CheckSession")]
        public Response CheckUserSessionDetails(LoginTracker obj)
        {
            var user = _user.GetByEmail(obj.EmailId);
            if (user == null) return new Response(false, "");

            obj.UserId = user.Id;

            var vLD = _loginTracker.GetByUserId(obj.UserId);
            if (vLD == null) return new Response(false, "Access denied.");

            //Check browser id and session not same then logout the current session
            if (vLD.BrowserId != obj.BrowserId || vLD.SessionId != obj.SessionId)
            {
                _loginTracker.Update(obj);
                return new Response(false, "New login attemptted from browser.");
            }
            return new Response(true, "Valid");
        }

        [Authorize]
        [HttpPost("UpdateDuplicateSession")]
        public Response UpdateDuplicateSession(LoginTracker obj)
        {
            if (obj == null) return new Response(false, "Request body empty.");

            var user = _user.GetByEmail(obj.EmailId);
            if (user == null) return new Response(false, "");

            obj.UserId = user.Id;
            obj.IsValid = true;
            var vLT = _loginTracker.Update(obj);

            return new Response(vLT? false : true, "Valid");
        }

        [Authorize]
        [HttpGet("Validate")]
        public Response Validate()
        {
            var u = _user.GetById(User!.Id);
            return new Response(true, "Valid", u);
        }

        [CompanyAuthorize]
        [HttpGet("ValidateCompany")]
        public Response ValidateCompany()
        {
            var u = _company.GetById(User!.Id);
            return new Response(true, "Valid", u);
        }

        // Customer Login
        [HttpGet("OTP/{mobile}")]
        public Response GenerateOtp(string mobile)
        {
            var company = _company.GetByMobile(mobile);
            if (company == null) return new Response(false, "User not found");
            AppUser? user = new AppUser
            {
                Id = company.Id,
                Name = company.CompanyName,
                Mobile = mobile,
                _Role = AppRole.CompanyAdmin
            };
            var r = _company.GenerateOtp(company.Id, mobile);
            return new Response(r, r ? "OTP Generated Successfully" : "An error occurred");
        }

        [HttpGet("OTP/{mobile}/{otp}")]
        public Response ValidateOtp(string mobile, string otp)
        {
            var company = _company.GetByMobile(mobile);
            if (company == null) return new Response(false, "User not found");
            AppUser? user = new AppUser
            {
                Id = company.Id,
                Name = company.CompanyName,
                Mobile = mobile,
                _Role = AppRole.CompanyAdmin
            };
            var r = _company.ValidateOtp(company.Id, mobile, otp);
            if (!r) return new Response(false, "Authentication Failed");
            return new Response(true, "Authentication Successful", Auth.CreateSession(user.WithoutPassword(), DateTime.Now.AddYears(1)).Token());
        }

        [Authorize]
        [HttpGet("ChangePassword")]
        public Response ChangePassword(int? id, string newPassword)
        {
            int userId = id.HasValue ? id.Value : User!.Id;
            //Fetching user details by Id
            var _appUser = _user.GetById(userId);
            if (_appUser == null) return new Response(false, "User not found.");

            if (string.IsNullOrEmpty(newPassword)) return new Response(false, "Password should not be blank.");

            // Password policy regex
            var passwordRegex = new Regex(@"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$");
            if (!passwordRegex.IsMatch(newPassword))
                return new Response(false, "Password must be at least 8 characters long and contain at least one uppercase letter, one lowercase letter, one digit, and one special character.");

            if (_appUser.Password == newPassword.A_Hash_SHA256().ToLower().Trim()) return new Response(false, "The new password cannot be the same as your current password.");

            //string decodednewPassword = HttpUtility.UrlDecode(newPassword);
            var r = _user.UpdatePassword(userId, newPassword);
            return new Response(r, r ? "Password changed successfully" : "An error occurred");
        }

        [Authorize]
        [HttpGet("ChangeCCPIN")]
        public Response ChangeCCPIN(int? id, string newCCPIN)
        {
            int userId = id.HasValue ? id.Value : User!.Id;
            // Fetching user details by Id
            var _appUser = _user.GetById(userId);
            if (_appUser == null) return new Response(false, "User not found.");

            if (string.IsNullOrEmpty(newCCPIN))
                return new Response(false, "CCPIN should not be blank.");

            // 4-digit PIN regex
            var pinRegex = new Regex(@"^\d{4}$");
            if (!pinRegex.IsMatch(newCCPIN))
                return new Response(false, "CCPIN must be exactly 4 digits.");

            // Prevent reuse of same CCPIN
            var newPinHash = newCCPIN.A_Hash_SHA256().ToLower().Trim();
            if (_appUser.CCPIN == newPinHash)
                return new Response(false, "New CCPIN must be different from the current one.");

            // Save hashed CCPIN
            var r = _user.UpdateCCPIN(userId, newPinHash);
            return new Response(r, r ? "CCPIN changed successfully." : "An error occurred.");
        }

        [Authorize]
        [HttpGet("UserInfo")]
        public Response LoggedInUserDetails()
        {
            var u = _user.GetById(User!.Id);
            if (u == null) return new Response(false, "User not found.");
            return new Response(true, "Valid", u);
        }
    }
}