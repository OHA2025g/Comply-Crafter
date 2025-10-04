using AlphaUtil.Core;
using ComplyCrafter_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplyCrafter_BL
{
    public interface IEmailTracker
    {
        EmailTracker? Save(EmailTracker obj);
    }
    public class EmailTrackerRepository : IEmailTracker
    {
        private const string TABLE_NAME = "tbl_email_tracker";
        public EmailTracker? Save(EmailTracker obj)
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
