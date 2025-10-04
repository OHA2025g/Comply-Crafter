using AlphaUtil.Core.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ComplyCrafter_Data
{
    [TableName("tbl_company_notice", "vw_company_notice")]
    public class CompanyNotice : BaseModel
    {
        [Column("company_id")]
        public int? CompanyId { get; set; }

        [Column("issue_date")]
        public DateTime? IssueDate { get; set; }

        [Column("meeting_date")]
        public DateTime? MeetingDate { get; set; }

        [Column("type")]
        public string? Type { get; set; }

        [Column("resolution")]
        public string? Resolution { get; set; }

    }

    [TableName("tbl_company_notice", "vw_company_notice")]
    public class CompanyNoticeView : CompanyNotice
    {

    }
}