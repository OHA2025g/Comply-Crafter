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
    public interface ICHG8 : BaseInterface<CHG8, CHG8View>
    {
        bool ChangeActiveStatus(CHG8 obj);
        IEnumerable<CHG8View> GetByCompany(int id);
    }

    public class CHG8Repository : BaseRepository<CHG8, CHG8View>, ICHG8
    {
        public bool ChangeActiveStatus(CHG8 obj)
        {
            return NpgSQL.NonQuery(R.ConnectionString, $@"update {TABLE_NAME} set is_active = @is_active where id = @id", new Dictionary<string, object>
            {
                { "@is_active", obj.IsActive },
                { "@id", obj.Id }
            }, ThrowError: true) > 0;
        }
        public IEnumerable<CHG8View> GetByCompany(int id)
        {
            var dt = NpgSQL.Query(R.ConnectionString, $@"select * from {VIEW_NAME} where company_id = @id",
             new Dictionary<string, object>
             {
                    { "@id", id },
             })
             .ParseList<CHG8View>();
            return dt;
        }
    }
}
