using ComplyCrafter_Data;
using ComplyCrafter_UI.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Data;
using System.Numerics;
using System.Reflection;
using System.Text.Json;

namespace ComplyCrafter_UI.Controllers
{
    public class SubscriptionController : Controller
    {
        private static readonly HttpClient _client = new HttpClient();

        public async Task<IActionResult> PlanDetails(int PlanId)
        {
            if (PlanId <= 0)
                return View(new SubscriptionPlansView());

            string? token = Request.Cookies["ComplyCrafterSessionId"];

            using var httpClient = new HttpClient();
            var apiUrl = $"{R.ApiUrl}/SubscriptionPlans/PlanById?planId={PlanId}";

            try
            {
                if (!string.IsNullOrEmpty(token))
                {
                    httpClient.DefaultRequestHeaders.Authorization =
                        new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
                }

                var response = await httpClient.GetAsync(apiUrl);
                response.EnsureSuccessStatusCode();

                var json = await response.Content.ReadAsStringAsync();

                var plan = System.Text.Json.JsonSerializer.Deserialize<SubscriptionPlansView>(json, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

                return View(plan);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return View(new SubscriptionPlansView());
            }
        }

        public async Task<IActionResult> Invoice(int InvoiceId)
        {
            if (InvoiceId <= 0)
                return View(new UserSubscriptionDetails());

            string? token = Request.Cookies["ComplyCrafterSessionId"];

            using var httpClient = new HttpClient();
            var apiUrl = $"{R.ApiUrl}/Subscription/Invoice?InvoiceId={InvoiceId}";

            try
            {
                if (!string.IsNullOrEmpty(token))
                {
                    httpClient.DefaultRequestHeaders.Authorization =
                        new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
                }

                var response = await httpClient.GetAsync(apiUrl);
                response.EnsureSuccessStatusCode();

                var json = await response.Content.ReadAsStringAsync();

                if (string.IsNullOrEmpty(json))
                    return RedirectToAction("Subscription");

                JArray jsonArray = JArray.Parse(json);
                var flatList = new List<Dictionary<string, object>>();

                foreach (JObject obj in jsonArray)
                {
                    flatList.Add(FlattenJObject(obj));
                }

                string flatJson = JsonConvert.SerializeObject(flatList);
                DataTable dt = JsonConvert.DeserializeObject<DataTable>(flatJson);

                var list = new List<UserSubscriptionDetails>();

                foreach (DataRow row in dt.Rows)
                {
                    var item = new UserSubscriptionDetails
                    {
                        user = new AppUser
                        {
                            Name = Convert.ToString(row["user.name"]),
                            Email = Convert.ToString(row["user.email"]),
                            Mobile = Convert.ToString(row["user.mobile"])
                        },
                        paymentDetails = new PaymentDetails
                        {
                            TransactionAmount = Convert.ToDecimal(row["paymentDetails.transactionAmount"]),
                        },
                        userSubscription = new UserSubscriptions
                        {
                            Id = Convert.ToInt32(row["userSubscription.id"]),
                            StartDate = Convert.ToDateTime(row["userSubscription.startDate"]),
                            EndDate = Convert.ToDateTime(row["userSubscription.endDate"]),
                            PurchasedOn = Convert.ToDateTime(row["userSubscription.purchasedOn"]),
                            IsActive = Convert.ToBoolean(row["userSubscription.isActive"])
                        },
                        subscriptionPlan = new SubscriptionPlans
                        {
                            PlanName = Convert.ToString(row["subscriptionPlan.planName"]),
                            PlanAmount = Convert.ToString(row["subscriptionPlan.planAmount"]),
                            NoOfCompany = Convert.ToInt32(row["subscriptionPlan.noOfCompany"]),
                            CouponCode = Convert.ToString(row["subscriptionPlan.couponCode"]),
                            DiscountAmount = Convert.ToString(row["subscriptionPlan.discountAmount"]),
                            DiscountPercentage = Convert.ToString(row["subscriptionPlan.discountPercentage"]),
                            SubTotal = Convert.ToString(row["subscriptionPlan.subTotal"]),
                            GSTAmount = Convert.ToString(row["subscriptionPlan.gstAmount"]),
                            GSTPercentage = Convert.ToString(row["subscriptionPlan.gstPercentage"]),
                            TotalAmount = Convert.ToString(row["subscriptionPlan.totalAmount"]),
                            PlanType = Convert.ToString(row["subscriptionPlan.planType"]),
                        }
                    };
                    list.Add(item);
                }
                if(list.Count == 0)
                    return Content("<script>window.close();</script>", "text/html");

                return View(list.FirstOrDefault());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return View(new UserSubscriptionDetails());
            }
        }

        static Dictionary<string, object> FlattenJObject(JObject jObject, string prefix = "")
        {
            var result = new Dictionary<string, object>();

            foreach (var property in jObject.Properties())
            {
                string key = string.IsNullOrEmpty(prefix) ? property.Name : $"{prefix}.{property.Name}";

                if (property.Value.Type == JTokenType.Object)
                {
                    var nested = FlattenJObject((JObject)property.Value, key);
                    foreach (var pair in nested)
                        result[pair.Key] = pair.Value;
                }
                else
                {
                    result[key] = ((JValue)property.Value).Value;
                }
            }

            return result;
        }

    }
}
