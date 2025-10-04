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
    public interface IAuditor: BaseInterface<Auditor, AuditorView>
    {
        bool ChangeActiveStatus(Auditor obj);
        IEnumerable<AuditorPartner> GetPartners(int id = 0);
        IEnumerable<AuditorView> Gets(int companyId = 0);
    }

    public class AuditorRepository : BaseRepository<Auditor, AuditorView>, IAuditor
    {
        const string PARTNERS_TABLE_NAME = "tbl_auditor_partner";

        public IEnumerable<AuditorView> Gets(int companyId = 0)
        {
            if (companyId > 0)
            {
                var dt = NpgSQL.Query(R.ConnectionString, $@"select * from {VIEW_NAME} where company_id = @companyId;",
                   new Dictionary<string, object>
                   {
                    { "@companyId", companyId },
                   }, ThrowError: true)
                   .ParseList<AuditorView>().ToList();

                return dt;
            }
            else
            {   
                var dt = NpgSQL.Query(R.ConnectionString, $@"select * from {VIEW_NAME};",
                   new Dictionary<string, object>
                   {
                   }, ThrowError: true)
                   .ParseList<AuditorView>().ToList();
                return dt;
            }
        }

        public new AuditorView GetById(int id = 0)
        {
            var dt = NpgSQL.Query(R.ConnectionString, $@"select * from {VIEW_NAME} where id = @id",
               new Dictionary<string, object>
               {
                    { "@id", id },
               }, ThrowError: true)
               .ParseList<AuditorView>().FirstOrDefault();
            if (dt != null)
            {
                dt.Partners = GetPartners(id);
            }
            return dt;
        }

        public IEnumerable<AuditorPartner> GetPartners(int id = 0)
        {
            var dt = NpgSQL.Query(R.ConnectionString, $@"select * from {PARTNERS_TABLE_NAME} where auditor = @id",
               new Dictionary<string, object>
               {
                    { "@id", id },
               })
               .ParseList<AuditorPartner>();
            return dt;
        }

        public new Auditor Save(Auditor obj)
        {
            if (obj.Id > 0)
            {
                obj.UpdateIntoDB(R.ConnectionString, TABLE_NAME, "id", obj.Id);
                //var obj1 = GetById(obj.Id);
                obj.Partners?.ToList().ForEach(partner =>
                {
                    if (partner.Id > 0)
                    {
                        partner.UpdateIntoDB(R.ConnectionString, PARTNERS_TABLE_NAME, "id", partner.Id);
                    }
                    else {
                        partner.Auditor = obj.Id;
                        partner.Id = partner.InsertIntoDBOutIdentity(R.ConnectionString, PARTNERS_TABLE_NAME, "id");
                    }
                });
            }
            else
            {
                obj.Id = obj.InsertIntoDBOutIdentity(R.ConnectionString, TABLE_NAME, "id");
                if (obj.Id == 0) return null;

                obj.Partners?.ToList().ForEach(partner =>
                {
                    partner.Auditor = obj.Id;
                    partner.Id = partner.InsertIntoDBOutIdentity(R.ConnectionString, PARTNERS_TABLE_NAME, "id");
                });
            }
            return obj;
        }


        public new bool Delete(Auditor obj)
        {
            return NpgSQL.NonQuery(R.ConnectionString, $@"update {TABLE_NAME} set deleted_on = @deleted_on where id = @id", new Dictionary<string, object>
            {
                { "@deleted_on", DateTime.Now },
                { "@id", obj.Id }
            }, ThrowError: true) > 0;
        }

        public bool DeletePartner(AuditorPartner obj)
        {
            return NpgSQL.NonQuery(R.ConnectionString, $@"update {PARTNERS_TABLE_NAME} set deleted_on = @deleted_on where id = @id", new Dictionary<string, object>
            {
                { "@deleted_on", DateTime.Now },
                { "@id", obj.Id }
            }, ThrowError: true) > 0;
        }
        public bool ChangeActiveStatus(Auditor obj)
        {
            return NpgSQL.NonQuery(R.ConnectionString, $@"update {TABLE_NAME} set is_active = @is_active where id = @id", new Dictionary<string, object>
            {
                { "@is_active", obj.IsActive },
                { "@id", obj.Id }
            }, ThrowError: true) > 0;
        }
    }
}
