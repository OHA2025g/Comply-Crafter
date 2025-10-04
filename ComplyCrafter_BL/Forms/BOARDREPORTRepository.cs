using AlphaUtil.Core;
using AlphaUtil.Core.Models;
using ComplyCrafter_Data;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Net;
using System.Net.Http.Json;
using System.Threading.Channels;
using static QRCoder.PayloadGenerator;

namespace ComplyCrafter_BL
{
    public interface IBOARDREPORT : BaseInterface<BOARDREPORT, BOARDREPORTView>
    {
        bool ChangeActiveStatus(BOARDREPORT obj);
        IEnumerable<BOARDREPORTView> GetByCompany(int id);
    }

    public class BOARDREPORTRepository : BaseRepository<BOARDREPORT, BOARDREPORTView>, IBOARDREPORT
    {
        public bool ChangeActiveStatus(BOARDREPORT obj)
        {
            return NpgSQL.NonQuery(R.ConnectionString, $@"update {TABLE_NAME} set is_active = @is_active where id = @id", new Dictionary<string, object>
            {
                { "@is_active", obj.IsActive },
                { "@id", obj.Id }
            }, ThrowError: true) > 0;
        }
        public IEnumerable<BOARDREPORTView> GetByCompany(int id)
        {
            var dt = NpgSQL.Query(R.ConnectionString, $@"select * from {VIEW_NAME} where company_id = @id",
             new Dictionary<string, object>
             {
                    { "@id", id },
             })
             .ParseList<BOARDREPORTView>();
            return dt;
        }
    }
}
