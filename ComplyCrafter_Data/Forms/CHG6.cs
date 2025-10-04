using AlphaUtil.Core.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ComplyCrafter_Data
{
    [TableName("tbl_chg6", "vw_chg6")]
    public class CHG6 : BaseModel
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

        [Column("filled_by")]
        public string? FilledBy { get; set; }

        [Column("notice_type")]
        public string? NoticeType { get; set; }

        [Column("pan_number")]
        public string? PanNumber { get; set; }

        [Column("receiver_name")]
        public string? ReceiverName { get; set; }

        [Column("address_line1")]
        public string? AddressLine1 { get; set; }

        [Column("address_line2")]
        public string? AddressLine2 { get; set; }

        [Column("country")]
        public string? Country { get; set; }

        [Column("zip_code")]
        public int? ZipCode { get; set; }

        [Column("locality")]
        public string? Locality { get; set; }

        [Column("city")]
        public string? City { get; set; }

        [Column("district")]
        public string? District { get; set; }

        [Column("state")]
        public string? State { get; set; }

        [Column("appointment_date")]
        public DateTime? AppointmentDate { get; set; }

        [Column("appointment_type")]
        public string? AppointmentType { get; set; }

        [Column("number_of_charges")]
        public string? NumberOfCharges { get; set; }

        [Column("pan_number2")]
        public string? PanNumber2 { get; set; }
    }

    [TableName("tbl_chg6", "vw_chg6")]
    public class CHG6View : CHG6
    {
        [Column("ref_user_name")]
        public string? RefUserName { get; set; }
    }

}