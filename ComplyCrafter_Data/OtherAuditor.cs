using AlphaUtil.Core.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ComplyCrafter_Data
{
    [TableName("tbl_other_auditor", "vw_other_auditor")]
    public class OtherAuditor : BaseModel
    {
        [Column("company_id")]
        public int CompanyId { get; set; }

        [Column("ref_user")]
        public int? RefUser { get; set; }

        [Column("category")]
        public string? Category { get; set; }

        [Column("sub_category")]
        public string? SubCategory { get; set; }

        [Column("profession")]
        public string? Profession { get; set; }

        [Column("frn")]
        public string? Frn { get; set; }

        [Column("firm_name")]
        public string? FirmName { get; set; }

        [Column("auditor_name")]
        public string? AuditorName { get; set; }

        [Column("auditor_designation_in_firm")]
        public string? AuditorDesignationInFirm { get; set; }

        [Column("member_no")]
        public string? MemberNo { get; set; }

        [Column("certificate_of_practice")]
        public string? CertificateOfPractice { get; set; }

        [Column("auditor_mobile")]
        public string? AuditorMobile { get; set; }

        [Column("auditor_email")]
        public string? AuditorEmail { get; set; }

        [Column("address_of_firm_auditor")]
        public string? AddressOfFirmAuditor { get; set; }

        [Column("type")]
        public string? Type { get; set; }
    }

    [TableName("tbl_other_auditor", "vw_other_auditor")]
    public class OtherAuditorView : OtherAuditor
    {
        [Column("ref_user_name")]
        public string? RefUserName { get; set; }
    }

}