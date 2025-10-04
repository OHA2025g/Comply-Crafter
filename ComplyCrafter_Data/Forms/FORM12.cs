using AlphaUtil.Core.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ComplyCrafter_Data
{
    [TableName("tbl_form12", "vw_form12")]
    public class FORM12 : BaseModel
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

        [Column("jurisdiction_police_station")]
        public string? JurisdictionPoliceStation { get; set; }

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

        [Column("district")]
        public string? District { get; set; }

        [Column("latitude")]
        public string? Latitude { get; set; }

        [Column("state")]
        public string? State { get; set; }

        [Column("longitude")]
        public string? Longitude { get; set; }

        [Column("phone")]
        public string? Phone { get; set; }

        [Column("fax")]
        public string? Fax { get; set; }

        [Column("jurisdiction_police_station2")]
        public string? JurisdictionPoliceStation2 { get; set; }

        [Column("reason_change_address")]
        public string? ReasonChangeAddress { get; set; }

        [Column("clause_reference")]
        public string? ClauseReference { get; set; }

        [Column("relevant_extract")]
        public string? RelevantExtract { get; set; }

        [Column("consent_date")]
        public DateTime? ConsentDate { get; set; }

        [Column("verified_status")]
        public Boolean? VerifiedStatus { get; set; }

        [Column("authorised_status")]
        public Boolean? AuthorisedStatus { get; set; }

        [Column("partner_din")]
        public string? PartnerDin { get; set; }

        [Column("dpin")]
        public string? Dpin { get; set; }

        [Column("records_certified")]
        public string? RecordsCertified { get; set; }

        [Column("professional_practice")]
        public string? ProfessionalPractice { get; set; }

        [Column("name_of_pcs")]
        public string? NameOfPcs { get; set; }

        [Column("professional_type")]
        public string? ProfessionalType { get; set; }

        [Column("membership_number")]
        public int? MembershipNumber { get; set; }

        [Column("instrument_creating")]
        public string? InstrumentCreating { get; set; }

        [Column("affidavit")]
        public string? Affidavit { get; set; }

        [Column("charge_holder")]
        public string? ChargeHolder { get; set; }

        [Column("attachment_file")]
        public string? AttachmentFile { get; set; }



    }

    [TableName("tbl_form12", "vw_form12")]
    public class FORM12View : FORM12
    {
        [Column("ref_user_name")]
        public string? RefUserName { get; set; }
    }

}