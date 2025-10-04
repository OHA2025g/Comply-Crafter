using AlphaUtil.Core.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ComplyCrafter_Data
{
    [TableName("tbl_inc22", "vw_inc22")]
    public class INC22 : BaseModel
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

        [Column("purpose_of_filing")]
        public string? PurposeOfFiling { get; set; }

        [Column("registered_office_date")]
        public DateTime? RegisteredOfficeDate { get; set; }

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
        public string? StateUT { get; set; }

        [Column("longitude")]
        public string? Longitude { get; set; }

        [Column("latitude")]
        public string? Latitude { get; set; }

        [Column("declarant_name")]
        public string? DeclarantName { get; set; }

        [Column("designation")]
        public string? Designation { get; set; }

        [Column("designation2")]
        public string? Designation2 { get; set; }

        [Column("resolution_number")]
        public string? ResolutionNumber { get; set; }

        [Column("resolution_date")]
        public DateTime? ResolutionDate { get; set; }

        [Column("director_name")]
        public string? DirectorName { get; set; }

        [Column("identification_number")]
        public string? IdentificationNumber { get; set; }

        [Column("category")]
        public string? Category { get; set; }

        [Column("pcs")]
        public string? Pcs { get; set; }

        [Column("membership_status")]
        public string? MembershipStatus { get; set; }

        [Column("membership_number")]
        public string? MembershipNumber { get; set; }
    }

    [TableName("tbl_inc22", "vw_inc22")]
    public class INC22View : INC22
    {
        [Column("ref_user_name")]
        public string? RefUserName { get; set; }
    }

}