using AlphaUtil.Core.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ComplyCrafter_Data
{
    [TableName("tbl_iepf2", "vw_iepf")]
    public class IEPF2 : BaseModel
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

        [Column("purpose")]
        public string? Purpose { get; set; }

        [Column("sub_purpose")]
        public string? SubPurpose { get; set; }

        [Column("is_existing_nodal_officer")]
        public string? IsExistingNodalOfficer { get; set; }

        [Column("cin_of_holding_or_subsidiary")]
        public string? CinOfHoldingOrSubsidiary { get; set; }

        // Details of Nodal Officer
        [Column("name_of_the_nodal_officer")]
        public string? NameOfTheNodalOfficer { get; set; }

        [Column("first_name")]
        public string? FirstName { get; set; }

        [Column("middle_name")]
        public string? MiddleName { get; set; }

        [Column("last_name")]
        public string? LastName { get; set; }

        [Column("fathers_first_name")]
        public string? FathersFirstName { get; set; }

        [Column("fathers_middle_name")]
        public string? FathersMiddleName { get; set; }

        [Column("fathers_last_name")]
        public string? FathersLastName { get; set; }

        [Column("dob")]
        public DateTime? Dob { get; set; }

        [Column("pan")]
        public string? Pan { get; set; }

        [Column("designation")]
        public string? Designation { get; set; }

        [Column("gender")]
        public string? Gender { get; set; }

        // Official Postal Address
        [Column("official_address_line1")]
        public string? OfficialAddressLine1 { get; set; }

        [Column("official_address_line2")]
        public string? OfficialAddressLine2 { get; set; }

        [Column("country")]
        public string? Country { get; set; }

        [Column("pin_code")]
        public string? PinCode { get; set; }

        [Column("locality")]
        public string? Locality { get; set; }

        [Column("city")]
        public string? City { get; set; }

        [Column("district")]
        public string? District { get; set; }

        [Column("state")]
        public string? State { get; set; }

        [Column("phone_number")]
        public string? PhoneNumber { get; set; }

        [Column("mobile_number")]
        public string? MobileNumber { get; set; }

        [Column("nodal_officer_email")]
        public string? NodalOfficerEmail { get; set; }

        [Column("dob_resolution")]
        public DateTime? DobResolution { get; set; }

        // Deputy nodal officer details
        [Column("deputy_nodal_officer_added")]
        public int? DeputyNodalOfficerAdded { get; set; }

        [Column("deputy_nodal_officer_update")]
        public int? DeputyNodalOfficerUpdate { get; set; }

        [Column("deputy_nodal_officer_ceased")]
        public int? DeputyNodalOfficerCeased { get; set; }

        [Column("financial_year_end_date")]
        public DateTime? FinancialYearEndDate { get; set; }

        [Column("date_of_agm")]
        public DateTime? DateOfAGM { get; set; }

        [Column("registered_with_rbi")]
        public string? RegisteredWithRBI { get; set; }

        [Column("number_of_small_share_holders")]
        public int? NumberOfSmallShareHolders { get; set; }

        [Column("number_of_small_depositors")]
        public int? NumberOfSmallDepositors { get; set; }

        // Table Data

        // Row 1: Unclaimed Dividend
        [Column("unclaimed_dividend_fy1")]
        public int? UnclaimedDividendFy1 { get; set; }

        [Column("unclaimed_dividend_fy2")]
        public int? UnclaimedDividendFy2 { get; set; }

        [Column("unclaimed_dividend_fy3")]
        public int? UnclaimedDividendFy3 { get; set; }

        [Column("unclaimed_dividend_fy4")]
        public int? UnclaimedDividendFy4 { get; set; }

        [Column("unclaimed_dividend_fy5")]
        public int? UnclaimedDividendFy5 { get; set; }

        [Column("unclaimed_dividend_fy6")]
        public int? UnclaimedDividendFy6 { get; set; }

        [Column("unclaimed_dividend_fy7")]
        public int? UnclaimedDividendFy7 { get; set; }

        [Column("unclaimed_dividend_total")]
        public int? UnclaimedDividendTotal { get; set; }

        // Row 2: Underlying Shares
        [Column("underlying_shares_fy1")]
        public int? UnderlyingSharesFy1 { get; set; }

        [Column("underlying_shares_fy2")]
        public int? UnderlyingSharesFy2 { get; set; }

        [Column("underlying_shares_fy3")]
        public int? UnderlyingSharesFy3 { get; set; }

        [Column("underlying_shares_fy4")]
        public int? UnderlyingSharesFy4 { get; set; }

        [Column("underlying_shares_fy5")]
        public int? UnderlyingSharesFy5 { get; set; }

        [Column("underlying_shares_fy6")]
        public int? UnderlyingSharesFy6 { get; set; }

        [Column("underlying_shares_fy7")]
        public int? UnderlyingSharesFy7 { get; set; }

        [Column("underlying_shares_total")]
        public int? UnderlyingSharesTotal { get; set; }

        // Row 3: Amount Refunded by the Company
        [Column("refund_by_company_fy1")]
        public int? RefundByCompanyFy1 { get; set; }

        [Column("refunded_by_company_fy2")]
        public int? RefundedByCompanyFy2 { get; set; }

        [Column("refunded_by_company_fy3")]
        public int? RefundedByCompanyFy3 { get; set; }

        [Column("refunded_by_company_fy4")]
        public int? RefundedByCompanyFy4 { get; set; }

        [Column("refunded_by_company_fy5")]
        public int? RefundedByCompanyFy5 { get; set; }

        [Column("refunded_by_company_fy6")]
        public int? RefundedByCompanyFy6 { get; set; }

        [Column("refunded_by_company_fy7")]
        public int? RefundedByCompanyFy7 { get; set; }

        [Column("refunded_by_company_fytotal")]
        public int? RefundedByCompanyFytotal { get; set; }

        // Row 4: Amount Received under Section 38
        [Column("recieved_under_sec38_fy1")]
        public int? RecievedUnderSec38Fy1 { get; set; }

        [Column("recieved_under_sec38_fy2")]
        public int? RecievedUnderSec38Fy2 { get; set; }

        [Column("recieved_under_sec38_fy3")]
        public int? RecievedUnderSec38Fy3 { get; set; }

        [Column("recieved_under_sec38_fy4")]
        public int? RecievedUnderSec38Fy4 { get; set; }

        [Column("recieved_under_sec38_fy5")]
        public int? RecievedUnderSec38Fy5 { get; set; }

        [Column("recieved_under_sec38_fy6")]
        public int? RecievedUnderSec38Fy6 { get; set; }

        [Column("recieved_under_sec38_fy7")]
        public int? RecievedUnderSec38Fy7 { get; set; }

        [Column("recieved_under_sec38_fytotal")]
        public int? RecievedUnderSec38Fytotal { get; set; }

        // Row 5: Application Money Received and Due for Refund
        [Column("recieved_and_due_for_refund_fy1")]
        public int? RecievedAndDueForRefundFy1 { get; set; }

        [Column("recieved_and_due_for_refund_fy2")]
        public int? RecievedAndDueForRefundFy2 { get; set; }

        [Column("recieved_and_due_for_refund_fy3")]
        public int? RecievedAndDueForRefundFy3 { get; set; }

        [Column("recieved_and_due_for_refund_fy4")]
        public int? RecievedAndDueForRefundFy4 { get; set; }

        [Column("recieved_and_due_for_refund_fy5")]
        public int? RecievedAndDueForRefundFy5 { get; set; }

        [Column("recieved_and_due_for_refund_fy6")]
        public int? RecievedAndDueForRefundFy6 { get; set; }

        [Column("recieved_and_due_for_refund_fy7")]
        public int? RecievedAndDueForRefundFy7 { get; set; }

        [Column("recieved_and_due_for_refund_fytotal")]
        public int? RecievedAndDueForRefundFytotal { get; set; }

        // Row 6: Matured Deposits
        [Column("matured_deposit_fy1")]
        public int? MaturedDepositFy1 { get; set; }

        [Column("matured_deposit_fy2")]
        public int? MaturedDepositFy2 { get; set; }

        [Column("matured_deposit_fy3")]
        public int? MaturedDepositFy3 { get; set; }

        [Column("matured_deposit_fy4")]
        public int? MaturedDepositFy4 { get; set; }

        [Column("matured_deposit_fy5")]
        public int? MaturedDepositFy5 { get; set; }

        [Column("matured_deposit_fy6")]
        public int? MaturedDepositFy6 { get; set; }

        [Column("matured_deposit_fy7")]
        public int? MaturedDepositFy7 { get; set; }

        [Column("matured_deposit_fytotal")]
        public int? MaturedDepositFytotal { get; set; }

        // Row 7: Refund from Matured Deposits
        [Column("refund_by_comp_from_meture_deposit_fy1")]
        public int? RefundByCompFromMetureDepositFy1 { get; set; }

        [Column("refund_by_comp_from_meture_deposit_fy2")]
        public int? RefundByCompFromMetureDepositFy2 { get; set; }

        [Column("refund_by_comp_from_meture_deposit_fy3")]
        public int? RefundByCompFromMetureDepositFy3 { get; set; }

        [Column("refund_by_comp_from_meture_deposit_fy4")]
        public int? RefundByCompFromMetureDepositFy4 { get; set; }

        [Column("refund_by_comp_from_meture_deposit_fy5")]
        public int? RefundByCompFromMetureDepositFy5 { get; set; }

        [Column("refund_by_comp_from_meture_deposit_fy6")]
        public int? RefundByCompFromMetureDepositFy6 { get; set; }

        [Column("refund_by_comp_from_meture_deposit_fy7")]
        public int? RefundByCompFromMetureDepositFy7 { get; set; }

        [Column("refund_by_comp_from_meture_deposit_fytotal")]
        public int? RefundByCompFromMetureDepositFytotal { get; set; }

        // Row 8: Amount of Matured Debentures
        [Column("amount_of_debentures_fy1")]
        public int? AmountOfDebenturesFy1 { get; set; }

        [Column("amount_of_debentures_fy2")]
        public int? AmountOfDebenturesFy2 { get; set; }

        [Column("amount_of_debentures_fy3")]
        public int? AmountOfDebenturesFy3 { get; set; }

        [Column("amount_of_debentures_fy4")]
        public int? AmountOfDebenturesFy4 { get; set; }

        [Column("amount_of_debentures_fy5")]
        public int? AmountOfDebenturesFy5 { get; set; }

        [Column("amount_of_debentures_fy6")]
        public int? AmountOfDebenturesFy6 { get; set; }

        [Column("amount_of_debentures_fy7")]
        public int? AmountOfDebenturesFy7 { get; set; }

        [Column("amount_of_debentures_fytotal")]
        public int? AmountOfDebenturesFytotal { get; set; }

        // Row 9: Refund from Matured Debentures
        [Column("refund_by_comp_from_meture_debentures_fy1")]
        public int? RefundByCompFromMetureDebenturesFy1 { get; set; }

        [Column("refund_by_comp_from_meture_debentures_fy2")]
        public int? RefundByCompFromMetureDebenturesFy2 { get; set; }

        [Column("refund_by_comp_from_meture_debentures_fy3")]
        public int? RefundByCompFromMetureDebenturesFy3 { get; set; }

        [Column("refund_by_comp_from_meture_debentures_fy4")]
        public int? RefundByCompFromMetureDebenturesFy4 { get; set; }

        [Column("refund_by_comp_from_meture_debentures_fy5")]
        public int? RefundByCompFromMetureDebenturesFy5 { get; set; }

        [Column("refund_by_comp_from_meture_debentures_fy6")]
        public int? RefundByCompFromMetureDebenturesFy6 { get; set; }

        [Column("refund_by_comp_from_meture_debentures_fy7")]
        public int? RefundByCompFromMetureDebenturesFy7 { get; set; }

        [Column("refund_by_comp_from_meture_debentures_fytotal")]
        public int? RefundByCompFromMetureDebenturesFytotal { get; set; }

        // Row 10: Interest Accrued on Amounts
        [Column("intrest_accured_on_amounts_fy1")]
        public string? IntrestAccuredOnAmountsFy1 { get; set; }

        [Column("intrest_accured_on_amounts_fy2")]
        public string? IntrestAccuredOnAmountsFy2 { get; set; }

        [Column("intrest_accured_on_amounts_fy3")]
        public string? IntrestAccuredOnAmountsFy3 { get; set; }

        [Column("intrest_accured_on_amounts_fy4")]
        public string? IntrestAccuredOnAmountsFy4 { get; set; }

        [Column("intrest_accured_on_amounts_fy5")]
        public string? IntrestAccuredOnAmountsFy5 { get; set; }

        [Column("intrest_accured_on_amounts_fy6")]
        public string? IntrestAccuredOnAmountsFy6 { get; set; }

        [Column("intrest_accured_on_amounts_fy7")]
        public string? IntrestAccuredOnAmountsFy7 { get; set; }

        [Column("intrest_accured_on_amounts_fytotal")]
        public string? IntrestAccuredOnAmountsFytotal { get; set; }

        // Row 11: Application Money Due for Refund
        [Column("app_money_due_for_refund_fy1")]
        public int? AppMoneyDueForRefundFy1 { get; set; }

        [Column("app_money_due_for_refund_fy2")]
        public int? AppMoneyDueForRefundFy2 { get; set; }

        [Column("app_money_due_for_refund_fy3")]
        public int? AppMoneyDueForRefundFy3 { get; set; }

        [Column("app_money_due_for_refund_fy4")]
        public int? AppMoneyDueForRefundFy4 { get; set; }

        [Column("app_money_due_for_refund_fy5")]
        public int? AppMoneyDueForRefundFy5 { get; set; }

        [Column("app_money_due_for_refund_fy6")]
        public int? AppMoneyDueForRefundFy6 { get; set; }

        [Column("app_money_due_for_refund_fy7")]
        public int? AppMoneyDueForRefundFy7 { get; set; }

        [Column("app_money_due_for_refund_fytotal")]
        public int? AppMoneyDueForRefundFytotal { get; set; }

        // Row 12: Matured Deposits with Companies/Banks
        [Column("matured_deposit_with_companey_fy1")]
        public int? MaturedDepositWithCompaneyFy1 { get; set; }

        [Column("matured_deposit_with_companey_fy2")]
        public int? MaturedDepositWithCompaneyFy2 { get; set; }

        [Column("matured_deposit_with_companey_fy3")]
        public int? MaturedDepositWithCompaneyFy3 { get; set; }

        [Column("matured_deposit_with_companey_fy4")]
        public int? MaturedDepositWithCompaneyFy4 { get; set; }

        [Column("matured_deposit_with_companey_fy5")]
        public int? MaturedDepositWithCompaneyFy5 { get; set; }

        [Column("matured_deposit_with_companey_fy6")]
        public int? MaturedDepositWithCompaneyFy6 { get; set; }

        [Column("matured_deposit_with_companey_fy7")]
        public int? MaturedDepositWithCompaneyFy7 { get; set; }

        [Column("matured_deposit_with_companey_fytotal")]
        public int? MaturedDepositWithCompaneyFytotal { get; set; }

        // Row 13: Matured Debentures with Companies/Banks
        [Column("matured_debentures_with_companey_fy1")]
        public int? MaturedDebenturesWithCompaneyFy1 { get; set; }

        [Column("matured_debentures_with_companey_fy2")]
        public int? MaturedDebenturesWithCompaneyFy2 { get; set; }

        [Column("matured_debentures_with_companey_fy3")]
        public int? MaturedDebenturesWithCompaneyFy3 { get; set; }

        [Column("matured_debentures_with_companey_fy4")]
        public int? MaturedDebenturesWithCompaneyFy4 { get; set; }

        [Column("matured_debentures_with_companey_fy5")]
        public int? MaturedDebenturesWithCompaneyFy5 { get; set; }

        [Column("matured_debentures_with_companey_fy6")]
        public int? MaturedDebenturesWithCompaneyFy6 { get; set; }

        [Column("matured_debentures_with_companey_fy7")]
        public int? MaturedDebenturesWithCompaneyFy7 { get; set; }

        [Column("matured_debentures_with_companey_fy8")]
        public int? MaturedDebenturesWithCompaneyFy8 { get; set; }

        // Row 14: Fractional Shares
        [Column("fractional_shares_fy1")]
        public int? FractionalSharesFy1 { get; set; }

        [Column("fractional_shares_fy2")]
        public int? FractionalSharesFy2 { get; set; }

        [Column("fractional_shares_fy3")]
        public int? FractionalSharesFy3 { get; set; }

        [Column("fractional_shares_fy4")]
        public int? FractionalSharesFy4 { get; set; }

        [Column("fractional_shares_fy5")]
        public int? FractionalSharesFy5 { get; set; }

        [Column("fractional_shares_fy6")]
        public int? FractionalSharesFy6 { get; set; }

        [Column("fractional_shares_fy7")]
        public int? FractionalSharesFy7 { get; set; }

        [Column("fractional_shares_fytotal")]
        public int? FractionalSharesFytotal { get; set; }

        // Row 15: Redemption Amount of Preference Shares
        [Column("redemption_amount_fy1")]
        public int? RedemptionAmountFy1 { get; set; }

        [Column("redemption_amount_fy2")]
        public int? RedemptionAmountFy2 { get; set; }

        [Column("redemption_amount_fy3")]
        public int? RedemptionAmountFy3 { get; set; }

        [Column("redemption_amount_fy4")]
        public int? RedemptionAmountFy4 { get; set; }

        [Column("redemption_amount_fy5")]
        public int? RedemptionAmountFy5 { get; set; }

        [Column("redemption_amount_fy6")]
        public int? RedemptionAmountFy6 { get; set; }

        [Column("redemption_amount_fy7")]
        public int? RedemptionAmountFy7 { get; set; }

        [Column("redemption_amount_fytotal")]
        public int? RedemptionAmountFytotal { get; set; }

        // Row 16: Others
        [Column("others_fy1")]
        public int? OthersFy1 { get; set; }

        [Column("others_fy2")]
        public int? OthersFy2 { get; set; }

        [Column("others_fy3")]
        public int? OthersFy3 { get; set; }

        [Column("others_fy4")]
        public int? OthersFy4 { get; set; }

        [Column("others_fy5")]
        public int? OthersFy5 { get; set; }

        [Column("others_fy6")]
        public int? OthersFy6 { get; set; }

        [Column("others_fy7")]
        public int? OthersFy7 { get; set; }

        [Column("others_fytotal")]
        public int? OthersFytotal { get; set; }

        // Row 17: Total Row (Each Fiscal Year and Overall Total)
        [Column("total_fy1")]
        public int? TotalFy1 { get; set; }

        [Column("total_fy2")]
        public int? TotalFy2 { get; set; }

        [Column("total_fy3")]
        public int? TotalFy3 { get; set; }

        [Column("total_fy4")]
        public int? TotalFy4 { get; set; }

        [Column("total_fy5")]
        public int? TotalFy5 { get; set; }

        [Column("total_fy6")]
        public int? TotalFy6 { get; set; }

        [Column("total_fy7")]
        public int? TotalFy7 { get; set; }

        [Column("total_fyamt")]
        public int? TotalFyamt { get; set; }

        [Column("dividend_declaired_on_shares")]
        public int? DividendDeclairedOnShares { get; set; }

        [Column("other_benefits_declaired")]
        public int? OtherBenefitsDeclaired { get; set; }

        // Part 2
        [Column("investor_file")]
        public string? InvestorFile { get; set; }

        [Column("nodal_appointment")]
        public string? NodalAppointment { get; set; }

        [Column("attachment_file")]
        public string? AttachmentFile { get; set; }

        [Column("resolution_number")]
        public string? ResolutionNumber { get; set; }

        [Column("resolution_date")]
        public DateTime? ResolutionDate { get; set; }

        [Column("declaration_designation")]
        public string? DeclarationDesignation { get; set; }

        [Column("declaration_membership_no")]
        public string? Signatory { get; set; }

        [Column("din_memebers")]
        public string? DinMemebers { get; set; }


    }

    [TableName("tbl_iepf2", "vw_iepf2")]
    public class IEPF2View : IEPF2
    {
        [Column("ref_user_name")]
        public string? RefUserName { get; set; }
    }

}