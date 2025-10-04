using AlphaUtil.Core.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ComplyCrafter_Data
{
    [TableName("tbl_inc24", "vw_inc24")]
    public class INC24 : BaseModel
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


        [Column("srn")]
        public int? srn { get; set; }

        [Column("proposed_company")]
        public string? ProposedCompany { get; set; }

        [Column("change_name")]
        public string? ChangeName { get; set; }

        [Column("srn_of_mgt")]
        public int? SrnOfMgt { get; set; }

        [Column("incorporation_company")]
        public string? IncorporationCompany { get; set; }

        [Column("assets_properties")]
        public string? AssetsProperties { get; set; }

        [Column("resolution_member_numbers")]
        public int? resolutionMemberNumbers { get; set; }

        [Column("resolution_member_shares")]
        public int? ResolutionMemberShares { get; set; }

        [Column("favour_members")]
        public int? FavourMembers { get; set; }

        [Column("favour_shares")]
        public int? FavourShares { get; set; }

        [Column("against_members")]
        public int? AgainstMembers { get; set; }

        [Column("against_shares")]
        public int? AgainstShares { get; set; }

        [Column("abstained_members")]
        public int? AbstainedMembers { get; set; }

        [Column("abstained_shares")]
        public int? AbstainedShares { get; set; }

        [Column("optional_attachment_file")]
        public string? OptionalAttachmentfile { get; set; }

        [Column("resolution_number")]
        public int? ResolutionNumber { get; set; }

        [Column("resolution_date")]
        public string? ResolutionDate { get; set; }

        [Column("declaration_designation")]
        public string? DeclarationDesignation { get; set; }

        [Column("signatory")]
        public string? Signatory { get; set; }

        [Column("din")]
        public string? Din { get; set; }

    }

    [TableName("tbl_inc24", "vw_inc24")]
    public class INC24View : INC24
    {
        [Column("ref_user_name")]
        public string? RefUserName { get; set; }
    }

}