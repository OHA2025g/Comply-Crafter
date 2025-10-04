using AlphaUtil.Core.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ComplyCrafter_Data
{
    [TableName("tbl_gnl1", "vw_gnl1")]
    public class GNL1 : BaseModel
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

        [Column("applicant_category")]
        public string? ApplicantCategory { get; set; }

        [Column("corporate_gln")]
        public string? CorporateGln { get; set; }

        [Column("name")]
        public string? Name { get; set; }

        [Column("address_line1")]
        public string? AddressLine1 { get; set; }

        [Column("address_line2")]
        public string? AddressLine2 { get; set; }

        [Column("city")]
        public string? City { get; set; }

        [Column("state")]
        public string? State { get; set; }

        [Column("iso_code")]
        public string? IsoCode { get; set; }

        [Column("country")]
        public string? Country { get; set; }

        [Column("pin_code")]
        public int? PinCode { get; set; }

        [Column("email")]
        public string? Email { get; set; }

        [Column("filed_for")]
        public string? FiledFor { get; set; }

        [Column("others")]
        public string? Others { get; set; }

        [Column("application_details")]
        public string? ApplicationDetails { get; set; }


        // Part 2 fields
        [Column("filed_company")]
        public Boolean? FiledCompany { get; set; }

        [Column("filed_director")]
        public Boolean? FiledDirector { get; set; }

        [Column("filed_manager")]
        public Boolean? FiledManager { get; set; }

        [Column("filed_other")]
        public Boolean? FiledOther { get; set; }

        [Column("persons_filed")]
        public int? PersonsFiled { get; set; }

        [Column("application_filed")]
        public string? ApplicationFiled { get; set; }

        [Column("notice_number")]
        public decimal? NoticeNumber { get; set; }

        [Column("section_filed")]
        public string? SectionFiled { get; set; }

        [Column("particulars_brief")]
        public string? ParticularsBrief { get; set; }

        [Column("agm_date")]
        public DateTime? AgmDate { get; set; }

        [Column("srn_mgt14")]
        public string? SrnMgt14 { get; set; }

        [Column("date_passing")]
        public DateTime? DatePassing { get; set; }

        [Column("mgt14_date")]
        public DateTime? Mgt14Date { get; set; }

        [Column("stamp_duty_amount")]
        public decimal? StampDutyAmount { get; set; }


        // Part 3 fields
        [Column("director_authorization")]
        public Boolean? DirectorAuthorization { get; set; }

        [Column("resolution_no")]
        public string? ResolutionNo { get; set; }

        [Column("resolution_date")]
        public DateTime? ResolutionDate { get; set; }

        [Column("self_declaration")]
        public Boolean? SelfDeclaration { get; set; }

        [Column("designation")]
        public string? Designation { get; set; }

        [Column("declaration")]
        public string? Declaration { get; set; }

        [Column("din")]
        public string? Din { get; set; }

        [Column("digitally_signed_by")]
        public string? DigitallySignedBy { get; set; }

        [Column("name_of_pcs")]
        public string? NameOfPcs { get; set; }

        [Column("associate_or_fellow")]
        public string? AssociateOrFellow { get; set; }

        [Column("membership_number")]
        public decimal? MembershipNumber { get; set; }

        [Column("cert_practise_number")]
        public string? CertPractiseNumber { get; set; }
    }

    [TableName("tbl_gnl1", "vw_gnl1")]
    public class GNL1View : GNL1
    {
        [Column("ref_user_name")]
        public string? RefUserName { get; set; }
    }

}