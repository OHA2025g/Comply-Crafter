using AlphaUtil.Core.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ComplyCrafter_Data
{
    [TableName("tbl_mgt8", "vw_mgt8")]
    public class MGT8 : BaseModel
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

        [Column("financial_year")]
        public string? FinancialYear { get; set; }

        [Column("firm_name")]
        public string? FirmName { get; set; }

        [Column("signing_pcs")]
        public string? SigningPcs { get; set; }

        [Column("membership_no")]
        public string? MembershipNo { get; set; }

        [Column("certificate")]
        public string? Certificate { get; set; }

        [Column("designation")]
        public string? Designation { get; set; }

        [Column("udin")]
        public string? Udin { get; set; }

        [Column("date_of_signing")]
        public DateTime? DateOfSigning { get; set; }

        [Column("place_of_signing")]
        public string? PlaceOfSigning { get; set; }

        [Column("format_transaction")]
        public string? FormatTransaction { get; set; }

        [Column("annual_return")]
        public Boolean? AnnualReturn { get; set; }

        [Column("status")]
        public Boolean? Status { get; set; }

        [Column("maintenance")]
        public Boolean? Maintenance { get; set; }

        [Column("filling_of_forms")]
        public Boolean? FillingOfForms { get; set; }

        [Column("commitees_members")]
        public Boolean? CommiteesMembers { get; set; }

        [Column("register_of_members")]
        public Boolean? RegisterOfMembers { get; set; }

        [Column("advances_and_loans")]
        public Boolean? AdvancesAndLoans { get; set; }

        [Column("related_party_contracts")]
        public Boolean? RelatedPartyContracts { get; set; }

        [Column("issue_or_allotments")]
        public Boolean? IssueOrAllotments { get; set; }

        [Column("keeping_in_abeyance")]
        public Boolean? KeepingInAbeyance { get; set; }

        [Column("declaration")]
        public Boolean? Declaration { get; set; }

        [Column("signing_of_audited")]
        public Boolean? SigningOfAudited { get; set; }

        [Column("constitution")]
        public Boolean? Constitution { get; set; }

        [Column("filling_up_casual")]
        public Boolean? FillingUpCasual { get; set; }

        [Column("approvals_required")]
        public Boolean? ApprovalsRequired { get; set; }

        [Column("repayment_of_deposits")]
        public Boolean? RepaymentOfDeposits { get; set; }

        [Column("borrowings")]
        public Boolean? Borrowings { get; set; }

        [Column("investements_or_guarantees")]
        public Boolean? InvestementsOrGuarantees { get; set; }

        [Column("alteration_provisions")]
        public Boolean? AlterationProvisions { get; set; }
    }

   

    [TableName("tbl_mgt8", "vw_mgt8")]
    public class MGT8View : MGT8
    {
        [Column("ref_user_name")]
        public string? RefUserName { get; set; }
    }

}