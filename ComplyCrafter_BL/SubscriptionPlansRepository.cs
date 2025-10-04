using AlphaUtil.Core;
using ComplyCrafter_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplyCrafter_BL
{
    public interface ISubscriptionPlans
    {
        IEnumerable<SubscriptionPlans> Get();
        IEnumerable<SubscriptionPlans> GetList();

        SubscriptionPlans? GetById(int id);

        SubscriptionPlans? Save(SubscriptionPlans obj);
    }

    public class SubscriptionPlansRepository : ISubscriptionPlans
    {
        private const string TABLE_NAME = "tbl_subscription_plans";
        private const string VIEW_NAME = "vw_subscription_plans";

        public IEnumerable<SubscriptionPlans> Get()
        {
            var dt = NpgSQL.Query(R.ConnectionString, $@"select * from {VIEW_NAME}", ThrowError: true)
                .ParseList<SubscriptionPlans>();
            return dt;
        }

        public IEnumerable<SubscriptionPlans> GetList()
        {
            var dt = NpgSQL.Query(R.ConnectionString, $@"select * from {VIEW_NAME} where id > 1;", ThrowError: true)
                .ParseList<SubscriptionPlans>();
            return dt;
        }

        public SubscriptionPlans? GetById(int id = 0)
        {
            var dt = NpgSQL.Query(R.ConnectionString, $@"select * from {VIEW_NAME} where id = @id",
               new Dictionary<string, object>
               {
                    { "@id", id },
               }, ThrowError: true)
               .ParseList<SubscriptionPlans>().FirstOrDefault();
            return dt;
        }

        public SubscriptionPlans? Save(SubscriptionPlans obj)
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
    }
}
