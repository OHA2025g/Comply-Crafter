using AlphaUtil.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplyCrafter_Data
{
    [Table("tbl_user_subscriptions")]
    public class UserSubscriptions : BaseModel
    {
        [BypassInSQLUpdate]
        [Column("user_id")]
        public int UserId { get; set; }

        [BypassInSQLUpdate]
        [Column("subscription_id")]
        public int SubscriptionId { get; set; }

        [BypassInSQLUpdate]
        [Column("payment_id")]
        public int PaymentId { get; set; }

        [BypassInSQLUpdate]
        [Column("start_date")]
        public DateTime StartDate { get; set; }

        [BypassInSQLUpdate]
        [Column("end_date")]
        public DateTime EndDate { get; set; }

        [BypassInSQLUpdate]
        [Column("purchased_on")]
        public DateTime PurchasedOn { get; set; }

        [BypassInSQLInsert]
        [Column("is_cancelled")]
        public Boolean? IsCancelled { get; set; }

        [BypassInSQLInsert]
        [Column("cancelled_on")]
        public DateTime? CancelledOn { get; set; }

        public void PreInsert(UserSubscriptions _us)
        {
            this.CreatedBy = _us.Id;
            this.CreatedOn = DateTime.Now;
        }

        public void PreUpdate(UserSubscriptions _us)
        {
            this.UpdatedBy = _us.Id;
            this.UpdatedOn = DateTime.Now;
        }
    }
    public class UserSubscriptionDetails
    {
        public AppUser? user { get; set; }
        public UserSubscriptions? userSubscription { get; set; }
        public PaymentDetails? paymentDetails { get; set; }
        public SubscriptionPlans? subscriptionPlan { get; set; }
    }
}
