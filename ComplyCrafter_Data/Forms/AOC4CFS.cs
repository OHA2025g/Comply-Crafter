using AlphaUtil.Core.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ComplyCrafter_Data
{
    [TableName("tbl_aoc4cfs", "vw_aoc4cfs")]
    public class AOC4CFS : BaseModel
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

        // Part 1 (AOC-4 and Financial Statements)
        [Column("aoc4_srn")]
        public string? Aoc4Srn { get; set; }

        [Column("financial_year_starting_date")]
        public DateTime? FinancialYearStartingDate { get; set; }

        [Column("financial_year_ending_date")]
        public DateTime? FinancialYearEndingDate { get; set; }

        [Column("board_meeting_date")]
        public DateTime? BoardMeetingDate { get; set; }

        [Column("section134_approval_date")]
        public DateTime? Section134ApprovalDate { get; set; }

        // Director 1 financial statement
        [Column("director1_signed")]
        public bool? Director1Signed { get; set; }

        [Column("director1_signing_date")]
        public DateTime? Director1SigningDate { get; set; }

        // Director 2 financial statement
        [Column("director2_signed")]
        public bool? Director2Signed { get; set; }

        [Column("director2_signing_date")]
        public DateTime? Director2SigningDate { get; set; }

        // Director 1 board report
        [Column("board_director1_signed")]
        public bool? BoardDirector1Signed { get; set; }

        [Column("board_director1_signing_date")]
        public DateTime? BoardDirector1SigningDate { get; set; }

        // Director 2 board report
        [Column("board_director2_signed")]
        public bool? BoardDirector2Signed { get; set; }

        [Column("board_director2_signing_date")]
        public DateTime? BoardDirector2SigningDate { get; set; }

        // Part 2 (Auditors)
        [Column("auditor_signing_date")]
        public DateTime? AuditorSigningDate { get; set; }

        // First auditor
        [Column("first_auditor_serial")]
        public bool? FirstAuditorSerial { get; set; }

        [Column("first_auditor_member_no")]
        public string? FirstAuditorMemberNo { get; set; }

        [Column("first_auditor_srn")]
        public string? FirstAuditorSrn { get; set; }

        // Second auditor
        [Column("second_auditor_serial")]
        public bool? SecondAuditorSerial { get; set; }

        [Column("second_auditor_member_no")]
        public string? SecondAuditorMemberNo { get; set; }

        [Column("second_auditor_srn")]
        public string? SecondAuditorSrn { get; set; }

        // Part 3 (Subsidiaries/Associates)
        [Column("has_subsidiary")]
        public string? HasSubsidiary { get; set; }

        [Column("associate_or_venture")]
        public string? AssociateOrVenture { get; set; }

        [Column("industries_type")]
        public string? IndustriesType { get; set; }

        [Column("schedule_applicable")]
        public string? ScheduleApplicable { get; set; }

        // Part 7 (CAG and Audit Reports)
        [Column("has_cag_comments")]
        public string? HasCagComments { get; set; }

        [Column("has_cag_supplementary_audit")]
        public string? HasCagSupplementaryAudit { get; set; }

        [Column("has_auditor_remarks")]
        public string? HasAuditorRemarks { get; set; }

        [Column("is_caro_applicable")]
        public string? IsCaroApplicable { get; set; }

        [Column("fixed_assets")]
        public string? FixedAssets { get; set; }

        [Column("inventories")]
        public string? Inventories { get; set; }

        [Column("loans_given")]
        public string? LoansGiven { get; set; }

        [Column("public_deposits")]
        public string? PublicDeposits { get; set; }

        [Column("cost_records")]
        public string? CostRecords { get; set; }

        [Column("statutory_dues")]
        public string? StatutoryDues { get; set; }

        [Column("term_loans")]
        public string? TermLoans { get; set; }

        [Column("fraud_noticed")]
        public string? FraudNoticed { get; set; }

        [Column("other_comments")]
        public string? OtherComments { get; set; }

        [Column("is_secretarial_audit_applicable")]
        public string? IsSecretarialAuditApplicable { get; set; }

        [Column("has_detailed_disclosures")]
        public string? HasDetailedDisclosures { get; set; }

        // Part 8 (Resolution and Signatures)
        [Column("resolution_number")]
        public decimal? ResolutionNumber { get; set; }

        [Column("resolution_date")]
        public DateTime? ResolutionDate { get; set; }

        [Column("signatory_id")]
        public string? SignatoryId { get; set; }

        [Column("signatory_designation")]
        public string? SignatoryDesignation { get; set; }

        [Column("signatory_din_pan")]
        public string? SignatoryDinPan { get; set; }

        [Column("certified_by")]
        public string? CertifiedBy { get; set; }

        [Column("name_of_pcs")]
        public string? NameOfPcs { get; set; }

        [Column("associate_or_fellow")]
        public string? AssosiateOrFellow { get; set; }

        [Column("memb_number")]
        public string? MembNumber { get; set; }

        [Column("cert_practice_no")]
        public string? CertPraticeNo { get; set; }

        [BypassInSQL]
        public IEnumerable<SUBSIDIARY>? SubsidiaryList { get; set; }

        [BypassInSQL]
        public IEnumerable<SUBSIDIARY>? AssociateList { get; set; }

        [BypassInSQL]
        public IEnumerable<CAG>? CagList { get; set; }

        [BypassInSQL]
        public IEnumerable<RESERVATION>? ReservationList { get; set; }
    }

    [TableName("tbl_aoc4cfs", "vw_aoc4cfs")]
    public class AOC4CFSView : AOC4CFS
    {
        [Column("ref_user_name")]
        public string? RefUserName { get; set; }
    }


        

}