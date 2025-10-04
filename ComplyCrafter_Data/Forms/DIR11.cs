using AlphaUtil.Core.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ComplyCrafter_Data
{
    [TableName("tbl_dir11", "vw_dir11")]
    public class DIR11 : BaseModel
    {
        [Column("ref_user")]
        public int? RefUser { get; set; }

        [Column("company_id")]
        public int? CompanyId { get; set; }

        [Column("cin")]
        public string? Cin { get; set; }

        [Column("company_name")]
        public string? CompanyName { get; set; }

        [Column("company_address")]
        public string? CompanyAddress { get; set; }

        [Column("company_email")]
        public string? CompanyEmail { get; set; }

        [Column("director")]
        public int? Director { get; set; }

        [Column("director_name")]
        public string? DirectorName { get; set; }

        [Column("nationality")]
        public string? Nationality { get; set; }

        [Column("appointment_date")]
        public DateTime? AppointmentDate { get; set; }

        [Column("designation")]
        public string? Designation { get; set; }

        [Column("category")]
        public string? Category { get; set; }

        [Column("filing_date")]
        public DateTime? FilingDate { get; set; }

        [Column("effective_resignation_date")]
        public DateTime? EffectiveResignationDate { get; set; }

        [Column("resignation_reason")]
        public string? ResignationReason { get; set; }

        [Column("other_reason_details")]
        public string? OtherReasonDetails { get; set; }

        [Column("confirmation_received")]
        public string? ConfirmationReceived { get; set; }

        [Column("director_name2")]
        public string? DirectorName2 { get; set; }

        [Column("din")]
        public string? Din { get; set; }
    }

    [TableName("tbl_DIR11", "vw_DIR11")]
    public class DIR11View : DIR11
    {
        [Column("ref_user_name")]
        public string? RefUserName { get; set; }
    }

}