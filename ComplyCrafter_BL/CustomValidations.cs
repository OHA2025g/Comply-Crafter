using AlphaUtil.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static QRCoder.PayloadGenerator;

namespace ComplyCrafter_BL
{
    public static class CustomValidations
    {
        public static bool IsValidEmail(string EmailId)
        {
            string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            return Regex.IsMatch(EmailId, pattern);
        }
        public static bool IsValidMobile(string Mobile)
        {
            string pattern = @"^[6-9]\d{9}$";
            return Regex.IsMatch(Mobile, pattern);
        }
    }

    public class APIResponse
    {
        public bool status { get; set; }
        public string? message { get; set; }
        public object? responseObject { get; set; }
    }

    public class APIResponseUserDetails
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public bool? IsEmailVerified { get; set; }
        public string? Mobile { get; set; }
        public bool? IsMobileVerified { get; set; }
        public string? AlternateNumber { get; set; }
        public string? FirmName { get; set; }
        public string? Profession { get; set; }
        public string? ProfessionOther { get; set; }
        public bool? IsCCPINSet { get; set; }
        public string? CCPIN { get; set; }
        public int? ParentUserId { get; set; }
        public bool? IsSubUser { get; set; }
        public string? Password { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? DeletedOn { get; set; }
        public int? DeletedBy { get; set; }
        public DateTime? LastPasswordChangedDate { get; set; }
        public DateTime? LastPINChangedDate { get; set; }
        public string? SignUpBy { get; set; }
        public int? Role { get; set; }
        public string? RoleName { get; set; }
        public int? Id { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool? IsActive { get; set; }
    }
}
