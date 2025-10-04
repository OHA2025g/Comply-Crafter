using AlphaUtil.Core.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ComplyCrafter_Data
{
    [TableName("tbl_shareholder_management", "vw_shareholder_management")]
    public class ShareholderManagement : BaseModel
    {
        [Column("ref_user")]
        public int? RefUser { get; set; }

        [Column("company_id")]
        public int? CompanyId { get; set; }

        [Column("joint_shareholding")]
        public string? JointShareholding { get; set; }

        [Column("joint_shareholders_count")]
        public int? JointShareholdersCount { get; set; }

        [Column("category")]
        public string? Category { get; set; }

        [Column("sh_list")]
        public string? ShList { get; set; }

        [Column("date_of_becoming_member")]
        public DateTime? DateOfBecomingMember { get; set; }

        [Column("shareholder_status")]
        public string? ShareholderStatus { get; set; }

        [Column("shareholding_mode")]
        public string? ShareholdingMode { get; set; }

        [Column("type_of_share")]
        public string? TypeOfShare { get; set; }

        [Column("number_of_shares_subscribed")]
        public int? NumberOfSharesSubscribed { get; set; }

        [Column("per_share_value")]
        public decimal? PerShareValue { get; set; }

        [Column("percentage_of_shares_held")]
        public decimal? PercentageOfSharesHeld { get; set; }

        [Column("folio_no")]
        public string? FolioNo { get; set; }

        [Column("dp_client_id")]
        public string? DpClientId { get; set; }

        [Column("is_bene")]
        public string? IsBene { get; set; }

        [BypassInSQL]
        public IEnumerable<SHOwner>? BeneList { get; set; }
    }

    [TableName("tbl_shareholder_management", "vw_shareholder_management")]
    public class ShareholderManagementView : ShareholderManagement
    {
        [Column("ref_user_name")]
        public string? RefUserName { get; set; }
    }

    public class SHOwner : NpgSQLTable
    {
        [BypassInSQLInsert]
        [Column("id")]
        public int Id { get; set; }

        [Column("parent_id")]
        public int? ParentId { get; set; }

        [Column("owner_name")]
        public string? OwnerName { get; set; }

        [Column("owner_address")]
        public string? OwnerAddress { get; set; }

        [Column("dec_date")]
        public string? DecDate { get; set; }
    }
}