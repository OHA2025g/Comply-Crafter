using AlphaUtil.Core.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ComplyCrafter_Data
{
    [TableName("tbl_sh7", "vw_sh7")]
    public class SH7 : BaseModel
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


        [Column("form_purpose")]
        public string? FormPurpose { get; set; }

        // 3 start
        [Column("share_type")]
        public string? ShareType { get; set; }

        [Column("resolution_date")]
        public DateTime? ResolutionDate { get; set; }

        [Column("srn_number")]
        public string? SrnNumber { get; set; }

        [Column("members_present")]
        public int? MembersPresent { get; set; }

        [Column("shares_held")]
        public int? SharesHeld { get; set; }

        [Column("members_voted_for")]
        public int? MembersVotedFor { get; set; }

        [Column("shares_voted_for")]
        public int? SharesVotedFor { get; set; }

        [Column("members_voted_against")]
        public int? MembersVotedAgainst { get; set; }

        [Column("shares_voted_against")]
        public int? SharesVotedAgainst { get; set; }

        [Column("members_abstained")]
        public int? MembersAbstained { get; set; }

        [Column("shares_abstained")]
        public int? SharesAbstained { get; set; }
        // 3 end

        // 5 start
        [Column("existing_members")]
        public int? ExistingMembers { get; set; }

        [Column("revised_members")]
        public int? RevisedMembers { get; set; }

        [Column("difference_members")]
        public int? DifferenceMembers { get; set; }

        [Column("max_members_excluding_employees")]
        public int? MaxMembersExcludingEmployees { get; set; }
        // 5 end

        // 6 start
        [Column("order_number")]
        public string? OrderNumber { get; set; }

        [Column("order_date")]
        public DateTime? OrderDate { get; set; }

        [Column("government_type")]
        public string? GovernmentType { get; set; }

        [Column("state")]
        public string? State { get; set; }

        [Column("debentures")]
        public bool? Debentures { get; set; }

        [Column("loans")]
        public bool? Loans { get; set; }

        [Column("order_received_date")]
        public DateTime? OrderReceivedDate { get; set; }

        [Column("appeal_filed")]
        public string? AppealFiled { get; set; }

        [Column("tribunal_order_date")]
        public DateTime? TribunalOrderDate { get; set; }

        [Column("order_receipt_date")]
        public DateTime? OrderReceiptDate { get; set; }

        [Column("srn_inc28")]
        public string? SrnInc28 { get; set; }
        // 6 end

        // 7 start
        [Column("company_notice_date")]
        public DateTime? CompanyNoticeDate { get; set; }

        [Column("impact_consolidated")]
        public bool? ImpactConsolidated { get; set; }

        [Column("impact_converted")]
        public bool? ImpactConverted { get; set; }

        [Column("impact_reconverted")]
        public bool? ImpactReconverted { get; set; }

        [Column("impact_subdivided")]
        public bool? ImpactSubdivided { get; set; }

        [Column("impact_cancellation")]
        public bool? ImpactCancellation { get; set; }
        // 7 end

        [Column("articles_altered")]
        public string? ArticlesAltered { get; set; }

        [Column("memorandum_altered")]
        public string? MemorandumAltered { get; set; }

        [Column("stamp_state")]
        public string? StampState { get; set; }

        [Column("stamp_duty_amount")]
        public decimal? StampDutyAmount { get; set; }

        [Column("stamp_details")]
        public string? StampDetails { get; set; }

        [Column("dec_name")]
        public string? DecName { get; set; }

        [Column("designation")]
        public string? Designation { get; set; }

        [Column("designation2")]
        public string? Designation2 { get; set; }

        [Column("identifier")]
        public string? Identifier { get; set; }

        [Column("category")]
        public string? Category { get; set; }

        [Column("pcs")]
        public string? Pcs { get; set; }

        [Column("membership_status")]
        public string? MembershipStatus { get; set; }

        [Column("membership_number")]
        public string? MembershipNumber { get; set; }

        [BypassInSQL]
        public IEnumerable<SH7Share>? Shares { get; set; }

        [BypassInSQL]
        public IEnumerable<SH7Structure>? ExistingStructure { get; set; }

        [BypassInSQL]
        public IEnumerable<SH7Structure>? RevisedStructure { get; set; }
    }

    [TableName("tbl_sh7", "vw_sh7")]
    public class SH7View : SH7
    {
        [Column("ref_user_name")]
        public string? RefUserName { get; set; }
    }

}