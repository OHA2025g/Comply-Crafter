using AlphaUtil.Core.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ComplyCrafter_Data
{
    [TableName("tbl_mr1", "vw_mr1")]
    public class MR1 : BaseModel
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

        [Column("public")]
        public string? Public { get; set; }

        [Column("appointee_name")]
        public string? AppointeeName { get; set; }

        [Column("appointee_din_pan")]
        public string? AppointeeDinPan { get; set; }

        [Column("appointee_designation")]
        public string? AppointeeDesignation { get; set; }

        [Column("appointee_resolution_date")]
        public DateTime? AppointeeResolutionDate { get; set; }

        [Column("appointee_appointment_date")]
        public DateTime? AppointeeAppointmentDate { get; set; }

        [Column("remuneration_type")]
        public string? RemunerationType { get; set; }

        [Column("remuneration_salary")]
        public decimal? RemunerationSalary { get; set; }

        [Column("remuneration_perquisites")]
        public decimal? RemunerationPerquisites { get; set; }

        [Column("remuneration_others")]
        public decimal? RemunerationOthers { get; set; }

        [Column("remuneration_total")]
        public decimal? RemunerationTotal { get; set; }

        [Column("appointment_from")]
        public DateTime? AppointmentFrom { get; set; }

        [Column("appointment_to")]
        public DateTime? AppointmentTo { get; set; }

        [Column("age_over_70")]
        public string? AgeOver70 { get; set; }

        [Column("convicted_detained")]
        public string? ConvictedDetained { get; set; }

        [Column("non_resident")]
        public string? NonResident { get; set; }

        [Column("approval_obtained")]
        public string? ApprovalObtained { get; set; }

        [Column("srn_mr2")]
        public string? SrnMR2 { get; set; }

        [Column("resolution_number")]
        public string? ResolutionNumber { get; set; }

        [Column("resolution_date")]
        public DateTime? ResolutionDate { get; set; }

        [Column("designation")]
        public string? Designation { get; set; }

        [Column("officer_designation")]
        public string? OfficerDesignation { get; set; }

        [Column("signatory_id")]
        public string? SignatoryId { get; set; }

        [Column("category")]
        public string? Category { get; set; }

        [Column("pcs")]
        public string? Pcs { get; set; }

        [Column("membership_status")]
        public string? MembershipStatus { get; set; }

        [Column("membership_number")]
        public string? MembershipNumber { get; set; }
    }

    [TableName("tbl_mr1", "vw_mr1")]
    public class MR1View : MR1
    {
        [Column("ref_user_name")]
        public string? RefUserName { get; set; }
    }

}