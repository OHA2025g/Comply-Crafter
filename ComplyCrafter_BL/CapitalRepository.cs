using AlphaUtil.Core;
using AlphaUtil.Core.Models;
using BunnyCDN.Net.Storage;
using ComplyCrafter_Data;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Net;
using System.Net.Http.Json;
using System.Threading.Channels;
using static QRCoder.PayloadGenerator;

namespace ComplyCrafter_BL
{
    public interface ICapital: BaseInterface<Capital, CapitalView>
    {
        bool ChangeActiveStatus(Capital obj);
        IEnumerable<CapitalView> GetByCompanyAndType(int id, string type);
        decimal? GetSumOfTotalCapital(string type, int cid, int id = 0);
    }
    public class CapitalRepository : BaseRepository<Capital, CapitalView>, ICapital
    {
        const string CHILD_TABLE_NAME = "tbl_capital_child";
        public new CapitalView GetById(int id = 0)
        {
            var dt = NpgSQL.Query(R.ConnectionString, $@"select * from {VIEW_NAME} where id = @id",
               new Dictionary<string, object>
               {
                    { "@id", id },
               }, ThrowError: true)
               .ParseList<CapitalView>().FirstOrDefault();
            if (dt != null)
            {
                dt.EquityList = GetChildList(id, "e");
                dt.PreferenceList = GetChildList(id, "p");
            }
            return dt;
        }
        public new Capital Save(Capital obj)
        {
            if (obj.Id > 0)
            {
                obj.UpdateIntoDB(R.ConnectionString, TABLE_NAME, "id", obj.Id);

                // Equity
                var equity = GetChildList(obj.Id, "e");
                var equityTodelete = equity.Where(x => (obj.EquityList == null || !obj.EquityList.Any(o => o.Id == x.Id)) && x.Id != 0).Select(x => x).ToList();
                equityTodelete?.ToList().ForEach(child =>
                {
                    DeleteChild(child);
                });
                obj.EquityList?.ToList().ForEach(child =>
                {
                    child.ChildType = "e";
                    child.ParentId = obj.Id;
                    if (child.Id > 0)
                    {
                        child.UpdateIntoDB(R.ConnectionString, CHILD_TABLE_NAME, "id", child.Id);
                    }
                    else
                    {
                        child.Id = child.InsertIntoDBOutIdentity(R.ConnectionString, CHILD_TABLE_NAME, "id");
                    }
                });

                // Preference
                var preference = GetChildList(obj.Id, "p");
                var preferenceTodelete = preference.Where(x => (obj.PreferenceList == null || !obj.PreferenceList.Any(o => o.Id == x.Id)) && x.Id != 0).Select(x => x).ToList();
                preferenceTodelete?.ToList().ForEach(child =>
                {
                    DeleteChild(child);
                });
                obj.PreferenceList?.ToList().ForEach(child =>
                {
                    child.ChildType = "p";
                    child.ParentId = obj.Id;
                    if (child.Id > 0)
                    {
                        child.UpdateIntoDB(R.ConnectionString, CHILD_TABLE_NAME, "id", child.Id);
                    }
                    else
                    {
                        child.Id = child.InsertIntoDBOutIdentity(R.ConnectionString, CHILD_TABLE_NAME, "id");
                    }
                });


            }
            else
            {
                obj.Id = obj.InsertIntoDBOutIdentity(R.ConnectionString, TABLE_NAME, "id");
                if (obj.Id == 0) return null;

                obj.EquityList?.ToList().ForEach(child =>
                {
                    child.ChildType = "e";
                    child.ParentId = obj.Id;
                    child.Id = child.InsertIntoDBOutIdentity(R.ConnectionString, CHILD_TABLE_NAME, "id");
                });
                obj.PreferenceList?.ToList().ForEach(child =>
                {
                    child.ChildType = "p";
                    child.ParentId = obj.Id;
                    child.Id = child.InsertIntoDBOutIdentity(R.ConnectionString, CHILD_TABLE_NAME, "id");
                });
            }
            return obj;
        }
        public IEnumerable<CapitalChild> GetChildList(int id = 0, string type = "")
        {
            var dt = NpgSQL.Query(R.ConnectionString, $@"select * from {CHILD_TABLE_NAME} where child_type = @type and parent_id = @id and deleted_on IS NULL ORDER BY id",
               new Dictionary<string, object>
               {
                    { "@id", id },
                    { "@type", type },
               })
               .ParseList<CapitalChild>();
            return dt;
        }
        public bool DeleteChild(CapitalChild obj)
        {
            return NpgSQL.NonQuery(R.ConnectionString, $@"update {CHILD_TABLE_NAME} set deleted_on = @deleted_on where id = @id", new Dictionary<string, object>
            {
                { "@deleted_on", DateTime.Now },
                { "@id", obj.Id }
            }, ThrowError: true) > 0;
        }
        public bool ChangeActiveStatus(Capital obj)
        {
            return NpgSQL.NonQuery(R.ConnectionString, $@"update {TABLE_NAME} set is_active = @is_active where id = @id", new Dictionary<string, object>
            {
                { "@is_active", obj.IsActive },
                { "@id", obj.Id }
            }, ThrowError: true) > 0;
        }
        public IEnumerable<CapitalView> GetByCompanyAndType(int id, string type)
        {
            var dt = NpgSQL.Query(R.ConnectionString, $@"select * from {VIEW_NAME} where company_id = @id and type = @type",
             new Dictionary<string, object>
             {
                    { "@id", id },
                    { "@type", type },
             })
             .ParseList<CapitalView>();
            return dt;
        }
        public decimal? GetSumOfTotalCapital(string type,int cid, int id = 0) {
            var dt = NpgSQL.Query(R.ConnectionString, $@"select Coalesce(Sum(total_capital), 0) from {TABLE_NAME} where company_id = @cid and type = @type and deleted_on is null and id != @id;",
                 new Dictionary<string, object>
                 {
                    { "@id", id },
                    { "@cid", cid },
                    { "@type", type },
                 });
            return (decimal) dt.Rows[0][0];
        }
    }
}
