using AlphaUtil.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplyCrafter_Data
{
    [Table("tbl_email_tracker")]
    public class EmailTracker : NpgSQLTable
    {
        [BypassInSQLInsert]
        [Column("id")]
        public int Id { get; set; }

        [BypassInSQLUpdate]
        [Column("user_id")]
        public int UserId { get; set; }

        [BypassInSQLUpdate]
        [Column("secret_id")]
        public string? SecretId { get; set; }

        [BypassInSQLUpdate]
        [Column("email_sent_on")]
        public DateTime EmailSentOn { get; set; }

        [Column("email_respond_on")]
        public DateTime EmailRespondOn { get; set; }

        [Column("email_config_id")]
        public int EmailConfigId { get; set; }

        [Column("is_valid")]
        public bool IsValid { get; set; }

        [BypassInSQLUpdate]
        [Column("otp")]
        public string? OTP { get; set; }
    }
}
