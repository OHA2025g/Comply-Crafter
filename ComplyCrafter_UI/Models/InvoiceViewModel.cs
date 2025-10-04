namespace ComplyCrafter_UI.Models
{
    public class InvoiceViewModel
    {
        public string InvoiceNumber { get; set; }
        public DateTime InvoiceDate { get; set; }

        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
        public string CompanyGSTIN { get; set; }

        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }

        public string PlanName { get; set; }
        public string CouponCode { get; set; }

        public decimal BasePrice { get; set; }
        public int DiscountPercent { get; set; }
        public decimal GSTPercent { get; set; }

        public DateTime SubscriptionStart { get; set; }
        public DateTime SubscriptionEnd { get; set; }

        
        public decimal DiscountAmount => (BasePrice * DiscountPercent) / 100;
        public decimal DiscountedPrice => BasePrice - DiscountAmount;
        public decimal GSTAmount => (DiscountedPrice * GSTPercent) / 100;
        public decimal FinalAmount => DiscountedPrice + GSTAmount;
    }

}
