using AlphaUtil.Core.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace ComplyCrafter_Data
{
    [Table("tbl_company_otp")]
    public class UserOtp : NpgSQLTable
    {

        [BypassInSQLInsert]
        [Column("id")]
        public int Id { get; set; }

        [Column("user")]
        public int? User { get; set; }

        [Column("mobile")]
        public string? Mobile { get; set; }

        [Column("otp_type")]
        public int? OtpType { get; set; }

        [Column("otp")]
        public string? Otp { get; set; }

        [Column("valid_till")]
        public DateTime? ValidTill { get; set; }

        [Column("is_valid")]
        public bool IsValid { get; set; }

        [Column("verified")]
        public bool? Verified { get; set; }
    }
}