using AlphaUtil.Core;
using BunnyCDN.Net.Storage;
using ComplyCrafter_Data;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http.Json;
using System.Threading.Channels;
using static QRCoder.PayloadGenerator;

namespace ComplyCrafter_BL
{
    public interface IOtherAuditor: BaseInterface<OtherAuditor, OtherAuditorView>
    {
        bool ChangeActiveStatus(OtherAuditor obj);
        IEnumerable<OtherAuditorView> Gets(int companyId = 0, string stype = "");
    }

    public class OtherAuditorRepository : BaseRepository<OtherAuditor, OtherAuditorView>, IOtherAuditor
    {
        public new OtherAuditorView GetById(int id = 0)
        {
            var dt = NpgSQL.Query(R.ConnectionString, $@"select * from {VIEW_NAME} where id = @id",
               new Dictionary<string, object>
               {
                    { "@id", id },
               }, ThrowError: true)
               .ParseList<OtherAuditorView>().FirstOrDefault();
            return dt;
        }


        public new OtherAuditor Save(OtherAuditor obj)
        {
            if (obj.Id > 0)
            {
                obj.UpdateIntoDB(R.ConnectionString, TABLE_NAME, "id", obj.Id);
            }
            else
            {
                obj.Id = obj.InsertIntoDBOutIdentity(R.ConnectionString, TABLE_NAME, "id");
                if (obj.Id == 0) return null;
            }
            return obj;
        }


        public new bool Delete(OtherAuditor obj)
        {
            return NpgSQL.NonQuery(R.ConnectionString, $@"update {TABLE_NAME} set deleted_on = @deleted_on where id = @id", new Dictionary<string, object>
            {
                { "@deleted_on", DateTime.Now },
                { "@id", obj.Id }
            }, ThrowError: true) > 0;
        }
        public bool ChangeActiveStatus(OtherAuditor obj)
        {
            return NpgSQL.NonQuery(R.ConnectionString, $@"update {TABLE_NAME} set is_active = @is_active where id = @id", new Dictionary<string, object>
            {
                { "@is_active", obj.IsActive },
                { "@id", obj.Id }
            }, ThrowError: true) > 0;
        }

        public IEnumerable<OtherAuditorView> Gets(int companyId = 0, string stype = "")
        {
            if (companyId > 0)
            {
                var dt = NpgSQL.Query(R.ConnectionString, $@"select * from {VIEW_NAME} where company_id = @companyId and type=@type;",
                   new Dictionary<string, object>
                   {
                    { "@companyId", companyId },
                    { "@type", stype },
                   }, ThrowError: true)
                   .ParseList<OtherAuditorView>().ToList();

                return dt;
            }
            else
            {
                var dt = NpgSQL.Query(R.ConnectionString, $@"select * from {VIEW_NAME} where type=@type;",
                   new Dictionary<string, object>
                   {
                    { "@type", stype },
                   }, ThrowError: true)
                   .ParseList<OtherAuditorView>().ToList();
                return dt;
            }
        }
    }
}
