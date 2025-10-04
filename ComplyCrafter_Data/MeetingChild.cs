using AlphaUtil.Core.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ComplyCrafter_Data
{
    public class MeetingSpecialInvitee: NpgSQLTable
    {
        [BypassInSQLInsert]
        [Column("id")]
        public int Id { get; set; }

        [Column("parent_id")]
        public int? ParentId { get; set; }

        [BypassInSQLUpdate]
        [Column("deleted_on")]
        public DateTime? DeletedOn { get; set; }

        [Column("si_name")]
        public string? SiName { get; set; }

        [Column("si_designation")]
        public string? SiDesignation { get; set; }

        [Column("si_org")]
        public string? SiOrg { get; set; }

    }
    public class MeetingCirculation: NpgSQLTable
    {
        [BypassInSQLInsert]
        [Column("id")]
        public int Id { get; set; }

        [Column("parent_id")]
        public int? ParentId { get; set; }

        [Column("type")]
        public string? Type { get; set; }

        [Column("c_director")]
        public string? CDirector { get; set; }

        [Column("c_date")]
        public DateTime? CDate { get; set; }

        [Column("c_receipt_date")]
        public DateTime? CReceiptDate { get; set; }

        [Column("c_mode")]
        public string? CMode { get; set; }

        [Column("c_other")]
        public string? COther { get; set; }

        [BypassInSQLUpdate]
        [Column("deleted_on")]
        public DateTime? DeletedOn { get; set; }

    }
    public class MeetingCommunicateComment : NpgSQLTable
    {
        [BypassInSQLInsert]
        [Column("id")]
        public int Id { get; set; }

        [Column("parent_id")]
        public int? ParentId { get; set; }

        [Column("cc_received_on")]
        public DateTime? CcReceivedOn { get; set; }

        [Column("cc_director")]
        public string? CcDirector { get; set; }

        [Column("cc_comment")]
        public string? CcComment { get; set; }

        [BypassInSQLUpdate]
        [Column("deleted_on")]
        public DateTime? DeletedOn { get; set; }

    }

}