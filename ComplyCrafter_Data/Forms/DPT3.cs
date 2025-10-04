using AlphaUtil.Core.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ComplyCrafter_Data
{
    [TableName("tbl_dpt3", "vw_dpt3")]
    public class DPT3 : BaseModel
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

        [Column("type")]
        public string? Type { get; set; }

        [Column("form_purpose")]
        public string? FormPurpose { get; set; }

        [Column("is_gov")]
        public string? IsGov { get; set; }

        [Column("company_objects")]
        public string? CompanyObjects { get; set; }

        [Column("deposit_accepted")]
        public string? DepositAccepted { get; set; }

        [Column("return_period")]
        public DateTime? ReturnPeriod { get; set; }

        [Column("date_of_issue")]
        public DateTime? DateOfIssue { get; set; }

        [Column("date_of_expiry")]
        public DateTime? DateOfExpiry { get; set; }

        [Column("paid_up_share_capital")]
        public decimal? PaidUpShareCapital { get; set; }

        [Column("free_reserves")]
        public decimal? FreeReserves { get; set; }

        [Column("securities_premium_account")]
        public decimal? SecuritiesPremiumAccount { get; set; }

        [Column("accumulated_loss")]
        public decimal? AccumulatedLoss { get; set; }

        [Column("deferred_revenue_expenditure_balance")]
        public decimal? DeferredRevenueExpenditureBalance { get; set; }

        [Column("accumulated_unprovided_depreciation")]
        public decimal? AccumulatedUnprovidedDepreciation { get; set; }

        [Column("miscellaneous_expense")]
        public decimal? MiscellaneousExpense { get; set; }

        [Column("other_intangible_assets")]
        public decimal? OtherIntangibleAssets { get; set; }

        [Column("net_worth")]
        public decimal? NetWorth { get; set; }

        [Column("deposit_max_limit")]
        public decimal? DepositMaxLimit { get; set; }

        [Column("total_deposit_holders_start")]
        public int? TotalDepositHoldersStart { get; set; }

        [Column("total_deposit_holders_end")]
        public int? TotalDepositHoldersEnd { get; set; }

        [Column("existing_deposits_start")]
        public int? ExistingDepositsStart { get; set; }

        [Column("deposits_renewed")]
        public int? DepositsRenewed { get; set; }

        [Column("secured_deposits")]
        public int? SecuredDeposits { get; set; }

        [Column("unsecured_deposits")]
        public int? UnsecuredDeposits { get; set; }

        [Column("deposits_repaid")]
        public int? DepositsRepaid { get; set; }

        [Column("deposits_outstanding")]
        public int? DepositsOutstanding { get; set; }

        [Column("matured_not_claimed")]
        public int? MaturedNotClaimed { get; set; }

        [Column("matured_claimed_not_paid")]
        public int? MaturedClaimedNotPaid { get; set; }

        [Column("deposits_maturing_before_march")]
        public int? DepositsMaturingBeforeMarch { get; set; }

        [Column("deposits_maturing_following_next_year")]
        public int? DepositsMaturingFollowingNextYear { get; set; }

        [Column("amount_required_in_liquid_assets")]
        public decimal? AmountRequiredInLiquidAssets { get; set; }

        [Column("current_deposits_free_from_charge")]
        public decimal? CurrentDepositsFreeFromCharge { get; set; }

        [Column("face_value_gov_securities")]
        public decimal? FaceValueGovSecurities { get; set; }

        [Column("market_value_gov_securities")]
        public decimal? MarketValueGovSecurities { get; set; }

        [Column("face_value_trust_securities")]
        public decimal? FaceValueTrustSecurities { get; set; }

        [Column("market_value_trust_securities")]
        public decimal? MarketValueTrustSecurities { get; set; }

        [Column("credit_rating_agency")]
        public string? CreditRatingAgency { get; set; }

        [Column("credit_rating")]
        public string? CreditRating { get; set; }

        [Column("credit_rating_date")]
        public DateTime? CreditRatingDate { get; set; }

        [Column("gnl_form_srn")]
        public string? GnlFormSrn { get; set; }

        [Column("auditor_name")]
        public string? AuditorName { get; set; }

        [Column("auditor_designation")]
        public string? AuditorDesignation { get; set; }

        [Column("membership_number")]
        public string? MembershipNumber { get; set; }

        [Column("resolution_number")]
        public string? ResolutionNumber { get; set; }

        [Column("declaration_date")]
        public DateTime? DeclarationDate { get; set; }

        [Column("signatory_designation")]
        public string? SignatoryDesignation { get; set; }

        [Column("signatory_id")]
        public string? SignatoryId { get; set; }
    }

    [TableName("tbl_dpt3", "vw_dpt3")]
    public class DPT3View : DPT3
    {
        [Column("ref_user_name")]
        public string? RefUserName { get; set; }
    }

}