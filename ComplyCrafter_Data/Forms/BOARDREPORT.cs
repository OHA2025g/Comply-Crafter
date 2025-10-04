using AlphaUtil.Core.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;
using System.Text.Json.Serialization;

namespace ComplyCrafter_Data
{
    [TableName("tbl_boardreport", "vw_boardreport")]
    public class BOARDREPORT : BaseModel
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

        [Column("amount_figure")]
        public string? AmountFigure { get; set; }

        [Column("type_board_report")]
        public string? TypeBoardReport { get; set; }

        [Column("agmnotice_date")]
        public DateTime? AgmnoticeDate { get; set; }

        [Column("date_agm")]
        public DateTime? DateAgm { get; set; }

        [Column("day_date")]
        public DateTime? DayDate { get; set; }

        [Column("time_agm")]
        public string? TimeAgm { get; set; }

        [Column("no_of_agm")]
        public int? NoOfAgm { get; set; }

        [Column("paidup_capital")]
        public string? PaidupCapital { get; set; }

        [Column("no_of_board_meeting")]
        public int? NoOfBoardMeeting { get; set; }

        [Column("board_meeting_sr_no")]
        public string? BoardMeetingSrNo { get; set; }

        [Column("board_meeting_date")]
        public DateTime? BoardMeetingDate { get; set; }

        [Column("board_strength1")]
        public int BoardStrength1 { get; set; }

        [Column("no_of_directors_present1")]
        public int? NoOfDirectorsPresent1 { get; set; }

        [Column("board_meeting_sr_no2")]
        public string? BoardMeetingSrNo2 { get; set; }

        [Column("board_meeting_date2")]
        public DateTime? BoardMeetingDate2 { get; set; }

        [Column("board_strength2")]
        public int? BoardStrength2 { get; set; }

        [Column("no_of_directors_present2")]
        public int? NoOfDirectorsPresent2 { get; set; }

        [Column("numbers_of_board_meeting_during_year")]
        public string? NumbersOfBoardMeetingDuringYear { get; set; }

        [Column("board_meeting_date3")]
        public DateTime? BoardMeetingDate3 { get; set; }

        [Column("board_strength3")]
        public int? BoardStrength3 { get; set; }

        [Column("no_of_directors_present3")]
        public int? NoOfDirectorsPresent3 { get; set; }

        [Column("sr_no4")]
        public string? SrNo4 { get; set; }

        [Column("board_meeting_date4")]
        public DateTime? BoardMeetingDate4 { get; set; }

        [Column("board_strength4")]
        public int? BoardStrength4 { get; set; }

        [Column("no_of_directors_present4")]
        public decimal? NoOfDirectorsPresent4 { get; set; }

        [Column("sr_no5")]
        public string? SrNo5 { get; set; }

        [Column("board_meeting_date5")]
        public DateTime? BoardMeetingDate5 { get; set; }

        [Column("board_strength5")]
        public int? BoardStrength5 { get; set; }

        [Column("no_of_directors_present5")]
        public int? NoOfDirectorsPresent5 { get; set; }

        [Column("sr_no6")]
        public string? SrNo6 { get; set; }

        [Column("board_meeting_date6")]
        public DateTime? BoardMeetingDate6 { get; set; }

        [Column("board_strength6")]
        public int? BoardStrength6 { get; set; }

        [Column("no_of_directors_present6")]
        public int? NoOfDirectorsPresent6 { get; set; }

        [Column("no_of_general_meeting")]
        public int? NoOfGeneralMeeting { get; set; }

        [Column("number_of_meeting_during_year2")]
        public string? NumberOfMeetingDuringYear2 { get; set; }

        [Column("select_meeting_type")]
        public string? SelectMeetingType { get; set; }

        [Column("general_meeting_date")]
        public DateTime? GeneralMeetingDate { get; set; }

        [Column("general_strength_meeting")]
        public int? GeneralStrengthMeeting { get; set; }

        [Column("no_of_members_present")]
        public int? NoOfMembersPresent { get; set; }

        [Column("have_website")]
        public string? HaveWebsite { get; set; }

        [Column("website_name")]
        public string? WebsiteName { get; set; }

