using AlphaUtil.Core;
using BunnyCDN.Net.Storage;
using ComplyCrafter_Data;

namespace ComplyCrafter_BL
{
    public interface IDMS: BaseInterface<DMS, DMS>
    {
        bool ChangeActiveStatus(DMS obj); 
        IEnumerable<DMS> GetByCompany(int id);
        Task UploadFile(byte[] fileBytes, int id, string column);
    }

    public class DMSRepository : BaseRepository<DMS, DMS>, IDMS
    {
        public new bool Delete(DMS obj)
        {
            return NpgSQL.NonQuery(R.ConnectionString, $@"update {TABLE_NAME} set deleted_on = @deleted_on where id = @id", new Dictionary<string, object>
            {
                { "@deleted_on", DateTime.Now },
                { "@id", obj.Id }
            }, ThrowError: true) > 0;
        }

        public IEnumerable<DMS> GetByCompany(int id)
        {
            var dt = NpgSQL.Query(R.ConnectionString, $@"select * from {TABLE_NAME} where company_id = @id and deleted_on is null",
             new Dictionary<string, object>
             {
                    { "@id", id },
             })
             .ParseList<DMS>();
            return dt;
        }

        public bool ChangeActiveStatus(DMS obj)
        {
            return NpgSQL.NonQuery(R.ConnectionString, $@"update {TABLE_NAME} set is_active = @is_active where id = @id", new Dictionary<string, object>
            {
                { "@is_active", obj.IsActive },
                { "@id", obj.Id }
            }, ThrowError: true) > 0;
        }

        public async Task UploadFile(byte[] fileBytes, int id, string column)
        {
            try
            {
                string filePath = @$"/DMS/{id}/{column}/{DateTime.Now.ToString("yyyyMMddHHmmss")}.pdf";
                var bunnyCDNStorage = new BunnyCDNStorage(R.AppSet("Bunny:StorageZone"), R.AppSet("Bunny:Key"));
                using (MemoryStream ms = new MemoryStream(fileBytes))
                    await bunnyCDNStorage.UploadAsync(ms, R.AppSet("Bunny:BasePath") + filePath);
                var sql = $@"update {TABLE_NAME} set {column} = @url where id = @id";
                NpgSQL.NonQuery(R.ConnectionString, sql, new Dictionary<string, object> {
                    { "@url", R.AppSet("Bunny:BaseUrl") + filePath },
                    { "@id", id },
                });
            }
            catch (Exception) { }
        }
    }
}
