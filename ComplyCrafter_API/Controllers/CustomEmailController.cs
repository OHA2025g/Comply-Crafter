using AlphaUtil.Core;
using AlphaUtil.Core.Models;
using ComplyCrafter_BL;
using ComplyCrafter_Data;
using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;
using System.Transactions;
using static QRCoder.PayloadGenerator;

namespace ComplyCrafter_API.Controllers
{
    [Route("api/Email")]
    [ApiController]
    public class CustomEmailController : ApiController
    {
        private readonly ICustomEmail _customEmail;
        private readonly IUser _user;

        public CustomEmailController(ICustomEmail customEmail, IUser user)
        {
            this._customEmail = customEmail;
            this._user = user;
        }

        [HttpGet("SendEmail")]
        public Response VerifyAccountEmail(string? email, string? emailType)
        {
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(emailType)) return new Response(false, "Please check request parameter.");

            //Fetching user details by Email Id
            var _appUser = _user.GetByEmail(email);
            if (_appUser == null) return new Response(false, "User not found.");

            //Checking email address verified
            if (_appUser.IsEmailVerified & emailType == "emailverify") return new Response(false, "Your email address has already been verified.");


            //Checking email type to send email
            int iEmailConfigId = 0;
            string sPageName = "ValidateEmail";
            switch (emailType)
            {
                case "emailverify":
                    iEmailConfigId = 1;
                    break;

                case "resetccpin":
                    iEmailConfigId = 2;
                    sPageName = "ResetCCPIN";
                    break;

                case "resetpassword":
                    iEmailConfigId = 3;
                    sPageName = "ResetPassword";
                    break;

                case "googlesignup":
                    iEmailConfigId = 7;
                    sPageName = "Login";
                    break;
            }

            //Inserting into email tracker
            EmailTracker _emTracker = new EmailTracker();
            _emTracker.EmailSentOn = DateTime.Now;
            _emTracker.UserId = _appUser.Id;
            _emTracker.EmailConfigId = iEmailConfigId;
            _emTracker.IsValid = true;
            _emTracker.SecretId = Guid.NewGuid().ToString().A_Hash_SHA256();

            //Saving into email tracker
            var vResult = _customEmail.SaveTracker(_emTracker);
            if (vResult == null) return new Response(false, "Email tracker not found.");

            //On Successfully saving into email tracker start
            string sVerifyLink = R.ApiUIUrl + "/Home/" + sPageName;
            sVerifyLink = iEmailConfigId != 7 ? sVerifyLink + "?Key=" + vResult.SecretId : sVerifyLink;

            //Getting email template
            var vEmail = _customEmail.GetById(iEmailConfigId);
            if (vEmail == null) return new Response(false, "Email config not found.");

            vEmail.EmailBody = vEmail.EmailBody.Replace("@User", _appUser.Name).Replace("@VerifyLink", sVerifyLink);
            vEmail.ToEmail = _appUser.Email;

            string sMessage = _customEmail.SendEmail(vEmail);
            return new Response(true, CONST.EmailSuccess);
        }

        [HttpGet("ValidateEmail")]
        public Response ValidateEmail(string Key)
        {
            //Checking request available
            var vTracker = _customEmail.GetTrackerById(Key);
            if (vTracker == null) return new Response(false, CONST.InvalidLink);

            //Checking time expiry
            TimeSpan _timeSpan = DateTime.Now.Subtract(vTracker.EmailSentOn);
            if (_timeSpan.Minutes > Convert.ToInt16(R.AppSet("Email:ValidityInMin"))) return new Response(false, CONST.ExpiredLink);

            //Validate email and update respond on
            vTracker.IsValid = false;
            vTracker.EmailRespondOn = DateTime.Now;
            vTracker = _customEmail.SaveTracker(vTracker);
            if (vTracker == null) return new Response(false, CONST.InvalidLink);

            var isSuccess = _user.SaveEmailVerified(vTracker.UserId);
            if (!isSuccess) return new Response(false, CONST.InvalidLink);

            if (vTracker.EmailConfigId != 1)
            {
                var user = _user.GetById(vTracker.UserId);
                return new Response(true, CONST.EmailValidateSuccess, Auth.CreateSession(user.WithoutPassword(), DateTime.Now.AddMinutes(5)).Token()); // this token will use to auth user
            }
            else
                return new Response(true, CONST.EmailValidateSuccess);
        }

