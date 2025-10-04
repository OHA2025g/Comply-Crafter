using AlphaUtil.Core.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ComplyCrafter_Data
{
    [Table("tbl_user")]
    public class AppUser : BaseModel
    {
        [Column("first_name")]
        public string? FirstName { get; set; }

        [Column("last_name")]
        public string? LastName { get; set; }

        [Column("display_name")]
        public string? Name { get; set; }

        [EmailAddress(ErrorMessage = "Invalid email address.")]
        [MaxLength(100)]
        [BypassInSQLUpdate]
        [Column("email_id")]
        public string? Email { get; set; }

        [BypassInSQLUpdate]
        [Column("is_email_verified")]
        public Boolean IsEmailVerified { get; set; }

        [RegularExpression(@"^[6-9]\d{9}$", ErrorMessage = "Invalid mobile number.")]
        [MaxLength(10)]
        [BypassInSQLUpdate]
        [Column("mobile_number")]
        public string? Mobile { get; set; }

        [BypassInSQLUpdate]
        [Column("is_mobile_verified")]
        public Boolean IsMobileVerified { get; set; }

        [RegularExpression(@"^[6-9]\d{9}$", ErrorMessage = "Invalid alternate mobile number.")]
        [BypassInSQLUpdate]
        [Column("alternate_number")]
        public string? AlternateNumber { get; set; }

        [BypassInSQLUpdate]
        [Column("firm_name")]
        public string? FirmName { get; set; }

        [BypassInSQLUpdate]
        [Column("profession")]
        public string? Profession { get; set; }

        [BypassInSQLUpdate]
        [Column("profession_other")]
        public string? ProfessionOther { get; set; }

        [BypassInSQLUpdate]
        [Column("is_ccpinset")]
        public Boolean IsCCPINSet { get; set; }

        //[RegularExpression(@"^[0-9]\d{4}$", ErrorMessage = "Invalid mobile number.")]
        [MaxLength(4)]
        [BypassInSQLUpdate]
        [Column("ccpin")]
        public string? CCPIN { get; set; }

        [Column("parent_user_id")]
        public int ParentUserId { get; set; }

        [Column("is_sub_user")]
        public Boolean IsSubUser { get; set; }

        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$",
            ErrorMessage = "Password must be at least 8 characters long and include at least one uppercase letter, one lowercase letter, one number, and one special character (e.g., @, $, !, %, , ?, &)")]
        [BypassInSQLUpdate]
        [Column("password")]
        public string? Password { get; set; }


        [BypassInSQLInsert]
        [BypassInSQLUpdate]
        [Column("is_deleted")]
        public Boolean IsDeleted { get; set; }

        [BypassInSQLInsert]
        [BypassInSQLUpdate]
        [Column("deleted_on")]
        public DateTime? DeletedOn { get; set; }

        [BypassInSQLInsert]
        [BypassInSQLUpdate]
        [Column("deleted_by")]
        public int DeletedBy { get; set; }

        [BypassInSQLUpdate]
        [Column("last_password_changed_date")]
        public DateTime? LastPasswordChangedDate { get; set; }

        [BypassInSQLUpdate]
        [Column("last_ccpin_changed_date")]
        public DateTime? LastPINChangedDate { get; set; }

        [Column("signup_by")]
        public string? SignUpBy { get; set; }

        [Column("role")]
        public int Role { get; set; }

        [BypassInSQL, JsonIgnore]
        public AppRole _Role { get => (AppRole)this.Role; set => this.Role = (int)value; }

        [BypassInSQL]
        public string RoleName { get => this._Role.ToString(); }

        [NotMapped]
        [BypassInSQL]
        public int CompanyAdminUserId // Used to get the main user ID for sub-users
        {
            get => ParentUserId > 0 ? ParentUserId : Id;
            set { }
        }

        public AppUser WithoutPassword()
        {
            this.Password = null;
            return this;
        }
    }

    public class AppUserView : AppUser
    {
        public new AppUserView WithoutPassword()
        {
            //this.Password = null;
            return this;
        }
    }

    public enum AppRole
    {
        SuperAdmin = 1,
        CompanyAdmin = 2,
        SubUser = 3
    }

    //public enum AppRole
    //{
    //    Admin = 1,
    //    System_User = 2,
    //    Sub_User = 3,
    //    GoogleSignUp = 101,
    //    Company = 99
    //}
}