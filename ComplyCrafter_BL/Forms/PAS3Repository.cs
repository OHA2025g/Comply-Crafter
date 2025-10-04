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
    public interface IPAS3 : BaseInterface<PAS3, PAS3View>
    {
        bool ChangeActiveStatus(PAS3 obj);
        IEnumerable<PAS3View> GetByCompany(int id);
    }

    public class PAS3Repository : BaseRepository<PAS3, PAS3View>, IPAS3
    {
        const string SHARE_TABLE_NAME = "tbl_share";

        public new PAS3View GetById(int id = 0)
        {
            var dt = NpgSQL.Query(R.ConnectionString, $@"select * from {VIEW_NAME} where id = @id",
               new Dictionary<string, object>
               {
                    { "@id", id },
               }, ThrowError: true)
               .ParseList<PAS3View>().FirstOrDefault();
            if (dt != null)
            {
                dt.EquityShareList = GetCirculationList(id, "noOfClassesEquity");
                dt.PreferenceShareList = GetCirculationList(id, "noOfClassesPreference");
              
            }
            return dt;
        }
        public new PAS3 Save(PAS3 obj)
        {
            if (obj.Id > 0)
            {
                
                // NOTICE CIRCULATION
                var noticeCirculation = GetCirculationList(obj.Id, "noOfClassesEquity");
                var noticeCirculationTodelete = noticeCirculation.Where(x => (obj.EquityShareList == null || !obj.EquityShareList.Any(o => o.Id == x.Id)) && x.Id != 0).Select(x => x).ToList();
                noticeCirculationTodelete?.ToList().ForEach(child =>
                {
                    DeleteCirculation(child);
                });
                obj.EquityShareList?.ToList().ForEach(child =>
                {
                    child.Type = "noOfClassesEquity";
                    child.ParentId = obj.Id;
                    if (child.Id > 0)
                    {
                        child.UpdateIntoDB(R.ConnectionString, SHARE_TABLE_NAME, "id", child.Id);
                    }
                    else
                    {
                        child.Id = child.InsertIntoDBOutIdentity(R.ConnectionString, SHARE_TABLE_NAME, "id");
                    }
                });

                // DRAFT CIRCULATION
                var draftCirculation = GetCirculationList(obj.Id, "noOfClassesPreference");
                var draftCirculationTodelete = draftCirculation.Where(x => (obj.PreferenceShareList == null || !obj.PreferenceShareList.Any(o => o.Id == x.Id)) && x.Id != 0).Select(x => x).ToList();
                draftCirculationTodelete?.ToList().ForEach(child =>
                {
                    DeleteCirculation(child);
                });
                obj.PreferenceShareList?.ToList().ForEach(child =>
                {
                    child.Type = "noOfClassesPreference";
                    child.ParentId = obj.Id;
                    if (child.Id > 0)
                    {
                        child.UpdateIntoDB(R.ConnectionString, SHARE_TABLE_NAME, "id", child.Id);
                    }
                    else
                    {
                        child.Id = child.InsertIntoDBOutIdentity(R.ConnectionString, SHARE_TABLE_NAME, "id");
                    }
                });
            }
            else
            {
                obj.Id = obj.InsertIntoDBOutIdentity(R.ConnectionString, TABLE_NAME, "id");
                if (obj.Id == 0) return null;

           
                obj.EquityShareList?.ToList().ForEach(child =>
                {
                    child.Type = "noOfClassesEquity";
                    child.ParentId = obj.Id;
                    child.Id = child.InsertIntoDBOutIdentity(R.ConnectionString, SHARE_TABLE_NAME, "id");
                });
                obj.PreferenceShareList?.ToList().ForEach(child =>
                {
                    child.Type = "noOfClassesPreference";
                    child.ParentId = obj.Id;
                    child.Id = child.InsertIntoDBOutIdentity(R.ConnectionString, SHARE_TABLE_NAME, "id");
                });
               
            }
            return obj;
        }

        public IEnumerable<ShareChild> GetCirculationList(int id = 0, string type = "")
        {
            var dt = NpgSQL.Query(R.ConnectionString, $@"select * from {SHARE_TABLE_NAME} where type = @type and parent_id = @id and deleted_on IS NULL ORDER BY id",
               new Dictionary<string, object>
               {
                    { "@id", id },
                    { "@type", type },
               })
               .ParseList<ShareChild>();
            return dt;
        }
        public bool DeleteCirculation(ShareChild obj)
        {
            return NpgSQL.NonQuery(R.ConnectionString, $@"update {SHARE_TABLE_NAME} set deleted_on = @deleted_on where id = @id", new Dictionary<string, object>
            {
                { "@deleted_on", DateTime.Now },
                { "@id", obj.Id }
            }, ThrowError: true) > 0;
        }

        public bool ChangeActiveStatus(PAS3 obj)
        {
            return NpgSQL.NonQuery(R.ConnectionString, $@"update {TABLE_NAME} set is_active = @is_active where id = @id", new Dictionary<string, object>
            {
                { "@is_active", obj.IsActive },
                { "@id", obj.Id }
            }, ThrowError: true) > 0;
        }
        public IEnumerable<PAS3View> GetByCompany(int id)
        {
            var dt = NpgSQL.Query(R.ConnectionString, $@"select * from {VIEW_NAME} where company_id = @id",
             new Dictionary<string, object>
             {
                    { "@id", id },
             })
             .ParseList<PAS3View>();
            return dt;
        }
    }
}
