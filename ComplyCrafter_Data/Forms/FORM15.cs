using AlphaUtil.Core.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ComplyCrafter_Data
{
    [TableName("tbl_form15", "vw_form15")]
    public class FORM15 : BaseModel
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



        [Column("llp_name")]
        public string? LlpName { get; set; }

        [Column("jurisdiction_of_police_station")]
        public string? JurisdictionOfPoliceStation { get; set; }

        [Column("purpose")]
        public string? Purpose { get; set; }

        [Column("address_line1")]
        public string? AddressLine1 { get; set; }

        [Column("address_line2")]
        public string? AddressLine2 { get; set; }

        [Column("country")]
        public string? Country { get; set; }

        [Column("pin_code")]
        public string? PinCode { get; set; }

        [Column("area_locality")]
        public string? AreaLocality { get; set; }

        [Column("city")]
        public string? City { get; set; }

        [Column("latitude")]
        public string? Latitude { get; set; }

        [Column("state")]
        public string? State { get; set; }

        [Column("district")]
        public string? District { get; set; }

        [Column("longitude")]
        public string? Longitude { get; set; }

        [Column("new_jurisdiction_of_police_station")]
        public string? NewJurisdictionOfPoliceStation { get; set; }

        [Column("prosecution_pending")]
        public string? ProsecutionPending { get; set; }

        [Column("case_number")]
        public int CaseNumber { get; set; }

        [Column("section_prosecution_pending")]
        public string? SectionProsecutionPending { get; set; }

        [Column("act_name_prosecution_pending")]
        public string? ActNameProsecutionPending { get; set; }

        [Column("stage_prosecution_pending")]
        public string? StageProsecutionPending { get; set; }

        [Column("court_name_prosecution_pending")]
        public string? CourtNameProsecutionPending { get; set; }

        [Column("case_details")]
        public string? CaseDetails { get; set; }

        [Column("application_pending")]
        public string? ApplicationPending { get; set; }

        [Column("brief_details")]
        public string? BriefDetails { get; set; }

        [Column("date_publication_in_english")]
        public DateTime? DatePublicationInEnglish { get; set; }

        [Column("date_publication_in_vernacular")]
        public DateTime? DatePublicationInVernacular { get; set; }

        [Column("newspaper_name_publication_in_english")]
        public string? NewspaperNamePublicationInEnglish { get; set; }

        [Column("newspaper_name_publication_in_vernaular")]
        public string? NewspaperNamePublicationInVernacular { get; set; }

        [Column("brief_details_objection_received")]
        public string? BriefDetailsObjectionReceived { get; set; }

        [Column("change_in_address")]
        public string? ChangeInAddress { get; set; }

        [Column("date_of_consent_partners")]
        public DateTime? DateOfConsentPartners { get; set; }

        [Column("clause_reference_llp_agreement")]
        public string? ClauseReferenceLlpAgreement { get; set; }

        [Column("partner_din")]
        public string? partnerDin { get; set; }

        [Column("relevant_extract_llp_agreement")]
        public string? RelevantExtractLlpAgreement { get; set; }

        [Column("consent_of_secured_creditors")]
        public string? ConsentOfSecuredCreditors { get; set; }

        [Column("date_of_consent_taken_of_creditors")]
        public DateTime? DateOfConsentTakenOfCreditors { get; set; }

        [Column("verification_check_box1")]
        public Boolean? VerificationCheckBox1 { get; set; }

        [Column("verification_check_box2")]
        public Boolean? VerificationCheckBox2 { get; set; }

        [Column("verification_check_box3")]
        public Boolean? VerificationCheckBox3 { get; set; }

        [Column("d_pin")]
        public string? DPin { get; set; }

        [Column("particulars_record")]
        public string? ParticularsRecord { get; set; }

        [Column("to_be_digitally_signed_by_member")]
        public string? ToBeDigitallySignedByMember { get; set; }

        [Column("name_of_pcs")]
        public string? NameOfPcs { get; set; }

        [Column("whether_associate")]
        public string? WhetherAssociate { get; set; }

        [Column("membership_number")]
        public string? MembershipNumber { get; set; }

        [Column("instrument_creating")]
        public string? InstrumentCreating { get; set; }

        [Column("affidavit")]
        public string? Affidavit { get; set; }

        [Column("charge_holder")]
        public string? ChargeHolder { get; set; }

        [Column("attachment_file")]
        public string? AttachmentFile { get; set; }





    }

    [TableName("tbl_form15", "vw_form15")]
    public class FORM15View : FORM15
    {
        [Column("ref_user_name")]
        public string? RefUserName { get; set; }
    }

}