using AlphaUtil.Core.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ComplyCrafter_Data
{
    [TableName("tbl_dir6", "vw_dir6")]
    public class DIR6 : BaseModel
    {
        [Column("ref_user")]
        public int? RefUser { get; set; }

        [Column("company_id")]
        public int? CompanyId { get; set; }

        [Column("director_din")]
        public string? DirectorDin { get; set; }

        [Column("director_name")]
        public string? DirectorName { get; set; }

        [Column("photograph")]
        public string? Photograph { get; set; }

        [Column("citizen_of_india")]
        public string? CitizenOfIndia { get; set; }

        [Column("director_first_name")]
        public string? DirectorFirstName { get; set; }

        [Column("director_middle_name")]
        public string? DirectorMiddleName { get; set; }

        [Column("director_last_name")]
        public string? DirectorLastName { get; set; }

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

        [Column("dob")]
        public DateTime? DateOfBirth { get; set; }

        [Column("gender")]
        public string? Gender { get; set; }

        [Column("pan_number")]
        public string? PanNumber { get; set; }

        [Column("pan_attachment")]
        public string? PanAttachment { get; set; }

        [Column("aadhaar_number")]
        public string? AadhaarNumber { get; set; }

        [Column("aadhaar_attachment")]
        public string? AadhaarAttachment { get; set; }

        [Column("voter_id_number")]
        public string? VoterIdNumber { get; set; }

        [Column("voter_id_attachment")]
        public string? VoterIdAttachment { get; set; }

        [Column("passport_number")]
        public string? PassportNumber { get; set; }

        [Column("passport_attachment")]
        public string? PassportAttachment { get; set; }

        [Column("driving_license_number")]
        public string? DrivingLicenseNumber { get; set; }

        [Column("driving_license_attachment")]
        public string? DrivingLicenseAttachment { get; set; }

        [Column("permanent_address_line_1")]
        public string? PermanentAddressLine1 { get; set; }

        [Column("permanent_address_line_2")]
        public string? PermanentAddressLine2 { get; set; }

        [Column("permanent_country")]
        public string? PermanentCountry { get; set; }

        [Column("permanent_pin_code")]
        public string? PermanentPinCode { get; set; }

        [Column("permanent_area")]
        public string? PermanentArea { get; set; }

        [Column("permanent_city")]
        public string? PermanentCity { get; set; }

        [Column("permanent_district")]
        public string? PermanentDistrict { get; set; }

        [Column("permanent_state")]
        public string? PermanentState { get; set; }

        [Column("permanent_police_station")]
        public string? PermanentPoliceStation { get; set; }

        [Column("phone")]
        public string? Phone { get; set; }

        [Column("fax")]
        public string? Fax { get; set; }

        [Column("same_address")]
        public string? SameAddress { get; set; }

        [Column("present_address_line_1")]
        public string? PresentAddressLine1 { get; set; }

        [Column("present_address_line_2")]
        public string? PresentAddressLine2 { get; set; }

        [Column("present_country")]
        public string? PresentCountry { get; set; }

        [Column("present_pin_code")]
        public string? PresentPinCode { get; set; }

        [Column("present_area")]
        public string? PresentArea { get; set; }

        [Column("present_city")]
        public string? PresentCity { get; set; }

        [Column("present_district")]
        public string? PresentDistrict { get; set; }

        [Column("present_state")]
        public string? PresentState { get; set; }

        [Column("present_police_station")]
        public string? PresentPoliceStation { get; set; }

        [Column("present_phone")]
        public string? PresentPhone { get; set; }

        [Column("present_fax")]
        public string? PresentFax { get; set; }

        [Column("category")]
        public string? Category { get; set; }

        [Column("pcs")]
        public string? Pcs { get; set; }

        [Column("membership_status")]
        public string? MembershipStatus { get; set; }

        [Column("membership_number")]
        public string? MembershipNumber { get; set; }
    }

    [TableName("tbl_dir6", "vw_dir6")]
    public class DIR6View : DIR6
    {
        [Column("ref_user_name")]
        public string? RefUserName { get; set; }
    }

}