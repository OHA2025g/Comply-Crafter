using AlphaUtil.Core.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ComplyCrafter_Data
{
    [TableName("tbl_form23", "vw_form23")]
    public class FORM23 : BaseModel
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

        [Column("catagory")]
        public string? Catagory { get; set; }

        [Column("line2")]
        public string? Line2 { get; set; }

        [Column("country")]
        public string? Country { get; set; }

        [Column("pin_code")]
        public string? PinCode { get; set; }

        [Column("area")]
        public string? Area { get; set; }

        [Column("city")]
        public string? City { get; set; }

        [Column("district")]
        public string? District { get; set; }

        [Column("state")]
        public string? State { get; set; }

        [Column("jurisdiction_police_station")]
        public string? JurisdictionPoliceStation { get; set; }

        [Column("phone_no")]
        public string? PhoneNo { get; set; }

        [Column("mobile_no")]
        public string? MobileNo { get; set; }

        [Column("llpin")]
        public string? Llpin { get; set; }

        [Column("name_llp")]
        public string? NameLlp { get; set; }

        [Column("email_id1")]
        public string? EmailId1 { get; set; }

        [Column("registered_llp")]
        public string? RegisteredLlp { get; set; }

        [Column("grounds_of_objection")]
        public string? GroundsOfObjection { get; set; }

        [Column("self_declaration")]
        public Boolean? SelfDeclaration { get; set; }

        [Column("provision_declaration")]
        public Boolean? ProvisionDeclaration { get; set; }

        [Column("authorized_declaration")]
        public Boolean? AuthorizedDeclaration { get; set; }

        [Column("designation")]
        public string? Designation { get; set; }

        [Column("designation_name")]
        public string? DesignationName { get; set; }

        [Column("dpin_number")]
        public string? DpinNumber { get; set; }

        [Column("authority")]
        public string? Authority { get; set; }

        [Column("attachment_file")]
        public string? AttachmentFile { get; set; }
    }

    [TableName("tbl_form23", "vw_form23")]
    public class FORM23View : FORM23
    {
        [Column("ref_user_name")]
        public string? RefUserName { get; set; }
    }

}