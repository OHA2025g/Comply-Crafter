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
    public interface IGNL1 : BaseInterface<GNL1, GNL1View>
    {
        bool ChangeActiveStatus(GNL1 obj);
        IEnumerable<GNL1View> GetByCompany(int id);
    }

    public class GNL1Repository : BaseRepository<GNL1, GNL1View>, IGNL1
    {
        public bool ChangeActiveStatus(GNL1 obj)
        {
            return NpgSQL.NonQuery(R.ConnectionString, $@"update {TABLE_NAME} set is_active = @is_active where id = @id", new Dictionary<string, object>
            {
                { "@is_active", obj.IsActive },
                { "@id", obj.Id }
            }, ThrowError: true) > 0;
        }
        public IEnumerable<GNL1View> GetByCompany(int id)
        {
            var dt = NpgSQL.Query(R.ConnectionString, $@"select * from {VIEW_NAME} where company_id = @id",
             new Dictionary<string, object>
             {
                    { "@id", id },
             })
             .ParseList<GNL1View>();
            return dt;
        }
    }
}
