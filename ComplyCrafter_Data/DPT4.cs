using AlphaUtil.Core.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ComplyCrafter_Data
{
    [TableName("tbl_dpt4", "vw_dpt4")]
    public class DPT4 : BaseModel
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

        [Column("company_type")]
        public string? CompanyType { get; set; }

        [Column("is_gov")]
        public string? IsGov { get; set; }

        [Column("amt")]
        public string? Amt { get; set; }

        [Column("number_of_depositors")]
        public string? NumberOfDepositors { get; set; }

        [Column("deposits_due_but_not_paid")]
        public string? DepositsDueButNotPaid { get; set; }

        [Column("interest_due_there_on_but_not_paid")]
        public string? InterestDueThereOnButNotPaid { get; set; }

        [Column("deposits_due_but_not_claimed")]
        public string? DepositsDueButNotClaimed { get; set; }

        [Column("interest_due_there_on_but_not_claimed")]
        public string? InterestDueThereOnButNotClaimed { get; set; }

        [Column("deposits_not_yet_due_for_repayment")]
        public string? DepositsNotYetDueForRepayment { get; set; }

        [Column("deposits_due_for_repayment_three_months")]
        public string? DepositsDueForRepaymentThreeMonths { get; set; }

        [Column("arrangement_for_repayment_deposits_due")]
        public string? ArrangementForRepaymentDepositsDue { get; set; }

        [Column("resolution_no")]
        public string? ResolutionNo { get; set; }

        [Column("resolution_date")]
        public DateTime? ResolutionDate { get; set; }
    }

    [TableName("tbl_dpt4", "vw_dpt4")]
    public class DPT4View : DPT4
    {
        [Column("ref_user_name")]
        public string? RefUserName { get; set; }
    }

}