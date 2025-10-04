using AlphaUtil.Core.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ComplyCrafter_Data
{
    [TableName("tbl_inc4", "vw_inc4")]
    public class INC4 : BaseModel
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

        [Column("purpose")]
        public string? Purpose { get; set; }

        [Column("withdrwal_nominee_name")]
        public string? WithdrwalNomineeName { get; set; }

        [Column("withdrawl_subscriber_name")]
        public string? WithdrawlSubscriberName { get; set; }

        [Column("withdrawl_date")]
        public DateTime? WithdrawlDate { get; set; }

        [Column("subscriber_name")]
        public string? SubscriberName { get; set; }

        [Column("member_company_name")]
        public string? MemberCompanyName { get; set; }

        [Column("first_name")]
        public string? FirstName { get; set; }

        [Column("middle_name")]
        public string? MiddleName { get; set; }

        [Column("last_name")]
        public string? LastName { get; set; }

        [Column("intimation_date")]
        public DateTime? IntimationDate { get; set; }

        [Column("nominee_name")]
        public string? NomineeName { get; set; }

        [Column("cessation_subscr_name")]
        public string? CessationSubscrName { get; set; }

        [Column("cess_company_name")]
        public string? CessCompanyName { get; set; }

        [Column("cesstion_date")]
        public DateTime? CesstionDate { get; set; }

        [Column("due_reason")]
        public string? DueReason { get; set; }

        [Column("cessation_first_name")]
        public string? CessationFirstName { get; set; }

        [Column("cessation_midd_name")]
        public string? CessationMiddName { get; set; }

        [Column("cessation_last_name")]
        public string? CessationLastName { get; set; }

        [Column("sole_member")]
        public string? SoleMember { get; set; }

        [Column("change_nominee_scr_name")]
        public string? ChangeNomineeScrName { get; set; }

        [Column("either_member_or_new")]
        public string? EitherMemberOrNew { get; set; }

        [Column("nominee_company")]
        public string? NomineeCompany { get; set; }

        [Column("nominee_first_name")]
        public string? NomineeFirstName { get; set; }

        [Column("nominee_midname")]
        public string? NomineeMidname { get; set; }

        [Column("nominee_last_name")]
        public string? NomineeLastName { get; set; }

        [Column("nominee_date")]
        public DateTime? NomineeDate { get; set; }

        [Column("nominee_din")]
        public string? NomineeDin { get; set; }

        [Column("first_name_of_din")]
        public string? FirstNameOfDin { get; set; }

        [Column("mid_name_of_din")]
        public string? MidNameOfDin { get; set; }

        [Column("sur_name_of_din")]
        public string? SurNameOfDin { get; set; }

        [Column("father_first_name")]
        public string? FatherFirstName { get; set; }

        [Column("father_mid_name_of_din")]
        public string? FatherMidNameOfDin { get; set; }

        [Column("father_surname")]
        public string? FatherSurname { get; set; }

        [Column("father_gender")]
        public string? FatherGender { get; set; }

        [Column("father_dob")]
        public DateTime? FatherDob { get; set; }

        [Column("nationality")]
        public string? Nationality { get; set; }

        [Column("nominee_pan")]
        public string? NomineePan { get; set; }

        [Column("place_of_birth")]
        public string? PlaceOfBirth { get; set; }

        [Column("occupation")]
        public string? Occupation { get; set; }

        [Column("occupation_area")]
        public string? OccupationArea { get; set; }

        [Column("qualification")]
        public string? Qualification { get; set; }

        [Column("line1")]
        public string? Line1 { get; set; }

        [Column("line2")]
        public string? Line2 { get; set; }

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

        [Column("state")]
        public string? State { get; set; }

        [Column("phone")]
        public string? Phone { get; set; }

        [Column("mobile")]
        public string? Mobile { get; set; }

        [Column("fax")]
        public string? Fax { get; set; }

        [Column("email_id")]
        public string? EmailId { get; set; }

        [Column("whether_address_same")]
        public string? WhetherAddressSame { get; set; }

        [Column("present_line1")]
        public string? PresentLine1 { get; set; }

        [Column("present_line2")]
        public string? PresentLine2 { get; set; }

        [Column("present_country")]
        public string? PresentCountry { get; set; }

        [Column("present_pin_code")]
        public string? PresentPinCode { get; set; }

        [Column("present_area_locality")]
        public string? PresentAreaLocality { get; set; }

        [Column("present_city")]
        public string? PresentCity { get; set; }

        [Column("present_district")]
        public string? PresentDistrict { get; set; }

        [Column("present_state")]
        public string? PresentState { get; set; }

        [Column("present_address")]
        public string? PresentAddress { get; set; }

        [Column("presentaddressyears")]
        public string? PresentAddressYears { get; set; }

        [Column("identity_proof")]
        public string? IdentityProof { get; set; }

        [Column("identity_proof_no")]
        public string? IdentityProofNo { get; set; }

        [Column("identity_prf_doc")]
        public string? IdentityPrfDoc { get; set; }

        [Column("residental_proof")]
        public string? ResidentalProof { get; set; }

        [Column("residental_proof_no")]
        public string? ResidentalProofNo { get; set; }

        [Column("residental_proof_doc")]
        public string? ResidentalProofDoc { get; set; }

        [Column("declarant_nominee_name")]
        public string? DeclarantNomineeName { get; set; }

        [Column("declarant_company_name")]
        public string? DeclarantCompanyName { get; set; }

        [Column("event_death")]
        public string? EventDeath { get; set; }

        [Column("optional_attachment")]
        public string? OptionalAttachment { get; set; } // Adjust the type if you expect multiple attachments

        [Column("pan")]
        public string? Pan { get; set; }

        [Column("designation")]
        public string? Designation { get; set; }

        [Column("signatory")]
        public string? Signatory { get; set; }

        [Column("din")]
        public string? Din { get; set; }
    }

    [TableName("tbl_inc4", "vw_inc4")]
    public class INC4View : INC4
    {
        [Column("ref_user_name")]
        public string? RefUserName { get; set; }
    }

}