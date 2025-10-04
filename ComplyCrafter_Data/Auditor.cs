using AlphaUtil.Core.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ComplyCrafter_Data
{
    [TableName("tbl_auditor", "vw_auditor")]
    public class Auditor : BaseModel
    {
        [Column("company_id")]
        public int CompanyId { get; set; }

        [Column("ref_user")]
        public int? RefUser { get; set; }

        [Column("category")]
        public string? Category { get; set; }

        [Column("frn")]
        public string? Frn { get; set; }

        [Column("firm_name")]
        public string? FirmName { get; set; }

        [Column("pan")]
        public string? Pan { get; set; }

        [Column("firm_email")]
        public string? FirmEmail { get; set; }

        [Column("address")]
        public string? Address { get; set; }

        [Column("country")]
        public string? Country { get; set; }

        [Column("state")]
        public string? State { get; set; }

        [Column("city")]
        public string? City { get; set; }

        [Column("pincode")]
        public string? Pincode { get; set; }

        [BypassInSQL]
        public IEnumerable<AuditorPartner>? Partners { get; set; }
    }

    [TableName("tbl_auditor", "vw_auditor")]
    public class AuditorView : Auditor
    {
        [Column("ref_user_name")]
        public string? RefUserName { get; set; }

        [Column("partner_name")]
        public string? PartnerName { get; set; }

        [Column("partner_mobile")]
        public string? PartnerMobile { get; set; }
    }

}