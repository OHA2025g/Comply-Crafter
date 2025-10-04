using AlphaUtil.Core.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ComplyCrafter_Data
{
    [TableName("tbl_aoccuntnsolvencyform", "vw_aoccuntnsolvencyform")]
    public class ACCOUNTNSOLVENCYFORM: BaseModel
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

        //part-1

        [Column("purpose")]
        public string? Purpose { get; set; }

        [Column("statement_of_account_date")]
        public DateTime? StatementOfAccountDate { get; set; }

        [Column("llpin_fllp_in")]
        public DateTime? LlpinFllpIn { get; set; }

        [Column("statement_of_asests_and_liabilities_at")]
        public DateTime? statementOfAsestsAndLiabilitiesAt { get; set; }


        [Column("llp_fllp_name")]
        public string? LlpFllpName { get; set; }

        [Column("jurisdiction_police_station")]
        public string? JurisdictionPoliceStation { get; set; }

        [Column("contribution_total")]
        public string? ContributionTotal { get; set; }

        [Column("llp_fllp_enquiry_confirmation")]
        public Boolean? LlpFllpEnquiryConfirmation { get; set; }

        [Column("llp_fllp_name_2")]
        public string? LlpFllpName2 { get; set; }

        [Column("llp_fllp_pay_debts")]
        public string? LlpFllpPayDebts { get; set; }

        [Column("append_statement")]
        public Boolean? AppendStatement { get; set; }

        [Column("statement_of_assets_and_liabilities_at")]
        public string? StatementOfAssetsAndLiabilitiesAt { get; set; }

        [Column("income_and_expenditure_ended_on")]
        public DateTime? IncomeAndExpenditureEndedOn { get; set; }

        [Column("confirmation_on_filing")]
        public string? ConfirmationOnFiling { get; set; }

        [Column("declare_turnover")]
        public Boolean? DeclareTurnover { get; set; }

        [Column("turnover")]
        public string? Turnover { get; set; }

        [Column("declare_obligation_of_contribution")]
        public Boolean? DeclareObligationOfContribution { get; set; }

        [Column("obligation_of_contribution")]
        public string? ObligationOfContribution { get; set; }

        [Column("confirming_partners")]
        public Boolean? ConfirmingPartners { get; set; }

        [Column("confirming_the_statement_is_true")]
        public Boolean? ConfirmingTheStatementIsTrue { get; set; }

        [Column("contingent_liabilities_radio_btn")]
        public string? ContingentLiabilitiesRadioBtn { get; set; }

        [Column("description_of_contingent_liability")]
        public string? DescriptionOfContingentLiability { get; set; }

        [Column("amount")]
        public string? Amount { get; set; }

        [Column("confirmation_on_filling")]
        public Boolean? ConfirmationOnFilling { get; set; }

        [Column("contingent_liabilites_radio_btn")]
        public string? contingentLiabilitesRadioBtn { get; set; }

        [Column("description_of_contigent_liability")]
        public string? descriptionOfContigentLiability { get; set; }



        //part-2


        [Column("statement_assets_liabilities")]
        public string? StatementAssetsLiabilities { get; set; }

        [Column("contribution_received_cr")]
        public string? ContributionReceivedCr { get; set; }

        [Column("contribution_received_pr")]
        public string? ContributionReceivedPr { get; set; }

        [Column("reserves_surplus_cr")]
        public string? ReservesSurplusCr { get; set; }

        [Column("reserves_surplus_pr")]
        public string? ReservesSurplusPr { get; set; }

        [Column("secured_loans_cr")]
        public string? SecuredLoansCr { get; set; }

        [Column("secured_loans_pr")]
        public string? SecuredLoansPr { get; set; }

        [Column("unsecure_loans_cr")]
        public string? UnsecureLoansCr { get; set; }

        [Column("unsecure_loans_pr")]
        public string? UnsecureLoansPr { get; set; }

        [Column("short_term_cr")]
        public string? ShortTermCr { get; set; }

        [Column("short_term_pr")]
        public string? ShortTermPr { get; set; }

        [Column("payables_advance_cr")]
        public string? PayablesAdvanceCr { get; set; }

        [Column("payables_advance_pr")]
        public string? PayablesAdvancePr { get; set; }

        [Column("other_liabilities_name_cr")]
        public string? OtherLiabilitiesNameCr { get; set; }

        [Column("other_liabilities_cr")]
        public string? OtherLiabilitiesCr { get; set; }

        [Column("other_liabilities_pr")]
        public string? OtherLiabilitiesPr { get; set; }

        [Column("for_taxation_cr")]
        public string? ForTaxationCr { get; set; }

        [Column("for_taxation_pr")]
        public string? ForTaxationPr { get; set; }

        [Column("for_contingencies_cr")]
        public string? ForContingenciesCr { get; set; }

        [Column("for_contingencies_pr")]
        public string? ForContingenciesPr { get; set; }

        [Column("for_insurance_cr")]
        public string? ForInsuranceCr { get; set; }

        [Column("for_insurance_pr")]
        public string? ForInsurancePr { get; set; }

        [Column("other_provisions_cr")]
        public string? OtherProvisionsCr { get; set; }

        [Column("other_provisions_pr")]
        public string? OtherProvisionsPr { get; set; }

        [Column("total_cr")]
        public string? TotalCr { get; set; }

        [Column("total_pr")]
        public string? TotalPr { get; set; }

        [Column("fixed_assets_cr")]
        public string? FixedAssetsCr { get; set; }

        [Column("fixed_assets_pr")]
        public string? FixedAssetsPr { get; set; }

        [Column("depreciation_cr")]
        public string? DepreciationCr { get; set; }

        [Column("depreciation_pr")]
        public string? DepreciationPr { get; set; }

        [Column("net_fixed_assets_cr")]
        public string? NetFixedAssetsCr { get; set; }

        [Column("net_fixed_assets_pr")]
        public string? NetFixedAssetsPr { get; set; }

        [Column("investments_cr")]
        public string? InvestmentsCr { get; set; }

        [Column("investments_pr")]
        public string? InvestmentsPr { get; set; }

        [Column("loans_cr")]
        public string? LoansCr { get; set; }

        [Column("loans_pr")]
        public string? LoansPr { get; set; }

        [Column("inventories_cr")]
        public string? InventoriesCr { get; set; }

        [Column("inventories_pr")]
        public string? InventoriesPr { get; set; }

        [Column("trade_receivables_cr")]
        public string? TradeReceivablesCr { get; set; }

        [Column("trade_receivables_pr")]
        public string? TradeReceivablesPr { get; set; }

        [Column("cash_equivalents_cr")]
        public string? CashEquivalentsCr { get; set; }

        [Column("cash_equivalents_pr")]
        public string? CashEquivalentsPr { get; set; }

        [Column("other_assets_cr")]
        public string? OtherAssetsCr { get; set; }

        [Column("other_assets_pr")]
        public string? OtherAssetsPr { get; set; }

        [Column("total_assets_cr")]
        public string? TotalAssetsCr { get; set; }

        [Column("total_assets_pr")]
        public string? TotalAssetsPr { get; set; }

        [Column("other_assets_name_cr")]
        public string? OtherAssetsNameCr { get; set; }




        //part-3

        [Column("starting_date_cr")]
        public DateTime? StartingDateCr { get; set; }

        [Column("starting_date_pr")]
        public DateTime? StartingDatePr { get; set; }

        [Column("closing_date_cr")]
        public DateTime? ClosingDateCr { get; set; }

        [Column("closing_date_pr")]
        public DateTime? ClosingDatePr { get; set; }

        [Column("gross_turnover_cr")]
        public string? GrossTurnoverCr { get; set; }

        [Column("gross_turnover_pr")]
        public string? GrossTurnoverPr { get; set; }

        [Column("excise_duty_cr")]
        public string? ExciseDutyCr { get; set; }

        [Column("excise_duty_pr")]
        public string? ExciseDutyPr { get; set; }

        [Column("net_turnover_cr")]
        public string? NetTurnoverCr { get; set; }

        [Column("net_turnover_pr")]
        public string? NetTurnoverPr { get; set; }

        [Column("sales_good_cr")]
        public string? SalesGoodCr { get; set; }

        [Column("sales_good_pr")]
        public string? SalesGoodPr { get; set; }

        [Column("sales_goods_t_cr")]
        public string? SalesGoodsTCr { get; set; }

        [Column("sales_goods_t_pr")]
        public string? SalesGoodsTPr { get; set; }

        [Column("sales_supply_cr")]
        public string? SalesSupplyCr { get; set; }

        [Column("sales_supply_pr")]
        public string? SalesSupplyPr { get; set; }

        [Column("sales_goods_1_cr")]
        public string? SalesGoods1Cr { get; set; }

        [Column("sales_goods_1_pr")]
        public string? SalesGoods1Pr { get; set; }

        [Column("sale_goods_t_1_cr")]
        public string? SaleGoodsT1Cr { get; set; }

        [Column("sale_goods_t_1_pr")]
        public string? SaleGoodsT1Pr { get; set; }

        [Column("sales_supply_1_cr")]
        public string? SalesSupply1Cr { get; set; }

        [Column("sales_supply_1_pr")]
        public string? SalesSupply1Pr { get; set; }

        [Column("other_income_cr")]
        public string? OtherIncomeCr { get; set; }

        [Column("other_income_pr")]
        public string? OtherIncomePr { get; set; }

        [Column("increase_cr")]
        public string? IncreaseCr { get; set; }

        [Column("increase_pr")]
        public string? IncreasePr { get; set; }

        [Column("total_revenue_cr")]
        public string? TotalRevenueCr { get; set; }

        [Column("total_revenue_pr")]
        public string? TotalRevenuePr { get; set; }

        [Column("material_cr")]
        public string? MaterialCr { get; set; }

        [Column("material_pr")]
        public string? MaterialPr { get; set; }

        [Column("purchase_made_c")]
        public string? PurchaseMadeC { get; set; }

        [Column("purchase_made_p")]
        public string? PurchaseMadeP { get; set; }

        [Column("consumption_cr")]
        public string? ConsumptionCr { get; set; }

        [Column("consumption_pr")]
        public string? ConsumptionPr { get; set; }

        [Column("power_cr")]
        public string? PowerCr { get; set; }

        [Column("power_pr")]
        public string? PowerPr { get; set; }

        [Column("personnel_cr")]
        public string? PersonnelCr { get; set; }

        [Column("personnel_pr")]
        public string? PersonnelPr { get; set; }

        [Column("administrative_cr")]
        public string? AdministrativeCr { get; set; }

        [Column("administrative_pr")]
        public string? AdministrativePr { get; set; }

        [Column("payment_cr")]
        public string? PaymentCr { get; set; }

        [Column("payment_pr")]
        public string? PaymentPr { get; set; }

        [Column("selling_c")]
        public string? SellingC { get; set; }

        [Column("selling_p")]
        public string? SellingP { get; set; }

        [Column("insurance_exp_cr")]
        public string? InsuranceExpCr { get; set; }

        [Column("insurance_exp_pr")]
        public string? InsuranceExpPr { get; set; }

        [Column("depreciation_p_cr")]
        public string? DepreciationPCr { get; set; }

        [Column("depreciation_p_pr")]
        public string? DepreciationPPr { get; set; }

        [Column("interest_cr")]
        public string? InterestCr { get; set; }

        [Column("interest_pr")]
        public string? InterestPr { get; set; }

        [Column("other_expenses_c")]
        public string? OtherExpensesC { get; set; }

        [Column("other_expenses_p")]
        public string? OtherExpensesP { get; set; }

        [Column("total_expenses_c")]
        public string? TotalExpensesC { get; set; }

        [Column("total_expenses_p")]
        public string? TotalExpensesP { get; set; }

        [Column("profit_net_cr")]
        public string? ProfitNetCr { get; set; }

        [Column("profit_net_pr")]
        public string? ProfitNetPr { get; set; }

        [Column("provision_c")]
        public string? ProvisionC { get; set; }

        [Column("provision_p")]
        public string? ProvisionP { get; set; }

        [Column("profit_aft_tax_c")]
        public string? ProfitAftTaxC { get; set; }

        [Column("profit_aft_tax_p")]
        public string? ProfitAftTaxP { get; set; }

        [Column("profit_transfer_cr")]
        public string? ProfitTransferCr { get; set; }

        [Column("profit_transfer_pr")]
        public string? ProfitTransferPr { get; set; }

        [Column("prof_tra_res_ser_c")]
        public string? ProfTraResSerC { get; set; }

        [Column("prof_tra_res_ser_p")]
        public string? ProfTraResSerP { get; set; }


        //part-4 


        [Column("dpin_income_tax_pan_11")]
        public string? DpinIncomeTaxPan11 { get; set; }

        [Column("dpin_income_tax_pan_12")]
        public string? DpinIncomeTaxPan12 { get; set; }

        [Column("administrator_name")]
        public string? AdministratorName { get; set; }

        [Column("designation")]
        public string? Designation { get; set; }

        [Column("administrator_id")]
        public string? AdministratorId { get; set; }

        [Column("certified_radio_button")]
        public string? CertifiedRadioButton { get; set; }

        [Column("number_membership")]
        public string? NumberMembership { get; set; }

        [Column("designated_name")]
        public string? DesignatedName { get; set; }

        [Column("address_line_1")]
        public string? AddressLine1 { get; set; }

        [Column("address_line_2")]
        public string? AddressLine2 { get; set; }

        [Column("country")]
        public string? Country { get; set; }

        [Column("pin_code_1")]
        public string? PinCode1 { get; set; }

        [Column("area_locality_1")]
        public string? AreaLocality1 { get; set; }

        [Column("city_1")]
        public string? City1 { get; set; }

        [Column("district_1")]
        public string? District1 { get; set; }

        [Column("state_1")]
        public string? State1 { get; set; }

        [Column("jurisdiction")]
        public string? Jurisdiction { get; set; }

        [Column("phone")]
        public string? Phone { get; set; }

        [Column("email_id")]
        public string? EmailId { get; set; }

        [Column("certificate_name")]
        public string? CertificateName { get; set; }

        [Column("category_radio_buttons")]
        public string? CategoryRadioButtons { get; set; }

        [Column("name_of_pcs")]
        public string? NameOfPcs { get; set; }

        [Column("professional_type")]
        public string? ProfessionalType { get; set; }

        [Column("certificate_of_practice_number")]
        public string? CertificateOfPracticeNumber { get; set; }



        //part-5

        [Column("attachment_file")]
        public string? AttachmentFile { get; set; }





    }

    [TableName("tbl_aoccuntnsolvencyform", "vw_aoccuntnsolvencyform")]
    public class ACCOUNTNSOLVENCYFORMView : ACCOUNTNSOLVENCYFORM
    {
        [Column("ref_user_name")]
        public string? RefUserName { get; set; }
    }

}