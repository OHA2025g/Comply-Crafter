using AlphaUtil.Core.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ComplyCrafter_Data
{
    [Table("tbl_UserDetails")]
    public class AppUserDetails : CCBaseModel
    {
        [Column("FirstName")]
        public string? FirstName { get; set; }

        [Column("LastName")]
        public string? LastName { get; set; }

        [BypassInSQLUpdate]
        [Column("EmailAddress")]
        public string? EmailAddress { get; set; }

        [BypassInSQLUpdate]
        [Column("IsEmailVerified")]
        public bool? IsEmailVerified { get; set; }

        [BypassInSQLUpdate]
        [Column("MobileNumber")]
        public string? MobileNumber { get; set; }

        [BypassInSQLUpdate]
        [Column("IsMobileVerified")]
        public bool? IsMobileVerified { get; set; }

        [BypassInSQLUpdate]
        [Column("AlternateNumber")]
        public string? AlternateNumber { get; set; }

        [BypassInSQLUpdate]
        [Column("IsCCPINSet")]
        public bool? IsCCPINSet { get; set; }

        [BypassInSQLUpdate]
        [Column("CCPIN")]
        public string? CCPIN { get; set; }

        [BypassInSQLUpdate]
        [Column("Password")]
        public string? Password { get; set; }

        [Column("SubscriptionId")]
        public int? SubscriptionId { get; set; }



        [BypassInSQLUpdate]
        [Column("LastPasswordChangedDate")]
        public DateTime? LastPasswordChangedDate { get; set; }

        [BypassInSQLUpdate]
        [Column("LastPINChangedDate")]
        public DateTime? LastPINChangedDate { get; set; }


        [Column("ActiveToken")]
        public string? ActiveToken { get; set; }

        [Column("ActiveTokenOn")]
        public DateTime? ActiveTokenOn { get; set; }


        [Column("BrowserId")]
        public string? BrowserId { get; set; }

        [Column("SignUpBy")]
        public string? SignUpBy { get; set; }

        [Column("RoleId")]
        public int Role { get; set; }

        [BypassInSQL, JsonIgnore]
        public AppRole _Role { get => (AppRole)this.Role; set => this.Role = (int)value; }

        [BypassInSQL]
        public string RoleName { get => this._Role.ToString(); }
        public AppUserDetails WithoutPassword()
        {
            this.Password = null;
            return this;
        }
    }

    public class AppUserDetailsView : AppUserDetails
    {
        public new AppUserDetailsView WithoutPassword()
        {
            this.Password = null;
            return this;
        }
    }
}
