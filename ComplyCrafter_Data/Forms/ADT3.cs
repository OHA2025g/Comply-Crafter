using AlphaUtil.Core.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ComplyCrafter_Data
{
    [TableName("tbl_adt3", "vw_adt3")]
    public class ADT3 : BaseModel
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

        [Column("auditor")]
        public string? Auditor { get; set; }

        [Column("category")]
        public string? Category { get; set; }

        [Column("reason")]
        public string? Reason { get; set; }

        [Column("resignation_place")]
        public string? ResignationPlace { get; set; }

        [Column("other_reason")]
        public string? OtherReason { get; set; }

        [Column("letter_date")]
        public DateTime? LetterDate { get; set; } // DateTime for date fields

        [Column("effective_date")]
        public DateTime? EffectiveDate { get; set; } // DateTime for date fields

        [Column("place_disqualified")]
        public string? PlaceDisqualified { get; set; }

        [Column("relative_name")]
        public string? RelativeName { get; set; }

        [Column("relation")]
        public string? Relation { get; set; }

        [Column("intimation_date")]
        public DateTime? IntimationDate { get; set; } // DateTime for date fields

        [Column("place")]
        public string? Place { get; set; }

        // Part 2
        [Column("auditor_category")]
        public string? AuditorCategory { get; set; }

        [Column("pan")]
        public string? Pan { get; set; }

        [Column("auditor_name")]
        public string? AuditorName { get; set; }

        [Column("membership")]
        public string? Membership { get; set; }

        [Column("auditor_address")]
        public string? AuditorAddress { get; set; }

        [Column("city")]
        public string? City { get; set; }

        [Column("state")]
        public string? State { get; set; }

        [Column("pin_code")]
        public int? PinCode { get; set; } // Nullable int

        [Column("auditor_email")]
        public string? AuditorEmail { get; set; }

        [Column("appointment_date")]
        public DateTime? AppointmentDate { get; set; } // DateTime for date fields

        [Column("resignation_date")]
        public DateTime? ResignationDate { get; set; } // DateTime for date fields

        [Column("resignation_reasons")]
        public string? ResignationReasons { get; set; }

        [Column("designation")]
        public string? Designation { get; set; }

        [Column("fellow_associate")]
        public string? FellowAssociate { get; set; }

        [Column("membership_number")]
        public decimal? MembershipNumber { get; set; } // Nullable int
    }

    [TableName("tbl_adt3", "vw_adt3")]
    public class ADT3View : ADT3
    {
        [Column("ref_user_name")]
        public string? RefUserName { get; set; }
    }

}