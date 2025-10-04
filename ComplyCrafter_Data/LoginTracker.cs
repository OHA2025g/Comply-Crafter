using AlphaUtil.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplyCrafter_Data
{
    [Table("tbl_login_tracker")]
    public class LoginTracker : NpgSQLTable
    {
        [BypassInSQLInsert]
        [Column("id")]
        public int Id { get; set; }

        [BypassInSQLUpdate]
        [Column("user_id")]
        public int UserId { get; set; }


        [BypassInSQLInsert]
        [BypassInSQLUpdate]
        [BypassInSQL]
        public string? EmailId { get; set; }

        [BypassInSQLUpdate]
        [Column("broswer_id")]
        public string? BrowserId { get; set; }

        [BypassInSQLUpdate]
        [Column("session_id")]
        public string? SessionId { get; set; }

        [Column("is_valid")]
        public bool IsValid { get; set; }

        [Column("created_on")]
        public DateTime CreatedOn { get; set; }

        [Column("updated_on")]
        public DateTime UpdatedOn { get; set; }
    }
}
