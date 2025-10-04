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
    public interface ISH7 : BaseInterface<SH7, SH7View>
    {
        bool ChangeActiveStatus(SH7 obj);
        IEnumerable<SH7View> GetByCompany(int id);
    }

    public class SH7Repository : BaseRepository<SH7, SH7View>, ISH7
    {
        const string SHARE_TABLE_NAME = "tbl_sh7_share";
        const string STRUCTURE_TABLE_NAME = "tbl_sh7_structure";

        public new SH7View GetById(int id = 0)
        {
            var dt = NpgSQL.Query(R.ConnectionString, $@"select * from {VIEW_NAME} where id = @id",
               new Dictionary<string, object>
               {
                    { "@id", id },
               }, ThrowError: true)
               .ParseList<SH7View>().FirstOrDefault();
            if (dt != null)
            {
                dt.Shares = GetShares(id);
                dt.ExistingStructure = GetStructure(id,"existing");
                dt.RevisedStructure = GetStructure(id, "revised");
            }
            return dt;
        }
        public new SH7 Save(SH7 obj)
        {
            if (obj.Id > 0)
            {
                obj.UpdateIntoDB(R.ConnectionString, TABLE_NAME, "id", obj.Id);
                var existingShares = GetShares(obj.Id);
                var shareTodelete = existingShares.Where(share => (obj.Shares == null || !obj.Shares.Any(o => o.Id == share.Id)) && share.Id != 0).Select(share => share).ToList();
                shareTodelete?.ToList().ForEach(child =>
                {
                    DeleteShare(child);
                });
                obj.Shares?.ToList().ForEach(child =>
                {
                    if (child.Id > 0)
                    {
                        child.UpdateIntoDB(R.ConnectionString, SHARE_TABLE_NAME, "id", child.Id);
                    }
                    else
                    {
                        child.ParentId = obj.Id;
                        child.Id = child.InsertIntoDBOutIdentity(R.ConnectionString, SHARE_TABLE_NAME, "id");
                    }
                });

                // existing
                var existingStructure= GetStructure(obj.Id,"existing");
                var existingStructureTodelete = existingStructure.Where(x => (obj.ExistingStructure == null || !obj.ExistingStructure.Any(o => o.Id == x.Id)) && x.Id != 0).Select(x => x).ToList();
                existingStructureTodelete?.ToList().ForEach(child =>
                {
                    DeleteStructure(child);
                });
                obj.ExistingStructure?.ToList().ForEach(child =>
                {
                    child.Type = "existing";
                    if (child.Id > 0)
                    {
                        child.UpdateIntoDB(R.ConnectionString, STRUCTURE_TABLE_NAME, "id", child.Id);
                    }
                    else
                    {
                        child.ParentId = obj.Id;
                        child.Id = child.InsertIntoDBOutIdentity(R.ConnectionString, STRUCTURE_TABLE_NAME, "id");
                    }
                });

                // revised
                var revisedStructure = GetStructure(obj.Id, "revised");
                var revisedStructureTodelete = revisedStructure.Where(x => (obj.RevisedStructure == null || !obj.RevisedStructure.Any(o => o.Id == x.Id)) && x.Id != 0).Select(x => x).ToList();
                revisedStructureTodelete?.ToList().ForEach(child =>
                {
                    DeleteStructure(child);
                });
                obj.RevisedStructure?.ToList().ForEach(child =>
                {
                    child.Type = "revised";
                    if (child.Id > 0)
                    {
                        child.UpdateIntoDB(R.ConnectionString, STRUCTURE_TABLE_NAME, "id", child.Id);
                    }
                    else
                    {
                        child.ParentId = obj.Id;
                        child.Id = child.InsertIntoDBOutIdentity(R.ConnectionString, STRUCTURE_TABLE_NAME, "id");
                    }
                });


            }
            else
            {
                obj.Id = obj.InsertIntoDBOutIdentity(R.ConnectionString, TABLE_NAME, "id");
                if (obj.Id == 0) return null;

                obj.Shares?.ToList().ForEach(child =>
                {
                    child.ParentId = obj.Id;
                    child.Id = child.InsertIntoDBOutIdentity(R.ConnectionString, SHARE_TABLE_NAME, "id");
                });
                obj.ExistingStructure?.ToList().ForEach(child =>
                {
                    child.Type = "existing";
                    child.ParentId = obj.Id;
                    child.Id = child.InsertIntoDBOutIdentity(R.ConnectionString, STRUCTURE_TABLE_NAME, "id");
                });
                obj.RevisedStructure?.ToList().ForEach(child =>
                {
                    child.Type = "revised";
                    child.ParentId = obj.Id;
                    child.Id = child.InsertIntoDBOutIdentity(R.ConnectionString, STRUCTURE_TABLE_NAME, "id");
                });
            }
            return obj;
        }

        public IEnumerable<SH7Share> GetShares(int id = 0)
        {
            var dt = NpgSQL.Query(R.ConnectionString, $@"select * from {SHARE_TABLE_NAME} where parent_id = @id and deleted_on IS NULL ORDER BY id",
               new Dictionary<string, object>
               {
                    { "@id", id },
               })
               .ParseList<SH7Share>();
            return dt;
        }
        public bool DeleteShare(SH7Share obj)
        {
            return NpgSQL.NonQuery(R.ConnectionString, $@"update {SHARE_TABLE_NAME} set deleted_on = @deleted_on where id = @id", new Dictionary<string, object>
            {
                { "@deleted_on", DateTime.Now },
                { "@id", obj.Id }
            }, ThrowError: true) > 0;
        }

        public IEnumerable<SH7Structure> GetStructure(int id = 0, string type= "")
        {
            var dt = NpgSQL.Query(R.ConnectionString, $@"select * from {STRUCTURE_TABLE_NAME} where type = @type and parent_id = @id and deleted_on IS NULL ORDER BY id",
               new Dictionary<string, object>
               {
                    { "@id", id },
                    { "@type", type },
               })
               .ParseList<SH7Structure>();
            return dt;
        }
        public bool DeleteStructure(SH7Structure obj)
        {
            return NpgSQL.NonQuery(R.ConnectionString, $@"update {STRUCTURE_TABLE_NAME} set deleted_on = @deleted_on where id = @id", new Dictionary<string, object>
            {
                { "@deleted_on", DateTime.Now },
                { "@id", obj.Id }
            }, ThrowError: true) > 0;
        }

        public bool ChangeActiveStatus(SH7 obj)
        {
            return NpgSQL.NonQuery(R.ConnectionString, $@"update {TABLE_NAME} set is_active = @is_active where id = @id", new Dictionary<string, object>
            {
                { "@is_active", obj.IsActive },
                { "@id", obj.Id }
            }, ThrowError: true) > 0;
        }
        public IEnumerable<SH7View> GetByCompany(int id)
        {
            var dt = NpgSQL.Query(R.ConnectionString, $@"select * from {VIEW_NAME} where company_id = @id",
             new Dictionary<string, object>
             {
                    { "@id", id },
             })
             .ParseList<SH7View>();
            return dt;
        }
    }
}
