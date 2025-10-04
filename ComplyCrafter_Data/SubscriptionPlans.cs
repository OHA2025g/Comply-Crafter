using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplyCrafter_Data
{
    [Table("tbl_subscription_plans")]
    public class SubscriptionPlans : BaseModel
    {
        [Column("plan_name")]
        public string? PlanName { get; set; }

        [Column("plan_desc")]
        public string? PlanDesc { get; set; }

        [Column("plan_amount")]
        public string? PlanAmount { get; set; }

        [Column("coupon_code")]
        public string? CouponCode { get; set; }

        [Column("coupon_desc")]
        public string? CouponDesc { get; set; }

        [Column("discount_amount")]
        public string? DiscountAmount { get; set; }

        [Column("discount_percentage")]
        public string? DiscountPercentage { get; set; }

        [Column("sub_total")]
        public string? SubTotal { get; set; }

        [Column("gst_percentage")]
        public string? GSTPercentage { get; set; }

        [Column("gst_amount")]
        public string? GSTAmount { get; set; }

        [Column("total_amount")]
        public string? TotalAmount { get; set; }

        [Column("no_of_company")]
        public int NoOfCompany { get; set; }

        [Column("plan_type")]
        public string? PlanType { get; set; }
    }

    public class SubscriptionPlansView
    {
        public int Id { get; set; }
        public string? PlanName { get; set; }
        public string? PlanDesc { get; set; }
        public string? PlanAmount { get; set; }
        public string? CouponCode { get; set; }
        public string? CouponDesc { get; set; }
        public string? DiscountPercentage { get; set; }
        public string? DiscountAmount { get; set; }
        public string? SubTotal { get; set; }
        public string? GSTPercentage { get; set; }
        public string? GSTAmount { get; set; }
        public string? TotalAmount { get; set; }
        public int NoOfCompany { get; set; }
        public string? PlanType { get; set; }
    }
}
