using AlphaUtil.Core.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ComplyCrafter_Data
{
    [TableName("tbl_form5", "vw_form5")]
    public class FORM5 : BaseModel
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

        [Column("number_partnership")]
        public string? NumberPartnership { get; set; }

        [Column("llp_name")]
        public string? LlpName { get; set; }

        [Column("srn_run")]
        public string? SrnRun { get; set; }

        [Column("llp_new_name")]
        public string? LlpNewName { get; set; }

        [Column("police_station_jurisdiction")]
        public string? PoliceStationJurisdiction { get; set; }

        [Column("change_name_declaration")]
        public string? ChangeNameDeclaration { get; set; }

        [Column("srn_of_3")]
        public string? SrnOf3 { get; set; }

        [Column("name_change_1")]
        public Boolean? NameChange1 { get; set; }

        [Column("name_change_2")]
        public Boolean? NameChange2 { get; set; }

        [Column("name_change_3")]
        public Boolean? NameChange3 { get; set; }

        [Column("name_change_4")]
        public Boolean? NameChange4 { get; set; }

        [Column("number_clause")]
        public string? NumberClause { get; set; }

        [Column("extract_relevant")]
        public string? ExtractRelevant { get; set; }

        [Column("date_of_consent")]
        public string? DateOfConsent { get; set; }

        [Column("statements_1")]
        public Boolean? Statements1 { get; set; }

        [Column("statements_2")]
        public Boolean? Statements2 { get; set; }

        [Column("designation")]
        public string? Designation { get; set; }

        [Column("designated_partners")]
        public string? DesignatedPartners { get; set; }

        [Column("professional_practice")]
        public string? ProfessionalPractice { get; set; }

        [Column("name_of_pcs")]
        public string? NameOfPcs { get; set; }

        [Column("professional_type")]
        public string? ProfessionalType { get; set; }

        [Column("practice_number")]
        public string? PracticeNumber { get; set; }

        [Column("consent_partners")]
        public string? ConsentPartners { get; set; }

        [Column("minutes")]
        public string? Minutes { get; set; }

        [Column("central")]
        public string? Central { get; set; }

        [Column("registrar")]
        public string? Registrar { get; set; }

        [Column("attachment_add")]
        public string? AttachmentAdd { get; set; }

        [Column("attachment_file")]
        public string? AttachmentFile { get; set; }

        [Column("company_address_llp")]
        public string? CompanyAddressLlp { get; set; }


    }

    [TableName("tbl_form5", "vw_form5")]
    public class FORM5View : FORM5
    {
        [Column("ref_user_name")]
        public string? RefUserName { get; set; }
    }

}