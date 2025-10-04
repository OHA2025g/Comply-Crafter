using AlphaUtil.Core.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ComplyCrafter_Data
{
    [Table("tbl_director_details")]
    public class DirectorDetails:NpgSQLTable
    {
        [BypassInSQLInsert]
        [Column("id")]
        public int Id { get; set; }

        [Column("director_id")]
        public int DirectorId { get; set; }

        [Column("address")]
        public string? Address { get; set; }

        [Column("country")]
        public string? Country { get; set; }

        [Column("state")]
        public string? State { get; set; }

        [Column("city")]
        public string? City { get; set; }

        [Column("pincode")]
        public int Pincode { get; set; }

        [Column("father_name")]
        public string? FatherName { get; set; }

        [Column("date_of_birth")]
        public DateTime? DateOfBirth { get; set; }

        [Column("occupation")]
        public string? Occupation { get; set; }

        [Column("gender")]
        public string? Gender { get; set; }

        [Column("nationality")]
        public string? Nationality { get; set; }

        [Column("residential_status")]
        public string? ResidentialStatus { get; set; }

        [Column("marital_status")]
        public string? MaritalStatus { get; set; }

        [Column("qualification")]
        public string? Qualification { get; set; }

        [Column("experience")]
        public string? Experience { get; set; }

        [Column("passport")]
        public string? Passport { get; set; }

        [Column("passport_expiry_date")]
        public DateTime? PassportExpiryDate { get; set; }

        [Column("permanent_address")]
        public string? PermanentAddress { get; set; }

        [Column("other_communication_address")]
        public string? OtherCommunicationAddress { get; set; }

        [BypassInSQLUpdate]
        [Column("pan_url")]
        public string? PanUrl { get; set; }

        [BypassInSQLUpdate]
        [Column("aadhar_url")]
        public string? AadharUrl { get; set; }

        [BypassInSQLUpdate]
        [Column("passport_url")]
        public string? PassportUrl { get; set; }

        [BypassInSQLUpdate]
        [Column("voter_id_url")]
        public string? VoterIdUrl { get; set; }

        [BypassInSQLUpdate]
        [Column("driving_licence_url")]
        public string? DrivingLicenceUrl { get; set; }


    }

}