        [HttpGet("ResendEmail")]
        public Response ResendEmail(string Key, string? emailType)
        {
            //Checking request available
            var vUser = _user.GetUserByEmailSecretKey(Key);
            if (vUser == null) return new Response(false, "Invalid request.");

            //Fetching user details by Email Id
            var _appUser = _user.GetByEmail(vUser.Email);
            if (_appUser == null) return new Response(false, "Invalid request.");

            //Checking email address verified
            if (_appUser.IsEmailVerified & emailType == "emailverify") return new Response(false, "Your email address has already been verified.");

            //Checking email type to send email
            int iEmailConfigId = 0;
            string sPageName = "ValidateEmail";
            switch (emailType)
            {
                case "emailverify":
                    iEmailConfigId = 1;
                    break;

                case "resetccpin":
                    iEmailConfigId = 2;
                    sPageName = "ResetCCPIN";
                    break;

                case "resetpassword":
                    iEmailConfigId = 3;
                    sPageName = "ResetPassword";
                    break;
            }

            //Inserting into email tracker
            EmailTracker _emTracker = new EmailTracker();
            _emTracker.EmailSentOn = DateTime.Now;
            _emTracker.UserId = _appUser.Id;
            _emTracker.EmailConfigId = iEmailConfigId;
            _emTracker.IsValid = true;
            _emTracker.SecretId = Guid.NewGuid().ToString().A_Hash_SHA256();

            //Saving into email tracker
            var vResult = _customEmail.SaveTracker(_emTracker);
            if (vResult == null) return new Response(false, "Email tracker not found.");

            //On Successfully saving into email tracker start
            string sVerifyLink = R.ApiUIUrl + "/Home/" + sPageName + "?Key=" + vResult.SecretId;

            //Getting email template
            var vEmail = _customEmail.GetById(iEmailConfigId);
            if (vEmail == null) return new Response(false, "Email config not found.");

            vEmail.EmailBody = vEmail.EmailBody.Replace("@User", _appUser.Name).Replace("@VerifyLink", sVerifyLink);
            vEmail.ToEmail = _appUser.Email;

            string sMessage = _customEmail.SendEmail(vEmail);
            return new Response(sMessage.Contains("Success") ? true : false, CONST.EmailSuccess);
        }

        [Authorize]
        [HttpGet("SendRegistrationEmail")]
        public Response SendRegistrationEmailToSubUser(string? email)
        {
            //string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";

            if (string.IsNullOrWhiteSpace(email))
                return new Response(false, "Email address is required.");

            if (!CustomValidations.IsValidEmail(email))
                return new Response(false, "Invalid email address format.");

            if (string.IsNullOrEmpty(email)) return new Response(false, "Please check request parameter.");

            //Inserting into email tracker
            EmailTracker _emTracker = new EmailTracker();
            _emTracker.EmailSentOn = DateTime.Now;
            _emTracker.UserId = User!.Id;
            _emTracker.EmailConfigId = (int)EmailType.SubUserRegistration;
            _emTracker.IsValid = true;
            _emTracker.SecretId = Guid.NewGuid().ToString().A_Hash_SHA256();

            //Saving into email tracker
            var vResult = _customEmail.SaveTracker(_emTracker);
            if (vResult == null) return new Response(false, "Email tracker not found.");

            //On Successfully saving into email tracker start
            string sVerifyLink = R.ApiUIUrl + "/Home/SetSubUserPassword?key=" + vResult.SecretId + "&emailId=" + email;

            //Getting email template
            var vEmail = _customEmail.GetById((int)EmailType.SubUserRegistration);
            if (vEmail == null) return new Response(false, "Email config not found.");

            vEmail.EmailBody = vEmail.EmailBody.Replace("@VerifyLink", sVerifyLink);
            vEmail.ToEmail = email;

            string sMessage = _customEmail.SendEmail(vEmail);
            return new Response(true, "Account access email link sent successfully to sub user.");
        }

        [HttpGet("ValidateRegistrationEmail")]
        public Response ValidateRegEmail(string key, string email)
        {
            //Checking request available
            var vTracker = _customEmail.GetTrackerById(key);
            if (vTracker == null) return new Response(false, CONST.InvalidLink);

            //Checking time expiry
            TimeSpan _timeSpan = DateTime.Now.Subtract(vTracker.EmailSentOn);
            if (_timeSpan.Minutes > Convert.ToInt16(R.AppSet("Email:ValidityInMin"))) return new Response(false, CONST.ExpiredLink);

            //Validate email and update respond on
            vTracker.IsValid = false;
            vTracker.EmailRespondOn = DateTime.Now;
            vTracker = _customEmail.SaveTracker(vTracker);
            if (vTracker == null) return new Response(false, CONST.InvalidLink);

            //getting user details by id
            var subUser = _user.GetByEmail(email);

            //updating email and mobile verified success
            _user.SaveEmailVerified(subUser.Id);
            _user.SaveMobileVerified(subUser.Id);

            return new Response(true, CONST.EmailValidateSuccess);
        }

