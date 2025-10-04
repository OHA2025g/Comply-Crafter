using AlphaUtil.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplyCrafter_Data
{
    [Table("tbl_payment_details")]
    public class PaymentDetails : NpgSQLTable
    {
        [BypassInSQLInsert]
        [BypassInSQLUpdate]
        [Column("id")]
        public int Id { get; set; }

        [BypassInSQLUpdate]
        [Column("user_id")]
        public int UserId { get; set; }

        [BypassInSQLUpdate]
        [Column("subscription_id")]
        public int SubscriptionId { get; set; }

        [BypassInSQLInsert]
        [BypassInSQLUpdate]
        [NotMapped]
        public string? SubscriptionPlanName { get; set; }

        [BypassInSQLUpdate]
        [Column("transaction_id")]
        public string? TransactionId { get; set; }

        [BypassInSQLUpdate]
        [Column("transaction_amount")]
        public decimal TransactionAmount { get; set; }

        [BypassInSQLUpdate]
        [Column("receipt_id")]
        public string? ReceiptId { get; set; }

        [Column("payment_id")]
        public string? PaymentId { get; set; }
        
        [Column("signature_id")]
        public string? SignatureId { get; set; }

        [Column("payment_status")]
        public int? PaymentStatus { get; set; }

        [Column("is_payment_verified")]
        public bool IsPaymentVerified { get; set; }

        [BypassInSQLUpdate]
        [Column("created_by")]
        public int CreatedBy { get; set; }

        [BypassInSQLUpdate]
        [Column("created_on")]
        public DateTime CreatedOn { get; set; }

        [Column("updated_by")]
        public int UpdatedBy { get; set; }

        [Column("updated_on")]
        public DateTime? UpdatedOn { get; set; }

        public void PreInsert(PaymentDetails _pd)
        {
            this.CreatedBy = _pd.Id;
            this.CreatedOn = DateTime.Now;
        }
        public void PreUpdate(PaymentDetails _pd)
        {
            this.UpdatedBy = _pd.Id;
            this.UpdatedOn = DateTime.Now;
        }
    }

    public enum PaymentStatus
    {
        Default = 0,
        Initiate = 1,
        Success = 2,
        Failed = 3,
        Refund = 4
    }
}
