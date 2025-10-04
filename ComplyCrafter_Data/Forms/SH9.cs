using AlphaUtil.Core.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ComplyCrafter_Data
{
    [TableName("tbl_sh9", "vw_sh9")]
    public class SH9 : BaseModel
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

        [Column("company_whether")]
        public string? CompanyWhether { get; set; }

        [Column("resolution_directors")]
        public string? ResolutionDirectors { get; set; }

        [Column("special_date")]
        public DateTime? SpecialDate { get; set; }

        [Column("service_number")]
        public int? ServiceNumber { get; set; }

        // Part 2
        [Column("resolution_number")]
        public int ResolutionNumber { get; set; }

        [Column("resolution_pass")]
        public string? ResolutionPass { get; set; }

        [Column("approved")]
        public string? Approved { get; set; }

        [Column("shares_in_words")]
        public string? SharesInWords { get; set; }

        [Column("companies_act")]
        public string? CompaniesAct { get; set; }

        [Column("day_of")]
        public string? DayOf { get; set; }

        [Column("designation")]
        public string? Designation { get; set; }

        [Column("name_director")]
        public string? NameDirector { get; set; }

        [Column("director_din")]
        public string? firstDirectorDin { get; set; }

        [Column("second_directors_designation")]
        public string? SecondDirectorsDesignation { get; set; }

        [Column("second_director_name")]
        public string? SecondDirectorName { get; set; }

        // Differentiating the two similar properties:
        [Column("second_directors_din")]
        public string? SecondDirectorsDIN { get; set; }

        [Column("liabilities")]
        public string? Liabilities { get; set; }

        [Column("report")]
        public string? Report { get; set; }

        [Column("affidavit")]
        public string? Affidavit { get; set; }

        [Column("attachment_file")]
        public string? AttachmentFile { get; set; }
    }

    [TableName("tbl_sh9", "vw_sh9")]
    public class SH9View : SH9
    {
        [Column("ref_user_name")]
        public string? RefUserName { get; set; }
    }

}