using AlphaUtil.Core.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ComplyCrafter_Data
{
    public class SH7Structure: NpgSQLTable
    {
        [BypassInSQLInsert]
        [Column("id")]
        public int? Id { get; set; }

        [Column("parent_id")]
        public int? ParentId { get; set; }

        [Column("type")]
        public string? Type { get; set; }

        [Column("share_type")]
        public string? ShareType { get; set; }

        [Column("class_of_shares")]
        public string? ClassOfShares { get; set; }

        [Column("auth_number_of_shares")]
        public int? AuthNumberOfShares { get; set; }

        [Column("auth_nominal_value")]
        public decimal? AuthNominalValue { get; set; }

        [Column("auth_total_amount")]
        public decimal? AuthTotalAmount { get; set; }

        [Column("issued_number_of_shares")]
        public int? IssuedNumberOfShares { get; set; }

        [Column("issued_nominal_value")]
        public decimal? IssuedNominalValue { get; set; }

        [Column("issued_total_amount")]
        public decimal? IssuedTotalAmount { get; set; }

        [Column("subscribed_number_of_shares")]
        public int? SubscribedNumberOfShares { get; set; }

        [Column("subscribed_nominal_value")]
        public decimal? SubscribedNominalValue { get; set; }

        [Column("subscribed_total_amount")]
        public decimal? SubscribedTotalAmount { get; set; }

        [Column("paid_up_number_of_shares")]
        public int? PaidUpNumberOfShares { get; set; }

        [Column("paid_up_nominal_value")]
        public decimal? PaidUpNominalValue { get; set; }

        [Column("paid_up_total_amount")]
        public decimal? PaidUpTotalAmount { get; set; }

        [BypassInSQLUpdate]
        [Column("deleted_on")]
        public DateTime? DeletedOn { get; set; }
    }

}