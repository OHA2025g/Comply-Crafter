using AlphaUtil.Core.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ComplyCrafter_Data
{
    [TableName("tbl_mr1", "vw_mr1")]
    public class FORM24 : BaseModel
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

        [Column("application_reason")]
        public string? ApplicationReason { get; set; }

        [Column("is_action_initiated")]
        public string? IsActionInitiated { get; set; }

        [Column("income_tax_updated")]
        public string? IncomeTaxUpdated { get; set; }

        [Column("ceased_llp_date")]
        public DateTime? CeasedLlpDate { get; set; }

        [Column("llp_under_law")]
        public string? LlpUnderLaw { get; set; }

        [Column("regulator_name")]
        public string? RegulatorName { get; set; }

        [Column("noc_approval_date")]
        public DateTime? NocApprovalDate { get; set; }

        [Column("prosecutions_pending")]
        public string? ProsecutionsPending { get; set; }

        [Column("number_of_prosecutions")]
        public decimal? NumberOfProsecutions { get; set; }

        [Column("statement_of_acc_date")]
        public DateTime? StatementOfAccDate { get; set; }

        [Column("capital")]
        public decimal? Capital { get; set; }

        [Column("reserves_and_surplus")]
        public decimal? ReservesAndSurplus { get; set; }

        [Column("secured_loans_from_fi")]
        public decimal? SecuredLoansFromFi { get; set; }

        [Column("secured_loans_from_bank")]
        public decimal? SecuredLoansFromBank { get; set; }

        [Column("secured_loans_from_govt")]
        public decimal? SecuredLoansFromGovt { get; set; }

        [Column("others_secured_loans")]
        public decimal? OthersSecuredLoans { get; set; }

        [Column("debentures")]
        public decimal? Debentures { get; set; }

        [Column("unsecured_loans")]
        public decimal? UnsecuredLoans { get; set; }

        [Column("deposits_and_interest")]
        public decimal? DepositsAndInterest { get; set; }

        [Column("total_loan_funds")]
        public decimal? TotalLoanFunds { get; set; }

        [Column("total")]
        public decimal? Total { get; set; }

        [Column("fixed_assets")]
        public decimal? FixedAssets { get; set; }

        [Column("investments")]
        public decimal? Investments { get; set; }

        [Column("current_assets")]
        public decimal? CurrentAssets { get; set; }

        [Column("creditors")]
        public decimal? Creditors { get; set; }

        [Column("unpaid_dividend")]
        public decimal? UnpaidDividend { get; set; }

        [Column("payables")]
        public decimal? Payables { get; set; }

        [Column("others")]
        public decimal? Others { get; set; }

        [Column("total_current_liabilities")]
        public decimal? TotalCurrentLiabilities { get; set; }

        [Column("net_current_assets")]
        public decimal? NetCurrentAssets { get; set; }

        [Column("miscellaneous_expenditure")]
        public decimal? MiscellaneousExpenditure { get; set; }

        [Column("profit_and_loss_account")]
        public decimal? ProfitAndLossAccount { get; set; }

        [Column("total2")]
        public decimal? Total2 { get; set; }

        // Part 2
        [Column("name")]
        public string? Name { get; set; }

        [Column("place")]
        public string? Place { get; set; }

        [Column("designation")]
        public string? Designation { get; set; } // Pre-filled and readonly

        [Column("membership_number")]
        public string? MembershipNumber { get; set; }

        [Column("partner_name")]
        public string? PartnerName { get; set; } // Selected value from the dropdown

        [Column("partner_dpin")]
        public string? PartnerDpin { get; set; }

        [Column("self_declaration")]
        public Boolean? SelfDeclaration { get; set; } // Checkbox value (Y/N)

        [Column("assets_declaration")]
        public Boolean? AssetsDeclaration { get; set; } // Checkbox value (Y/N)

        [Column("liability_declaration")]
        public Boolean? LiabilityDclaration { get; set; } // Checkbox value (Y/N)

        [Column("authority_copy")]
        public string? AuthorityCopy { get; set; } // File input

        [Column("acknowledgment_copy")]
        public string? AcknowledgmentCopy { get; set; } // File input

        [Column("statement_copy")]
        public string? StatementCopy { get; set; } // File input

        [Column("return_copy")]
        public string? ReturnCopy { get; set; } // File input

        [Column("order_copy")]
        public string? OrderCopy { get; set; } // File input

        [Column("signed_affidavit")]
        public string? SignedAffidavit { get; set; } // File input

        [Column("optional_attachment")]
        public string? OptionalAttachment { get; set; } // File input

    }

    [TableName("tbl_form24", "vw_form24")]
    public class FORM24View : FORM24
    {
        [Column("ref_user_name")]
        public string? RefUserName { get; set; }
    }

}