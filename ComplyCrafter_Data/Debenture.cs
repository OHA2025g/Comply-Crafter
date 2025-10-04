using AlphaUtil.Core.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ComplyCrafter_Data
{
    [TableName("tbl_debenture", "vw_debenture")]
    public class Debenture : BaseModel
    {
        [Column("company_id")]
        public int CompanyId { get; set; }

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

        [Column("category")]
        public string? Category { get; set; }

        [Column("sub_category")]
        public string? SubCategory { get; set; }

        [Column("under_sub_category")]
        public string? UnderSubCategory { get; set; }

        [Column("type")]
        public string? Type { get; set; }

        [Column("director")]
        public int? Director{ get; set; }

        [Column("shareholder")]
        public int? Shareholder{ get; set; }

        [Column("gender")]
        public string? Gender { get; set; }

        [Column("pan")]
        public string? Pan { get; set; }

        [Column("passport")]
        public string? Passport { get; set; }

        [Column("dob")]
        public DateTime? Dob { get; set; }

        [Column("email")]
        public string? Email { get; set; }

        [Column("mobile")]
        public string? Mobile { get; set; }

        [Column("marital_status")]
        public string? MaritalStatus { get; set; }

        [Column("guardian")]
        public string? Guardian { get; set; }

        [Column("cin_reg_no")]
        public string? CinRegNo { get; set; }

        [Column("date_of_incorporation_reg")]
        public DateTime? DateOfIncorporationReg { get; set; }

        [BypassInSQL]
        public DebentureDetails? Details { get; set; }
    }

    [TableName("tbl_debenture", "vw_debenture")]
    public class DebentureView : Debenture
    {
        [Column("ref_user_name")]
        public string? RefUserName { get; set; }
    }

}