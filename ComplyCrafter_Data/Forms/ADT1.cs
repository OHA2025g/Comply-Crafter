using AlphaUtil.Core.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ComplyCrafter_Data
{
    [TableName("tbl_adt1", "vw_adt1")]
    public class ADT1 : BaseModel
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

        [Column("falling_section")]
        public string? FallingSection { get; set; }

        [Column("appointment_nature")]
        public string? AppointmentNature { get; set; }

        [Column("is_auditor_appointed")]
        public string? IsAuditorAppointed { get; set; }

        [Column("auditor_number")]
        public decimal? AuditorNumber { get; set; }

        [Column("annual_general_meeting")]
        public string? AnnualGeneralMeeting { get; set; }

        [Column("agm_date")]
        public DateTime? AgmDate { get; set; }

        [Column("appointment_date")]
        public DateTime? AppointmentDate { get; set; }

        [Column("is_casual_vacancy")]
        public string? IsCasualVacancy { get; set; }

        [Column("sr_no_of_relevant_form")]
        public string? SrnOfRelevantForm { get; set; }

        [Column("person_vacated")]
        public string? PersonVacated { get; set; }

        [Column("vacancy_date")]
        public DateTime? VacancyDate { get; set; }

        [Column("casual_vacancy_reasons")]
        public string? CasualVacancyReasons { get; set; }

        [Column("membership_number")]
        public decimal? MembershipNumber { get; set; }

        [Column("auditor_serial")]
        public Boolean? AuditorSerial { get; set; }

        [Column("auditor_member_no")]
        public string? AuditorMemberNo { get; set; }

        [Column("resolution_number")]
        public string? ResolutionNumber { get; set; }

        [Column("resolution_date")]
        public DateTime? ResolutionDate { get; set; }

        [Column("signed_by")]
        public string? SignedBy { get; set; }

        [Column("designation")]
        public string? Designation { get; set; }

        [Column("din")]
        public string?  DIN { get; set; }
    }

    [TableName("tbl_adt1", "vw_adt1")]
    public class ADT1View : ADT1
    {
        [Column("ref_user_name")]
        public string? RefUserName { get; set; }
    }

}