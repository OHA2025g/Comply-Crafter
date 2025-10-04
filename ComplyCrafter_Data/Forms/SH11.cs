using AlphaUtil.Core.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ComplyCrafter_Data
{
    [TableName("tbl_sh11", "vw_sh11")]
    public class SH11 : BaseModel
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

        [Column("srn_of_sh8")]
        public string? SrnOfSh8 { get; set; }

        [Column("srn_of_sh9")]
        public string? SrnOfSh9 { get; set; } 

        [Column("amount_as_on")]
        public DateTime? AmountAsOn { get; set; }

        [Column("free_reserve")]
        public Boolean? FreeReserve { get; set; } 

        [Column("free_reserve_amount")]
        public string? FreeReserveAmount { get; set; } 

        [Column("free_reserve_utilized_amount")]
        public string? FreeReserveUtilizedAmount { get; set; } 

        [Column("securities_premium")]
        public Boolean? SecuritiesPremium { get; set; } 

        [Column("securities_premium_amount")]
        public string? SecuritiesPremiumAmount { get; set; } 

        [Column("securities_premium_utilized_amount")]
        public string? SecuritiesPremiumUtilizedAmount { get; set; } 

        [Column("preceding_capital")]
        public Boolean? PrecedingCapital { get; set; } 

        [Column("proceeds_capital_amount")]
        public string? ProceedsCapitalAmount { get; set; } 

        [Column("proceeds_capital_utilized")]
        public string? ProceedsCapitalUtilized { get; set; } 

        [Column("capital_share_date")]
        public DateTime? CapitalShareDate { get; set; } 

        [Column("equity_classes")]
        public int? EquityClasses { get; set; }  

        [Column("preference_classes")]
        public int? PreferenceClasses { get; set; } 

        [Column("capital_description")]
        public string? CapitalDescription { get; set; } 

        [Column("pre_buy_shares_auth")]
        public int? PreBuySharesAuth { get; set; } 

        [Column("pre_buy_shares_issue")]
        public int? PreBuySharesIssue { get; set; } 

        [Column("pre_buy_shares_subs")]
        public int? PreBuySharesSubs { get; set; } 

        [Column("pre_buy_shares_paid_up")]
        public int? PreBuySharesPaidUp { get; set; } 

        [Column("shares_eqty_auth")]
        public int? SharesEqtyAuth { get; set; } 

        [Column("shares_issue")]
        public int? SharesIssue { get; set; } 

        [Column("shares_subs")]
        public int? SharesSubs { get; set; } 

        [Column("shares_paid_up")]
        public int? SharesPaidUp { get; set; } 

        [Column("total_amount_auth")]
        public int? TotalAmountAuth { get; set; } 

        [Column("total_amount_issue")]
        public int? TotalAmountIssue { get; set; } 

        [Column("total_amount_subs")]
        public int? TotalAmountSubs { get; set; } 

        [Column("total_amount_paid_up")]
        public int? TotalAmountPaidUp { get; set; } 

        [Column("securities_auth")]
        public int? SecuritiesAuth { get; set; } 

        [Column("securities_issue")]
        public int? SecuritiesIssue { get; set; } 

        [Column("securities_subs")]
        public int? SecuritiesSubs { get; set; } 

        [Column("securities_paid_up")]
        public int? SecuritiesPaidUp { get; set; } 

        [Column("buy_back_price_auth")]
        public int? BuyBackPriceAuth { get; set; } 

        [Column("buy_back_price_issue")]
        public int? BuyBackPriceIssue { get; set; } 

        [Column("buy_back_price_subs")]
        public int? BuyBackPriceSubs { get; set; } 

        [Column("buy_back_price_paid_up")]
        public int? BuyBackPricePaidUp { get; set; } 

        [Column("total_amount_of_buy_back_auth")]
        public int? TotalAmountOfBuyBackAuth { get; set; } 

        [Column("total_amount_of_buy_back_issue")]
        public int? TotalAmountOfBuyBackIssue { get; set; } 

        [Column("total_amount_of_buy_back_subs")]
        public int? TotalAmountOfBuyBackSubs { get; set; } 

        [Column("total_amount_of_buy_back_paid_up")]
        public int? TotalAmountOfBuyBackPaidUp { get; set; } 

        [Column("post_buy_back_auth")]
        public int? PostBuyBackAuth { get; set; } 

        [Column("post_buy_back_issue")]
        public int? PostBuyBackIssue { get; set; } 

        [Column("post_buy_back_subs")]
        public int? PostBuyBackSubs { get; set; } 

        [Column("post_buy_back_paid_up")]
        public int? PostBuyBackPaidUp { get; set; } 

        [Column("amount_shares_auth")]
        public int? AmountSharesAuth { get; set; } 

        [Column("amount_shares_issue")]
        public int? AmountSharesIssue { get; set; } 

        [Column("amount_shares_subs")]
        public int? AmountSharesSubs { get; set; } 

        [Column("amount_shares_paid_up")]
        public int? AmountSharesPaidUp { get; set; } 

        [Column("unclassified_capital")]
        public int? UnclassifiedCapital { get; set; } 

        [Column("details_date")]
        public DateTime? DetailsDate { get; set; } 

        [Column("equity_total")]
        public int? EquityTotal { get; set; }

        [Column("capital_paid")]
        public int? CapitalPaid { get; set; }  

        [Column("free_reserved_capital")]
        public int? FreeReservedCapital { get; set; }  

        [Column("premium_securities")]
        public int? PremiumSecurities { get; set; }  

        [Column("amount_total")]
        public int? AmountTotal { get; set; }  

        // Part 2
        [Column("board_director_date")]
        public DateTime? BoardDirectorDate { get; set; } 

        [Column("srn_of_mgt_14")]
        public string? SrnOfMgt14 { get; set; } 

        [Column("completion_date")]
        public DateTime? CompletionDate { get; set; } 

        [Column("opening_offer_date")]
        public DateTime? OpeningOfferDate { get; set; } 

        [Column("closing_offer_date")]
        public DateTime? ClosingOfferDate { get; set; } 

        [Column("buy_back_completion_date")]
        public DateTime? BuyBackCompletionDate { get; set; } 

        [Column("payment_consideration_date")]
        public DateTime? PaymentConsiderationDate { get; set; } 

        [Column("ratio_applicable")]
        public string? RatioApplicable { get; set; } 

        [Column("free_reserve_ratio")]
        public string? FreeReserveRatio { get; set; } 

        [Column("pre_buy_back_debt_and_reserve_ratio")]
        public string? PreBuyBackDebtAndReserveRatio { get; set; } 

        [Column("post_buy_back_debt_and_reserve_ration")]
        public string? PostBuyBackDebtAndReserveRation { get; set; } 

        [Column("securities_held_before_date")]
        public DateTime? SecuritiesHeldBeforeDate { get; set; } 

        [Column("securities_held_after_date")]
        public DateTime? SecuritiesHeldAfterDate { get; set; } 

        [Column("government_central_securities")]
        public int? GovernmentCentralSecurities { get; set; }  

        [Column("number_of_shares_buy_back")]
        public int? NumberOfSharesBuyBack { get; set; }  

        [Column("securities_held_government_companies")]
        public int? SecuritiesHeldGovernmentCompanies { get; set; }  

        [Column("securities_back_government_companies")]
        public int? SecuritiesBackGovernmentCompanies { get; set; }  

        [Column("public_financial_institution")]
        public int? PublicFinancialInstitution { get; set; }  

        [Column("public_financial_securities")]
        public int? PublicFinancialSecurities { get; set; }  

        [Column("nationalized_other_bank_securities")]
        public int? NationalizedOtherBankSecurities { get; set; }  

        [Column("nationalized_other_buy_back_securities")]
        public int? NationalizedOtherBuyBackSecurities { get; set; }  

        [Column("mutual_fund_security")]
        public int? MutualFundSecurity { get; set; }  

        [Column("mutual_fund_buy_back_securities")]
        public int? MutualFundBuyBackSecurities { get; set; }  

        [Column("venture_capital_securities")]
        public int? VentureCapitalSecurities { get; set; }  

        [Column("venture_capital_buy_back_securities")]
        public int? VentureCapitalBuyBackSecurities { get; set; }  

        [Column("foreign_securities_before")]
        public int? ForeignSecuritiesBefore { get; set; }  

        [Column("foreign_securities_after")]
        public int? ForeignSecuritiesAfter { get; set; }

        [Column("corporate_securities_before")]
        public int? CorporateSecuritiesBefore { get; set; }

        [Column("corporate_securities_after")]
        public int? CorporateSecuritiesAfter { get; set; }  

        [Column("directors_back_on")]
        public int? DirectorsBackOn { get; set; }  

        [Column("directors_back_on_relatives")]
        public int? DirectorsBackOnRelatives { get; set; }  

        [Column("shareholders_back_on")]
        public int? ShareholdersBackOn { get; set; }  

        [Column("shareholders_securities")]
        public int? ShareholdersSecurities { get; set; }  

        [Column("others_back_on")]
        public int? OthersBackOn { get; set; }  

        [Column("others_securities")]
        public int? OthersSecurities { get; set; }  

        [Column("total_back_on")]
        public int? TotalBackOn { get; set; }  

        [Column("total_securities")]
        public int? TotalSecurities { get; set; }  

        [Column("buy_back_back_on")]
        public int? BuyBackBackOn { get; set; }  

        [Column("buy_back_securities")]
        public int? BuyBackSecurities { get; set; }  

       
        // Part 3
        [Column("buy_back_details")]
        public string? BuyBackDetails { get; set; } 

        [Column("board_resolution_copy")]
        public string? BoardResolutionCopy { get; set; } 

        [Column("optional_attachment")]
        public string? OptionalAttachment { get; set; } 

        [Column("resolution_number")]
        public string? ResolutionNumber { get; set; } 

        [Column("application_date")]
        public DateTime? ApplicationDate { get; set; } 

        [Column("designation1")]
        public string? Designation1 { get; set; } 

        [Column("director_name1")]
        public string? DirectorName1 { get; set; } 
         
        [Column("din1")]
        public string? Din1 { get; set; } 

        [Column("designation2")]
        public string? Designation2 { get; set; } 

        [Column("director_name2")]
        public string? DirectorName2 { get; set; } 

        [Column("din2")]
        public string? Din2 { get; set; } 

        [Column("certified_by")]
        public string? CertifiedBy { get; set; } 

        [Column("associate_or_fellow")]
        public string? AssociateOrFellow { get; set; } 

        [Column("membership_number")]
        public string? MembershipNumber { get; set; }
    }

    [TableName("tbl_sh11", "vw_sh11")]
    public class SH11View : SH11
    {
        [Column("ref_user_name")]
        public string? RefUserName { get; set; }
    }

}