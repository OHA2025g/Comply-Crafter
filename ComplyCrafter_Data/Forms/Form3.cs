using AlphaUtil.Core.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ComplyCrafter_Data
{
    [TableName("tbl_Form3", "vw_Form3")]
    public class FORM3 : BaseModel
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


        [Column("form_filled_for")]
        public string? FormFilledFor { get; set; }

        [Column("llp_in")]
        public int? LlpIn { get; set; }

        [Column("llp_name")]
        public string? LlpName { get; set; }

        [Column("jurisdiction_police_station")]
        public string? JurisdictionPoliceStation { get; set; }

        [Column("liability_state3")]
        public string? LiabilityState3 { get; set; }

        [Column("business_activities")]
        public string? BusinessActivities { get; set; }

        [Column("total_partners_as_on_date_of_filing")]
        public string? TotalPartnersAsOnDateOfFiling { get; set; }

        [Column("initial_llp_attach")]
        public string? InitialLlpAttach { get; set; }

        //[Column("designated_data")]
        //public string? DesignatedData { get; set; }

        [Column("total_monetary_value_partner_contribution_llp")]
        public string? TotalMonetaryValuePartnerContributionLlp { get; set; }

        [Column("new_mutual_rights")]
        public string? NewMutualRights { get; set; }

        [Column("new_restrictions")]
        public string? NewRestrictions { get; set; }

        [Column("new_acts_matters_things")]
        public string? NewActsMattersThings { get; set; }

        [Column("new_meeting_procedure")]
        public string? NewMeetingProcedure { get; set; }

        [Column("new_indemnity_clause")]
        public string? NewIndemnityClause { get; set; }

        [Column("new_partner_admission")]
        public string? NewPartnerAdmission { get; set; }

        [Column("new_partner_retirement")]
        public string? NewPartnerRetirement { get; set; }

        [Column("new_partner_cessation")]
        public string? NewPartnerCessation { get; set; }

        [Column("new_partner_expulsion")]
        public string? NewPartnerExpulsion { get; set; }

        [Column("new_partner_resignation")]
        public string? NewPartnerResignation { get; set; }

        [Column("new_disputes_partner")]
        public string? NewDisputesPartner { get; set; }

        [Column("new_disputes_between_partner_llp")]
        public string? NewDisputesBetweenPartnerLlp { get; set; }

        [Column("new_llp_duration")]
        public string? NewLlpDuration { get; set; }

        [Column("new_voluntary_winding_up")]
        public string? NewVoluntaryWindingUp { get; set; }

        [Column("new_rule16")]
        public string? NewRule16 { get; set; }

        [Column("new_rule17")]
        public string? NewRule17 { get; set; }

        [Column("new_rule120")]
        public string? NewRule120 { get; set; }

        [Column("new_rule24")]
        public string? NewRule24 { get; set; }

        [Column("new_other_information_clause")]
        public string? NewOtherInformationClause { get; set; }

        [Column("date_of_modification16")]
        public DateTime? DateOfModification16 { get; set; }

        [Column("number_of_changes")]
        public int? NumberOfChanges { get; set; }

        [Column("delete_row")]
        public Boolean? DeleteRow { get; set; }

        [Column("srn_number")]
        public string? SrnNumber { get; set; }

        [Column("change_in_business_activities_flag")]
        public Boolean? ChangeInBusinessActivitiesFlag { get; set; }

        [Column("change_in_partner_flag")]
        public Boolean? ChangeInPartnerFlag { get; set; }

        [Column("changes_in_partners_profit_sharing_flag")]
        public Boolean? ChangesInPartnersProfitSharingFlag { get; set; }

        [Column("changes_due_to_other_reason_flag")]
        public Boolean? ChangesDueToOtherReasonFlag { get; set; }

        [Column("other_reason_mutual_rights_flag")]
        public Boolean? OtherReasonMutualRightsFlag { get; set; }

        //[Column("count_check")]
        //public string? CountCheck { get; set; }

        [Column("search_code")]
        public string? SearchCode { get; set; }

        [Column("nic_code_serial")]
        public string? NicCodeSerial { get; set; }

        [Column("nic_code1")]
        public string? NicCode1 { get; set; }

        [Column("nic_code1_desc")]
        public string? NicCode1Desc { get; set; }

        [Column("remove")]
        public string? Remove { get; set; }

        [Column("nic_code2_desc")]
        public string? NicCode2Desc { get; set; }

        [Column("nic_code3")]
        public string? NicCode3 { get; set; }

        [Column("nic_code3_desc")]
        public string? NicCode3Desc { get; set; }

        [Column("nic_codes")]
        public string? NicCodes { get; set; }

        [Column("nic_codes_desc")]
        public string? NicCodesDesc { get; set; }

        [Column("des_business_activity18f")]
        public string? DesBusinessActivity18F { get; set; }

        [Column("change_business_activity18g")]
        public string? ChangeBusinessActivity18G { get; set; }

        [Column("changes_in_llp_attach")]
        public string? ChangesInLlpAttach { get; set; }

        //[Column("linked_form_name")]
        //public string? LinkedFormName { get; set; }

        [Column("table2_excel_data")]
        public string? Table2ExcelData { get; set; }

        //[Column("total_profit1")]
        //public string? TotalProfit1 { get; set; }

        [Column("total_existing_partner19b")]
        public int? TotalExistingPartner19B { get; set; }

        [Column("total_partner_appointed19b")]
        public string? TotalPartnerAppointed19B { get; set; }

        [Column("total_partners_removed19b")]
        public string? TotalPartnersRemoved19B { get; set; }

        [Column("total_partners_changed19b")]
        public string? TotalPartnersChanged19B { get; set; }

        [Column("existing19c")]
        public int? Existing19C { get; set; }

        [Column("addition19c")]
        public int? Addition19C { get; set; }

        [Column("reduction19c")]
        public int? Reduction19C { get; set; }

        [Column("total_sum19c")]
        public string? TotalSum19C { get; set; }

        [Column("total_in_words")]
        public string? TotalInWords { get; set; }

        [Column("chg_mutual_rights")]
        public string? ChgMutualRights { get; set; }

        [Column("chg_restrictions")]
        public string? ChgRestrictions { get; set; }

        [Column("chg_acts_matters_things")]
        public string? ChgActsMattersThings { get; set; }

        [Column("chg_meeting_procedure")]
        public string? ChgMeetingProcedure { get; set; }

        [Column("chg_indemnity_clause")]
        public string? ChgIndemnityClause { get; set; }

        [Column("chg_partner_admission")]
        public string? ChgPartnerAdmission { get; set; }

        [Column("chg_partner_retirement")]
        public string? ChgPartnerRetirement { get; set; }

        [Column("chg_partner_cessation")]
        public string? ChgPartnerCessation { get; set; }

        [Column("chg_partner_expulsion")]
        public string? ChgPartnerExpulsion { get; set; }

        [Column("chg_partner_resignation")]
        public string? ChgPartnerResignation { get; set; }

        [Column("chg_disputes_partner")]
        public string? ChgDisputesPartner { get; set; }

        [Column("chg_disputes_between_partner_llp")]
        public string? ChgDisputesBetweenPartnerLlp { get; set; }

        [Column("chg_llp_duration")]
        public string? ChgLlpDuration { get; set; }

        [Column("chg_voluntary_winding_up")]
        public string? ChgVoluntaryWindingUp { get; set; }

        [Column("chg_rule16")]
        public string? ChgRule16 { get; set; }

        [Column("chg_rule17")]
        public string? ChgRule17 { get; set; }

        [Column("chg_rule20")]
        public string? ChgRule20 { get; set; }

        [Column("chg_rule24")]
        public string? ChgRule24 { get; set; }

        [Column("chg_other_information_clause")]
        public string? ChgOtherInformationClause { get; set; }

        [Column("nic_code_serial_2")]
        public string? NicCodeSerial2 { get; set; }


        //part-2
        [Column("initial_llp")]
        public string? InitialLlp { get; set; }

        [Column("changes_llp")]
        public string? ChangesLlp { get; set; }

             [Column("attachment_file")]
        public string? AttachmentFile { get; set; }

        [Column("designated_partner")]
        public string? DesignatedPartner { get; set; }

        [Column("designated_partner_id")]
        public string? DesignatedPartnerId { get; set; }

        [Column("professional_practice")]
        public string? ProfessionalPractice { get; set; }

        [Column("name_of_pcs")]
        public string? NameOfPcs { get; set; }

        [Column("professional_type")]
        public string? ProfessionalType { get; set; }

        [Column("membership_number")]
        public string? MembershipNumber { get; set; }

        [Column("certificate_number")]
        public string? CertificateNumber { get; set; }



    }

    [TableName("tbl_Form3", "vw_Form3")]
    public class FORM3View : FORM3
    {
        [Column("ref_user_name")]
        public string? RefUserName { get; set; }
    }

}