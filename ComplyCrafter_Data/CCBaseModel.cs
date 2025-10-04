using AlphaUtil.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplyCrafter_Data
{
    public class CCBaseModel : NpgSQLTable
    {

        [BypassInSQLInsert]
        [Column("UserId")]
        public int UserId { get; set; }

        [BypassInSQLUpdate]
        [Column("CreatedBy")]
        public string? CreatedBy { get; set; }

        [BypassInSQLUpdate]
        [Column("CreatedOn")]
        public DateTime? CreatedOn { get; set; }

        [Column("UpdatedBy")]
        public string? UpdatedBy { get; set; }

        [Column("UpdatedOn")]
        public DateTime? UpdatedOn { get; set; }

        [BypassInSQLUpdate]
        [Column("IsActive")]
        public bool IsActive { get; set; }

        public void PreInsert(AppUserDetails user)
        {
            this.CreatedBy = Convert.ToString(user.UserId);
            this.CreatedOn = DateTime.Now;
            this.UpdatedBy = Convert.ToString(user.UserId);
            this.UpdatedOn = DateTime.Now;
            this.IsActive = true;
        }
    }
}