        [Column("operation_revenue_cur")]
        public string? OperationRevenueCur { get; set; }

        [Column("operation_revenue_pre")]
        public string? OperationRevenuePre { get; set; }

        [Column("profit_before_cur")]
        public string? ProfitBeforeCur { get; set; }

        [Column("profit_before_pre")]
        public string? ProfitBeforePre { get; set; }

        [Column("other_income_cur")]
        public string? OtherIncomeCur { get; set; }

        [Column("other_income_pre")]
        public string? OtherIncomePre { get; set; }

        [Column("finance_charge_cur")]
        public string? FinanceChargeCur { get; set; }

        [Column("finance_charge_pre")]
        public string? FinanceChargePre { get; set; }

        [Column("depreciation_cur")]
        public string? DepreciationCur { get; set; }

        [Column("depreciation_pre")]
        public string? DepreciationPre { get; set; }

        [Column("otherexp_cur")]
        public string? OtherexpCur { get; set; }

        [Column("otherexp_pre")]
        public string? OtherexpPre { get; set; }

        [Column("net_profit_before_cur")]
        public string? NetProfitBeforeCur { get; set; }

        [Column("net_profit_before_pre")]
        public string? NetProfitBeforePre { get; set; }

        [Column("tax_expense_cur")]
        public string? TaxExpenseCur { get; set; }

        [Column("tax_expense_pre")]
        public string? TaxExpensePre { get; set; }

        [Column("deffere_tax_expense_cur")]
        public string? DeffereTaxExpenseCur { get; set; }

        [Column("deffered_tax_expense_pre")]
        public string? DefferedTaxExpensePre { get; set; }

        [Column("net_profit_cur")]
        public string? NetProfitCur { get; set; }

        [Column("net_profit_pre")]
        public string? NetProfitPre { get; set; }

        [Column("revenue_changes")]
        public string? RevenueChanges { get; set; }

        [Column("pbdit_changes")]
        public string? PbditChanges { get; set; }

        [Column("pbt_changes")]
        public string? PbtChanges { get; set; }

        [Column("pat_changes")]
        public string? PatChanges { get; set; }

        [Column("is_independ_director")]
        public string? IsIndependDirector { get; set; }

        [Column("have_csr")]
        public string? HaveCsr { get; set; }

        [Column("risk_management_policy")]
        public string? RiskManagementPolicy { get; set; }

        [Column("no_of_committee_meeting")]
        public int? NoOfCommitteeMeeting { get; set; }

        [Column("have_cas")]
        public string? HaveCas { get; set; }

        [Column("is_committee_of_director")]
        public string? IsCommitteeOfDirector { get; set; }

        [Column("name_of_audit_firm")]
        public string? NameOfAuditFirm { get; set; }

        [Column("date_appo_auditor")]
        public DateTime? DateAppoAuditor { get; set; }

        [Column("category")]
        public string? Category { get; set; }

        [Column("firm_registration")]
        public string? FirmRegistration { get; set; }

        [Column("period_appointment")]
        public string? PeriodAppointment { get; set; }

        [Column("effective_date_au")]
        public DateTime? EffectiveDateAu { get; set; }

        [Column("any_observation")]
        public string? AnyObservation { get; set; }

        [Column("have_costaudit")]
        public string? HaveCostaudit { get; set; }

        [Column("name_of_secretarial_auditor")]
        public string? NameOfSecretarialAuditor { get; set; }

        [Column("date_secretaria_auditor")]
        public DateTime? DateSecretariaAuditor { get; set; }

        [Column("any_observation_sect")]
        public string? AnyObservationSect { get; set; }

        [Column("cost_secretaria_fees")]
        public string? CostSecretariaFees { get; set; }

        [Column("have_internalaudit")]
        public string? HaveInternalaudit { get; set; }

        [Column("name_of_internal_auditor")]
        public string? NameOfInternalAuditor { get; set; }

        [Column("date_internal_auditor")]
        public DateTime? DateInternalAuditor { get; set; }

        [Column("any_observation_int")]
        public string? AnyObservationInt { get; set; }

