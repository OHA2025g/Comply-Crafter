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
    public interface IMGT7A : BaseInterface<MGT7A, MGT7AView>
    {
        bool ChangeActiveStatus(MGT7A obj);
        IEnumerable<MGT7AView> GetByCompany(int id);
    }

    public class MGT7ARepository : BaseRepository<MGT7A, MGT7AView>, IMGT7A
    {
        public bool ChangeActiveStatus(MGT7A obj)
        {
            return NpgSQL.NonQuery(R.ConnectionString, $@"update {TABLE_NAME} set is_active = @is_active where id = @id", new Dictionary<string, object>
            {
                { "@is_active", obj.IsActive },
                { "@id", obj.Id }
            }, ThrowError: true) > 0;
        }
        public IEnumerable<MGT7AView> GetByCompany(int id)
        {
            var dt = NpgSQL.Query(R.ConnectionString, $@"select * from {VIEW_NAME} where company_id = @id",
             new Dictionary<string, object>
             {
                    { "@id", id },
             })
             .ParseList<MGT7AView>();
            return dt;
        }
    }
}
