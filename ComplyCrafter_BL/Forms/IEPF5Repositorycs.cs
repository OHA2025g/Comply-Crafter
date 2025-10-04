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
    public interface IIEPF5 : BaseInterface<IEPF5, IEPF5View>
    {
        bool ChangeActiveStatus(IEPF5 obj);
        IEnumerable<IEPF5View> GetByCompany(int id);
    }

    public class IEPF5Repository : BaseRepository<IEPF5, IEPF5View>, IIEPF5
    {
        public bool ChangeActiveStatus(IEPF5 obj)
        {
            return NpgSQL.NonQuery(R.ConnectionString, $@"update {TABLE_NAME} set is_active = @is_active where id = @id", new Dictionary<string, object>
            {
                { "@is_active", obj.IsActive },
                { "@id", obj.Id }
            }, ThrowError: true) > 0;
        }
        public IEnumerable<IEPF5View> GetByCompany(int id)
        {
            var dt = NpgSQL.Query(R.ConnectionString, $@"select * from {VIEW_NAME} where company_id = @id",
             new Dictionary<string, object>
             {
                    { "@id", id },
             })
             .ParseList<IEPF5View>();
            return dt;
        }
    }
}
