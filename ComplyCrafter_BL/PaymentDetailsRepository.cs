using AlphaUtil.Core;
using ComplyCrafter_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace ComplyCrafter_BL
{
    public interface IPaymentDetails
    {
        IEnumerable<PaymentDetails> Get();

        PaymentDetails? GetByTransactionId(string TransactionId);

        PaymentDetails? SavePaymentDetails(PaymentDetails obj);

        bool VerifyPaymen(string TransactionId);
    }

    public class PaymentDetailsRepository : IPaymentDetails
    {
        private const string TABLE_NAME = "tbl_payment_details";

        public IEnumerable<PaymentDetails> Get()
        {
            var dt = NpgSQL.Query(R.ConnectionString, $@"select * from {TABLE_NAME}", ThrowError: true)
                .ParseList<PaymentDetails>();
            return dt;
        }

        public PaymentDetails? GetByTransactionId(string TransactionId)
        {
            var dt = NpgSQL.Query(R.ConnectionString, $@"select * from {TABLE_NAME} where transaction_id = @TransactionId",
               new Dictionary<string, object>
               {
                    { "@TransactionId", TransactionId },
               }, ThrowError: true)
               .ParseList<PaymentDetails>().FirstOrDefault();
            return dt;
        }

        public PaymentDetails? SavePaymentDetails(PaymentDetails obj)
        {
            if (obj.Id == 0)
            {
                obj.Id = obj.InsertIntoDBOutIdentity(R.ConnectionString, TABLE_NAME, "id");
                if (obj.Id > 0)
                    return obj;
                return null;
            }
            else
                obj.UpdateIntoDB(R.ConnectionString, TABLE_NAME, "id", obj.Id);
            return obj;
        }

        public bool VerifyPaymen(string TransactionId)
        {
            bool res = false;
            var uPT = GetByTransactionId(TransactionId);
            if (uPT == null) res = false;

            var obj = NpgSQL.Query(R.ConnectionString, $@"select * from {TABLE_NAME} where transaction_id = @TransactionId",
                new Dictionary<string, object> { { "@TransactionId", TransactionId } }).ParseList<PaymentDetails>().FirstOrDefault();
            if (obj != null)
            {
                res = obj.IsPaymentVerified;
            }
            return res;
        }
    }
}
