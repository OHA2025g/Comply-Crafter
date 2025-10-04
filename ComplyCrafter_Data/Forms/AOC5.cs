using AlphaUtil.Core.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ComplyCrafter_Data
{
    [TableName("tbl_aoc5", "vw_aoc5")]
    public class AOC5 : BaseModel
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

        //[Column("company_email")]
        //public string? CompanyEmail { get; set; }

        //part-1
       
        [Column("decision_date")]
        public DateTime? DecisionDate { get; set; }

        [Column("line_address1")]
        public string? LineAddress1 { get; set; }

        [Column("line_address2")]
        public string? LineAddress2 { get; set; }

        [Column("line_address3")]
        public string? LineAddress3 { get; set; }

        [Column("line_address4")]
        public string? LineAddress4 { get; set; }

        [Column("longitude")]
        public string? Longitude { get; set; }

        [Column("latitude")]
        public string? Latitude { get; set; }

        [Column("country")]
        public string? Country { get; set; }

        [Column("country2")]
        public string? Country2 { get; set; }

        [Column("pin_code")]
        public string? PinCode { get; set; }

        [Column("pin_code2")]
        public string? PinCode2 { get; set; }

        [Column("locality_area")]
        public string? LocalityArea { get; set; }

        [Column("locality_area2")]
        public string? LocalityArea2 { get; set; }

        [Column("city")]
        public string? City { get; set; }

        [Column("city2")]
        public string? City2 { get; set; }

        [Column("district")]
        public string? District { get; set; }

        [Column("district2")]
        public string? District2 { get; set; }

        [Column("ut_state")]
        public string? UtState { get; set; }

        [Column("ut_state2")]
        public string? UtState2 { get; set; }

        [Column("police_station_name")]
        public string? PoliceStationName { get; set; }

        //part-2

        [Column("address_proof")]
        public string? AddressProof { get; set; }

        [Column("bills_copy")]
        public string? BillsCopy { get; set; }

        [Column("register_office_photo")]
        public string? RegisterOfficePhoto { get; set; }

        [Column("attachment_file")]
        public string? AttachmentFile { get; set; }

        [Column("comp_vide_resolution")]
        public string? CompVideResolution { get; set; }

        [Column("date_declaration")]
        public DateTime? DateDeclaration { get; set; }

        [Column("designation")]
        public string? Designation { get; set; }

        [Column("signatory")]
        public string? Signatory { get; set; }


    }

    [TableName("tbl_aoc5", "vw_aoc5")]
    public class AOC5View : AOC5
    {
        [Column("ref_user_name")]
        public string? RefUserName { get; set; }
    }

}