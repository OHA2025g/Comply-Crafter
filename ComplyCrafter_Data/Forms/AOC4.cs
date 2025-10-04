using AlphaUtil.Core.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ComplyCrafter_Data
{
    [TableName("tbl_aoc4", "vw_aoc4")]
    public class AOC4 : BaseModel
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

        //Part 1
        [Column("authorised_capital")]
        public string? AuthorisedCapital { get; set; } 

        [Column("members_number")]
        public decimal? MembersNumber { get; set; } = 0;

        [Column("from_year_start_date")]
        public DateTime? FromYearStartingDate { get; set; }

        [Column("to_year_end_date")]
        public DateTime? ToYearEndingDate { get; set; }

        [Column("approved_date")]
        public DateTime? ApprovedDate { get; set; }

        [Column("statement_nature")]
        public string? StatmentNature { get; set; }

        [Column("provisional_financial_statement")]
        public string? ProvisionalFinancialStatment { get; set; }

        [Column("adopted_agm")]
        public string? AdoptedAgm { get; set; }

        [Column("nature_revision")]
        public string? NatureRevision { get; set; } 

        [Column("financial_date")]
        public DateTime? FinancialDate { get; set; }

        [Column("srn_inc_28")]
        public string? SrnOfInc28 { get; set; }

        [Column("srn_aoc_4")]
        public string? SrnOfAoc4 { get; set; } 

        [Column("is_general_meeting_held")]
        public string? IsGeneralMeetingHeld { get; set; }

        [Column("agm_date")]
        public DateTime? AgmDate { get; set; }

        [Column("agm_due_date")]
        public DateTime? AgmDueDate { get; set; }

        [Column("is_agm_granted")]
        public string? IsAgmGranted { get; set; }

        [Column("due_date_of_agm")]
        public DateTime? DueDateOfAgm { get; set; }

        //Part 2
        [Column("is_financial_statement_signer_selected1")]
        public Boolean? IsFinancialStatementSignerSelected1 { get; set; }

        [Column("is_financial_statement_signer_selected2")]
        public Boolean? IsFinancialStatementSignerSelected2 { get; set; }

        [Column("date_of_signing1")]
        public DateTime? DateOfSigning1 { get; set; }

        [Column("date_of_signing2")]
        public DateTime? DateOfSigning2 { get; set; }

        // Board Report Approval
        [Column("report_referred_date")]
        public DateTime? ReportReferredDate { get; set; }

        // Board Report Signers
        [Column("is_board_report_signer_selected1")]
        public Boolean? IsBoardReportSignerSelected1 { get; set; }

        [Column("is_board_report_signer_selected2")]
        public Boolean? IsBoardReportSignerSelected2 { get; set; }

        [Column("board_report_signing_date1")]
        public DateTime? BoardReportSigningDate1 { get; set; }

        [Column("board_report_signing_date2")]
        public DateTime? BoardReportSigningDate2 { get; set; }

        // Auditor Report
        [Column("auditor_signing_report_date")]
        public DateTime? AuditorSigningReportDate { get; set; }

        // Part 3
        [Column("is_subsidiary_company")]
        public string? IsSubsidiaryCompany { get; set; }

        [Column("has_subsidiary_companies")]
        public string? HasSubsidiaryCompanies { get; set; }

        [Column("subsidiary_provision")]
        public string? SubsidiaryProvision { get; set; }

        [Column("is_auditor_selected")]
        public Boolean? IsAuditorSelected { get; set; }

        [Column("auditor_member_no")]
        public string? AuditorMemberNo { get; set; }

        [Column("srn_adt1")]
        public string? SrnAdt1 { get; set; }

        [Column("is_schedule3_applicable")]
        public string? IsSchedule3Applicable { get; set; }

        [Column("industry_type")]
        public string? IndustryType { get; set; }

        [Column("are_consolidated_financials_required")]
        public string? AreConsolidatedFinancialsRequired { get; set; }

        // Part 4
        [Column("maintains_electronic_books")]
        public string? MaintainsElectronicBooks { get; set; }

        [Column("server_address_line1")]
        public string? ServerAddressLine1 { get; set; }

        [Column("server_address_line2")]
        public string? ServerAddressLine2 { get; set; }

        [Column("city")]
        public string? City { get; set; }

        [Column("state")]
        public string? State { get; set; }

        [Column("district")]
        public string? District { get; set; }

        [Column("country")]
        public string? Country { get; set; }

        [Column("pin_code_address")]
        public decimal? PinCodeAddress { get; set; }

        [Column("phone_number")]
        public decimal? PhoneNumber { get; set; }

        [Column("service_provider_name")]
        public string? ServiceProviderName { get; set; }

        [Column("service_provider_ip")]
        public string? ServiceProviderIP { get; set; }

        [Column("service_provider_location")]
        public string? ServiceProviderLocation { get; set; }

        [Column("books_on_cloud")]
        public string? BooksOnCloud { get; set; }

        [Column("service_provider_address")]
        public string? ServiceProviderAddress { get; set; }

        //Part 5
        // Non-Current Assets
        [Column("tangible_assets_current")]
        public decimal? TangibleAssetsCurrent { get; set; }

        [Column("tangible_assets_previous")]
        public decimal? TangibleAssetsPrevious { get; set; }

        [Column("intangible_assets_current")]
        public decimal? IntangibleAssetsCurrent { get; set; }

        // Reporting Periods
        [Column("current_reporting_period")]
        public string? CurrentReportingPeriod { get; set; }

        [Column("previous_reporting_period")]
        public string? PreviousReportingPeriod { get; set; }

        // Shareholders Fund
        [Column("share_capital_current")]
        public decimal? ShareCapitalCurrent { get; set; }

        [Column("share_capital_previous")]
        public decimal? ShareCapitalPrevious { get; set; }

        [Column("reserves_and_surplus_current")]
        public decimal? ReservesSurplusCurrent { get; set; }

        [Column("reserves_and_surplus_previous")]
        public decimal? ReservesSurplusPrevious { get; set; }

        [Column("money_against_share_warrants_current")]
        public decimal? MoneyShareWarrantsCurrent { get; set; }

        [Column("money_against_share_warrants_previous")]
        public decimal? MoneyShareWarrantsPrevious { get; set; }

        // Share Application Money
        [Column("share_application_money_pending_allotment_current")]
        public decimal? ShareApplicationMoneyCurrent { get; set; }

        [Column("share_application_money_pending_allotment_previous")]
        public decimal? ShareApplicationMoneyPrevious { get; set; }

        // Non-Current Liabilities
        [Column("long_term_borrowings_current")]
        public decimal? LongTermBorrowingsCurrent { get; set; }

        [Column("long_term_borrowings_previous")]
        public decimal? LongTermBorrowingsPrevious { get; set; }

        [Column("deferred_tax_liabilities_current")]
        public decimal? DeferredTaxLiabilitiesCurrent { get; set; }

        [Column("deferred_tax_liabilities_previous")]
        public decimal? DeferredTaxLiabilitiesPrevious { get; set; }

        [Column("other_long_term_liabilities_current")]
        public decimal? OtherLongTermLiabilitiesCurrent { get; set; }

        [Column("other_long_term_liabilities_previous")]
        public decimal? OtherLongTermLiabilitiesPrevious { get; set; }

        [Column("long_term_provisions_current")]
        public decimal? LongTermProvisionsCurrent { get; set; }

        [Column("long_term_provisions_previous")]
        public decimal? LongTermProvisionsPrevious { get; set; }

        // Current Liabilities
        [Column("short_term_borrowings_current")]
        public decimal? ShortTermBorrowingsCurrent { get; set; }

        [Column("short_term_borrowings_previous")]
        public decimal? ShortTermBorrowingsPrevious { get; set; }

        [Column("trade_payables_current")]
        public decimal? TradePayablesCurrent { get; set; }

        [Column("trade_payables_previous")]
        public decimal? TradePayablesPrevious { get; set; }

        [Column("other_current_liabilities_current")]
        public decimal? OtherCurrentLiabilitiesCurrent { get; set; }

        [Column("other_current_liabilities_previous")]
        public decimal? OtherCurrentLiabilitiesPrevious { get; set; }

        [Column("short_term_provisions_current")]
        public decimal? ShortTermProvisionsCurrent { get; set; }

        [Column("short_term_provisions_previous")]
        public decimal? ShortTermProvisionsPrevious { get; set; }

        // Equity and Liabilities Total
        [Column("total_equity_and_liabilities_current")]
        public decimal? TotalEquityAndLiabilitiesCurrent { get; set; }

        [Column("total_equity_and_liabilities_previous")]
        public decimal? TotalEquityAndLiabilitiesPrevious { get; set; }

        // Additional Assets and Liabilities
        [Column("intangible_assets_previous")]
        public decimal? IntangibleAssetsPrevious { get; set; }

        [Column("capital_work_in_progress_current")]
        public decimal? CapitalWorkInProgressCurrent { get; set; }

        [Column("capital_work_in_progress_previous")]
        public decimal? CapitalWorkInProgressPrevious { get; set; }

        [Column("intangible_assets_under_development_current")]
        public decimal? IntangibleAssetsUnderDevelopmentCurrent { get; set; }

        [Column("intangible_assets_under_development_previous")]
        public decimal? IntangibleAssetsUnderDevelopmentPrevious { get; set; }

        [Column("non_current_investments_current")]
        public decimal? NonCurrentInvestmentsCurrent { get; set; }

        [Column("non_current_investments_previous")]
        public decimal? NonCurrentInvestmentsPrevious { get; set; }

        [Column("deferred_tax_assets_current")]
        public decimal? DeferredTaxAssetsCurrent { get; set; }

        [Column("deferred_tax_assets_previous")]
        public decimal? DeferredTaxAssetsPrevious { get; set; }

        [Column("long_term_loans_and_advances_current")]
        public decimal? LongTermLoansAdvancesCurrent { get; set; }

        [Column("long_term_loans_and_advances_previous")]
        public decimal? LongTermLoansAdvancesPrevious { get; set; }

        [Column("other_non_current_assets_current")]
        public decimal? OtherNonCurrentAssetsCurrent { get; set; }

        [Column("other_non_current_assets_previous")]
        public decimal? OtherNonCurrentAssetsPrevious { get; set; }

        // Current Assets
        [Column("current_investments_current")]
        public decimal? CurrentInvestmentsCurrent { get; set; }

        [Column("current_investments_previous")]
        public decimal? CurrentInvestmentsPrevious { get; set; }

        [Column("inventories_current")]
        public decimal? InventoriesCurrent { get; set; }

        [Column("inventories_previous")]
        public decimal? InventoriesPrevious { get; set; }

        [Column("trade_receivables_current")]
        public decimal? TradeReceivablesCurrent { get; set; }

        [Column("trade_receivables_previous")]
        public decimal? TradeReceivablesPrevious { get; set; }

        [Column("cash_and_equivalents_current")]
        public decimal? CashAndEquivalentsCurrent { get; set; }

        [Column("cash_and_equivalents_previous")]
        public decimal? CashAndEquivalentsPrevious { get; set; }

        [Column("short_term_loans_and_advances_current")]
        public decimal? ShortTermLoansAdvancesCurrent { get; set; }

        [Column("short_term_loans_and_advances_previous")]
        public decimal? ShortTermLoansAdvancesPrevious { get; set; }

        [Column("other_current_assets_current")]
        public decimal? OtherCurrentAssetsCurrent { get; set; }

        [Column("other_current_assets_previous")]
        public decimal? OtherCurrentAssetsPrevious { get; set; }

        // Assets Total
        [Column("total_assets_current")]
        public decimal? TotalAssetsCurrent { get; set; }

        [Column("total_assets_previous")]
        public decimal? TotalAssetsPrevious { get; set; }

        // part 6
        // Current Period Properties (40 properties)
        [Column("starting_date_current")]
        public DateTime? StartingDateCurrent { get; set; }

        [Column("closing_date_current")]
        public DateTime? ClosingDateCurrent { get; set; }

        [Column("sales_goods_manufactured_current")]
        public decimal? SalesGoodsManufacturedCurrent { get; set; }

        [Column("sales_goods_traded_current")]
        public decimal? SalesGoodsTradedCurrent { get; set; }

        [Column("sales_supply_services_current")]
        public decimal? SalesSupplyServicesCurrent { get; set; }

        [Column("export_sales_goods_manufactured_current")]
        public decimal? ExportSalesGoodsManufacturedCurrent { get; set; }

        [Column("export_sales_goods_traded_current")]
        public decimal? ExportSalesGoodsTradedCurrent { get; set; }

        [Column("export_sales_supply_services_current")]
        public decimal? ExportSalesSupplyServicesCurrent { get; set; }

        [Column("other_income_current")]
        public decimal? OtherIncomeCurrent { get; set; }

        [Column("total_revenue_current")]
        public decimal? TotalRevenueCurrent { get; set; }

        [Column("cost_material_consumed_current")]
        public decimal? CostMaterialConsumedCurrent { get; set; }

        [Column("purchases_stock_trade_current")]
        public decimal? PurchasesStockTradeCurrent { get; set; }

        [Column("changes_inventories_finished_goods_current")]
        public decimal? ChangesInventoriesFinishedGoodsCurrent { get; set; }

        [Column("changes_inventories_work_in_progress_current")]
        public decimal? ChangesInventoriesWorkInProgressCurrent { get; set; }

        [Column("changes_inventories_stock_trade_current")]
        public decimal? ChangesInventoriesStockTradeCurrent { get; set; }

        [Column("employee_benefit_expense_current")]
        public decimal? EmployeeBenefitExpenseCurrent { get; set; }

        [Column("managerial_remuneration_current")]
        public decimal? ManagerialRemunerationCurrent { get; set; }

        [Column("payment_to_auditors_current")]
        public decimal? PaymentToAuditorsCurrent { get; set; }

        [Column("insurance_expenses_current")]
        public decimal? InsuranceExpensesCurrent { get; set; }

        [Column("power_and_fuel_current")]
        public decimal? PowerAndFuelCurrent { get; set; }

        [Column("finance_cost_current")]
        public decimal? FinanceCostCurrent { get; set; }

        [Column("depreciation_amortisation_current")]
        public decimal? DepreciationAmortisationCurrent { get; set; }

        [Column("other_expenses_current")]  
        public decimal? OtherExpensesCurrent { get; set; }

        [Column("total_expenses_current")]
        public decimal? TotalExpensesCurrent { get; set; }

        [Column("profit_before_exceptional_items_current")]
        public decimal? ProfitBeforeExceptionalItemsCurrent { get; set; }

        [Column("exceptional_items_current")]
        public decimal? ExceptionalItemsCurrent { get; set; }

        [Column("profit_before_extraordinary_items_current")]
        public decimal? ProfitBeforeExtraordinaryItemsCurrent { get; set; }

        [Column("extraordinary_items_current")]
        public decimal? ExtraordinaryItemsCurrent { get; set; }

        [Column("profit_before_tax_current")]
        public decimal? ProfitBeforeTaxCurrent { get; set; }

        [Column("current_tax_current")]
        public decimal? CurrentTaxCurrent { get; set; }

        [Column("deferred_tax_current")]
        public decimal? DeferredTaxCurrent { get; set; }

        [Column("profit_loss_continuing_operations_current")]
        public decimal? ProfitLossContinuingOperationsCurrent { get; set; }

        [Column("profit_loss_discontinuing_operations_current")]
        public decimal? ProfitLossDiscontinuingOperationsCurrent { get; set; }

        [Column("tax_expense_discontinuing_operations_current")]
        public decimal? TaxExpenseDiscontinuingOperationsCurrent { get; set; }

        [Column("profit_loss_discontinuing_after_tax_current")]
        public decimal? ProfitLossDiscontinuingAfterTaxCurrent { get; set; }

        [Column("total_profit_loss_current")]
        public decimal? TotalProfitLossCurrent { get; set; }

        [Column("basic_eps_before_extraordinary_items_current")]
        public decimal? BasicEpsBeforeExtraordinaryItemsCurrent { get; set; }

        [Column("diluted_eps_before_extraordinary_items_current")]
        public decimal? DilutedEpsBeforeExtraordinaryItemsCurrent { get; set; }

        [Column("basic_eps_after_extraordinary_items_current")]
        public decimal? BasicEpsAfterExtraordinaryItemsCurrent { get; set; }

        [Column("diluted_eps_after_extraordinary_items_current")]
        public decimal? DilutedEpsAfterExtraordinaryItemsCurrent { get; set; }

        // Previous Period Properties (40 properties)
        [Column("starting_date_previous")]
        public DateTime? StartingDatePrevious { get; set; }

        [Column("closing_date_previous")]
        public DateTime? ClosingDatePrevious { get; set; }

        [Column("sales_goods_manufactured_previous")]
        public decimal? SalesGoodsManufacturedPrevious { get; set; }

        [Column("sales_goods_traded_previous")]
        public decimal? SalesGoodsTradedPrevious { get; set; }

        [Column("sales_supply_services_previous")]
        public decimal? SalesSupplyServicesPrevious { get; set; }

        [Column("export_sales_goods_manufactured_previous")]
        public decimal? ExportSalesGoodsManufacturedPrevious { get; set; }

        [Column("export_sales_goods_traded_previous")]
        public decimal? ExportSalesGoodsTradedPrevious { get; set; }

        [Column("export_sales_supply_services_previous")]
        public decimal? ExportSalesSupplyServicesPrevious { get; set; }

        [Column("other_income_previous")]
        public decimal? OtherIncomePrevious { get; set; }

        [Column("total_revenue_previous")]
        public decimal? TotalRevenuePrevious { get; set; }

        [Column("cost_material_consumed_previous")]
        public decimal? CostMaterialConsumedPrevious { get; set; }

        [Column("purchases_stock_trade_previous")]
        public decimal? PurchasesStockTradePrevious { get; set; }

        [Column("changes_inventories_finished_goods_previous")]
        public decimal? ChangesInventoriesFinishedGoodsPrevious { get; set; }

        [Column("changes_inventories_work_in_progress_previous")]
        public decimal? ChangesInventoriesWorkInProgressPrevious { get; set; }

        [Column("changes_inventories_stock_trade_previous")]
        public decimal? ChangesInventoriesStockTradePrevious { get; set; }

        [Column("employee_benefit_expense_previous")]
        public decimal? EmployeeBenefitExpensePrevious { get; set; }

        [Column("managerial_remuneration_previous")]
        public decimal? ManagerialRemunerationPrevious { get; set; }

        [Column("payment_to_auditors_previous")]
        public decimal? PaymentToAuditorsPrevious { get; set; }

        [Column("insurance_expenses_previous")]
        public decimal? InsuranceExpensesPrevious { get; set; }

        [Column("power_and_fuel_previous")]
        public decimal? PowerAndFuelPrevious { get; set; }

        [Column("finance_cost_previous")]
        public decimal? FinanceCostPrevious { get; set; }

        [Column("depreciation_amortisation_previous")]
        public decimal? DepreciationAmortisationPrevious { get; set; }

        [Column("other_expenses_previous")]
        public decimal? OtherExpensesPrevious { get; set; }

        [Column("total_expenses_previous")]
        public decimal? TotalExpensesPrevious { get; set; }

        [Column("profit_before_exceptional_items_previous")]
        public decimal? ProfitBeforeExceptionalItemsPrevious { get; set; }

        [Column("exceptional_items_previous")]
        public decimal? ExceptionalItemsPrevious { get; set; }

        [Column("profit_before_extraordinary_items_previous")]
        public decimal? ProfitBeforeExtraordinaryItemsPrevious { get; set; }

        [Column("extraordinary_items_previous")]
        public decimal? ExtraordinaryItemsPrevious { get; set; }

        [Column("profit_before_tax_previous")]
        public decimal? ProfitBeforeTaxPrevious { get; set; }

        [Column("current_tax_previous")]
        public decimal? CurrentTaxPrevious { get; set; }

        [Column("deferred_tax_previous")]
        public decimal? DeferredTaxPrevious { get; set; }

        [Column("profit_loss_continuing_operations_previous")]
        public decimal? ProfitLossContinuingOperationsPrevious { get; set; }

        [Column("profit_loss_discontinuing_operations_previous")]
        public decimal? ProfitLossDiscontinuingOperationsPrevious { get; set; }

        [Column("tax_expense_discontinuing_operations_previous")]
        public decimal? TaxExpenseDiscontinuingOperationsPrevious { get; set; }

        [Column("profit_loss_discontinuing_after_tax_previous")]
        public decimal? ProfitLossDiscontinuingAfterTaxPrevious { get; set; }

        [Column("total_profit_loss_previous")]
        public decimal? TotalProfitLossPrevious { get; set; }

        [Column("basic_eps_before_extraordinary_items_previous")]
        public decimal? BasicEpsBeforeExtraordinaryItemsPrevious { get; set; }

        [Column("diluted_eps_before_extraordinary_items_previous")]
        public decimal? DilutedEpsBeforeExtraordinaryItemsPrevious { get; set; }

        [Column("basic_eps_after_extraordinary_items_previous")]
        public decimal? BasicEpsAfterExtraordinaryItemsPrevious { get; set; }

        [Column("diluted_eps_after_extraordinary_items_previous")]
        public decimal? DilutedEpsAfterExtraordinaryItemsPrevious { get; set; } // total = 80 // part 6

        // part 7
        // Share capital raised during the reporting period (Amount in Rupees)
        // Public Issue
        [Column("public_iss_eqt")]
        public decimal? PublicIssEqt { get; set; }

        [Column("public_iss_pre")]
        public decimal? PublicIssPre { get; set; }

        [Column("public_iss_total")]
        public decimal? PublicIssTotal { get; set; }

        // Bonus Issue
        [Column("bonus_iss_eqt")]
        public decimal? BonusIssEqt { get; set; }

        [Column("bonus_iss_pre")]
        public decimal? BonusIssPre { get; set; }

        [Column("bonus_iss_total")]
        public decimal? BonusIssTotal { get; set; }

        // Right Issue
        [Column("right_iss_eqt")]
        public decimal? RightIssEqt { get; set; }

        [Column("right_iss_pre")]
        public decimal? RightIssPre { get; set; }

        [Column("right_iss_total")]
        public decimal? RightIssTotal { get; set; }

        // Private Placement (Conversion)
        [Column("pri_plc_deb_pre1")]
        public decimal? PriPlcDebPre1 { get; set; }

        [Column("pri_plc_deb_pre2")]
        public decimal? PriPlcDebPre2 { get; set; }

        [Column("pri_plc_deb_pre_total")]
        public decimal? PriPlcDebPreTotal { get; set; }

        // Other Private Placement
        [Column("other_plc_deb_pre1")]
        public decimal? OtherPlcDebPre1 { get; set; }

        [Column("other_plc_deb_pre2")]
        public decimal? OtherPlcDebPre2 { get; set; }

        [Column("other_plc_deb_pre_total")]
        public decimal? OtherPlcDebPreTotal { get; set; }

        // Preferential Allotment (Conversion)
        [Column("pre_all_deb1")]
        public decimal? PreAllDeb1 { get; set; }

        [Column("pre_all_deb2")]
        public decimal? PreAllDeb2 { get; set; }

        [Column("pre_all_deb_total")]
        public decimal? PreAllDebTotal { get; set; }

        // Other Preferential Allotment
        [Column("other_pre_all1")]
        public decimal? OtherPreAll1 { get; set; }

        [Column("other_pre_all2")]
        public decimal? OtherPreAll2 { get; set; }

        [Column("other_pre_all_total")]
        public decimal? OtherPreAllTotal { get; set; }

        // ESOP
        [Column("esop_eqt")]
        public decimal? EsopEqt { get; set; }

        [Column("esop_pre")]
        public decimal? EsopPre { get; set; }

        [Column("esop_total")]
        public decimal? EsopTotal { get; set; }

        // Others
        [Column("other_eqt")]
        public decimal? OtherEqt { get; set; }

        [Column("other_pre")]
        public decimal? OtherPre { get; set; }

        [Column("other_total")]
        public decimal? OtherTotal { get; set; }

        // Totals
        [Column("total_amt_eqt")]
        public decimal? TotalAmtEqt { get; set; }

        [Column("total_amt_pre")]
        public decimal? TotalAmtPre { get; set; }

        [Column("total_amt_total")]
        public decimal? TotalAmtTotal { get; set; }

        // Financial parameters – Balance sheet items as on financial year end date
        // Row 1
        [Column("amt_issue_all")]
        public decimal? AmtIssueAll { get; set; }

        // Row 2
        [Column("app_money_given")]
        public decimal? AppMoneyGiven { get; set; }

        // Row 3
        [Column("share_app_mom_give")]
        public decimal? ShareAppMomGive { get; set; }

        // Row 4
        [Column("app_money_rec")]
        public decimal? AppMoneyRec { get; set; }

        // Row 5
        [Column("app_money_refund")]
        public decimal? AppMoneyRefund { get; set; }

        // Row 6
        [Column("paid_up_cap")]
        public decimal? PaidUpCap { get; set; }

        [Column("paid_up_cap_per")]
        public decimal? PaidUpCapPer { get; set; }

        // Row 7
        [Column("paid_up_cap_fore")]
        public decimal? PaidUpCapFore { get; set; }

        [Column("paid_up_cap_fore_per")]
        public decimal? PaidUpCapForePer { get; set; }

        // Row 8
        [Column("bought_back_share")]
        public decimal? BoughtBackShare { get; set; }

        // Row 9
        [Column("deposits_accepted")]
        public decimal? DepositsAccepted { get; set; }

        // Row 10
        [Column("deposited_matured")]
        public decimal? DepositedMatured { get; set; }

        // Row 11
        [Column("claimed_not_paid")]
        public decimal? ClaimedNotPaid { get; set; }

        // Row 12
        [Column("matured_not_claimed")]
        public decimal? MaturedNotClaimed { get; set; }

        // Row 13
        [Column("unclaimed_matured")]
        public decimal? UnclaimedMatured { get; set; }

        // Row 14
        [Column("debenture_claimed")]
        public decimal? DebentureClaimed { get; set; }

        // Row 15
        [Column("interest_on_deposits")]
        public decimal? InterestOnDeposits { get; set; }

        // Row 16
        [Column("unpaid_dividend")]
        public decimal? UnpaidDividend { get; set; }

        // Row 17
        [Column("invest_in_subsidiary")]
        public decimal? InvestInSusidiary { get; set; }

        // Row 18
        [Column("invest_in_government")]
        public decimal? InvestInGovernment { get; set; }

        // Row 19
        [Column("capital_reserves")]
        public decimal? CapitalReserves { get; set; }

        // Row 20
        [Column("investor_education")]
        public decimal? InvestorEducation { get; set; }

        // Row 21
        [Column("inter_corporate")]
        public decimal? InterCorporate { get; set; }

        // Row 22
        [Column("gross_value")]
        public decimal? GrossValue { get; set; }

        // Row 23
        [Column("grants_received")]
        public decimal? GrantsReceived { get; set; }

        // Row 24
        [Column("unpaid_directors")]
        public decimal? UnpaidDirectors { get; set; }

        // Row 25
        [Column("calls_unpaid")]
        public decimal? CallsUnpaid { get; set; }

        // Row 26
        [Column("forfeited_shares")]
        public decimal? ForfeitedShares { get; set; }

        // Row 27
        [Column("forfeited_shares_reissue")]
        public decimal? ForfeitedSharesReissue { get; set; }

        // Row 28
        [Column("foreign_institutional")]
        public decimal? ForeignInstitutional { get; set; }

        // Row 29
        [Column("borrowing_foreign")]
        public decimal? BorrowingForeign { get; set; }

        // Row 30
        [Column("corporate_borrowing")]
        public decimal? CorporateBorrowing { get; set; }

        // Row 31
        [Column("unsecured_borrowing")]
        public decimal? UnsecuredBorrowing { get; set; }

        // Row 32
        [Column("commercial_paper")]
        public decimal? CommercialPaper { get; set; }

        // Row 33
        [Column("warrents_conversion")]
        public decimal? WarrentsConversion { get; set; }

        // Row 34
        [Column("preference_warrants_convewrter")]
        public decimal? PreferenceWarrantsConvewrter { get; set; }

        // Row 35
        [Column("debenture_warrants_convewrter")]
        public decimal? DebentureWarrantsConvewrter { get; set; }

        // Row 36
        [Column("reporting_period_warrents")]
        public decimal? ReportingPeriodWarrents { get; set; }

        // Row 37
        [Column("rupees_warrents_issued")]
        public decimal? RupeesWarrentsIssued { get; set; }

        // Row 38
        [Column("payment_short_term")]
        public decimal? PaymentShortTerm { get; set; }

        // Row 39
        [Column("payment_long_term")]
        public decimal? PaymentLongTerm { get; set; }

        // Row 40
        [Column("opr_lease_con_finleas")]
        public string? OprLeaseConFinleas { get; set; }

        // Row 41
        [Column("net_worth")]
        public decimal? NetWorth { get; set; }

        // Row 42
        [Column("num_shareholder")]
        public decimal? NumShareholder { get; set; }

        // Row 43
        [Column("secured_loan")]
        public decimal? SecuredLoan { get; set; }

        // Row 44
        [Column("gross_fix_ass")]
        public decimal? GrossFixAss { get; set; }

        // Row 45
        [Column("deprec")]
        public decimal? Deprec { get; set; }

        // Row 46
        [Column("mis_exp")]
        public decimal? MisExp { get; set; }

        // Row 47
        [Column("unhedged_fore_ex")]
        public decimal? UnhedgedForeEx { get; set; }

        // Details of long term borrowings (unsecured)
        // Row 1 - Bonds/Debentures
        [Column("bonds_deb_cr")]
        public decimal? BondsDebCr { get; set; }

        [Column("bonds_deb_pr")]
        public decimal? BondsDebPr { get; set; }

        // Row 2a - Term Loans from Banks
        [Column("bank_loans_cr")]
        public decimal? BankLoansCr { get; set; }

        [Column("bank_loans_pr")]
        public decimal? BankLoansPr { get; set; }

        // Row 2b - Term Loans from Other Parties
        [Column("other_loan_cr")]
        public decimal? OtherLoanCr { get; set; }

        [Column("other_loan_pr")]
        public decimal? OtherLoanPr { get; set; }

        // Row 3 - Deferred Payment Liabilities
        [Column("deferred_lib_cr")]
        public decimal? DeferredLibCr { get; set; }

        [Column("deferred_lib_pr")]
        public decimal? DeferredLibPr { get; set; }

        // Row 4 - Deposits
        [Column("deposits_cr")]
        public decimal? DepositsCr { get; set; }

        [Column("deposits_pr")]
        public decimal? DepositsPr { get; set; }

        // Row 5 - Loans from Related Parties
        [Column("loan_from_rp_cr")]
        public decimal? LoanFromRpCr { get; set; }

        [Column("loan_from_rp_pr")]
        public decimal? LoanFromRpPr { get; set; }

        // Row 6 - Financial Lease Obligations
        [Column("financial_lease_cr")]
        public decimal? FinancialLeaseCr { get; set; }

        [Column("financial_lease_pr")]
        public decimal? FinancialLeasePr { get; set; }

        // Row 7 - Other Loans & Advances
        [Column("other_advances_cr")]
        public decimal? OtherAdvancesCr { get; set; }

        [Column("other_advances_pr")]
        public decimal? OtherAdvancesPr { get; set; }

        // Row 8 - Total (calculated)
        [Column("total_l_borring_cr")]
        public decimal? TotalLBorringCr { get; set; }

        [Column("total_l_borring_pr")]
        public decimal? TotalLBorringPr { get; set; }

        // Row 9 - Director Guarantees
        [Column("aggregate_amt_cr")]
        public decimal? AggregateAmtCr { get; set; }

        [Column("aggregate_amt_pr")]
        public decimal? AggregateAmtPr { get; set; }

        // Details of short term borrowings (unsecured)
        // Row 1b - Loans from Other Parties
        [Column("other_loan_cr_short")]
        public decimal? OtherLoanCrShort { get; set; }

        [Column("other_loan_pr_short")]
        public decimal? OtherLoanPrShort { get; set; }

        // Row 2 - Loans from Related Parties
        [Column("loans_advances_cr")]
        public decimal? LoansAdvancesCr { get; set; }

        [Column("loans_advances_pr")]
        public decimal? LoansAdvancesPr { get; set; }

        // Row 3 - Deposits
        [Column("deposits_cr_short")]
        public decimal? DepositsCrShort { get; set; }

        [Column("deposits_pr_short")]
        public decimal? DepositsPrShort { get; set; }

        // Row 4 - Other Loans & Advances
        [Column("other_advance_loan_cr")]
        public decimal? OtherAdvanceLoanCr { get; set; }

        [Column("other_advance_loan_pr")]
        public decimal? OtherAdvanceLoanPr { get; set; }

        // Row 5 - Total (calculated)
        [Column("total_borrowing_cr")]
        public decimal? TotalBorrowingCr { get; set; }

        [Column("total_borrowing_pr")]
        public decimal? TotalBorrowingPr { get; set; }

        // Row 6 - Director Guarantees
        [Column("aggregate_amount_cr")]
        public decimal? AggregateAmountCr { get; set; }

        [Column("aggregate_amount_pr")]
        public decimal? AggregateAmountPr { get; set; }

        // Details of long term loans and advances (unsecured, considered good)/(doubtful)
        // Row 1 - Capital Advances
        [Column("unsecured_cap_ad_cr")]
        public decimal? UnsecuredCapAdCr { get; set; }

        [Column("unsecured_cap_ad_pr")]
        public decimal? UnsecuredCapAdPr { get; set; }

        [Column("doubt_cap_ad_cr")]
        public decimal? DoubtCapAdCr { get; set; }

        [Column("doubt_cap_ad_pr")]
        public decimal? DoubtCapAdPr { get; set; }

        // Row 2 - Security Deposits
        [Column("un_security_dep_cr")]
        public decimal? UnSecurityDepCr { get; set; }

        [Column("un_security_dep_pr")]
        public decimal? UnSecurityDepPr { get; set; }

        [Column("dt_security_dep_cr")]
        public decimal? DtSecurityDepCr { get; set; }

        [Column("dt_security_dep_pr")]
        public decimal? DtSecurityDepPr { get; set; }

        // Row 3 - Loans to Related Parties
        [Column("un_rp_loan_cr")]
        public decimal? UnRpLoanCr { get; set; }

        [Column("un_rp_loan_pr")]
        public decimal? UnRpLoanPr { get; set; }

        [Column("dt_rp_loan_cr")]
        public decimal? DtRpLoanCr { get; set; }

        [Column("dt_rp_loan_pr")]
        public decimal? DtRpLoanPr { get; set; }

        // Row 4 - Other Loans
        [Column("un_other_loan_cr")]
        public decimal? UnOtherLoanCr { get; set; }

        [Column("un_other_loan_pr")]
        public decimal? UnOtherLoanPr { get; set; }

        [Column("dt_other_loan_cr")]
        public decimal? DtOtherLoanCr { get; set; }

        [Column("dt_other_loan_pr")]
        public decimal? DtOtherLoanPr { get; set; }

        // Row 5 - Totals
        [Column("un_total_cr")]
        public decimal? UnTotalCr { get; set; }

        [Column("un_total_pr")]
        public decimal? UnTotalPr { get; set; }

        [Column("dt_total_cr")]
        public decimal? DtTotalCr { get; set; }

        [Column("dt_total_pr")]
        public decimal? DtTotalPr { get; set; }

        // Row 6a - Bad Debt Provisions (Related Parties)
        [Column("un_rp_baddebt_cr")]
        public decimal? UnRpBaddebtCr { get; set; }

        [Column("un_rp_baddebt_pr")]
        public decimal? UnRpBaddebtPr { get; set; }

        [Column("dt_rp_baddebt_cr")]
        public decimal? DtRpBaddebtCr { get; set; }

        [Column("dt_rp_baddebt_pr")]
        public decimal? DtRpBaddebtPr { get; set; }

        // Row 6b - Bad Debt Provisions (Others)
        [Column("un_other_baddebt_cr")]
        public decimal? UnOtherBaddebtCr { get; set; }

        [Column("un_other_baddebt_pr")]
        public decimal? UnOtherBaddebtPr { get; set; }

        [Column("dt_other_baddebt_cr")]
        public decimal? DtOtherBaddebtCr { get; set; }

        [Column("dt_other_baddebt_pr")]
        public decimal? DtOtherBaddebtPr { get; set; }

        // Row 7 - Net Loans
        [Column("un_net_loan_cr")]
        public decimal? UnNetLoanCr { get; set; }

        [Column("un_net_loan_pr")]
        public decimal? UnNetLoanPr { get; set; }

        [Column("dt_net_loan_cr")]
        public decimal? DtNetLoanCr { get; set; }

        [Column("dt_net_loan_pr")]
        public decimal? DtNetLoanPr { get; set; }

        // Row 8 - Director/Officer Loans
        [Column("un_due_loan_cr")]
        public decimal? UnDueLoanCr { get; set; }

        [Column("un_due_loan_pr")]
        public decimal? UnDueLoanPr { get; set; }

        [Column("dt_due_loan_cr")]
        public decimal? DtDueLoanCr { get; set; }

        [Column("dt_due_loan_pr")]
        public decimal? DtDueLoanPr { get; set; }

        // Details of trade receivables
        // Row 1 - Secured, Considered Good
        [Column("consider_good_ces")]
        public decimal? ConsiderGoodCes { get; set; }

        [Column("consider_good_cws")]
        public decimal? ConsiderGoodCws { get; set; }

        [Column("consider_good_pes")]
        public decimal? ConsiderGoodPes { get; set; }

        [Column("consider_good_pws")]
        public decimal? ConsiderGoodPws { get; set; }

        // Row 2 - Unsecured, Considered Good
        [Column("unsecured_con_ces")]
        public decimal? UnsecuredConCes { get; set; }

        [Column("unsecured_con_cws")]
        public decimal? UnsecuredConCws { get; set; }

        [Column("unsecured_con_pes")]
        public decimal? UnsecuredConPes { get; set; }

        [Column("unsecured_con_pws")]
        public decimal? UnsecuredConPws { get; set; }

        // Row 3 - Doubtful
        [Column("doubtful_ces")]
        public decimal? DoubtfulCes { get; set; }

        [Column("doubtful_cws")]
        public decimal? DoubtfulCws { get; set; }

        [Column("doubtful_pes")]
        public decimal? DoubtfulPes { get; set; }

        [Column("doubtful_pws")]
        public decimal? DoubtfulPws { get; set; }

        // Row 4 - Total Trade Receivables (calculated)
        [Column("trade_receivables_ces")]
        public decimal? TradeReceivablesCes { get; set; }

        [Column("trade_receivables_cws")]
        public decimal? TradeReceivablesCws { get; set; }

        [Column("trade_receivables_pes")]
        public decimal? TradeReceivablesPes { get; set; }

        [Column("trade_receivables_pws")]
        public decimal? TradeReceivablesPws { get; set; }

        // Row 5 - Bad Debt Provisions
        [Column("doubtful_debts_ces")]
        public decimal? DoubtfulDebtsCes { get; set; }

        [Column("doubtful_debts_cws")]
        public decimal? DoubtfulDebtsCws { get; set; }

        [Column("doubtful_debts_pes")]
        public decimal? DoubtfulDebtsPes { get; set; }

        [Column("doubtful_debts_pws")]
        public decimal? DoubtfulDebtsPws { get; set; }

        // Row 6 - Net Trade Receivables (calculated)
        [Column("net_trade_ces")]
        public decimal? NetTradeCes { get; set; }

        [Column("net_trade_cws")]
        public decimal? NetTradeCws { get; set; }

        [Column("net_trade_pes")]
        public decimal? NetTradePes { get; set; }

        [Column("net_trade_pws")]
        public decimal? NetTradePws { get; set; }

        // Row 7 - Director/Officer Debts
        [Column("other_officers_ces")]
        public decimal? OtherOfficersCes { get; set; }

        [Column("other_officers_cws")]
        public decimal? OtherOfficersCws { get; set; }

        [Column("other_officers_pes")]
        public decimal? OtherOfficersPes { get; set; }

        [Column("other_officers_pws")]
        public decimal? OtherOfficersPws { get; set; }

        // Details of earning in foreign exchange
        // Current Reporting Period (CR)
        [Column("exports_goods_cr")]
        public decimal? ExportsGoodsCr { get; set; }

        [Column("int_div_cr")]
        public decimal? IntDivCr { get; set; }

        [Column("royalty_cr")]
        public decimal? RoyaltyCr { get; set; }

        [Column("know_how_cr")]
        public decimal? KnowHowCr { get; set; }

        [Column("pro_con_cr")]
        public decimal? ProConCr { get; set; }

        [Column("other_in_cr")]
        public decimal? OtherInCr { get; set; }

        [Column("total_earn_cr")]
        public decimal? TotalEarnCr { get; set; }

        // Previous Reporting Period (PR)
        [Column("exports_goods_pr")]
        public decimal? ExportsGoodsPr { get; set; }

        [Column("int_div_pr")]
        public decimal? IntDivPr { get; set; }

        [Column("royalty_pr")]
        public decimal? RoyaltyPr { get; set; }

        [Column("know_how_pr")]
        public decimal? KnowHowPr { get; set; }

        [Column("pro_con_pr")]
        public decimal? ProConPr { get; set; }

        [Column("other_in_pr")]
        public decimal? OtherInPr { get; set; }

        [Column("total_earn_pr")]
        public decimal? TotalEarnPr { get; set; }

        // Details of expenditure in foreign exchange
        // Import of Goods
        [Column("raw_mat_cr")]
        public decimal? RawMatCr { get; set; }

        [Column("raw_mat_pr")]
        public decimal? RawMatPr { get; set; }

        [Column("com_sap_cr")]
        public decimal? ComSapCr { get; set; }

        [Column("com_sap_pr")]
        public decimal? ComSapPr { get; set; }

        [Column("cap_goods_cr")]
        public decimal? CapGoodsCr { get; set; }

        [Column("cap_goods_pr")]
        public decimal? CapGoodsPr { get; set; }

        // Expenditures
        [Column("exp_royality_cr")]
        public decimal? ExpRoyalityCr { get; set; }

        [Column("exp_royality_pr")]
        public decimal? ExpRoyalityPr { get; set; }

        [Column("exp_know_cr")]
        public decimal? ExpKnowCr { get; set; }

        [Column("exp_know_pr")]
        public decimal? ExpKnowPr { get; set; }

        [Column("exp_pro_cr")]
        public decimal? ExpProCr { get; set; }

        [Column("exp_pro_pr")]
        public decimal? ExpProPr { get; set; }

        [Column("exp_int_cr")]
        public decimal? ExpIntCr { get; set; }

        [Column("exp_int_pr")]
        public decimal? ExpIntPr { get; set; }

        [Column("other_mat_cr")]
        public decimal? OtherMatCr { get; set; }

        [Column("other_mat_pr")]
        public decimal? OtherMatPr { get; set; }

        // Dividend
        [Column("did_paid_cr")]
        public decimal? DidPaidCr { get; set; }

        [Column("did_paid_pr")]
        public decimal? DidPaidPr { get; set; }

        // Totals
        [Column("total_exp_cr")]
        public decimal? TotalExpCr { get; set; }

        [Column("total_exp_pr")]
        public decimal? TotalExpPr { get; set; }

        // Financial parameters – Profit and loss account items during the reporting period
        // Row 1 - Proposed Dividend
        [Column("pro_did_rup")]
        public decimal? ProDidRup { get; set; }

        [Column("pro_did_per")]
        public decimal? ProDidPer { get; set; }

        // Row 2 - Earnings Per Share
        [Column("earn_basic_share")]
        public decimal? EarnBasicShare { get; set; }

        [Column("earn_diluted_share")]
        public decimal? EarnDilutedShare { get; set; }

        // Row 3 - Foreign Currency Income
        [Column("income_in_fc")]
        public decimal? IncomeInFc { get; set; }

        // Row 4 - Foreign Currency Expenditure
        [Column("exp_in_fc")]
        public decimal? ExpInFc { get; set; }

        // Row 5 - Government Grants
        [Column("revenue_rec")]
        public decimal? RevenueRec { get; set; }

        // Row 6 - Rent
        [Column("rent_paid")]
        public decimal? RentPaid { get; set; }

        // Row 7 - Stores Consumption
        [Column("consup_str_sp")]
        public decimal? ConsupStrSp { get; set; }

        // Row 8 - Related Party Transactions
        [Column("gross_val_trans")]
        public decimal? GrossValTrans { get; set; }

        // Row 9 - Bad Debts
        [Column("bad_debts")]
        public decimal? BadDebts { get; set; }


        // Part 8: Basic Financials and CSR Details

        // CSR Applicability
        [Column("is_csr_applicable")]
        public string? IsCsrApplicable { get; set; }  // Radio button value (Yes/No)

        // Basic Financials
        [Column("turnover")]
        public decimal? TurnOver { get; set; }        // Turnover (readonly)

        [Column("financial_net_worth")]
        public decimal? FinancialNetWorth { get; set; }         // Net worth

        // Financial Years
        [Column("first_financial_year_ended")]
        public decimal? FirstFinancialYearEnded { get; set; }  // Year 1

        [Column("second_financial_year_ended")]
        public decimal? SecondFinancialYearEnded { get; set; } // Year 2

        [Column("third_financial_year_ended")]
        public decimal? ThirdFinancialYearEnded { get; set; }  // Year 3

        // Profit Before Tax (readonly)
        [Column("first_year_profit_before_tax")]
        public decimal? FirstYearProfitBeforeTax { get; set; }  // Year 1

        [Column("second_year_profit_before_tax")]
        public decimal? SecondYearProfitBeforeTax { get; set; } // Year 2

        [Column("third_year_profit_before_tax")]
        public decimal? ThirdYearProfitBeforeTax { get; set; }  // Year 3

        // Computed Net Profit
        [Column("first_year_computed_net_profit")]
        public decimal? FirstYearComputedNetProfit { get; set; }  // Year 1

        [Column("second_year_computed_net_profit")]
        public decimal? SecondYearComputedNetProfit { get; set; } // Year 2

        [Column("third_year_computed_net_profit")]
        public decimal? ThirdYearComputedNetProfit { get; set; }  // Year 3

        // Calculated Values
        [Column("average_net_profit")]
        public decimal? AverageNetProfit { get; set; }            // Average of 3 years (readonly)

        [Column("prescribed_csr_expenditure")]
        public decimal? PrescribedCsrExpenditure { get; set; }    // 2% of average (readonly)

        // CSR Spending
        [Column("total_csr_spending")]
        public decimal? TotalCsrSpending { get; set; }           // Total CSR spent

        [Column("local_area_spending")]
        public decimal? LocalAreaSpending { get; set; }           // Amount spent locally

        // Part 9: Implementing Agency & Explanation Details

        [Column("details_of_implenting_agency")]
        public string? DetailsOfImplentingAgency { get; set; }

        [Column("explanation_for_not_spending")]
        public string? ExplanationForNotSpending { get; set; }

        [Column("other_explaination_reason")]
        public string? OtherExplainationReason { get; set; }

        [Column("responsibility_statement_of_csr")]
        public string? ResponsibilityStatementOfCsr { get; set; }

        // Part 11: Cost Record and Central Excise Tariff Details

        [Column("cost_record_maintain")]
        public string? CostRecordMaintain { get; set; }  // Radio button (YES/NO)

        [Column("central_excise_tariff")]
        public string? CentralExciseTariff { get; set; }   // Tariff heading (if YES)

        // Conditional fields (if costRecordMaintain is YES)
        [Column("cost_record_sn1")]
        public string? CostRecordSn1 { get; set; }       // Audit requirement radio (YES/NO)

        [Column("centralexcisetariff2")]
        public string? CentralExciseTariff2 { get; set; }   // Second tariff heading (if costRecordSn1 is YES)

        // Part 12: CAG, Auditor, CARO, Secretarial Audit & Directors Report

        // CAG Section
        [Column("is_cag_commented")]
        public string? IsCagCommented { get; set; }       // 'Yes', 'No' or 'NA'

        // Auditor Report
        [Column("has_auditor_remarks")]
        public string? HasAuditorRemarks { get; set; }      // 'Yes' or 'No'

        // CARO Section
        [Column("is_caro_applicable")]
        public string? IsCaroApplicable { get; set; }       // 'Yes' or 'No'

        // CARO Dropdowns
        [Column("caro_fixed_assets")]
        public string? CaroFixedAssets { get; set; }        // Fixed assets remark

        [Column("caro_inventories")]
        public string? CaroInventories { get; set; }        // Inventories remark

        [Column("caro_loans_given")]
        public string? CaroLoansGiven { get; set; }         // Loans given remark

        [Column("caro_public_deposits")]
        public string? CaroPublicDeposits { get; set; }     // Public deposits remark

        [Column("caro_cost_records")]
        public string? CaroCostRecords { get; set; }        // Cost records remark

        [Column("caro_statutory_dues")]
        public string? CaroStatutoryDues { get; set; }      // Statutory dues remark

        [Column("caro_term_loans")]
        public string? CaroTermLoans { get; set; }          // Term loans remark

        [Column("caro_fraud_noticed")]
        public string? CaroFraudNoticed { get; set; }       // Fraud noticed remark

        [Column("caro_other_remarks")]
        public string? CaroOtherRemarks { get; set; }       // Other remarks

        // Secretarial Audit
        [Column("is_secretarial_audit_applicable")]
        public string? IsSecretarialAuditApplicable { get; set; }  // 'Yes' or 'No'

        // Directors Report
        [Column("has_director_report_disclosures")]
        public string? HasDirectorReportDisclosures { get; set; }   // 'Yes' or 'No'

        // Part 13: Resolution, Signatory & Certification Details

        // Resolution Details
        [Column("resolution_number")]
        public string? ResolutionNumber { get; set; }      // Number input (could be alphanumeric)

        [Column("resolution_date")]
        public string? ResolutionDate { get; set; }        // Date input

        // Signatory Details
        [Column("signatory_name")]
        public string? SignatoryName { get; set; }         // Select (signed)

        [Column("signatory_designation")]
        public string? SignatoryDesignation { get; set; }  // Select (designationDropDown)

        [Column("din_pan_number")]
        public string? DinPanNumber { get; set; }          // Text input (dinPan)

        // Certification
        [Column("certified_by")]
        public string? CertifiedBy {  get; set; }           // Select (certificateBy)

        [Column("certifying_professional")]
        public string? CertifyingProfessional { get; set; } // Select (nameOfPcs)

        [Column("professional_type")]
        public string? ProfessionalType { get; set; }      // Radio (rbAssocFellow) - 'ASS', 'FW', or 'NONE'

        [Column("membership_number")]
        public string? MembershipNumber { get; set; }      // Text input (membershipNum)

        [Column("practice_certificate_number")]
        public string? PracticeCertificateNumber { get; set; } // Text input (certPraticeNo)

    }

    [TableName("tbl_aoc4", "vw_aoc4")]
    public class AOC4View : AOC4
    {
        [Column("ref_user_name")]
        public string? RefUserName { get; set; }
    }

}