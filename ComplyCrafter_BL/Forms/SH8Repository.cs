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
    public interface ISH8 : BaseInterface<SH8, SH8View>
    {
        bool ChangeActiveStatus(SH8 obj);
        IEnumerable<SH8View> GetByCompany(int id);
    }

    public class SH8Repository : BaseRepository<SH8, SH8View>, ISH8
    {
        public bool ChangeActiveStatus(SH8 obj)
        {
            return NpgSQL.NonQuery(R.ConnectionString, $@"update {TABLE_NAME} set is_active = @is_active where id = @id", new Dictionary<string, object>
            {
                { "@is_active", obj.IsActive },
                { "@id", obj.Id }
            }, ThrowError: true) > 0;
        }
        public IEnumerable<SH8View> GetByCompany(int id)
        {
            var dt = NpgSQL.Query(R.ConnectionString, $@"select * from {VIEW_NAME} where company_id = @id",
             new Dictionary<string, object>
             {
                    { "@id", id },
             })
             .ParseList<SH8View>();
            return dt;
        }
    }
}
