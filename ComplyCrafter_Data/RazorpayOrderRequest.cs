using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplyCrafter_Data
{
    public class RazorpayOrderRequest
    {
        public int SubscriptionId {  get; set; }
        public string? ReceiptId { get; set; }

        public int Amount { get; set; }  // in INR, will be converted to paise
    }
    public class RazorpayPaymentResponse
    {
        public string razorpay_payment_id { get; set; } = string.Empty;
        public string razorpay_order_id { get; set; } = string.Empty;
        public string razorpay_signature { get; set; } = string.Empty;
    }
}