        [Column("cost_internal_fees")]
        public string? CostInternalFees { get; set; }

        [Column("loan_invest")]
        public string? LoanInvest { get; set; }

        [Column("no_of_party")]
        public string? NoOfParty { get; set; }

        [Column("detail_loan_invest")]
        public string? DetailLoanInvest { get; set; }

        [Column("related_party_trans")]
        public string? RelatedPartyTrans { get; set; }

        [Column("related_party_trans_matrial")]
        public string? RelatedPartyTransMatrial { get; set; }

        [Column("no_teno_of_related_party")]
        public string? NoTenoOfRelatedParty { get; set; }

        [Column("is_related_party_detail")]
        public string? IsRelatedPartyDetail { get; set; }

        [Column("no_of_matarial")]
        public int? NoOfMatarial { get; set; }

        [Column("is_related_party_detailarms")]
        public string? IsRelatedPartyDetailarms { get; set; }

        [Column("no_of_contracts")]
        public int? NoOfContracts { get; set; }

        [Column("changes_nature")]
        public string? ChangesNature { get; set; }

        [Column("tab_changes_nature")]
        public string? TabChangesNature { get; set; }

        [Column("changes_share")]
        public string? ChangesShare { get; set; }

        [Column("authorised_capital")]
        public string? AuthorisedCapital { get; set; }

        [Column("no_of_authorized")]
        public int? NoOfAuthorized { get; set; }

        [Column("share_issue")]
        public string? ShareIssue { get; set; }

        [Column("no_of_share_issue")]
        public string? NoOfShareIssue { get; set; }

        [Column("buy_back")]
        public string? BuyBack { get; set; }

        [Column("no_of_buck_back")]
        public string? NoOfBuckBack { get; set; }

        [Column("data_box1")]
        public string? DataBox1 { get; set; }

        [Column("data_box2")]
        public string? DataBox2 { get; set; }

        [Column("data_boxs3")]
        public string? DataBoxs3 { get; set; }

        [Column("data_box4")]
        public string? DataBox4 { get; set; }

        [Column("sweet_equity")]
        public string? SweetEquity { get; set; }

        [Column("no_of_sweet_equity")]
        public string? NoOfSweetEquity { get; set; }

        [Column("value_sweet_equity")]
        public string? ValueSweetEquity { get; set; }

        [Column("total_sweet_equity")]
        public string? TotalSweetEquity { get; set; }

        [Column("bonus_share")]
        public string? BonusShare { get; set; }

        [Column("no_of_bonus_share")]
        public string? NoOfBonusShare { get; set; }

        [Column("value_bonus_share")]
        public string? ValueBonusShare { get; set; }

        [Column("total_bonu_share")]
        public string? TotalBonuShare { get; set; }

        [Column("esop_share")]
        public string? EsopShare { get; set; }

        [Column("no_of_esopshare")]
        public string? NoOfEsopshare { get; set; }

        [Column("value_esopshare")]
        public string? ValueEsopshare { get; set; }

        [Column("total_esopshare")]
        public string? TotalEsopshare { get; set; }

        [Column("shared_if_right")]
        public string? SharedIfRight { get; set; }

        [Column("no_of_shared_if_right")]
        public string? NoOfSharedIfRight { get; set; }

        [Column("value_shared_if_right")]
        public string? ValueSharedIfRight { get; set; }

        [Column("total_shared_if_right")]
        public string? TotalSharedIfRight { get; set; }

        [Column("amount_transfer_reserve")]
        public string? AmountTransferReserve { get; set; }

        [Column("no_of_transfer_reserve")]
        public string? NoOfTransferReserve { get; set; }

        [Column("have_dividend")]
        public string? HaveDividend { get; set; }

        [Column("reason_no_payment")]
        public string? ReasonNoPayment { get; set; }

        [Column("interim_dividend")]
        public string? InterimDividend { get; set; }

        [Column("dividend_distribution_tax_interim")]
        public string? DividendDistributionTaxInterim { get; set; }

        [Column("data_board_interim")]
        public string? DataBoardInterim { get; set; }

        [Column("data_board_interim_face_value")]
        public string? DataBoardInterimFaceValue { get; set; }

