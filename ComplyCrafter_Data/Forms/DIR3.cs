using AlphaUtil.Core.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ComplyCrafter_Data
{
    [TableName("tbl_dir3", "vw_dir3")]
    public class DIR3 : BaseModel
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

        [Column("is_citizen_of_india")]
        public string? IsCitizenOfIndia { get; set; }

        [Column("passport_size_photograph")]
        public string? PassportSizePhotograph { get; set; }

        [Column("applicant_first_name")]
        public string? ApplicantFirstName { get; set; }

        [Column("applicant_middle_name")]
        public string? ApplicantMiddleName { get; set; }

        [Column("applicant_last_name")]
        public string? ApplicantLastName { get; set; }

        [Column("father_first_name")]
        public string? FatherFirstName { get; set; }

        [Column("father_middle_name")]
        public string? FatherMiddleName { get; set; }

        [Column("father_last_name")]
        public string? FatherLastName { get; set; }

        [Column("nationality")]
        public string? Nationality { get; set; }

        [Column("is_resident_in_india")]
        public string? IsResidentInIndia { get; set; }

        [Column("occupation_type")]
        public string? OccupationType { get; set; }

        [Column("educational_qualification")]
        public string? EducationalQualification { get; set; }

        [Column("date_of_birth")]
        public DateTime? DateOfBirth { get; set; }

        [Column("gender")]
        public string? Gender { get; set; }

        [Column("income_tax_permanent_account_number")]
        public string? IncomeTaxPermanentAccountNumber { get; set; }

        [Column("income_tax_pan_file")]
        public string? IncomeTaxPanFile { get; set; }

        [Column("has_aadhaar")]
        public string? HasAadhaar { get; set; }

        [Column("aadhaar_number")]
        public string? AadhaarNumber { get; set; }

        [Column("aadhaar_file")]
        public string? AadhaarFile { get; set; }

        [Column("voter_id_number")]
        public string? VoterIdNumber { get; set; }

        [Column("voter_id_file")]
        public string? VoterIdFile { get; set; }

        [Column("passport_number")]
        public string? PassportNumber { get; set; }

        [Column("passport_file")]
        public string? PassportFile { get; set; }

        [Column("driving_license_number")]
        public string? DrivingLicenseNumber { get; set; }

        [Column("driving_license_file")]
        public string? DrivingLicenseFile { get; set; }

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

        [Column("state_ut")]
        public string? StateUt { get; set; }

        [Column("jurisdiction_police_station")]
        public string? JurisdictionPoliceStation { get; set; }

        [Column("phone")]
        public string? Phone { get; set; }

        [Column("fax")]
        public string? Fax { get; set; }

        [Column("email")]
        public string? Email { get; set; }

        [Column("is_address_same")]
        public string? IsAddressSame { get; set; }

        [Column("present_address_line1")]
        public string? PresentAddressLine1 { get; set; }

        [Column("present_address_line2")]
        public string? PresentAddressLine2 { get; set; }

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

        [Column("present_state_ut")]
        public string? PresentStateUt { get; set; }

        [Column("present_jurisdiction_police_station")]
        public string? PresentJurisdictionPoliceStation { get; set; }

        [Column("present_phone")]
        public string? PresentPhone { get; set; }

        [Column("present_fax")]
        public string? PresentFax { get; set; }

        [Column("verification_name")]
        public string? VerificationName { get; set; }

        [Column("verification_fathers_name")]
        public string? VerificationFathersName { get; set; }

        [Column("verification_dob")]
        public DateTime? VerificationDob { get; set; }

        [Column("verification_address")]
        public string? VerificationAddress { get; set; }

        [Column("security_clearance")]
        public string? SecurityClearance { get; set; }

        [Column("category_select")]
        public string? CategorySelect { get; set; }

        [Column("director_dpin_or_pan_or_membership_number")]
        public string? DirectorDpinOrPanOrMembershipNumber { get; set; }

        [Column("category_select_duplicate")]
        public string? CategorySelectDuplicate { get; set; }
    }

    [TableName("tbl_dir3", "vw_dir3")]
    public class DIR3View : DIR3
    {
        [Column("ref_user_name")]
        public string? RefUserName { get; set; }
    }

}