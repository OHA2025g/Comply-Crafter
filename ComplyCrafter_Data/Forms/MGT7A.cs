using AlphaUtil.Core.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ComplyCrafter_Data
{
    [TableName("tbl_mgt7a", "vw_mgt7a")]
    public class MGT7A : BaseModel
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

        // Part 1
        [Column("company_gln")]
        public string? CompanyGln { get; set; }

        [Column("pan")]
        public string? Pan { get; set; }

        [Column("company_date_incorporation")]
        public DateTime? CompanyDateIncorporation { get; set; }

        [Column("company_website")]
        public string? CompanyWebsite { get; set; }

        [Column("telephone")]
        public string? Telephone { get; set; }

        [Column("type_of_company")]
        public string? TypeOfCompany { get; set; }

        [Column("category_company")]
        public string? CategoryCompany { get; set; }

        [Column("sub_category_company")]
        public string? SubCategoryCompany { get; set; }

        [Column("company_share_capital")]
        public string? CompanyShareCapital { get; set; }

        [Column("form_filed")]
        public string? FormFiled { get; set; }

        // Part 2
        [Column("financial_year_from")]
        public string? FinancialYearFrom { get; set; }

        [Column("financial_year_to")]
        public string? FinancialYearTo { get; set; }

        [Column("annual_general_meeting")]
        public string? AnnualGeneralMeeting { get; set; }

        [Column("date_amg")]
        public DateTime? DateAmg { get; set; }

        [Column("due_date_amg")]
        public DateTime? DueDateAmg { get; set; }

        [Column("extension_agm")]
        public string? ExtensionAgm { get; set; }

        [Column("srn_application_extention")]
        public string? SrnApplicationExtention { get; set; }

        [Column("due_date_agm2")]
        public DateTime? DueDateAgm2 { get; set; }

        [Column("reasons_specify")]
        public string? ReasonsSpecify { get; set; }

        [Column("turn_over")]
        public string? TurnOver { get; set; }

        [Column("net_worth")]
        public string? NetWorth { get; set; }

        // Part 3: Debentures Section (counts/amounts)
        [Column("total_auth")]
        public decimal? TotalAuth { get; set; }

        [Column("total_iss")]
        public decimal? TotalIss { get; set; }

        [Column("total_sub")]
        public decimal? TotalSub { get; set; }

        [Column("total_paid")]
        public decimal? TotalPaid { get; set; }

        [Column("total_auth_amount")]
        public decimal? TotalAuthAmount { get; set; }

        [Column("total_iss_amount")]
        public decimal? TotalIssAmount { get; set; }

        [Column("total_sub_amount")]
        public decimal? TotalSubAmount { get; set; }

        [Column("total_paid_amount")]
        public decimal? TotalPaidAmount { get; set; }

        // Preference Shares Count
        [Column("preference_shares_authorized_count")]
        public decimal? PreferenceSharesAuthorizedCount { get; set; }

        [Column("preference_shares_issued_count")]
        public decimal? PreferenceSharesIssuedCount { get; set; }

        [Column("preference_shares_subscribed_count")]
        public decimal? PreferenceSharesSubscribedCount { get; set; }

        [Column("preference_shares_paid_up_count")]
        public decimal? PreferenceSharesPaidUpCount { get; set; }

        // Preference Shares Amount (in Rupees)
        [Column("preference_shares_authorized_amount")]
        public decimal? PreferenceSharesAuthorizedAmount { get; set; }

        [Column("preference_shares_issued_amount")]
        public decimal? PreferenceSharesIssuedAmount { get; set; }

        [Column("preference_shares_subscribed_amount")]
        public decimal? PreferenceSharesSubscribedAmount { get; set; }

        [Column("preference_shares_paid_up_amount")]
        public decimal? PreferenceSharesPaidUpAmount { get; set; }

        [Column("share_capital")]
        public decimal? ShareCapital { get; set; }

        // Part 4: Equity Shares Details
        [Column("equity_shares_at_beginning_number_of_shares")]
        public decimal? EquitySharesAtBeginningNumberOfShares { get; set; }

        [Column("equity_shares_at_beginning_nominal_amount")]
        public decimal? EquitySharesAtBeginningNominalAmount { get; set; }

        [Column("equity_shares_at_beginning_paid_up_amount")]
        public decimal? EquitySharesAtBeginningPaidUpAmount { get; set; }

        [Column("equity_shares_at_beginning_premium")]
        public decimal? EquitySharesAtBeginningPremium { get; set; }

        [Column("equity_shares_increase_number_of_shares")]
        public decimal? EquitySharesIncreaseNumberOfShares { get; set; }

        [Column("equity_shares_increase_nominal_amount")]
        public decimal? EquitySharesIncreaseNominalAmount { get; set; }

        [Column("equity_shares_increase_paid_up_amount")]
        public decimal? EquitySharesIncreasePaidUpAmount { get; set; }

        [Column("equity_shares_increase_premium")]
        public decimal? EquitySharesIncreasePremium { get; set; }

        [Column("public_issues_number_of_shares")]
        public decimal? PublicIssuesNumberOfShares { get; set; }

        [Column("public_issues_nominal_amount")]
        public decimal? PublicIssuesNominalAmount { get; set; }

        [Column("public_issues_paid_up_amount")]
        public decimal? PublicIssuesPaidUpAmount { get; set; }

        [Column("public_issues_premium")]
        public decimal? PublicIssuesPremium { get; set; }

        [Column("rights_issue_number_of_shares")]
        public decimal? RightsIssueNumberOfShares { get; set; }

        [Column("rights_issue_nominal_amount")]
        public decimal? RightsIssueNominalAmount { get; set; }

        [Column("rights_issue_paid_up_amount")]
        public decimal? RightsIssuePaidUpAmount { get; set; }

        [Column("rights_issue_premium")]
        public decimal? RightsIssuePremium { get; set; }

        [Column("bonus_issue_number_of_shares")]
        public decimal? BonusIssueNumberOfShares { get; set; }

        [Column("bonus_issue_nominal_amount")]
        public decimal? BonusIssueNominalAmount { get; set; }

        [Column("bonus_issue_paid_up_amount")]
        public decimal? BonusIssuePaidUpAmount { get; set; }

        [Column("bonus_issue_premium")]
        public decimal? BonusIssuePremium { get; set; }

        [Column("private_placement_number_of_shares")]
        public decimal? PrivatePlacementNumberOfShares { get; set; }

        [Column("private_placement_nominal_amount")]
        public decimal? PrivatePlacementNominalAmount { get; set; }

        [Column("private_placement_paid_up_amount")]
        public decimal? PrivatePlacementPaidUpAmount { get; set; }

        [Column("private_placement_premium")]
        public decimal? PrivatePlacementPremium { get; set; }

        [Column("esops_number_of_shares")]
        public decimal? EsopsNumberOfShares { get; set; }

        [Column("esops_nominal_amount")]
        public decimal? EsopsNominalAmount { get; set; }

        [Column("esops_paid_up_amount")]
        public decimal? EsopsPaidUpAmount { get; set; }

        [Column("esops_premium")]
        public decimal? EsopsPremium { get; set; }

        [Column("sweat_equity_number_of_shares")]
        public decimal? SweatEquityNumberOfShares { get; set; }

        [Column("sweat_equity_nominal_amount")]
        public decimal? SweatEquityNominalAmount { get; set; }

        [Column("sweat_equity_paid_up_amount")]
        public decimal? SweatEquityPaidUpAmount { get; set; }

        [Column("sweat_equity_premium")]
        public decimal? SweatEquityPremium { get; set; }

        [Column("preference_conversion_number_of_shares")]
        public decimal? PreferenceConversionNumberOfShares { get; set; }

        [Column("preference_conversion_nominal_amount")]
        public decimal? PreferenceConversionNominalAmount { get; set; }

        [Column("preference_conversion_paid_up_amount")]
        public decimal? PreferenceConversionPaidUpAmount { get; set; }

        [Column("preference_conversion_premium")]
        public decimal? PreferenceConversionPremium { get; set; }

        [Column("debenture_conversion_number_of_shares")]
        public decimal? DebentureConversionNumberOfShares { get; set; }

        [Column("debenture_conversion_nominal_amount")]
        public decimal? DebentureConversionNominalAmount { get; set; }

        [Column("debenture_conversion_paid_up_amount")]
        public decimal? DebentureConversionPaidUpAmount { get; set; }

        [Column("debenture_conversion_premium")]
        public decimal? DebentureConversionPremium { get; set; }

        [Column("gdr_adr_number_of_shares")]
        public decimal? GdrAdrNumberOfShares { get; set; }

        [Column("gdr_adr_nominal_amount")]
        public decimal? GdrAdrNominalAmount { get; set; }

        [Column("gdr_adr_paid_up_amount")]
        public decimal? GdrAdrPaidUpAmount { get; set; }

        [Column("gdr_adr_premium")]
        public decimal? GdrAdrPremium { get; set; }

        [Column("other_equity_description")]
        public string? OtherEquityDescription { get; set; }

        [Column("other_equity_number_of_shares")]
        public decimal? OtherEquityNumberOfShares { get; set; }

        [Column("other_equity_nominal_amount")]
        public decimal? OtherEquityNominalAmount { get; set; }

        [Column("other_equity_paid_up_amount")]
        public decimal? OtherEquityPaidUpAmount { get; set; }

        [Column("other_equity_premium")]
        public decimal? OtherEquityPremium { get; set; }

        [Column("equity_shares_decrease_number_of_shares")]
        public decimal? EquitySharesDecreaseNumberOfShares { get; set; }

        [Column("equity_shares_decrease_nominal_amount")]
        public decimal? EquitySharesDecreaseNominalAmount { get; set; }

        [Column("equity_shares_decrease_paid_up_amount")]
        public decimal? EquitySharesDecreasePaidUpAmount { get; set; }

        [Column("equity_shares_decrease_premium")]
        public decimal? EquitySharesDecreasePremium { get; set; }

        [Column("buy_back_number_of_shares")]
        public decimal? BuyBackNumberOfShares { get; set; }

        [Column("buy_back_nominal_amount")]
        public decimal? BuyBackNominalAmount { get; set; }

        [Column("buy_back_paid_up_amount")]
        public decimal? BuyBackPaidUpAmount { get; set; }

        [Column("buy_back_premium")]
        public decimal? BuyBackPremium { get; set; }

        [Column("forfeited_shares_number_of_shares")]
        public decimal? ForfeitedSharesNumberOfShares { get; set; }

        [Column("forfeited_shares_nominal_amount")]
        public decimal? ForfeitedSharesNominalAmount { get; set; }

        [Column("forfeited_shares_paid_up_amount")]
        public decimal? ForfeitedSharesPaidUpAmount { get; set; }

        [Column("forfeited_shares_premium")]
        public decimal? ForfeitedSharesPremium { get; set; }

        [Column("capital_reduction_number_of_shares")]
        public decimal? CapitalReductionNumberOfShares { get; set; }

        [Column("capital_reduction_nominal_amount")]
        public decimal? CapitalReductionNominalAmount { get; set; }

        [Column("capital_reduction_paid_up_amount")]
        public decimal? CapitalReductionPaidUpAmount { get; set; }

        [Column("capital_reduction_premium")]
        public decimal? CapitalReductionPremium { get; set; }

        [Column("other_decrease_description")]
        public string? OtherDecreaseDescription { get; set; }

        [Column("other_decrease_number_of_shares")]
        public decimal? OtherDecreaseNumberOfShares { get; set; }

        [Column("other_decrease_nominal_amount")]
        public decimal? OtherDecreaseNominalAmount { get; set; }

        [Column("other_decrease_paid_up_amount")]
        public decimal? OtherDecreasePaidUpAmount { get; set; }

        [Column("other_decrease_premium")]
        public decimal? OtherDecreasePremium { get; set; }

        [Column("equity_shares_at_end_number_of_shares")]
        public decimal? EquitySharesAtEndNumberOfShares { get; set; }

        [Column("equity_shares_at_end_nominal_amount")]
        public decimal? EquitySharesAtEndNominalAmount { get; set; }

        [Column("equity_shares_at_end_paid_up_amount")]
        public decimal? EquitySharesAtEndPaidUpAmount { get; set; }

        [Column("equity_shares_at_end_premium")]
        public decimal? EquitySharesAtEndPremium { get; set; }

        // Part 5: Preference Shares Details
        [Column("preference_shares_at_beginning_number_of_shares")]
        public decimal? PreferenceSharesAtBeginningNumberOfShares { get; set; }

        [Column("preference_shares_at_beginning_nominal_amount")]
        public decimal? PreferenceSharesAtBeginningNominalAmount { get; set; }

        [Column("preference_shares_at_beginning_paid_up_amount")]
        public decimal? PreferenceSharesAtBeginningPaidUpAmount { get; set; }

        [Column("preference_shares_at_beginning_premium")]
        public decimal? PreferenceSharesAtBeginningPremium { get; set; }

        [Column("preference_shares_increase_number_of_shares")]
        public decimal? PreferenceSharesIncreaseNumberOfShares { get; set; }

        [Column("preference_shares_increase_nominal_amount")]
        public decimal? PreferenceSharesIncreaseNominalAmount { get; set; }

        [Column("preference_shares_increase_paid_up_amount")]
        public decimal? PreferenceSharesIncreasePaidUpAmount { get; set; }

        [Column("preference_shares_increase_premium")]
        public decimal? PreferenceSharesIncreasePremium { get; set; }

        [Column("preference_shares_issued_number_of_shares")]
        public decimal? PreferenceSharesIssuedNumberOfShares { get; set; }

        [Column("preference_shares_issued_nominal_amount")]
        public decimal? PreferenceSharesIssuedNominalAmount { get; set; }

        [Column("preference_shares_issued_paid_up_amount")]
        public decimal? PreferenceSharesIssuedPaidUpAmount { get; set; }

        [Column("preference_shares_issued_premium")]
        public decimal? PreferenceSharesIssuedPremium { get; set; }

        [Column("preference_shares_reissued_number_of_shares")]
        public decimal? PreferenceSharesReissuedNumberOfShares { get; set; }

        [Column("preference_shares_reissued_nominal_amount")]
        public decimal? PreferenceSharesReissuedNominalAmount { get; set; }

        [Column("preference_shares_reissued_paid_up_amount")]
        public decimal? PreferenceSharesReissuedPaidUpAmount { get; set; }

        [Column("preference_shares_reissued_premium")]
        public decimal? PreferenceSharesReissuedPremium { get; set; }

        [Column("other_preference_increase_description")]
        public string? OtherPreferenceIncreaseDescription { get; set; }

        [Column("other_preference_increase_number_of_shares")]
        public decimal? OtherPreferenceIncreaseNumberOfShares { get; set; }

        [Column("other_preference_increase_nominal_amount")]
        public decimal? OtherPreferenceIncreaseNominalAmount { get; set; }

        [Column("other_preference_increase_paid_up_amount")]
        public decimal? OtherPreferenceIncreasePaidUpAmount { get; set; }

        [Column("other_preference_increase_premium")]
        public decimal? OtherPreferenceIncreasePremium { get; set; }

        [Column("preference_shares_decrease_number_of_shares")]
        public decimal? PreferenceSharesDecreaseNumberOfShares { get; set; }

        [Column("preference_shares_decrease_nominal_amount")]
        public decimal? PreferenceSharesDecreaseNominalAmount { get; set; }

        [Column("preference_shares_decrease_paid_up_amount")]
        public decimal? PreferenceSharesDecreasePaidUpAmount { get; set; }

        [Column("preference_shares_decrease_premium")]
        public decimal? PreferenceSharesDecreasePremium { get; set; }

        [Column("preference_shares_redeemed_number_of_shares")]
        public decimal? PreferenceSharesRedeemedNumberOfShares { get; set; }

        [Column("preference_shares_redeemed_nominal_amount")]
        public decimal? PreferenceSharesRedeemedNominalAmount { get; set; }

        [Column("preference_shares_redeemed_paid_up_amount")]
        public decimal? PreferenceSharesRedeemedPaidUpAmount { get; set; }

        [Column("preference_shares_redeemed_premium")]
        public decimal? PreferenceSharesRedeemedPremium { get; set; }

        [Column("preference_shares_forfeited_number_of_shares")]
        public decimal? PreferenceSharesForfeitedNumberOfShares { get; set; }

        [Column("preference_shares_forfeited_nominal_amount")]
        public decimal? PreferenceSharesForfeitedNominalAmount { get; set; }

        [Column("preference_shares_forfeited_paid_up_amount")]
        public decimal? PreferenceSharesForfeitedPaidUpAmount { get; set; }

        [Column("preference_shares_forfeited_premium")]
        public decimal? PreferenceSharesForfeitedPremium { get; set; }

        [Column("preference_capital_reduction_number_of_shares")]
        public decimal? PreferenceCapitalReductionNumberOfShares { get; set; }

        [Column("preference_capital_reduction_nominal_amount")]
        public decimal? PreferenceCapitalReductionNominalAmount { get; set; }

        [Column("preference_capital_reduction_paid_up_amount")]
        public decimal? PreferenceCapitalReductionPaidUpAmount { get; set; }

        [Column("preference_capital_reduction_premium")]
        public decimal? PreferenceCapitalReductionPremium { get; set; }

        [Column("other_preference_decrease_description")]
        public string? OtherPreferenceDecreaseDescription { get; set; }

        [Column("other_preference_decrease_number_of_shares")]
        public decimal? OtherPreferenceDecreaseNumberOfShares { get; set; }

        [Column("other_preference_decrease_nominal_amount")]
        public decimal? OtherPreferenceDecreaseNominalAmount { get; set; }

        [Column("other_preference_decrease_paid_up_amount")]
        public decimal? OtherPreferenceDecreasePaidUpAmount { get; set; }

        [Column("other_preference_decrease_premium")]
        public decimal? OtherPreferenceDecreasePremium { get; set; }

        [Column("preference_shares_at_end_number_of_shares")]
        public decimal? PreferenceSharesAtEndNumberOfShares { get; set; }

        [Column("preference_shares_at_end_nominal_amount")]
        public decimal? PreferenceSharesAtEndNominalAmount { get; set; }

        [Column("preference_shares_at_end_paid_up_amount")]
        public decimal? PreferenceSharesAtEndPaidUpAmount { get; set; }

        [Column("preference_shares_at_end_premium")]
        public decimal? PreferenceSharesAtEndPremium { get; set; }

        // Part 6
        [Column("is_nil")]
        public Boolean? IsNil { get; set; }

        [Column("details_provided_in_digital_media")]
        public string? DetailsProvidedInDigitalMedia { get; set; }

        [Column("seprate_sheet_transfers")]
        public string? SeprateSheetTransfers { get; set; }

        [Column("previous_annual_meeting_date")]
        public DateTime? PreviousAnnualMeetingDate { get; set; }

        // Part 7: Debentures
        [Column("debentures_number_of_units")]
        public decimal? DebenturesNumberOfUnits { get; set; }

        [Column("nominal_value_per_unit")]
        public decimal? NominalValuePerUnit { get; set; }

        [Column("deb_total_unit1")]
        public decimal? DebTotalUnit1 { get; set; }

        [Column("partly_convertible_debentures_number_of_units")]
        public decimal? PartlyConvertibleDebenturesNumberOfUnits { get; set; }

        [Column("partly_convertible_debentures_nominal_value")]
        public decimal? PartlyConvertibleDebenturesNominalValue { get; set; }

        [Column("partly_convertible_debentures_total_value")]
        public decimal? PartlyConvertibleDebenturesTotalValue { get; set; }

        [Column("fully_convertible_debentures_number_of_units")]
        public decimal? FullyConvertibleDebenturesNumberOfUnits { get; set; }

        [Column("fully_convertible_debentures_nominal_value_per_unit")]
        public decimal? FullyConvertibleDebenturesNominalValuePerUnit { get; set; }

        [Column("fully_convertible_debentures_total_value")]
        public decimal? FullyConvertibleDebenturesTotalValue { get; set; }

        [Column("total_debentures_number_of_units")]
        public decimal? TotalDebenturesNumberOfUnits { get; set; }

        [Column("total_debentures_nominal_value_per_unit")]
        public decimal? TotalDebenturesNominalValuePerUnit { get; set; }

        [Column("total_debentures_total_value")]
        public decimal? TotalDebenturesTotalValue { get; set; }

        // Details of Debentures
        [Column("non_convertible_debentures_outstanding_at_beginning")]
        public decimal? NonConvertibleDebenturesOutstandingAtBeginning { get; set; }

        [Column("non_convertible_debentures_increase_during_year")]
        public decimal? NonConvertibleDebenturesIncreaseDuringYear { get; set; }

        [Column("non_convertible_debentures_decrease_during_year")]
        public decimal? NonConvertibleDebenturesDecreaseDuringYear { get; set; }

        [Column("non_convertible_debentures_outstanding_at_end")]
        public decimal? NonConvertibleDebenturesOutstandingAtEnd { get; set; }

        [Column("partly_convertible_debentures_outstanding_at_beginning")]
        public decimal? PartlyConvertibleDebenturesOutstandingAtBeginning { get; set; }

        [Column("partly_convertible_debentures_increase_during_year")]
        public decimal? PartlyConvertibleDebenturesIncreaseDuringYear { get; set; }

        [Column("partly_convertible_debentures_decrease_during_year")]
        public decimal? PartlyConvertibleDebenturesDecreaseDuringYear { get; set; }

        [Column("partly_convertible_debentures_outstanding_at_end")]
        public decimal? PartlyConvertibleDebenturesOutstandingAtEnd { get; set; }

        [Column("fully_convertible_debentures_outstanding_at_beginning")]
        public decimal? FullyConvertibleDebenturesOutstandingAtBeginning { get; set; }

        [Column("fully_convertible_debentures_increase_during_year")]
        public decimal? FullyConvertibleDebenturesIncreaseDuringYear { get; set; }

        [Column("fully_convertible_debentures_decrease_during_year")]
        public decimal? FullyConvertibleDebenturesDecreaseDuringYear { get; set; }

        [Column("fully_convertible_debentures_outstanding_at_end")]
        public decimal? FullyConvertibleDebenturesOutstandingAtEnd { get; set; }

        // Part 8: Shareholding Details (non-public)
        [Column("ind_eqt_num")]
        public decimal? IndEqtNum { get; set; }

        [Column("ind_eqt_pre")]
        public decimal? IndEqtPre { get; set; }

        [Column("ind_pre_num")]
        public decimal? IndPreNum { get; set; }

        [Column("ind_pre_pre")]
        public decimal? IndPrePre { get; set; }

        [Column("nri_eqt_num")]
        public decimal? NriEqtNum { get; set; }

        [Column("nri_eqt_pre")]
        public decimal? NriEqtPre { get; set; }

        [Column("nri_pre_num")]
        public decimal? NriPreNum { get; set; }

        [Column("nri_pre_pre")]
        public decimal? NriPrePre { get; set; }

        [Column("oth_eqt_num")]
        public decimal? OthEqtNum { get; set; }

        [Column("oth_eqt_pre")]
        public decimal? OthEqtPre { get; set; }

        [Column("oth_pre_num")]
        public decimal? OthPreNum { get; set; }

        [Column("oth_pre_pre")]
        public decimal? OthPrePre { get; set; }

        [Column("cgov_eqt_num")]
        public decimal? CgovEqtNum { get; set; }

        [Column("cgov_eqt_pre")]
        public decimal? CgovEqtPre { get; set; }

        [Column("cgov_pre_num")]
        public decimal? CgovPreNum { get; set; }

        [Column("cgov_pre_pre")]
        public decimal? CgovPrePre { get; set; }

        [Column("sgov_eqt_num")]
        public decimal? SgovEqtNum { get; set; }

        [Column("sgov_eqt_pre")]
        public decimal? SgovEqtPre { get; set; }

        [Column("sgov_pre_num")]
        public decimal? SgovPreNum { get; set; }

        [Column("sgov_pre_pre")]
        public decimal? SgovPrePre { get; set; }

        [Column("govcom_eqt_num")]
        public decimal? GovcomEqtNum { get; set; }

        [Column("govcom_eqt_pre")]
        public decimal? GovcomEqtPre { get; set; }

        [Column("govcom_pre_num")]
        public decimal? GovcomPreNum { get; set; }

        [Column("govcom_pre_pre")]
        public decimal? GovcomPrePre { get; set; }

        [Column("insur_eqt_num")]
        public decimal? InsurEqtNum { get; set; }

        [Column("insur_eqt_pre")]
        public decimal? InsurEqtPre { get; set; }

        [Column("insur_pre_num")]
        public decimal? InsurPreNum { get; set; }

        [Column("insur_pre_pre")]
        public decimal? InsurPrePre { get; set; }

        [Column("banks_eqt_num")]
        public decimal? BanksEqtNum { get; set; }

        [Column("banks_eqt_pre")]
        public decimal? BanksEqtPre { get; set; }

        [Column("banks_pre_num")]
        public decimal? BanksPreNum { get; set; }

        [Column("banks_pre_pre")]
        public decimal? BanksPrePre { get; set; }

        [Column("finist_eqt_num")]
        public decimal? FinistEqtNum { get; set; }

        [Column("finist_eqt_pre")]
        public decimal? FinistEqtPre { get; set; }

        [Column("finist_pre_num")]
        public decimal? FinistPreNum { get; set; }

        [Column("finist_pre_pre")]
        public decimal? FinistPrePre { get; set; }

        [Column("fit_eqt_num")]
        public decimal? FitEqtNum { get; set; }

        [Column("fit_eqt_pre")]
        public decimal? FitEqtPre { get; set; }

        [Column("fit_pre_num")]
        public decimal? FitPreNum { get; set; }

        [Column("fit_pre_pre")]
        public decimal? FitPrePre { get; set; }

        [Column("mf_eqt_num")]
        public decimal? MfEqtNum { get; set; }

        [Column("mf_eqt_pre")]
        public decimal? MfEqtPre { get; set; }

        [Column("mf_pre_num")]
        public decimal? MfPreNum { get; set; }

        [Column("mf_pre_pre")]
        public decimal? MfPrePre { get; set; }

        [Column("vc_eqt_num")]
        public decimal? VcEqtNum { get; set; }

        [Column("vc_eqt_pre")]
        public decimal? VcEqtPre { get; set; }

        [Column("vc_pre_num")]
        public decimal? VcPreNum { get; set; }

        [Column("vc_pre_pre")]
        public decimal? VcPrePre { get; set; }

        [Column("corp_eqt_num")]
        public decimal? CorpEqtNum { get; set; }

        [Column("corp_eqt_pre")]
        public decimal? CorpEqtPre { get; set; }

        [Column("corp_pre_num")]
        public decimal? CorpPreNum { get; set; }

        [Column("corp_pre_pre")]
        public decimal? CorpPrePre { get; set; }

        [Column("other_eqt_num")]
        public decimal? OtherEqtNum { get; set; }

        [Column("other_eqt_pre")]
        public decimal? OtherEqtPre { get; set; }

        [Column("other_pre_num")]
        public decimal? OtherPreNum { get; set; }

        [Column("other_pre_pre")]
        public decimal? OtherPrePre { get; set; }

        [Column("total_eqt_num")]
        public decimal? TotalEqtNum { get; set; }

        [Column("total_eqt_pre")]
        public decimal? TotalEqtPre { get; set; }

        [Column("total_pre_num")]
        public decimal? TotalPreNum { get; set; }

        [Column("total_pre_pre")]
        public decimal? TotalPrePre { get; set; }

        [Column("numbers_promoters")]
        public decimal? NumbersPromoters { get; set; }

        // Part 9: Public Shareholding Details
        [Column("ind_eqt_num_pub")]
        public decimal? IndEqtNumPub { get; set; }

        [Column("ind_eqt_pre_pub")]
        public decimal? IndEqtPrePub { get; set; }

        [Column("ind_pre_num_pub")]
        public decimal? IndPreNumPub { get; set; }

        [Column("ind_pre_pre_pub")]
        public decimal? IndPrePrePub { get; set; }

        [Column("nri_eqt_num_pub")]
        public decimal? NriEqtNumPub { get; set; }

        [Column("nri_eqt_pre_pub")]
        public decimal? NriEqtPrePub { get; set; }

        [Column("nri_pre_num_pub")]
        public decimal? NriPreNumPub { get; set; }

        [Column("nri_pre_pre_pub")]
        public decimal? NriPrePrePub { get; set; }

        [Column("oth_eqt_num_pub")]
        public decimal? OthEqtNumPub { get; set; }

        [Column("oth_eqt_pre_pub")]
        public decimal? OthEqtPrePub { get; set; }

        [Column("oth_pre_num_pub")]
        public decimal? OthPreNumPub { get; set; }

        [Column("oth_pre_pre_pub")]
        public decimal? OthPrePrePub { get; set; }

        [Column("cgov_eqt_num_pub")]
        public decimal? CgovEqtNumPub { get; set; }

        [Column("cgov_eqt_pre_pub")]
        public decimal? CgovEqtPrePub { get; set; }

        [Column("cgov_pre_num_pub")]
        public decimal? CgovPreNumPub { get; set; }

        [Column("cgov_pre_pre_pub")]
        public decimal? CgovPrePrePub { get; set; }

        [Column("sgov_eqt_num_pub")]
        public decimal? SgovEqtNumPub { get; set; }

        [Column("sgov_eqt_pre_pub")]
        public decimal? SgovEqtPrePub { get; set; }

        [Column("sgov_pre_num_pub")]
        public decimal? SgovPreNumPub { get; set; }

        [Column("sgov_pre_pre_pub")]
        public decimal? SgovPrePrePub { get; set; }

        [Column("govcom_eqt_num_pub")]
        public decimal? GovcomEqtNumPub { get; set; }

        [Column("govcom_eqt_pre_pub")]
        public decimal? GovcomEqtPrePub { get; set; }

        [Column("govcom_pre_num_pub")]
        public decimal? GovcomPreNumPub { get; set; }

        [Column("govcom_pre_pre_pub")]
        public decimal? GovcomPrePrePub { get; set; }

        [Column("insur_eqt_num_pub")]
        public decimal? InsurEqtNumPub { get; set; }

        [Column("insur_eqt_pre_pub")]
        public decimal? InsurEqtPrePub { get; set; }

        [Column("insur_pre_num_pub")]
        public decimal? InsurPreNumPub { get; set; }

        [Column("insur_pre_pre_pub")]
        public decimal? InsurPrePrePub { get; set; }

        [Column("banks_eqt_num_pub")]
        public decimal? BanksEqtNumPub { get; set; }

        [Column("banks_eqt_pre_pub")]
        public decimal? BanksEqtPrePub { get; set; }

        [Column("banks_pre_num_pub")]
        public decimal? BanksPreNumPub { get; set; }

        [Column("banks_pre_pre_pub")]
        public decimal? BanksPrePrePub { get; set; }

        [Column("finist_eqt_num_pub")]
        public decimal? FinistEqtNumPub { get; set; }

        [Column("finist_eqt_pre_pub")]
        public decimal? FinistEqtPrePub { get; set; }

        [Column("finist_pre_num_pub")]
        public decimal? FinistPreNumPub { get; set; }

        [Column("finist_pre_pre_pub")]
        public decimal? FinistPrePrePub { get; set; }

        [Column("fit_eqt_num_pub")]
        public decimal? FitEqtNumPub { get; set; }

        [Column("fit_eqt_pre_pub")]
        public decimal? FitEqtPrePub { get; set; }

        [Column("fit_pre_num_pub")]
        public decimal? FitPreNumPub { get; set; }

        [Column("fit_pre_pre_pub")]
        public decimal? FitPrePrePub { get; set; }

        [Column("mf_eqt_num_pub")]
        public decimal? MfEqtNumPub { get; set; }

        [Column("mf_eqt_pre_pub")]
        public decimal? MfEqtPrePub { get; set; }

        [Column("mf_pre_num_pub")]
        public decimal? MfPreNumPub { get; set; }

        [Column("mf_pre_pre_pub")]
        public decimal? MfPrePrePub { get; set; }

        [Column("vc_eqt_num_pub")]
        public decimal? VcEqtNumPub { get; set; }

        [Column("vc_eqt_pre_pub")]
        public decimal? VcEqtPrePub { get; set; }

        [Column("vc_pre_num_pub")]
        public decimal? VcPreNumPub { get; set; }

        [Column("vc_pre_pre_pub")]
        public decimal? VcPrePrePub { get; set; }

        [Column("corp_eqt_num_pub")]
        public decimal? CorpEqtNumPub { get; set; }

        [Column("corp_eqt_pre_pub")]
        public decimal? CorpEqtPrePub { get; set; }

        [Column("corp_pre_num_pub")]
        public decimal? CorpPreNumPub { get; set; }

        [Column("corp_pre_pre_pub")]
        public decimal? CorpPrePrePub { get; set; }

        [Column("other_eqt_num_pub")]
        public decimal? OtherEqtNumPub { get; set; }

        [Column("other_eqt_pre_pub")]
        public decimal? OtherEqtPrePub { get; set; }

        [Column("other_pre_num_pub")]
        public decimal? OtherPreNumPub { get; set; }

        [Column("other_pre_pre_pub")]
        public decimal? OtherPrePrePub { get; set; }

        [Column("total_eqt_num_pub")]
        public decimal? TotalEqtNumPub { get; set; }

        [Column("total_eqt_pre_pub")]
        public decimal? TotalEqtPrePub { get; set; }

        [Column("total_pre_num_pub")]
        public decimal? TotalPreNumPub { get; set; }

        [Column("total_pre_pre_pub")]
        public decimal? TotalPrePrePub { get; set; }

        [Column("numbers_promoters_pub")]
        public decimal? NumbersPromotersPub { get; set; }

        // Promoters Section
        [Column("num_of_promoters")]
        public decimal? NumOfPromoters { get; set; }

        [Column("num_of_promoters1")]
        public decimal? NumOfPromoters1 { get; set; }

        [Column("num_of_members")]
        public decimal? NumOfMembers { get; set; }

        [Column("num_of_members1")]
        public decimal? NumOfMembers1 { get; set; }

        [Column("num_of_deb")]
        public decimal? NumOfDeb { get; set; }

        [Column("num_of_deb1")]
        public decimal? NumOfDeb1 { get; set; }

        // Part 10: Certification Section
        [Column("complince_made")]
        public string? ComplinceMade { get; set; }

        [Column("reason")]
        public string? Reason { get; set; }

        // Penalty Section
        [Column("resolution_number")]
        public string? ResolutionNumber { get; set; }

        [Column("resolution_date")]
        public DateTime? ResolutionDate { get; set; }

        [Column("signed")]
        public string? Signed { get; set; }

        [Column("din_pan")]
        public string? DinPan { get; set; }


    }

    [TableName("tbl_mgt7a", "vw_mgt7a")]
    public class MGT7AView : MGT7A
    {
        [Column("ref_user_name")]
        public string? RefUserName { get; set; }
    }

}