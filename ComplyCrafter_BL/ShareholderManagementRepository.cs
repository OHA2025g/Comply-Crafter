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
    public interface IShareholderManagement: BaseInterface<ShareholderManagement, ShareholderManagementView>
    {
        bool ChangeActiveStatus(ShareholderManagement obj);
        IEnumerable<ShareholderManagementView> GetByCompany(int id);
    }
    public class ShareholderManagementRepository : BaseRepository<ShareholderManagement, ShareholderManagementView>, IShareholderManagement
    {
        const string OWNER_TABLE_NAME = "tbl_shareholder_management_owner";
        public new ShareholderManagementView GetById(int id = 0)
        {
            var dt = NpgSQL.Query(R.ConnectionString, $@"select * from {VIEW_NAME} where id = @id",
               new Dictionary<string, object>
               {
                    { "@id", id },
               }, ThrowError: true)
               .ParseList<ShareholderManagementView>().FirstOrDefault();
            if (dt != null)
            {
                dt.BeneList = GetOwnerList(id, "");
            }
            return dt;
        }
        public new ShareholderManagement Save(ShareholderManagement obj)
        {
            if (obj.Id > 0)
            {
                obj.UpdateIntoDB(R.ConnectionString, TABLE_NAME, "id", obj.Id);

                // Bene
                var a = GetOwnerList(obj.Id, "");
                var aTodelete = a.Where(x => (obj.BeneList == null || !obj.BeneList.Any(o => o.Id == x.Id)) && x.Id != 0).Select(x => x).ToList();
                aTodelete?.ToList().ForEach(child =>
                {
                    DeleteOwner(child);
                });
                obj.BeneList?.ToList().ForEach(child =>
                {
                    child.ParentId = obj.Id;
                    if (child.Id > 0)
                    {
                        child.UpdateIntoDB(R.ConnectionString, OWNER_TABLE_NAME, "id", child.Id);
                    }
                    else
                    {
                        child.Id = child.InsertIntoDBOutIdentity(R.ConnectionString, OWNER_TABLE_NAME, "id");
                    }
                });
            }
            else
            {
                obj.Id = obj.InsertIntoDBOutIdentity(R.ConnectionString, TABLE_NAME, "id");
                if (obj.Id == 0) return null;

                obj.BeneList?.ToList().ForEach(child =>
                {
                    child.ParentId = obj.Id;
                    child.Id = child.InsertIntoDBOutIdentity(R.ConnectionString, OWNER_TABLE_NAME, "id");
                });
            }
            return obj;
        }
        public IEnumerable<SHOwner> GetOwnerList(int id = 0, string type = "")
        {
            var dt = NpgSQL.Query(R.ConnectionString, $@"select * from {OWNER_TABLE_NAME} where parent_id = @id and deleted_on IS NULL ORDER BY id",
               new Dictionary<string, object>
               {
                    { "@id", id },
                    { "@type", type },
               })
               .ParseList<SHOwner>();
            return dt;
        }
        public bool DeleteOwner(SHOwner obj)
        {
            return NpgSQL.NonQuery(R.ConnectionString, $@"update {OWNER_TABLE_NAME} set deleted_on = @deleted_on where id = @id", new Dictionary<string, object>
            {
                { "@deleted_on", DateTime.Now },
                { "@id", obj.Id }
            }, ThrowError: true) > 0;
        }
        public bool ChangeActiveStatus(ShareholderManagement obj)
        {
            return NpgSQL.NonQuery(R.ConnectionString, $@"update {TABLE_NAME} set is_active = @is_active where id = @id", new Dictionary<string, object>
            {
                { "@is_active", obj.IsActive },
                { "@id", obj.Id }
            }, ThrowError: true) > 0;
        }
        public IEnumerable<ShareholderManagementView> GetByCompany(int id)
        {
            var dt = NpgSQL.Query(R.ConnectionString, $@"select * from {VIEW_NAME} where company_id = @id",
             new Dictionary<string, object>
             {
                    { "@id", id },
             })
             .ParseList<ShareholderManagementView>();
            return dt;
        }
    }
}
