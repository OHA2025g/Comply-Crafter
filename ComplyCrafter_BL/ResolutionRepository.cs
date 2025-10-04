using AlphaUtil.Core;
using BunnyCDN.Net.Storage;
using ComplyCrafter_Data;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http.Json;
using System.Threading.Channels;
using static QRCoder.PayloadGenerator;

namespace ComplyCrafter_BL
{
    public interface IResolution: BaseInterface<Resolution, ResolutionView>
    {
        bool ChangeActiveStatus(Resolution obj);
    }

    public class ResolutionRepository : BaseRepository<Resolution, ResolutionView>, IResolution
    {
        public bool ChangeActiveStatus(Resolution obj)
        {
            return NpgSQL.NonQuery(R.ConnectionString, $@"update {TABLE_NAME} set is_active = @is_active where id = @id", new Dictionary<string, object>
            {
                { "@is_active", obj.IsActive },
                { "@id", obj.Id }
            }, ThrowError: true) > 0;
        }
    }
}
