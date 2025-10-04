namespace ComplyCrafter_UI.Models
{
    public class PlanDetailsViewModel
    {
        public string PlanName { get; set; }
        public decimal BasePrice { get; set; }
        public string CouponCode { get; set; }
        public decimal DiscountPercent { get; set; }
        public decimal GSTPercent { get; set; } = 18;

    }
}
