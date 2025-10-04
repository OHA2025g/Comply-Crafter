using AlphaUtil.Core;
using AlphaUtil.Core.Models;
using ComplyCrafter_Data;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Net.Http.Json;
using System.Threading.Channels;
using static QRCoder.PayloadGenerator;

namespace ComplyCrafter_BL
{
    public interface ISTK2 : BaseInterface<STK2, STK2View>
    {
        bool ChangeActiveStatus(STK2 obj);
        IEnumerable<STK2View> GetByCompany(int id);
    }

    public class STK2Repository : BaseRepository<STK2, STK2View>, ISTK2
    {
        const string LITIGATION_TABLE_NAME = "tbl_litigation";
        public new STK2View GetById(int id = 0)
        {
            var dt = NpgSQL.Query(R.ConnectionString, $@"select * from {VIEW_NAME} where id = @id",
               new Dictionary<string, object>
               {
                    { "@id", id },
               }, ThrowError: true)
               .ParseList<STK2View>().FirstOrDefault();
            if (dt != null)
            {
                dt.LitigationList = GetSpecialInviteeList(id);
              
            }
            return dt;
        }
        public new STK2 Save(STK2 obj)
        {
            if (obj.Id > 0)
            {
                obj.UpdateIntoDB(R.ConnectionString, TABLE_NAME, "id", obj.Id);

                // SPECIAL_INVITEE
                var existingSpecialInvitee = GetSpecialInviteeList(obj.Id);
                var specialInviteeTodelete = existingSpecialInvitee.Where(d => (obj.LitigationList == null || !obj.LitigationList.Any(o => o.Id == d.Id)) && d.Id != 0).Select(d => d).ToList();
                specialInviteeTodelete?.ToList().ForEach(child =>
                {
                    DeleteSpecialInvitee(child);
                });
                obj.LitigationList?.ToList().ForEach(child =>
                {
                    if (child.Id > 0)
                    {
                        child.UpdateIntoDB(R.ConnectionString, LITIGATION_TABLE_NAME, "id", child.Id);
                    }
                    else
                    {
                        child.ParentId = obj.Id;
                        child.Id = child.InsertIntoDBOutIdentity(R.ConnectionString, LITIGATION_TABLE_NAME, "id");
                    }
                });

              
            }
            else
            {
                obj.Id = obj.InsertIntoDBOutIdentity(R.ConnectionString, TABLE_NAME, "id");
                if (obj.Id == 0) return null;

                obj.LitigationList?.ToList().ForEach(child =>
                {
                    child.ParentId = obj.Id;
                    child.Id = child.InsertIntoDBOutIdentity(R.ConnectionString, LITIGATION_TABLE_NAME, "id");
                });

             
            }
            return obj;
        }

        public IEnumerable<LitigationChild> GetSpecialInviteeList(int id = 0)
        {
            var dt = NpgSQL.Query(R.ConnectionString, $@"select * from {LITIGATION_TABLE_NAME} where parent_id = @id and deleted_on IS NULL ORDER BY id",
               new Dictionary<string, object>
               {
                    { "@id", id },
               })
               .ParseList<LitigationChild>();
            return dt;
        }
        public bool DeleteSpecialInvitee(LitigationChild obj)
        {
            return NpgSQL.NonQuery(R.ConnectionString, $@"update {LITIGATION_TABLE_NAME} set deleted_on = @deleted_on where id = @id", new Dictionary<string, object>
            {
                { "@deleted_on", DateTime.Now },
                { "@id", obj.Id }
            }, ThrowError: true) > 0;
        }
        public bool ChangeActiveStatus(STK2 obj)
        {
            return NpgSQL.NonQuery(R.ConnectionString, $@"update {TABLE_NAME} set is_active = @is_active where id = @id", new Dictionary<string, object>
            {
                { "@is_active", obj.IsActive },
                { "@id", obj.Id }
            }, ThrowError: true) > 0;
        }
        public IEnumerable<STK2View> GetByCompany(int id)
        {
            var dt = NpgSQL.Query(R.ConnectionString, $@"select * from {VIEW_NAME} where company_id = @id",
             new Dictionary<string, object>
             {
                    { "@id", id },
             })
             .ParseList<STK2View>();
            return dt;
        }
    }
}