        [Authorize]
        [HttpGet("PaymentConfirmationEmail")]
        public Response SendPaymentConfirmationEmail(string transactionId)
        {
            //Inserting into email tracker
            EmailTracker _emTracker = new EmailTracker();
            _emTracker.EmailSentOn = DateTime.Now;
            _emTracker.UserId = User!.Id;
            _emTracker.EmailConfigId = 5;
            _emTracker.IsValid = false;
            _emTracker.SecretId = Guid.NewGuid().ToString().A_Hash_SHA256();

            //Saving into email tracker
            var vResult = _customEmail.SaveTracker(_emTracker);
            if (vResult == null) return new Response(false, "Email tracker not found.");

            //Getting email template
            var vEmail = _customEmail.GetById(5);
            if (vEmail == null) return new Response(false, "Email config not found.");

            UserSubscriptionsRepository _usr = new UserSubscriptionsRepository();
            var vPaymentDetails = _usr.GetPaymentDetailsforEmail(transactionId);
            if (vPaymentDetails == null) return new Response(false, "Payment details not found.");

            vEmail.EmailBody = vEmail.EmailBody.Replace("@Name", User!.Name)
                .Replace("@OrderID", vPaymentDetails.paymentDetails.PaymentId)
                .Replace("@Amount", Convert.ToString(vPaymentDetails.paymentDetails.TransactionAmount))
                .Replace("@PlanName", vPaymentDetails.subscriptionPlan.PlanName)
                .Replace("@PaymentDate", vPaymentDetails.paymentDetails.CreatedOn.ToString("dd MMM, yyyy hh:mmtt"))
                .Replace("@PlanExpire", vPaymentDetails.userSubscription.EndDate.ToString("dd MMM, yyyy"));

            vEmail.ToEmail = User!.Email;

            string sMessage = _customEmail.SendEmail(vEmail);
            return new Response(true, CONST.EmailSuccess);
        }

        [Authorize]
        [HttpGet("SendEmailOTP")]
        public Response SendEmailDirectorOTP(string email, string dirName)
        {
            bool isValidEmail = CustomValidations.IsValidEmail(email);
            if (!isValidEmail) return new Response(false, "Invalid email id.");

            //Inserting into email tracker
            EmailTracker _emTracker = new EmailTracker();
            _emTracker.EmailSentOn = DateTime.Now;
            _emTracker.UserId = User!.CompanyAdminUserId;
            _emTracker.EmailConfigId = 6;
            _emTracker.IsValid = true;
            _emTracker.SecretId = Guid.NewGuid().ToString().A_Hash_SHA256();
            _emTracker.OTP = Random.Shared.Next(100000, 999999).ToString(); // Generating a 6-digit OTP 

            //Saving into email tracker
            var vResult = _customEmail.SaveTracker(_emTracker);
            if (vResult == null) return new Response(false, "Email tracker not found.");

            //Getting email template
            var vEmail = _customEmail.GetById(6);
            if (vEmail == null) return new Response(false, "Email config not found.");

            vEmail.EmailBody = vEmail.EmailBody.Replace("@User", dirName).Replace("@OTPCode", _emTracker.OTP);
            vEmail.ToEmail = email;

            string sMessage = _customEmail.SendEmail(vEmail);
            return new Response(true, CONST.EmailSuccess);
        }

        [Authorize]
        [HttpGet("VerifyEmailOTP")]
        public Response VerifyDirectorOTP(string otp)
        {
            //Checking request available
            var vTracker = _customEmail.GetByUserId(User!.CompanyAdminUserId);
            if (vTracker == null) return new Response(false, "Invalid request");

            //Checking time expiry
            TimeSpan _timeSpan = DateTime.Now.Subtract(vTracker.EmailSentOn);
            if (_timeSpan.Minutes > Convert.ToInt16(R.AppSet("Email:ValidityInMin")))
                return new Response(false, "Your OTP has expired. Please request a new one.");

            if (vTracker.OTP != otp)
                return new Response(false, "Invalid otp, please try again");

            //Validate email and update respond on
            vTracker.IsValid = false;
            vTracker.EmailRespondOn = DateTime.Now;
            vTracker = _customEmail.SaveTracker(vTracker);

            return new Response(true, "Your OTP has been verified successfully.");
        }
    }
}
