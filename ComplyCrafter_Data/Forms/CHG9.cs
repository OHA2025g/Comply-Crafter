using AlphaUtil.Core.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ComplyCrafter_Data
{
    [TableName("tbl_chg9", "vw_chg9")]
    public class CHG9 : BaseModel
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

        [Column("form_registration_for")]
        public string? FormRegistrationFor { get; set; }

        [Column("applicant_type")]
        public string? ApplicantType { get; set; }

        [Column("resolution_no")]
        public string? ResolutionNo { get; set; }

        [Column("declaration_date")]
        public DateTime? DeclarationDate { get; set; }

        [Column("member_designation")]
        public string? MemberDesignation { get; set; }

        [Column("member_id")]
        public string? MemberId { get; set; }

        [Column("pan_of_charge_holder")]
        public string? PanOfChargeHolder { get; set; }

        [Column("pan_assignee")]
        public string? PanAssignee { get; set; }

        [Column("signed_by_designation")]
        public string? SignedByDesignation { get; set; }

        [Column("signed_by_pan")]
        public string? SignedByPan { get; set; }

        [Column("signed_by_email_id")]
        public string? SignedByEmailId { get; set; }

        [Column("professional_type")]
        public string? ProfessionalType { get; set; }

        [Column("professional_flag")]
        public string? ProfessionalFlag { get; set; }
    }

    [TableName("tbl_chg9", "vw_chg9")]
    public class CHG9View : CHG9
    {
        [Column("ref_user_name")]
        public string? RefUserName { get; set; }
    }

}