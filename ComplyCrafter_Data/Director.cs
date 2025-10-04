using AlphaUtil.Core.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ComplyCrafter_Data
{
    [TableName("tbl_director", "vw_director")]
    public class Director : BaseModel
    {
        [Column("ref_user")]
        public int? RefUser { get; set; }

        [Column("salutation")]
        public string? Salutation { get; set; }

        [Column("first_name")]
        public string? FirstName { get; set; }

        [Column("middle_name")]
        public string? MiddleName { get; set; }

        [Column("last_name")]
        public string? LastName { get; set; }

        [Column("din")]
        public string? Din { get; set; }

        [BypassInSQLUpdate]
        [Column("din_updated_on")]
        public DateTime? DinUpdatedOn { get; set; }

        [Column("pan")]
        public string? Pan { get; set; }

        [Column("mobile")]
        public string? Mobile { get; set; }

        [Column("aadhar")]
        public string? Aadhar { get; set; }

        [Column("email")]
        public string? Email { get; set; }

        [Column("dsc_expiry")]
        public DateTime? DscExpiry { get; set; }

        [Column("din_status")]
        public string? DinStatus { get; set; }

        [Column("dir_kyc_status")]
        public string? DirKycStatus { get; set; }

        [BypassInSQL]
        public DateTime? AppointmentDate { get; set; }

        [BypassInSQL]
        public DirectorDetails? Details { get; set; }
    }

    [TableName("tbl_director", "vw_director")]
    public class DirectorView : Director
    {
        [Column("ref_user_name")]
        public string? RefUserName { get; set; }
    }

    [TableName("tbl_director", "vw_director")]
    public class DirectorViewCompany : DirectorView
    {
        [Column("appointment_date")]
        public new DateTime? AppointmentDate { get; set; }
    }

}