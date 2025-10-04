using AlphaUtil.Core.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ComplyCrafter_Data
{
    [TableName("tbl_inc28", "vw_inc28")]
    public class INC28 : BaseModel
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

        [Column("order_passed_by")]
        public string? OrderPassedBy { get; set; }

        [Column("court_name")]
        public string? CourtName { get; set; }

        [Column("central_gov_office_name")]
        public string? CentralGovOfficeName { get; set; }

        [Column("debt_recovery_tribunal_name")]
        public string? DebtRecoveryTribunalName { get; set; }

        [Column("competent_authority_name")]
        public string? CompetentAuthorityName { get; set; }

        [Column("location")]
        public string? Location { get; set; }

        [Column("petition_number")]
        public string? PetitionNumber { get; set; }

        [Column("order_number")]
        public string? OrderNumber { get; set; }

        [Column("date_of_passing_order")]
        public DateTime? DateOfPassingOrder { get; set; }

        [Column("relevant_act")]
        public string? RelevantAct { get; set; }
        
        [Column("order_filling_days")]
        public string? OrderFilingDays { get; set; }

        [Column("application_date")]
        public DateTime? ApplicationDate { get; set; }

        [Column("certified_copy_date")]
        public DateTime? CertifiedCopyDate { get; set; }

        [Column("due_date_registrar")]
        public DateTime? DueDateRegistrar { get; set; }

        [Column("board_resolution_number")]
        public string? BoardResolutionNumber { get; set; }

        [Column("board_resolution_date")]
        public DateTime? BoardResolutionDate { get; set; }

        [Column("director_dsc")]
        public string? DirectorDSC { get; set; }

        [Column("director_din")]
        public string? DirectorDIN { get; set; }

        [Column("category_time")]
        public string? CategoryTime { get; set; }

        [Column("name_of_pcs")]
        public string? NameOfPCS { get; set; }

        [Column("whether_associate")]
        public string? WhetherAssociate { get; set; }

        [Column("membership_number")]
        public string? MembershipNumber { get; set; }
    }

    [TableName("tbl_inc28", "vw_inc28")]
    public class INC28View : INC28
    {
        [Column("ref_user_name")]
        public string? RefUserName { get; set; }
    }

}