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
    public interface IRUNLLP : BaseInterface<RUNLLP, RUNLLPView>
    {
        bool ChangeActiveStatus(RUNLLP obj);
        IEnumerable<RUNLLPView> GetByCompany(int id);
    }

    public class RUNLLPRepository : BaseRepository<RUNLLP, RUNLLPView>, IRUNLLP
    {
        public bool ChangeActiveStatus(RUNLLP obj)
        {
            return NpgSQL.NonQuery(R.ConnectionString, $@"update {TABLE_NAME} set is_active = @is_active where id = @id", new Dictionary<string, object>
            {
                { "@is_active", obj.IsActive },
                { "@id", obj.Id }
            }, ThrowError: true) > 0;
        }
        public IEnumerable<RUNLLPView> GetByCompany(int id)
        {
            var dt = NpgSQL.Query(R.ConnectionString, $@"select * from {VIEW_NAME} where company_id = @id",
             new Dictionary<string, object>
             {
                    { "@id", id },
             })
             .ParseList<RUNLLPView>();
            return dt;
        }
    }
}
