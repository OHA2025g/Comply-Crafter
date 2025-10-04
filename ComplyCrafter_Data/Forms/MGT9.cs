using AlphaUtil.Core.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ComplyCrafter_Data
{
    [TableName("tbl_mgt9", "vw_mgt9")]
    public class MGT9 : BaseModel
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

        [Column("is_registrar_agent")]
        public string? IsRegistrarAgent { get; set; } = "no";

        [Column("registrar_agent_name")]
        public string? RegistrarAgentName { get; set; }

        [Column("registrar_agent_address")]
        public string? RegistrarAgentAddress { get; set; }

        [Column("registrar_agent_phone")]
        public string? RegistrarAgentPhone { get; set; }

        [Column("registrar_agent_email")]
        public string? RegistrarAgentEmail { get; set; }

        // II. PRINCIPAL BUSINESS ACTIVITIES
        [Column("no_of_business")]
        public decimal? NoOfBusiness { get; set; }

        // III. HOLDING, SUBSIDIARY AND ASSOCIATE COMPANIES
        [Column("no_of_holding")]
        public decimal? NoOfHolding { get; set; }

        // IV. INDEBTEDNESS - Beginning of Year
        [Column("secured_principal_beg")]
        public decimal? SecuredPrincipalBeg { get; set; }

        [Column("unsecured_principal_beg")]
        public decimal? UnsecuredPrincipalBeg { get; set; }

        [Column("deposit_principal_beg")]
        public decimal? DepositPrincipalBeg { get; set; }

        [Column("total_principal_beg")]
        public decimal? TotalPrincipalBeg { get; set; }

        [Column("secured_interest_due_beg")]
        public decimal? SecuredInterestDueBeg { get; set; }

        [Column("unsecured_interest_due_beg")]
        public decimal? UnsecuredInterestDeuBeg { get; set; }

        [Column("deposit_interest_due_beg")]
        public decimal? DepositInterestDeuBeg { get; set; }

        [Column("total_interest_due_beg")]
        public decimal? TotalInterestDeuBeg { get; set; }

        [Column("secured_interest_accrued_beg")]
        public decimal? SecuredInterestAccruedBeg { get; set; }

        [Column("unsecured_interest_accrued_beg")]
        public decimal? UnsecuredInterestAccruedBeg { get; set; }

        [Column("deposit_interest_accrued_beg")]
        public decimal? DepositInterestAccruedBeg { get; set; }

        [Column("total_interest_accrued_beg")]
        public decimal? TotalInterestAccruedBeg { get; set; }

        [Column("total_secured_beg")]
        public decimal? TotalSecuredBeg { get; set; }

        [Column("total_unsecured_beg")]
        public decimal? TotalUnsecuredBeg { get; set; }

        [Column("total_deposit_beg")]
        public decimal? TotalDepositBeg { get; set; }

        [Column("total_beg")]
        public decimal? TotalBeg { get; set; }

        // IV. INDEBTEDNESS - Changes During Year
        [Column("secured_addition_beg")]
        public decimal? SecuredAdditionBeg { get; set; }

        [Column("unsecured_addition_beg")]
        public decimal? UnsecuredAdditionBeg { get; set; }

        [Column("deposit_addition_beg")]
        public decimal? DepositAdditionBeg { get; set; }

        [Column("total_addition_beg")]
        public decimal? TotalAdditionBeg { get; set; }

        [Column("secured_reduction_beg")]
        public decimal? SecuredReductionBeg { get; set; }

        [Column("unsecured_reduction_beg")]
        public decimal? UnsecuredReductionBeg { get; set; }

        [Column("deposit_reduction_beg")]
        public decimal? DepositReductionBeg { get; set; }

        [Column("total_reduction_beg")]
        public decimal? TotalReductionBeg { get; set; }

        [Column("secured_net_change")]
        public decimal? SecuredNetChange { get; set; }

        [Column("unsecured_net_change")]
        public decimal? UnsecuredNetChange { get; set; }

        [Column("deposit_net_change")]
        public decimal? DepositNetChange { get; set; }

        [Column("total_net_change")]
        public decimal? TotalNetChange { get; set; }

        // IV. INDEBTEDNESS - End of Year
        [Column("secured_principal_end")]
        public decimal? SecuredPrincipalEnd { get; set; }

        [Column("unsecured_principal_end")]
        public decimal? UnsecuredPrincipalEnd { get; set; }

        [Column("deposit_principal_end")]
        public decimal? DepositPrincipalEnd { get; set; }

        [Column("total_principal_end")]
        public decimal? TotalPrincipalEnd { get; set; }

        [Column("secured_interest_due_end")]
        public decimal? SecuredInterestDueEnd { get; set; }

        [Column("unsecured_interest_due_end")]
        public decimal? UnsecuredInterestDueEnd { get; set; }

        [Column("deposit_interest_due_end")]
        public decimal? DepositInterestDueEnd { get; set; }

        [Column("total_interest_due_end")]
        public decimal? TotalInterestDueEnd { get; set; }

        [Column("secured_interest_accrued_end")]
        public decimal? SecuredInterestAccruedEnd { get; set; }

        [Column("unsecured_interest_accrued_end")]
        public decimal? UnsecuredInterestAccruedEnd { get; set; }

        [Column("deposit_interest_accrued_end")]
        public decimal? DepositInterestAccruedEnd { get; set; }

        [Column("total_interest_accrued_end")]
        public decimal? TotalInterestAccruedEnd { get; set; }

        [Column("total_secured_end")]
        public decimal? TotalSecuredEnd { get; set; }

        [Column("total_unsecured_end")]
        public decimal? TotalUnsecuredEnd { get; set; }

        [Column("total_deposit_end")]
        public decimal? TotalDepositEnd { get; set; }

        [Column("total_end")]
        public decimal? TotalEnd { get; set; }

        // V. REMUNERATION OF DIRECTORS AND KEY MANAGERIAL PERSONNEL
        [Column("is_remuneration")]
        public string? IsRemuneration { get; set; }

        [Column("no_of_persons")]
        public decimal? NoOfPersons { get; set; }

        [Column("is_remuneration_other")]
        public string? IsRemunerationOther { get; set; }

        [Column("no_of_independent_directors")]
        public decimal? NoOfIndependentDirectors { get; set; }

        [Column("no_of_non_executive_directors")]
        public decimal? NoOfNonExecutiveDirectors { get; set; }

        [Column("over_all_ceiling")]
        public string? OverAllCeiling { get; set; }

        // C. Remuneration to KMP other than MD/ WTD/Manager
        [Column("is_remuneration_other_kmp")]
        public string? IsRemunerationOtherKmp { get; set; } = "Not Applicable";

        // CEO Details
        [Column("ceo_name")]
        public string? CeoName { get; set; }

        [Column("ceo_salary")]
        public decimal? CeoSalary { get; set; }

        [Column("ceo_stock")]
        public decimal? CeoStock { get; set; }

        [Column("ceo_value")]
        public decimal? CeoValue { get; set; }

        [Column("ceo_sweat")]
        public decimal? CeoSweat { get; set; }

        [Column("ceo_profit")]
        public decimal? CeoProfit { get; set; }

        [Column("ceo_commisionper")]
        public decimal? CeoCommisionPer { get; set; }

        [Column("ceo_gross")]
        public decimal? CeoGross { get; set; }

        [Column("ceo_commision_other")]
        public decimal? CeoCommisionOther { get; set; }

        [Column("ceo_other_amount")]
        public decimal? CeoOtherAmount { get; set; }

        // Company Secretary Details
        [Column("sec_name")]
        public string? SecName { get; set; }

        [Column("sec_salary")]
        public decimal? SecSalary { get; set; }

        [Column("sec_stock")]
        public decimal? SecStock { get; set; }

        [Column("sec_value")]
        public decimal? SecValue { get; set; }

        [Column("sec_sweat")]
        public decimal? SecSweat { get; set; }

        [Column("sec_profit")]
        public decimal? SecProfit { get; set; }

        [Column("sec_commisionper")]
        public decimal? SecCommisionPer { get; set; }

        [Column("sec_gross")]
        public decimal? SecGross { get; set; }

        [Column("sec_commision_other")]
        public decimal? SecCommisionOther { get; set; }

        [Column("sec_other_amount")]
        public decimal? SecOtherAmount { get; set; }

        // CFO Details
        [Column("cfo_name")]
        public string? CfoName { get; set; }

        [Column("cfo_salary")]
        public decimal? CfoSalary { get; set; }

        [Column("cfo_stock")]
        public decimal? CfoStock { get; set; }

        [Column("cfo_value")]
        public decimal? CfoValue { get; set; }

        [Column("cfo_sweat")]
        public decimal? CfoSweat { get; set; }

        [Column("cfo_profit")]
        public decimal? CfoProfit { get; set; }

        [Column("cfo_commisionper")]
        public decimal? CfoCommisionPer { get; set; }

        [Column("cfo_gross")]
        public decimal? CfoGross { get; set; }

        [Column("cfo_commisionother")]
        public decimal? CfoCommisionOther { get; set; }

        [Column("cfo_otheramount")]
        public decimal? CfoOtherAmount { get; set; }

        // VI. PENALTIES / PUNISHMENT/ COMPOUNDING OF OFFENCES
        [Column("is_penalties")]
        public string? IsPenalties { get; set; } = "Not Applicable";

        // A. COMPANY
        [Column("company_section_penalty")]
        public string? CompanySectionPenalty { get; set; }

        [Column("company_descriptioin_penalty")]
        public string? CompanyDescriptioinPenalty { get; set; }

        [Column("company_fees_penalty")]
        public decimal? CompanyFeesPenalty { get; set; }

        [Column("company_imposed_penalty")]
        public string? CompanyImposedPenalty { get; set; }

        [Column("company_detail_penalty")]
        public string? CompanyDetailPenalty { get; set; }

        [Column("company_section_punishment")]
        public string? CompanySectionPunishment { get; set; }

        [Column("company_descriptioin_punishment")]
        public string? CompanyDescriptioinPunishment { get; set; }

        [Column("company_fees_punishment")]
        public decimal? CompanyFeesPunishment { get; set; }

        [Column("company_imposed_punishment")]
        public string? CompanyImposedPunishment { get; set; }

        [Column("company_detail_punishment")]
        public string? CompanyDetailPunishment { get; set; }

        [Column("company_section_compounding")]
        public string? CompanySectionCompounding { get; set; }

        [Column("company_descriptioin_compounding")]
        public string? CompanyDescriptioinCompounding { get; set; }

        [Column("company_fees_compounding")]
        public decimal? CompanyFeesCompounding { get; set; }

        [Column("company_imposed_compounding")]
        public string? CompanyImposedCompounding { get; set; }

        [Column("company_detail_compounding")]
        public string? CompanyDetailCompounding { get; set; }

        // B. DIRECTORS
        [Column("director_section_penalty")]
        public string? DirectorSectionPenalty { get; set; }

        [Column("director_descriptioin_penalty")]
        public string? DirectorDescriptioinPenalty { get; set; }

        [Column("director_fees_penalty")]
        public decimal? DirectorFeesPenalty { get; set; }

        [Column("director_imposed_penalty")]
        public string? DirectorImposedPenalty { get; set; }

        [Column("director_detail_penalty")]
        public string? DirectorDetailPenalty { get; set; }

        [Column("director_section_punishment")]
        public string? DirectorSectionPunishment { get; set; }

        [Column("director_descriptioin_punishment")]
        public string? DirectorDescriptioinPunishment { get; set; }

        [Column("director_fees_punishment")]
        public decimal? DirectorFeesPunishment { get; set; }

        [Column("director_imposed_punishment")]
        public string? DirectorImposedPunishment { get; set; }

        [Column("director_detail_punishment")]
        public string? DirectorDetailPunishment { get; set; }

        [Column("director_section_compounding")]
        public string? DirectorSectionCompounding { get; set; }

        [Column("director_descriptioin_compounding")]
        public string? DirectorDescriptioinCompounding { get; set; }

        [Column("director_fees_compounding")]
        public decimal? DirectorFeesCompounding { get; set; }

        [Column("director_imposed_compounding")]
        public string? DirectorImposedCompounding { get; set; }

        [Column("director_detail_compounding")]
        public string? DirectorDetailCompounding { get; set; }

        // C. OTHER OFFICERS IN DEFAULT
        [Column("officer_section_penalty")]
        public string? OfficerSectionPenalty { get; set; }

        [Column("officer_descriptioin_penalty")]
        public string? OfficerDescriptioinPenalty { get; set; }

        [Column("officer_fees_penalty")]
        public decimal? OfficerFeesPenalty { get; set; }

        [Column("officer_imposed_penalty")]
        public string? OfficerImposedPenalty { get; set; }

        [Column("officer_detail_penalty")]
        public string? OfficerDetailPenalty { get; set; }

        [Column("officer_section_punishment")]
        public string? OfficerSectionPunishment { get; set; }

        [Column("officer_descriptioin_punishment")]
        public string? OfficerDescriptioinPunishment { get; set; }

        [Column("officer_dees_punishment")]
        public decimal? OfficerDeesPunishment { get; set; }

        [Column("officer_dmposed_punishment")]
        public string? OfficerDmposedPunishment { get; set; }

        [Column("officer_detail_punishment")]
        public string? OfficerDetailPunishment { get; set; }

        [Column("officer_section_compounding")]
        public string? OfficerSectionCompounding { get; set; }

        [Column("officer_descriptioin_compounding")]
        public string? OfficerDescriptioinCompounding { get; set; }

        [Column("officer_fees_compounding")]
        public decimal? OfficerFeesCompounding { get; set; }

        [Column("officer_imposed_compounding")]
        public string? OfficerImposedCompounding { get; set; }

        [Column("officer_detail_compounding")]
        public string? OfficerDetailCompounding { get; set; }
    }

    [TableName("tbl_mgt9", "vw_mgt9")]
    public class MGT9View : MGT9
    {
        [Column("ref_user_name")]
        public string? RefUserName { get; set; }
    }

}