using AlphaUtil.Core.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ComplyCrafter_Data
{
    [Table("tbl_shareholder_details")]
    public class ShareholderDetails : NpgSQLTable
    {
        [BypassInSQLInsert]
        [Column("id")]
        public int Id { get; set; }

        [Column("shareholder")]
        public int Shareholder { get; set; }

        [Column("address_line_1")]
        public string? AddressLine1 { get; set; }

        [Column("city")]
        public string? City { get; set; }

        [Column("state")]
        public string? State { get; set; }

        [Column("country")]
        public string? Country { get; set; }

        [Column("pin_code")]
        public string? PinCode { get; set; }

        [Column("father_name")]
        public string? FatherName { get; set; }

        [Column("mother_name")]
        public string? MotherName { get; set; }

        [Column("nationality")]
        public string? Nationality { get; set; }

        [Column("voter_id")]
        public string? VoterId { get; set; }

        [Column("aadhar_no")]
        public string? AadharNo { get; set; }

        [Column("occupation")]
        public string? Occupation { get; set; }

        [Column("spouse_name")]
        public string? SpouseName { get; set; }
        
        [Column("gaurdian")]
        public string? Gaurdian { get; set; }

        [BypassInSQLUpdate]
        [Column("pan_url")]
        public string? PanUrl { get; set; }

        [BypassInSQLUpdate]
        [Column("aadhar_url")]
        public string? AadharUrl { get; set; }
    }

}