        [Column("data_board_interim_percent")]
        public string? DataBoardInterimPercent { get; set; }

        [Column("final_dividend")]
        public string? FinalDividend { get; set; }

        [Column("dividend_distribution_tax_final")]
        public string? DividendDistributionTaxFinal { get; set; }

        [Column("board_dividend_share")]
        public string? BoardDividendShare { get; set; }

        [Column("board_face_value_share")]
        public string? BoardFaceValueShare { get; set; }

        [Column("board_percent_of_dividend")]
        public string? BoardPercentOfDividend { get; set; }

        [Column("transfer_dividend")]
        public string? TransferDividend { get; set; }

        [Column("trans_dividend_amount")]
        public string? TransDividendAmount { get; set; }

        [Column("have_changes")]
        public string? HaveChanges { get; set; }

        [Column("no_of_events")]
        public string? NoOfEvents { get; set; }

        [Column("conserve_energy")]
        public string? ConserveEnergy { get; set; }

        [Column("tech_absortion")]
        public string? TechAbsortion { get; set; }

        [Column("tech_absortion_step3")]
        public string? TechAbsortionStep3 { get; set; }

        [Column("foreign_exchange")]
        public string? ForeignExchange { get; set; }

        [Column("foreign_exchange_income")]
        public string? ForeignExchangeIncome { get; set; }

        [Column("foreign_exchange_income_pre")]
        public string? ForeignExchangeIncomePre { get; set; }

        [Column("foreign_exchange_import")]
        public string? ForeignExchangeImport { get; set; }

        [Column("foreign_exchange_import_pre")]
        public string? ForeignExchangeImportPre { get; set; }

        [Column("foreign_exchange_pnterest")]
        public string? ForeignExchangePnterest { get; set; }

        [Column("foreign_exchange_interest_pre")]
        public string? ForeignExchangeInterestPre { get; set; }

        [Column("foreign_exchange_travel")]
        public string? ForeignExchangeTravel { get; set; }

        [Column("foreign_exchange_travel_pre")]
        public string? ForeignExchangeTravelPre { get; set; }

        [Column("foreign_exchange_other")]
        public string? ForeignExchangeOther { get; set; }

        [Column("foreign_exchange_other_pre")]
        public string? ForeignExchangeOtherPre { get; set; }

        [Column("directors_kmp")]
        public string? DirectorsKmp { get; set; }

        [Column("director_and_kmp_name")]
        public string? DirectorAndKmpName { get; set; }

        [Column("designation")]
        public string? Designation { get; set; }

        [Column("select_type_of_change")]
        public string? SelectTypeOfChange { get; set; }

        [Column("date_appointment_cessation")]
        public DateTime? DateAppointmentCessation { get; set; }

        [Column("no_of_directors_kmp_rotation")]
        public int? NoOfDirectorsKmpRotation { get; set; }

        [Column("deposits")]
        public string? Deposits { get; set; }

        [Column("deposits_accept")]
        public string? DepositsAccept { get; set; }

        [Column("tab_deposits")]
        public string? TabDeposits { get; set; }

        [Column("deposit_accept")]
        public string? DepositAccept { get; set; }

        [Column("deposit_unpaid")]
        public string? DepositUnpaid { get; set; }

        [Column("whether_default")]
        public string? WhetherDefault { get; set; }

        [Column("no_such_cases")]
        public string? NoSuchCases { get; set; }

        [Column("tamount_begining")]
        public string? TamountBegining { get; set; }

        [Column("tmaount_during")]
        public string? TmaountDuring { get; set; }

        [Column("tamount_end")]
        public string? TamountEnd { get; set; }

        [Column("details_deposits")]
        public string? DetailsDeposits { get; set; }

        [Column("disclouser_related")]
        public string? DisclouserRelated { get; set; }

        [Column("no_of_persons")]
        public string? NoOfPersons { get; set; }

        [Column("board_evalution")]
        public string? BoardEvalution { get; set; }

        [Column("info_about_subsidiary")]
        public string? InfoAboutSubsidiary { get; set; }

