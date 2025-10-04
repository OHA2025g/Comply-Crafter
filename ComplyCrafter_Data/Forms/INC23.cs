using AlphaUtil.Core.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ComplyCrafter_Data
{
    [TableName("tbl_inc23", "vw_inc23")]
    public class INC23 : BaseModel
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

        [Column("fillig_purpose")]
        public string? FilligPurpose { get; set; }

        [Column("filed_mgt14")]
        public string? FiledMgt14 { get; set; }

        [Column("request_number")]
        public string? RequestNumber { get; set; }

        [Column("state")]
        public string? State { get; set; }

        [Column("office_roc")]
        public string? OfficeRoc { get; set; }

        [Column("reason_shifting_office")]
        public string? ReasonShiftingOffice { get; set; }

        [Column("is_objections")]
        public string? IsObjections { get; set; }

        [Column("english_advertisement_date")]
        public DateTime? EnglishAdvertisementDate { get; set; }

        [Column("vernacular_advertisement_date")]
        public DateTime? VernacularAdvertisementDate { get; set; }

        [Column("brief_objection")]
        public string? BriefObjection { get; set; }

        [Column("prosecution")]
        public string? Prosecution { get; set; }

        [Column("prosecution_details")]
        public string? ProsecutionDetails { get; set; }

        [Column("inquiry")]
        public Boolean? Inquiry { get; set; }

        [Column("inspection")]
        public Boolean? Inspection { get; set; }

        [Column("investigation")]
        public Boolean? Investigation { get; set; }

        [Column("inspection_details")]
        public string? InspectionDetails { get; set; }

        [Column("application_copy")]
        public string? ApplicationCopy { get; set; }

        [Column("service_acknowledgement_date")]
        public DateTime? ServiceAcknowledgementDate { get; set; }

        [Column("pending_application")]
        public string? PendingApplication { get; set; }

        [Column("pending_application_details")]
        public string? PendingApplicationDetails { get; set; }

        [Column("attorney")]
        public string? Attorney { get; set; }

        [Column("newspaper_adv")]
        public string? NewspaperAdv { get; set; }

        [Column("authority_proof")]
        public string? AuthorityProof { get; set; }

        [Column("resolution_number")]
        public string? ResolutionNumber { get; set; }

        [Column("resolution_date")]
        public string? ResolutionDate { get; set; }

        [Column("attachment_declaration")]
        public Boolean? AttachmentDeclaration { get; set; }

        [Column("attachment_declaration2")]
        public Boolean? AttachmentDeclaration2 { get; set; }

        [Column("authority_declaration")]
        public Boolean? AuthorityDeclaration { get; set; }

        [Column("payment_declaration")]
        public Boolean? PaymentDeclaration { get; set; }

        [Column("jurisdiction_declaration")]
        public Boolean? JurisdictionDeclaration { get; set; }

        [Column("shifting_declaration")]
        public Boolean? ShiftingDeclaration { get; set; }

        [Column("enquiry_declaration")]
        public Boolean? EnquiryDeclaration { get; set; }

        [Column("declaration_designation")]
        public string? DeclarationDesignation { get; set; }

        [Column("signatory")]
        public string? Signatory { get; set; }

        [Column("din")]
        public string? Din { get; set; }

    }

    [TableName("tbl_inc23", "vw_inc23")]
    public class INC23View : INC23
    {
        [Column("ref_user_name")]
        public string? RefUserName { get; set; }
    }

}