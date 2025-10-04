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
    public interface IActionChangeOfficeAddress : BaseInterface<ChangeOfficeAddress, ChangeOfficeAddress>
    {
        bool ChangeActiveStatus(ChangeOfficeAddress obj);
        IEnumerable<ChangeOfficeAddress> GetByCompany(int id);
    }

    public class ActionChangeOfficeAddressRepository : BaseRepository<ChangeOfficeAddress, ChangeOfficeAddress>, IActionChangeOfficeAddress
    {
        public bool ChangeActiveStatus(ChangeOfficeAddress obj)
        {
            return NpgSQL.NonQuery(R.ConnectionString, $@"update {TABLE_NAME} set is_active = @is_active where id = @id", new Dictionary<string, object>
            {
                { "@is_active", obj.IsActive },
                { "@id", obj.Id }
            }, ThrowError: true) > 0;
        }
        public IEnumerable<ChangeOfficeAddress> GetByCompany(int id)
        {
            var dt = NpgSQL.Query(R.ConnectionString, $@"select * from {VIEW_NAME} where company_id = @id",
             new Dictionary<string, object>
             {
                    { "@id", id },
             })
             .ParseList<ChangeOfficeAddress>();
            return dt;
        }
    }
}
