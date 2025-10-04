using AlphaUtil.Core.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ComplyCrafter_Data
{
    [TableName("tbl_dir5", "vw_dir5")]
    public class DIR5 : BaseModel
    {
        [Column("ref_user")]
        public int? RefUser { get; set; }

        [Column("company_id")]
        public int? CompanyId { get; set; }

        [Column("reason_for_surrender")]
        public string? ReasonForSurrender { get; set; }

        [Column("retaining_din")]
        public string? RetainingDIN { get; set; }

        [Column("din_to_retain")]
        public string? DinToRetain { get; set; }

        [Column("first_name")]
        public string? FirstName { get; set; }

        [Column("middle_name")]
        public string? MiddleName { get; set; }

        [Column("last_name")]
        public string? LastName { get; set; }

        [Column("father_first_name")]
        public string? FatherFirstName { get; set; }

        [Column("father_middle_name")]
        public string? FatherMiddleName { get; set; }

        [Column("father_last_name")]
        public string? FatherLastName { get; set; }

        [Column("dob")]
        public DateTime? Dob { get; set; }

        [Column("pan")]
        public string? Pan { get; set; }

        [Column("num_of_dins_surrendered")]
        public int? NumOfDinsSurrendered { get; set; }

        [Column("is_digitally_signed")]
        public string? IsDigitallySigned { get; set; }

        [Column("other_information")]
        public string? OtherInformation { get; set; }

        [Column("name")]
        public string? Name { get; set; }

        [Column("id_number")]
        public string? IdNumber { get; set; }

        [Column("category")]
        public string? Category { get; set; }

        [Column("pcs")]
        public string? Pcs { get; set; }

        [Column("membership_status")]
        public string? MembershipStatus { get; set; }

        [Column("membership_number")]
        public string? MembershipNumber { get; set; }
    }

    [TableName("tbl_dir5", "vw_dir5")]
    public class DIR5View : DIR5
    {
        [Column("ref_user_name")]
        public string? RefUserName { get; set; }
    }

}