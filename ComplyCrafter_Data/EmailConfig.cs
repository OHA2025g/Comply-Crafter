using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplyCrafter_Data
{
    [Table("tbl_email_config")]
    public class EmailConfig : BaseModel
    {
        [Column("from_email")]
        public string FromEmail { get; set; }

        [Column("email_password")]
        public string EmailPassword { get; set; }

        public string ToEmail { get; set; }

        [Column("cc_email")]
        public string CCEmail { get; set; }

        [Column("bcc_email")]
        public string BCCEmail { get; set; }

        [Column("email_body")]
        public string EmailBody { get; set; }

        [Column("email_subject")]
        public string EmailSubject { get; set; }

        [Column("display_name")]
        public string DisplayName { get; set; }

        [Column("smtp")]
        public string SMTP { get; set; }

        [Column("enable_ssl")]
        public bool EnableSSL { get; set; }

        [Column("port_number")]
        public int PortNumber { get; set; }
    }

    public enum EmailType
    {
        VerifyEmail = 1,
        ResetCCPIN = 2,
        ResetPassword = 3,
        SubUserRegistration = 4
    }
}
