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
    public interface IIEPF2 : BaseInterface<IEPF2, IEPF2View>
    {
        bool ChangeActiveStatus(IEPF2 obj);
        IEnumerable<IEPF2View> GetByCompany(int id);
    }

    public class IEPF2Repository : BaseRepository<IEPF2, IEPF2View>, IIEPF2
    {
        public bool ChangeActiveStatus(IEPF2 obj)
        {
            return NpgSQL.NonQuery(R.ConnectionString, $@"update {TABLE_NAME} set is_active = @is_active where id = @id", new Dictionary<string, object>
            {
                { "@is_active", obj.IsActive },
                { "@id", obj.Id }
            }, ThrowError: true) > 0;
        }
        public IEnumerable<IEPF2View> GetByCompany(int id)
        {
            var dt = NpgSQL.Query(R.ConnectionString, $@"select * from {VIEW_NAME} where company_id = @id",
             new Dictionary<string, object>
             {
                    { "@id", id },
             })
             .ParseList<IEPF2View>();
            return dt;
        }
    }
}
