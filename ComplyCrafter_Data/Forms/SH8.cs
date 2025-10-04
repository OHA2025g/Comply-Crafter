using AlphaUtil.Core.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ComplyCrafter_Data
{
    [TableName("tbl_sh8", "vw_sh8")]
    public class SH8 : BaseModel
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

        [Column("capital_date")]
        public DateTime? CapitalDate { get; set; }

        [Column("equity_share_classes")]
        public int? EquityShareClasses { get; set; }

        [Column("preference_share_classes")]
        public int? PreferenceShareClasses { get; set; }

        [Column("share_description")]
        public string? ShareDescription { get; set; }

        [Column("number_of_shares_authorize_capital")]
        public int? NumberOfSharesAutherizeCapital { get; set; }

        [Column("number_of_shares_issued_capital")]
        public int? NumberOfSharesOfIssuedCapital { get; set; }

        [Column("nominal_number_of_shares_issued_capital")]
        public int? NominalNumberOfSharesIssuedCapital { get; set; }

        [Column("number_of_shares_subscribed_capital")]
        public int? NumberOfSharesSubscribedCapital { get; set; }

        [Column("number_of_shares_paid_up")]
        public int? NumberOfSharesPaidUp { get; set; }

        [Column("nominal_of_shares_eqty_auth")]
        public int? NominalOfSharesEqtyAuth { get; set; }

        [Column("nominal_shares_subs")]
        public int? NominalSharesSubs { get; set; }

        [Column("nominal_shares_paid_up")]
        public int? NominalSharesPaidUp { get; set; }

        [Column("total_authorised")]
        public int? TotalAuthorised { get; set; }

        [Column("total_issued")]
        public int? TotalIssued { get; set; }

        [Column("total_subscribed")]
        public int? TotalSubscribed { get; set; }

        [Column("total_paid_up")]
        public int? TotalPaidUp { get; set; }

        [Column("unclassified_share_total")]
        public int? UnclassifiedShareTotal { get; set; }

        // Paid-up equity capital, paid-up capital, and free reserve
        [Column("equity_capital_date")]
        public DateTime? EquityCapitalDate { get; set; }

        [Column("total_paid_up_equity")]
        public int? TotalPaidUpEquity { get; set; }

        [Column("free_reserves_capital")]
        public int? FreeReservesCapital { get; set; }

        [Column("premium_securities")]
        public int? PremiumSecurities { get; set; }

        // Buy-back details
        [Column("date_of_completion")]
        public DateTime? DateOfCompletion { get; set; }

        [Column("expected_proposed_date")]
        public DateTime? ExpectedProposedDate { get; set; }

        [Column("proposed_completion_date")]
        public DateTime? ProposedCompletionDate { get; set; }

        [Column("extinguishment_date")]
        public DateTime? ExtinguishmentDate { get; set; }

        // Source of the buy-back
        [Column("free_reserves")]
        public Boolean? FreeReserves { get; set; }

        [Column("security_premium_account")]
        public Boolean? SecurityPremiumAccount { get; set; }

        [Column("other_specified_securities")]
        public Boolean? OtherSpecifiedSecurities { get; set; }

        [Column("amount_date")]
        public DateTime? AmountDate { get; set; }

        [Column("free_reserve_amount")]
        public int? FreeReserveAmount { get; set; }

        [Column("buy_back_reserves_amount")]
        public int? BuyBackReservesAmount { get; set; }

        [Column("securities_premium_amount")]
        public int? SecuritiesPremiumAmount { get; set; }

        [Column("security_buy_back_amount")]
        public int? SecurityBuyBackAmount { get; set; }

        [Column("other_specified_securities_amount")]
        public int? OtherSpecifiedSecuritiesAmount { get; set; }

        [Column("other_specified_securities_buy_back")]
        public int? OtherSpecifiedSecuritiesBuyBack { get; set; }

        [Column("equity_shares")]
        public Boolean? EquityShares { get; set; }

        [Column("preference_shares")]
        public Boolean? PreferenceShares { get; set; }

        [Column("other_shares")]
        public Boolean? OtherShares { get; set; }

        [Column("classes_number")]
        public int? ClassesNumber { get; set; }

        [Column("total_buy_back_amount")]
        public int? TotalBuyBackAmount { get; set; }

        [Column("existing_holders")]
        public Boolean? ExistingHolders { get; set; }

        [Column("open_market")]
        public Boolean OpenMarket { get; set; } = false;

        [Column("odd_lots_listed")]
        public Boolean? OddLotsListed { get; set; }

        [Column("employees_stock")]
        public Boolean? EmployeesStock { get; set; }

        [Column("sweat_equity")]
        public Boolean? SweatEquity { get; set; }

        [Column("any_other_mode")]
        public Boolean? AnyOtherMode { get; set; }

        [Column("specify_details")]
        public string? SpecifyDetails { get; set; }

        [Column("article_authorising")]
        public string? ArticleAuthorising { get; set; }

        [Column("directors_date")]
        public DateTime? DirectorsDate { get; set; }

        [Column("resolution_date")]
        public DateTime? ResolutionDate { get; set; }

        [Column("srn")]
        public string? SRN { get; set; }

        // Part 2: Shareholding details
        [Column("equity_shares_preceding")]
        public int? EquitySharesPreceding { get; set; }

        [Column("preference_shares_preceding")]
        public int? PreferenceSharesPreceding { get; set; }

        [Column("other_shares_preceding")]
        public int? OtherSharesPreceding { get; set; }

        [Column("total_shares_preceding")]
        public int? TotalSharesPreceding { get; set; }

        [Column("equity_shares_purchased")]
        public int? EquitySharesPurchased { get; set; }

        [Column("preference_shares_purchased")]
        public int? PreferenceSharesPurchased { get; set; }

        [Column("other_shares_purchased")]
        public int? OtherSharesPurchased { get; set; }

        [Column("total_shares_purchased")]
        public int? TotalSharesPurchased { get; set; }

        [Column("equity_shares_purchased_after_meeting")]
        public int? EquitySharesPurchasedAfterMeeting { get; set; }

        [Column("preference_shares_purchased_after_meeting")]
        public int? PreferenceSharesPurchasedAfterMeeting { get; set; }

        [Column("other_shares_purchased_after_meeting")]
        public int? OtherSharesPurchasedAfterMeeting { get; set; }

        [Column("total_shares_purchased_after_meeting")]
        public int? TotalSharesPurchasedAfterMeeting { get; set; }

        [Column("max_price_equity")]
        public decimal? MaxPriceEquity { get; set; }

        [Column("max_price_preference")]
        public decimal? MaxPricePreference { get; set; }

        [Column("max_price_other")]
        public decimal? MaxPriceOther { get; set; }

        [Column("total_max_price")]
        public decimal? TotalMaxPrice { get; set; }

        [Column("max_price_date_equity")]
        public DateTime? MaxPriceDateEquity { get; set; }

        [Column("max_price_date_preference")]
        public DateTime? MaxPriceDatePreference { get; set; }

        [Column("max_price_date_other")]
        public DateTime? MaxPriceDateOther { get; set; }

        [Column("total_max_price_date")]
        public string? TotalMaxPriceDate { get; set; }

        [Column("equity_shares_sold")]
        public int? EquitySharesSold { get; set; }

        [Column("preference_shares_sold")]
        public int? PreferenceSharesSold { get; set; }

        [Column("other_shares_sold")]
        public int? OtherSharesSold { get; set; }

        [Column("total_shares_sold")]
        public int? TotalSharesSold { get; set; }

        [Column("equity_shares_sold_after_meeting")]
        public int? EquitySharesSoldAfterMeeting { get; set; }

        [Column("preference_shares_sold_after_meeting")]
        public int? PreferenceSharesSoldAfterMeeting { get; set; }

        [Column("other_shares_sold_after_meeting")]
        public int? OtherSharesSoldAfterMeeting { get; set; }

        [Column("total_shares_sold_after_meeting")]
        public int? TotalSharesSoldAfterMeeting { get; set; }

        [Column("max_price_received_equity")]
        public decimal? MaxPriceReceivedEquity { get; set; }

        [Column("max_price_received_preference")]
        public decimal? MaxPriceReceivedPreference { get; set; }

        [Column("max_price_received_other")]
        public decimal? MaxPriceReceivedOther { get; set; }

        [Column("total_max_price_received")]
        public decimal? TotalMaxPriceReceived { get; set; }

        [Column("max_price_received_date_equity")]
        public DateTime? MaxPriceReceivedDateEquity { get; set; }

        [Column("max_price_received_date_preference")]
        public DateTime? MaxPriceReceivedDatePreference { get; set; }

        [Column("max_price_received_date_other")]
        public DateTime? MaxPriceReceivedDateOther { get; set; }

        [Column("total_max_price_received_date")]
        public string? TotalMaxPriceReceivedDate { get; set; }

        [Column("balance_equity_shares")]
        public int? BalanceEquityShares { get; set; }

        [Column("balance_preference_shares")]
        public int? BalancePreferenceShares { get; set; }

        [Column("balance_other_shares")]
        public int? BalanceOtherShares { get; set; }

        [Column("total_balance_shares")]
        public int? TotalBalanceShares { get; set; }

        // Shareholding pattern before buy-back
        [Column("security_date")]
        public DateTime? SecurityDate { get; set; }

        [Column("government_holders")]
        public string? GovernmentHolders { get; set; }

        [Column("government_companies_holders")]
        public string? GovernmentCompaniesHolders { get; set; }

        [Column("public_financial_holder")]
        public string? PublicFinancialHolder { get; set; }

        [Column("nationalized_bank")]
        public string? NationalizedBank { get; set; }

        [Column("mutual_funds")]
        public string? MutualFunds { get; set; }

        [Column("venture_capital")]
        public string? VentureCapital { get; set; }

        [Column("foreign_financial")]
        public string? ForeignFinancial { get; set; }

        [Column("bodies_corporate")]
        public string? BodiesCorporate { get; set; }

        [Column("relatives_of_directors")]
        public string? RelativesOfDirectors { get; set; }

        [Column("other_top_fifty")]
        public string? OtherTopFifty { get; set; }

        [Column("others")]
        public string? Others { get; set; }

        [Column("total")]
        public string? Total { get; set; }

        [Column("total_share_holder")]
        public string? TotalShareHolder { get; set; }

        // Debt equity ratio section
        [Column("government_ratio")]
        public string? GovernmentRatio { get; set; }

        [Column("board_of_resolution")]
        public string? BoardOfResolution { get; set; }

        [Column("reserve_debt")]
        public string? ReserveDebt { get; set; }

        [Column("reserve_post")]
        public string? ReservePost { get; set; }

        // Defaults section
        [Column("repayment_deposit")]
        public string? RepaymentDeposit { get; set; }

        [Column("annual_return")]
        public string? AnnualReturn { get; set; }

        // Part 3
        [Column("first_designation")]
        public string? FirstDesignation { get; set; }

        [Column("first_director_name")]
        public string? FirstDirectorName { get; set; }

        [Column("first_directors_din")]
        public string? FirstDirectorsDin { get; set; }

        [Column("second_designation")]
        public string? SecondDesignation { get; set; }

        [Column("second_director_name")]
        public string? SecondDirectorName { get; set; }

        [Column("second_director_din")]
        public string? SecondDirectorDIN { get; set; }

        [Column("unaudited_financial_statement")]
        public string? UnauditedFinancialStatement { get; set; }

        [Column("auditor_declaration")]
        public string? AuditorDeclaration { get; set; }

        [Column("statutory_approval")]
        public string? StatutoryApproval { get; set; }

        [Column("board_resolution_copy")]
        public string? BoardResolutionCopy { get; set; }

        [Column("optional_attachment")]
        public string? OptionalAttachment { get; set; }


    }

    [TableName("tbl_SH8", "vw_SH8")]
    public class SH8View : SH8
    {
        [Column("ref_user_name")]
        public string? RefUserName { get; set; }
    }

}