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
    public interface ICompanyNotice : BaseInterface<CompanyNotice, CompanyNoticeView>
    {
        bool ChangeActiveStatus(CompanyNotice obj);
        IEnumerable<CompanyNoticeView> GetByCompany(int id);

    }

    public class CompanyNoticeRepository : BaseRepository<CompanyNotice, CompanyNoticeView>, ICompanyNotice
    {
        public bool ChangeActiveStatus(CompanyNotice obj)
        {
            return NpgSQL.NonQuery(R.ConnectionString, $@"update {TABLE_NAME} set is_active = @is_active where id = @id", new Dictionary<string, object>
            {
                { "@is_active", obj.IsActive },
                { "@id", obj.Id }
            }, ThrowError: true) > 0;
        }
        public IEnumerable<CompanyNoticeView> GetByCompany(int id)
        {
            var dt = NpgSQL.Query(R.ConnectionString, $@"select * from {VIEW_NAME} where company_id = @id",
             new Dictionary<string, object>
             {
                    { "@id", id },
             })
             .ParseList<CompanyNoticeView>();
            return dt;
        }
        public new bool Delete(CompanyNotice obj)
        {
            return NpgSQL.NonQuery(R.ConnectionString, $@"update {TABLE_NAME} set deleted_on = @deleted_on where id = @id", new Dictionary<string, object>
            {
                { "@deleted_on", DateTime.Now },
                { "@id", obj.Id }
            }, ThrowError: true) > 0;
        }
    }
}
