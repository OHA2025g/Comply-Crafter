using AlphaUtil.Core.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ComplyCrafter_Data
{
    [TableName("tbl_dms", "tbl_dms")]
    public class DMS : BaseModel
    {
        [Column("company_id")]
        public int? CompanyId { get; set; }

        [Column("type")]
        public string? Type { get; set; }


        [Column("form_name")]
        public string? FormName { get; set; }

        [Column("event_date")]
        public DateTime? EventDate { get; set; }

        [Column("financial_year")]
        public int? FinancialYear { get; set; }

        [BypassInSQL]
        [Column("form_original")]
        public string? FormOriginal { get; set; }

        [Column("form_client")]
        public string? FormClient { get; set; }

        [BypassInSQL]
        [Column("challan_original")]
        public string? ChallanOriginal { get; set; }

        [Column("challan_client")]
        public string? ChallanClient { get; set; }

    }
}