        [Column("commen_ceoperations_subs")]
        public string? CommenCeoperationsSubs { get; set; }

        [Column("liquidated_subs")]
        public string? LiquidatedSubs { get; set; }

        [Column("commen_ceoperations_jv")]
        public string? CommenCeoperationsJv { get; set; }

        [Column("liquidated_jv")]
        public string? LiquidatedJv { get; set; }

        [Column("regulator_order")]
        public string? RegulatorOrder { get; set; }

        [Column("tab_regulator_order")]
        public string? TabRegulatorOrder { get; set; }

        [Column("have_vigil")]
        public string? HaveVigil { get; set; }

        [Column("have_fraud")]
        public string? HaveFraud { get; set; }

        [Column("have_adequacy")]
        public string? HaveAdequacy { get; set; }

        [Column("adequacy_text_area")]
        public string? AdequacyTextArea { get; set; }

        [Column("sexual_rating")]
        public string? SexualRating { get; set; }

        [Column("complaints_received")]
        public string? ComplaintsReceived { get; set; }

        [Column("complaints_disposed")]
        public string? ComplaintsDisposed { get; set; }

        [Column("complaints_pending")]
        public string? ComplaintsPending { get; set; }

        [Column("complaints_unsolved")]
        public string? ComplaintsUnsolved { get; set; }

        [Column("have_manaperson")]
        public string? HaveManaperson { get; set; }

        [Column("name_appoint")]
        public string? NameAppoint { get; set; }

        [Column("designation_app")]
        public string? DesignationApp { get; set; }

        [Column("remuneraion")]
        public string? Remuneraion { get; set; }

        [Column("credit_rating")]
        public string? CreditRating { get; set; }

        [Column("secretarial_standard")]
        public string? SecretarialStandard { get; set; }

        [Column("detail_secretarial_standard")]
        public string? DetailSecretarialStandard { get; set; }

        [Column("any_cirp")]
        public string? AnyCirp { get; set; }

        [Column("any_corporateaction")]
        public string? AnyCorporateaction { get; set; }

        [Column("any_topten")]
        public string? AnyTopten { get; set; }

        [Column("annexure")]
        public string? Annexure { get; set; }

        [Column("detail_any_topten")]
        public string? DetailAnyTopten { get; set; }

        [Column("dis_emp_name")]
        public string? DisEmpName { get; set; }

        [Column("dis_designation")]
        public string? DisDesignation { get; set; }

        [Column("dis_remuneration")]
        public string? DisRemuneration { get; set; }

        [Column("dis_nature")]
        public string? DisNature { get; set; }

        [Column("dis_qualification")]
        public string? DisQualification { get; set; }

        [Column("dis_date_commence")]
        public DateTime? DisDateCommence { get; set; }

        [Column("dis_age")]
        public string? DisAge { get; set; }

        [Column("dis_last_emp")]
        public string? DisLastEmp { get; set; }

        [Column("dis_percent_equity")]
        public string? DisPercentEquity { get; set; }

        [Column("dis_nature_name")]
        public string? DisNatureName { get; set; }

        [Column("any_diffvalution")]
        public string? AnyDiffvalution { get; set; }

        [Column("any_disclosure")]
        public string? AnyDisclosure { get; set; }

        [Column("place_boardreport")]
        public string? PlaceBoardreport { get; set; }

        [Column("meeting_date")]
        public DateTime? MeetingDate { get; set; }

        [Column("director_name1")]
        public string? DirectorName1 { get; set; }

        [Column("director_din1")]
        public string? DirectorDin1 { get; set; }

        [Column("director_desigation1")]
        public string? DirectorDesigation1 { get; set; }

        [Column("director_name2")]
        public string? DirectorName2 { get; set; }

        [Column("director_din2")]
        public string? DirectorDin2 { get; set; }

        [Column("director_desigation2")]
        public string? DirectorDesigation2 { get; set; }

        [Column("title")]
        public string? Title { get; set; }




    }

    [TableName("tbl_boardreport", "vw_boardreport")]
    public class BOARDREPORTView : BOARDREPORT
    {
        [Column("ref_user_name")]
        public string? RefUserName { get; set; }
    }

}