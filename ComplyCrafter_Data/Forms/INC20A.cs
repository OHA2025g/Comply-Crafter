using AlphaUtil.Core.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ComplyCrafter_Data
{
    [TableName("tbl_inc20a", "vw_inc20a")]
    public class INC20A : BaseModel
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

        [Column("longitude")]
        public decimal? Longitude { get; set; }

        [Column("latitude")]
        public decimal? Latitude { get; set; }

        [Column("is_regulated_by_sector")]
        public string? IsRegulatedBySector { get; set; }

        [Column("regulator_name")]
        public string? RegulatorName { get; set; }

        [Column("other_regulator_name")]
        public string? OtherRegulatorName { get; set; }

        [Column("letter_number")]
        public string? LetterNumber { get; set; }

        [Column("approval_date")]
        public DateTime? ApprovalDate { get; set; }

        [Column("number_of_shareholders")]
        public int? NumberOfShareholders { get; set; }

        [Column("resolution_number")]
        public int? ResolutionNumber { get; set; }

        [Column("resolution_date")]
        public DateTime? ResolutionDate { get; set; }

        [Column("director")]
        public int? Director { get; set; }

        [Column("director_din")]
        public string? DirectorDin { get; set; }

        [Column("category")]
        public string? Category { get; set; }

        [Column("pcs")]
        public string? Pcs { get; set; }

        [Column("membership_status")]
        public string? MembershipStatus { get; set; }

        [Column("membership_number")]
        public string? MembershipNumber { get; set; }
    }

    [TableName("tbl_inc20a", "vw_inc20a")]
    public class INC20AView : INC20A
    {
        [Column("ref_user_name")]
        public string? RefUserName { get; set; }
    }

}