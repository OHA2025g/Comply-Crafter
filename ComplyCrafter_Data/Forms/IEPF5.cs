using AlphaUtil.Core.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ComplyCrafter_Data
{
    [TableName("tbl_iepf5", "vw_iepf5")]
    public class IEPF5 : BaseModel
    {
        [Column("ref_user")]
        public int? RefUser { get; set; }

        [Column("company_id")]
        public int? CompanyId { get; set; }

        //part-1
        [Column("applicant_category")]
        public string? ApplicantCategory { get; set; }

        [Column("applicant_first_name")]
        public string? ApplicantFirstName { get; set; }

        [Column("applicant_middle_name")]
        public string? ApplicantMiddleName { get; set; }

        [Column("applicant_last_name")]
        public string? ApplicantLastName { get; set; }

        [Column("applicant_fathers_first_name")]
        public string? ApplicantFathersFirstName { get; set; }

        [Column("applicant_fathers_middle_name")]
        public string? ApplicantFathersMiddleName { get; set; }

        [Column("applicant_fathers_last_name")]
        public string? ApplicantFathersLastName { get; set; }

        [Column("applicant_dob")]
        public DateTime? ApplicantDob { get; set; }

        [Column("type_of_entity")]
        public string? TypeOfEntity { get; set; }

        [Column("entity_identification_no")]
        public string? EntityIdentificationNo { get; set; }

        [Column("entity_name")]
        public string? EntityName { get; set; }

        [Column("entity_incorporate_date")]
        public DateTime? EntityIncorporateDate { get; set; }

        [Column("applicant_address")]
        public string? ApplicantAddress { get; set; }

        [Column("applicant_phone_no")]
        public string? ApplicantPhoneNo { get; set; }

        [Column("applicant_mobile_no")]
        public string? ApplicantMobile { get; set; }

        [Column("applicant_mobile_otp")]
        public string? ApplicantMobileOtp { get; set; }

        [Column("applicant_email_id")]
        public string? ApplicantEmailId { get; set; }

        [Column("applicant_email_otp")]
        public string? ApplicantEmailOtp { get; set; }

        [Column("applicant_aadhar_no")]
        public string? ApplicantAadharNo { get; set; }

        [Column("aadhaar_attach")]
        public string? AadhaarAttach { get; set; }

        [Column("passport")]
        public string? Passport { get; set; }

        [Column("passport_attach")]
        public string? PassportAttach { get; set; }

        [Column("applicant_pan")]
        public string? ApplicantPan { get; set; }

        [Column("bcin")]
        public string? bcin { get; set; }

        [Column("company_name_bank")]
        public string? CompanyNameBank { get; set; }

        [Column("company_reg_office_address")]
        public string? CompanyRegOfficeAddress { get; set; }

        [Column("company_email_id")]
        public string? CompanyEmailId { get; set; }

        [Column("covered_rules")]
        public string? CoveredRules { get; set; }

        [Column("security_holder_name")]
        public string? SecurityHolderName { get; set; }

        [Column("security_holder_relation")]
        public string? SecurityHolderRelation { get; set; }

        [Column("no_nominee")]
        public string? NoNominee { get; set; }

        [Column("death_certificate")]
        public string? DeathCertificate { get; set; }

        [Column("will_certificate")]
        public string? WillCertificate { get; set; }

        [Column("no_objection_certificate")]
        public string? NoObjCertificate { get; set; }

        [Column("indemnity")]
        public string? Indemnity { get; set; }

        [Column("other_doc")]
        public string? OtherDoc { get; set; }

        //part-2

        [Column("claim_type")]
        public string? ClaimType { get; set; }

        [Column("number_of_folio")]
        public string? NumberOfFolio { get; set; }

        [Column("number_of_claims")]
        public string? NumberOfClaims { get; set; }

        [Column("bank_account_number")]
        public string? BankAccountNumber { get; set; }

        [Column("bank_name")]
        public string? BankName { get; set; }

        [Column("ifsc_code")]
        public string? IfscCode { get; set; }

        [Column("bank_branch")]
        public string? BankBranch { get; set; }

        [Column("demat_account_number")]
        public string? DematAccountNumber { get; set; }

        //part-3

        [Column("clients_list")]
        public string? ClientsList { get; set; }

        [Column("entitle")]
        public string? Entitle { get; set; }

        [Column("cheque")]
        public string? Cheque { get; set; }

        [Column("attachment_file")]
        public string? AttachmentFile { get; set; }

        [Column("declaration")]
        public Boolean? Declaration { get; set; }

    }

    [TableName("tbl_iepf5", "vw_iepf5")]
    public class IEPF5View : IEPF5
    {
        [Column("ref_user_name")]
        public string? RefUserName { get; set; }
    }

}