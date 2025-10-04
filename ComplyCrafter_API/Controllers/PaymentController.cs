using AlphaUtil.Core.Models;
using ComplyCrafter_API.Models;
using ComplyCrafter_BL;
using ComplyCrafter_Data;
using Microsoft.AspNetCore.Mvc;
using Org.BouncyCastle.Asn1.Ocsp;
using Org.BouncyCastle.Asn1.X509;
using Razorpay.Api;
using System.Security.Cryptography;
using System.Text;

namespace ComplyCrafter_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class PaymentController : ApiController
    {
        private readonly IPaymentDetails _payment;

        public PaymentController(IPaymentDetails payment)
        {
            this._payment = payment;
        }

        [Authorize]
        [HttpPost("CreateOrder")]
        public IActionResult CreateOrder([FromBody] RazorpayOrderRequest request)
        {
            var guid = Guid.NewGuid().ToString();
            var hash = guid.GetHashCode();
            request.ReceiptId= Math.Abs(hash).ToString().PadLeft(15, '0');

            RazorpayClient client = new RazorpayClient(R.AppSet("RazorpayDetails:RazorpayKey"), R.AppSet("RazorpayDetails:RazorpaySecret"));

            Dictionary<string, object> options = new Dictionary<string, object>
            {
                { "amount", request.Amount * 100 }, // amount in paise
                { "currency", "INR" },
                { "receipt", request.ReceiptId },
                { "payment_capture", 1 }
            };

            Order order = client.Order.Create(options);

            if (order == null)
            {

                return Ok(new
                {
                    status = false,
                    message ="Error while creating payment order. Please try again later"
                });
            }

            try
            {
                PaymentDetails trans = new PaymentDetails();
                //Saving payment details
                trans.UserId = User!.Id;
                trans.SubscriptionId = request.SubscriptionId;
                trans.TransactionId = order["id"].ToString();
                trans.ReceiptId = request.ReceiptId;
                trans.TransactionAmount = request.Amount;
                trans.PaymentStatus = (int)PaymentStatus.Initiate;
                trans.PreInsert(trans!);
                var vPT = _payment.SavePaymentDetails(trans);
            }
            catch (Exception ex)
            {
            }

            return Ok(new
            {
                status=true,
                message = "Payment order created successfully.",
                orderId = order["id"].ToString(),
                amount = order["amount"],
                key = R.AppSet("RazorpayDetails:RazorpayKey") // public key for frontend
            });
        }

        [Authorize]
        [HttpPost("VerifyPayment")]
        public Response VerifyPayment(RazorpayPaymentResponse res)
        {
            string payload = res.razorpay_order_id + "|" + res.razorpay_payment_id;
            string generatedSignature;

            using (var hmac = new HMACSHA256(Encoding.UTF8.GetBytes(R.AppSet("RazorpayDetails:RazorpaySecret"))))
            {
                byte[] hash = hmac.ComputeHash(Encoding.UTF8.GetBytes(payload));
                generatedSignature = BitConverter.ToString(hash).Replace("-", "").ToLower();
            }
            var vPT = _payment.GetByTransactionId(res.razorpay_order_id);
            if (vPT == null)
            {
                return new Response(false, "Payment details not found. Please contact administrations.");
            }
            PaymentDetails trans = new PaymentDetails();
            //Saving payment details
            trans.Id = vPT.Id;
            trans.UserId = User!.Id;
            trans.TransactionId = res.razorpay_order_id;
            trans.PaymentId = res.razorpay_payment_id;
            trans.SignatureId = res.razorpay_signature;

            trans.PreUpdate(trans!);
            if (generatedSignature == res.razorpay_signature)
            {
                trans.PaymentStatus = (int)PaymentStatus.Success;
                trans.IsPaymentVerified = true;
                _payment.SavePaymentDetails(trans);
                return new Response(true, "Payment verified successfully.");
            }
            trans.PaymentStatus = (int)PaymentStatus.Failed;
            _payment.SavePaymentDetails(trans);
            return new Response(false, "Invalid signature.");
        }

        [Authorize]
        [HttpGet("Transaction")]
        public Response GetTransactionById(string TransactionId)
        {
            var res= _payment.GetByTransactionId(TransactionId);
            if (res == null)
                return new Response(false, "Transaction not found.");

            SubscriptionPlansRepository _subscription = new SubscriptionPlansRepository();
            var sub= _subscription.GetById(res.SubscriptionId);
            res.SubscriptionPlanName = sub.PlanName;

            return new Response(true, "Success", res);
        }
    }
}
