using AlphaUtil.Core;
using AlphaUtil.Core.Models;
using ComplyCrafter_Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ComplyCrafter_BL
{
    public interface IUserSubscriptions
    {
        IEnumerable<UserSubscriptions> GetByUserId(int userId); // Get List of purchased plans

        List<UserSubscriptionDetails> GetByUser(int userId);
        List<UserSubscriptionDetails> GetInvoiceById(int InvoiceId); // Fetch invoice detailes by invoice id

        UserSubscriptions? PurchaseSubscription(UserSubscriptions obj);// Create/ Save subscription plan

        int TotalCompanyCount(int userId); // Get total company count from purchased plan

        int UsedCompanyCount(int userId); // Total company used count

        int TrialCompanyCount(int userId); // Trial pack total company count

        bool CancelTrialPack(int userId); // to cancel trial pack on subscription purchase

        UserSubscriptions? GetTrialPackInfo(int userId); // Get trial pack details

        int PlanExpiryInDaysById(int subId); // Plan expiry in days by id

        UserSubscriptionDetails GetPaymentDetailsforEmail(string paymentId); //Payment confirmation for email
    }


    public class UserSubscriptionsRepository : IUserSubscriptions
    {
        private const string TABLE_NAME = "tbl_user_subscriptions";
        private const string VIEW_NAME = "vw_u_subscriptions";

        public IEnumerable<UserSubscriptions> GetByUserId(int userId)
        {
            var dt = NpgSQL.Query(R.ConnectionString, $@"select * from {VIEW_NAME} where user_id = @UserId;",
               new Dictionary<string, object>
               {
                    { "@UserId", userId },
               }, ThrowError: true)
               .ParseList<UserSubscriptions>();
            return dt;
        }

        public UserSubscriptions? GetTrialPackInfo(int userId)
        {
            var obj = NpgSQL.Query(R.ConnectionString, $@"select * from {VIEW_NAME} where user_id = @UserId and subscription_id = 1 and is_active = true and is_cancelled = false;",
               new Dictionary<string, object>
               {
                    { "@UserId", userId },
               }, ThrowError: true)
               .ParseList<UserSubscriptions>().FirstOrDefault();
            return obj;
        }

        public List<UserSubscriptionDetails> GetByUser(int userId)
        {
            var dt = NpgSQL.Query(R.ConnectionString, @"
            select 
            ud.display_name, ud.email_id, ud.mobile_number,
            us.start_date, us.end_date, us.purchased_on, us.is_active, us.id, us.is_cancelled,
            pd.transaction_id, pd.transaction_amount, pd.receipt_id, pd.payment_id,
            sp.plan_name, sp.no_of_company, sp.plan_amount, sp.coupon_code, 
            sp.discount_amount, sp.discount_percentage, sp.sub_total, 
            sp.gst_amount, sp.gst_percentage, sp.total_amount, sp.plan_type

            from tbl_user_subscriptions us 
            inner join tbl_subscription_plans sp on us.subscription_id = sp.id
            inner join tbl_user_details ud on us.user_id = ud.id
            left join tbl_payment_details pd on us.payment_id = pd.id
            where us.user_id = @UserId order by us.id desc;",
                new Dictionary<string, object> { { "@UserId", userId } },
                ThrowError: true
            );

            var list = new List<UserSubscriptionDetails>();

            foreach (DataRow row in dt.Rows)
            {
                var item = new UserSubscriptionDetails
                {
                    user = new AppUser
                    {
                        Name = Convert.ToString(row["display_name"]),
                        Email = Convert.ToString(row["email_id"]),
                        Mobile = Convert.ToString(row["mobile_number"])
                    },
                    paymentDetails = new PaymentDetails
                    {
                        TransactionAmount = row["transaction_amount"] != DBNull.Value ? Convert.ToDecimal(row["transaction_amount"]) : 0
                    },
                    userSubscription = new UserSubscriptions
                    {
                        Id = Convert.ToInt32(row["id"]),
                        StartDate = Convert.ToDateTime(row["start_date"]),
                        EndDate = Convert.ToDateTime(row["end_date"]),
                        PurchasedOn = Convert.ToDateTime(row["purchased_on"]),
                        IsActive = Convert.ToBoolean(row["is_active"]),
                        IsCancelled = Convert.ToBoolean(row["is_cancelled"])
                    },
                    subscriptionPlan = new SubscriptionPlans
                    {
                        PlanName = Convert.ToString(row["plan_name"]),
                        NoOfCompany = Convert.ToInt32(row["no_of_company"]),
                        CouponCode = Convert.ToString(row["coupon_code"]),
                        DiscountAmount = Convert.ToString(row["discount_amount"]),
                        DiscountPercentage = Convert.ToString(row["discount_percentage"]),
                        SubTotal = Convert.ToString(row["sub_total"]),
                        GSTAmount = Convert.ToString(row["gst_amount"]),
                        GSTPercentage = Convert.ToString(row["gst_percentage"]),
                        TotalAmount = Convert.ToString(row["total_amount"]),
                        PlanType = Convert.ToString(row["plan_type"]),
                    }
                };
                list.Add(item);
            }

            return list;
        }

        public List<UserSubscriptionDetails> GetInvoiceById(int InvoiceId)
        {
            var dt = NpgSQL.Query(R.ConnectionString, @"
            select 
            ud.display_name, ud.email_id, ud.mobile_number,
            us.start_date, us.end_date, us.purchased_on, us.is_active, us.id, us.is_cancelled,
            pd.transaction_id, pd.transaction_amount, pd.receipt_id, pd.payment_id,
            sp.plan_name, sp.no_of_company, sp.plan_amount, sp.coupon_code, 
            sp.discount_amount, sp.discount_percentage, sp.sub_total, 
            sp.gst_amount, sp.gst_percentage, sp.total_amount, sp.plan_type

            from tbl_user_subscriptions us 
            inner join tbl_subscription_plans sp on us.subscription_id = sp.id
            inner join tbl_user_details ud on us.user_id = ud.id
            inner join tbl_payment_details pd on us.payment_id = pd.id
            where us.id = @InvoiceId;",
                new Dictionary<string, object> { { "@InvoiceId", InvoiceId } },
                ThrowError: true
            );

            var list = new List<UserSubscriptionDetails>();

            foreach (DataRow row in dt.Rows)
            {
                var item = new UserSubscriptionDetails
                {
                    user = new AppUser
                    {
                        Name = Convert.ToString(row["display_name"]),
                        Email = Convert.ToString(row["email_id"]),
                        Mobile = Convert.ToString(row["mobile_number"])
                    },
                    paymentDetails = new PaymentDetails
                    {
                        TransactionAmount = Convert.ToDecimal(row["transaction_amount"]),
                    },
                    userSubscription = new UserSubscriptions
                    {
                        Id = Convert.ToInt32(row["id"]),
                        StartDate = Convert.ToDateTime(row["start_date"]),
                        EndDate = Convert.ToDateTime(row["end_date"]),
                        PurchasedOn = Convert.ToDateTime(row["purchased_on"]),
                        IsActive = Convert.ToBoolean(row["is_active"]),
                        IsCancelled = Convert.ToBoolean(row["is_cancelled"])
                    },
                    subscriptionPlan = new SubscriptionPlans
                    {
                        PlanName = Convert.ToString(row["plan_name"]),
                        PlanAmount = Convert.ToString(row["plan_amount"]),
                        NoOfCompany = Convert.ToInt32(row["no_of_company"]),
                        CouponCode = Convert.ToString(row["coupon_code"]),
                        DiscountAmount = Convert.ToString(row["discount_amount"]),
                        DiscountPercentage = Convert.ToString(row["discount_percentage"]),
                        SubTotal = Convert.ToString(row["sub_total"]),
                        GSTAmount = Convert.ToString(row["gst_amount"]),
                        GSTPercentage = Convert.ToString(row["gst_percentage"]),
                        TotalAmount = Convert.ToString(row["total_amount"]),
                        PlanType = Convert.ToString(row["plan_type"]),
                    }
                };
                list.Add(item);
            }

            return list;
        }

        public UserSubscriptions? PurchaseSubscription(UserSubscriptions obj)
        {
            obj.Id = obj.InsertIntoDBOutIdentity(R.ConnectionString, TABLE_NAME, "id");
            if (obj.Id > 0)
                return obj;
            return null;
        }

        public bool CancelTrialPack(int userId)
        {
            return NpgSQL.NonQuery(R.ConnectionString, $@"update {TABLE_NAME} set is_cancelled = true, cancelled_on=now(), end_date = now(), 
                is_active = false, updated_on= now(), updated_by = @id where user_id = @id and subscription_id = 1;", new Dictionary<string, object>
            {
                { "@id", userId }
            }, ThrowError: true) > 0;
        }

        public int TrialCompanyCount(int userId)
        {
            var i = NpgSQL.Query(R.ConnectionString, $@"select sum(sp.no_of_company) as total_company_limit from {TABLE_NAME} us inner join tbl_subscription_plans sp on us.subscription_id = sp.id
                where us.subscription_id = 1 and us.is_active = true and us.user_id = @userId;",
               new Dictionary<string, object>
               {
                    { "@userId", userId },
               });
            return Convert.ToInt32(i.Rows[0].ItemArray[0] == System.DBNull.Value ? 0 : i.Rows[0].ItemArray[0]);
        }

        public int TotalCompanyCount(int userId)
        {
            var dt = NpgSQL.Query(
                R.ConnectionString,
                $@"select sum(sp.no_of_company) as total_company_limit
                from {TABLE_NAME} us
                inner join tbl_subscription_plans sp on us.subscription_id = sp.id
                where us.is_active = true and us.user_id = @userId;",
                new Dictionary<string, object>
             {
                    { "@userId", userId },
             });

            // ✅ No subscription rows for this user → treat as 0
            if (dt == null || dt.Rows.Count == 0)
                return 0;

            var value = dt.Rows[0].ItemArray[0];

            if (value == System.DBNull.Value)
                return 0;

            return Convert.ToInt32(value);
        }


        public int UsedCompanyCount(int userId)
        {
            var i = NpgSQL.Query(R.ConnectionString, $@"select count(1) as used_company_limit from tbl_company where ref_user = @userId;",
               new Dictionary<string, object>
               {
                    { "@userId", userId },
               });
            return Convert.ToInt32(i.Rows[0].ItemArray[0] == System.DBNull.Value ? 0 : i.Rows[0].ItemArray[0]);
        }

        public int PlanExpiryInDaysById(int subId)
        {
            var i = NpgSQL.Query(R.ConnectionString, $@"SELECT end_date::date - now()::date as date_diff from tbl_user_subscriptions where id = @id;",
               new Dictionary<string, object>
               {
                    { "@id", subId },
               });
            return Convert.ToInt32(i.Rows[0].ItemArray[0] == System.DBNull.Value ? 0 : i.Rows[0].ItemArray[0]);
        }

        public UserSubscriptionDetails GetPaymentDetailsforEmail(string TransactionId)
        {
            var dt = NpgSQL.Query(R.ConnectionString, @"
            select ud.display_name, 
            us.end_date, us.purchased_on, pd.created_on, 
            sp.plan_name, pd.transaction_amount, pd.payment_id 
            from tbl_user_subscriptions us
            inner join tbl_user_details ud on ud.id = us.user_id
            inner join tbl_subscription_plans sp on us.subscription_id = sp.id
            inner join tbl_payment_details pd on us.payment_id = pd.id
            where pd.transaction_id = @TransactionId;"
            ,
                new Dictionary<string, object> { { "@TransactionId", TransactionId } },
                ThrowError: true
            );

            var list = new List<UserSubscriptionDetails>();

            foreach (DataRow row in dt.Rows)
            {
                var item = new UserSubscriptionDetails
                {
                    user = new AppUser
                    {
                        Name = Convert.ToString(row["display_name"]),
                    },
                    paymentDetails = new PaymentDetails
                    {
                        PaymentId = Convert.ToString(row["payment_id"]),
                        TransactionAmount = Convert.ToDecimal(row["transaction_amount"]),
                        CreatedOn = Convert.ToDateTime(row["created_on"]),
                    },
                    userSubscription = new UserSubscriptions
                    {
                        EndDate = Convert.ToDateTime(row["end_date"]),
                        PurchasedOn = Convert.ToDateTime(row["purchased_on"]),
                    },
                    subscriptionPlan = new SubscriptionPlans
                    {
                        PlanName = Convert.ToString(row["plan_name"]),
                    }
                };
                list.Add(item);
            }

            return list.FirstOrDefault();
        }
    }
}
