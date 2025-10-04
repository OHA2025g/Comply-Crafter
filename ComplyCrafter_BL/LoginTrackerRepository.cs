using AlphaUtil.Core;
using ComplyCrafter_Data;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplyCrafter_BL
{
    public interface ILoginTracker
    {
        LoginTracker? GetByUserId(int userId);
        LoginTracker? Save(LoginTracker obj);
        bool Update(LoginTracker obj);
    }

    public class LoginTrackerRepository : ILoginTracker
    {
        private const string TABLE_NAME = "tbl_login_tracker";


        public LoginTracker? GetByUserId(int userId)
        {
            var dt = NpgSQL.Query(R.ConnectionString, $@"select * from {TABLE_NAME} where is_valid = true and user_id = @userId",
               new Dictionary<string, object>
               {
                    { "@userId", userId },
               }, ThrowError: true)
               .ParseList<LoginTracker>().FirstOrDefault();
            return dt;
        }

        public LoginTracker? Save(LoginTracker obj)
        {
            if (obj.Id == 0)
            {
                obj.Id = obj.InsertIntoDBOutIdentity(R.ConnectionString, TABLE_NAME, "Id");
                if (obj.UserId > 0)
                    return obj;
                return null;
            }
            else
                obj.UpdateIntoDB(R.ConnectionString, TABLE_NAME, "Id", obj.UserId);
            return obj;
        }

        public bool Update(LoginTracker obj)
        {
            //For first login with browser id null
            if(string.IsNullOrEmpty(obj.BrowserId))
            {
                var i = NpgSQL.NonQuery(R.ConnectionString, $@"update {TABLE_NAME} set is_valid = false, updated_on = now() where is_valid = true and user_id = @userId",
                   new Dictionary<string, object>
                   {
                    { "@userId", obj.UserId }
                   });
                return i > 0;
            }
            else
            {
                {
                    var i = NpgSQL.NonQuery(R.ConnectionString, $@"update {TABLE_NAME} set is_valid = false, updated_on = now() where is_valid = true and user_id = @userId and broswer_id = @BrowserId",
                       new Dictionary<string, object>
                       {
                    { "@userId", obj.UserId },
                    { "@BrowserId", obj.BrowserId }
                       });
                    return i > 0;
                }
            }
        }
    }
}
