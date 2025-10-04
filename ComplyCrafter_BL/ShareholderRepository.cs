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
    public interface IShareholder : BaseInterface<Shareholder, ShareholderView>
    {
        bool ChangeActiveStatus(Shareholder obj);
        ShareholderDetails GetDetails(int id = 0);
        Task UploadImage(IFormFileCollection files, int id, bool deletePan, bool deleteAadhar);
        bool UpdateMobileEmailVerifyStatus(int id, string type); //To verify mobile/email if din is selected
        IEnumerable<ShareholderView> Gets(int companyId = 0);

    }

    public class ShareholderRepository : BaseRepository<Shareholder, ShareholderView>, IShareholder
    {
        const string DETAILS_TABLE_NAME = "tbl_shareholder_details";

        public IEnumerable<ShareholderView> Gets(int companyId = 0)
        {
            if (companyId > 0)
            {
                var dt = NpgSQL.Query(R.ConnectionString, $@"select * from {VIEW_NAME} where company_id = @companyId;",
                   new Dictionary<string, object>
                   {
                    { "@companyId", companyId },
                   }, ThrowError: true)
                   .ParseList<ShareholderView>().ToList();

                return dt;
            }
            else
            {
                var dt = NpgSQL.Query(R.ConnectionString, $@"select * from {VIEW_NAME};",
                   new Dictionary<string, object>
                   {
                   }, ThrowError: true)
                   .ParseList<ShareholderView>().ToList();
                return dt;
            }
        }

        public new ShareholderView GetById(int id = 0)
        {
            var dt = NpgSQL.Query(R.ConnectionString, $@"select * from {VIEW_NAME} where id = @id",
               new Dictionary<string, object>
               {
                    { "@id", id },
               }, ThrowError: true)
               .ParseList<ShareholderView>().FirstOrDefault();
            if (dt != null)
            {
                dt.Details = GetDetails(id);
            }
            return dt;
        }

        public ShareholderDetails GetDetails(int id = 0)
        {
            var dt = NpgSQL.Query(R.ConnectionString, $@"select * from {DETAILS_TABLE_NAME} where shareholder = @id",
               new Dictionary<string, object>
               {
                    { "@id", id },
               })
               .ParseList<ShareholderDetails>().FirstOrDefault();
            return dt;
        }

        public new Shareholder Save(Shareholder obj)
        {
            if (obj.Id > 0)
            {
                obj.UpdateIntoDB(R.ConnectionString, TABLE_NAME, "id", obj.Id);
                var obj1 = GetById(obj.Id);
                obj.Details.Shareholder = obj.Id;

                obj.Details.UpdateIntoDB(R.ConnectionString, DETAILS_TABLE_NAME, "id", obj1.Details.Id);
            }
            else
            {
                obj.Id = obj.InsertIntoDBOutIdentity(R.ConnectionString, TABLE_NAME, "id");
                if (obj.Id == 0)
                    return null;

                obj.Details.Shareholder = obj.Id;

                obj.Details.Id = obj.Details.InsertIntoDBOutIdentity(R.ConnectionString, DETAILS_TABLE_NAME, "id");
            }
            return obj;
        }


        public new bool Delete(Shareholder obj)
        {
            return NpgSQL.NonQuery(R.ConnectionString, $@"update {TABLE_NAME} set deleted_on = @deleted_on where id = @id", new Dictionary<string, object>
            {
                { "@deleted_on", DateTime.Now },
                { "@id", obj.Id }
            }, ThrowError: true) > 0;
        }
        public bool ChangeActiveStatus(Shareholder obj)
        {
            return NpgSQL.NonQuery(R.ConnectionString, $@"update {TABLE_NAME} set is_active = @is_active where id = @id", new Dictionary<string, object>
            {
                { "@is_active", obj.IsActive },
                { "@id", obj.Id }
            }, ThrowError: true) > 0;
        }
        public async Task UploadImage(IFormFileCollection files, int id, bool deletePan, bool deleteAadhar)
        {
            try
            {
                if (deletePan)
                {
                    var sql = $@"update {DETAILS_TABLE_NAME} set pan_url = null where id = @id";
                    NpgSQL.NonQuery(R.ConnectionString, sql, new Dictionary<string, object> {
                        { "@id", id },
                    }, ThrowError: true);
                }
                if (deleteAadhar)
                {
                    var sql = $@"update {DETAILS_TABLE_NAME} set aadhar_url = null where id = @id";
                    NpgSQL.NonQuery(R.ConnectionString, sql, new Dictionary<string, object> {
                        { "@id", id },
                    }, ThrowError: true);
                }
                foreach (var file in files)
                {
                    string filePath = @$"/Shareholder/{id}_{DateTime.Now.ToString("yyyyMMddHHmmss")}_{file.FileName}";
                    var bunnyCDNStorage = new BunnyCDNStorage(R.AppSet("Bunny:StorageZone"), R.AppSet("Bunny:Key"));
                    byte[] fileBytes;
                    using (var memoryStream = new MemoryStream())
                    {
                        await file.CopyToAsync(memoryStream);
                        fileBytes = memoryStream.ToArray();
                    }
                    using (MemoryStream ms = new MemoryStream(fileBytes))
                        await bunnyCDNStorage.UploadAsync(ms, R.AppSet("Bunny:BasePath") + filePath);
                    var sql = $@"update {DETAILS_TABLE_NAME} set {ConvertToSnakeCase(file.Name)} = @url where id = @id";
                    NpgSQL.NonQuery(R.ConnectionString, sql, new Dictionary<string, object> {
                        { "@url", R.AppSet("Bunny:BaseUrl") + filePath },
                        { "@id", id },
                    }, ThrowError: true);
                }
            }
            catch (Exception ex)
            {

            }
        }
        public static string ConvertToSnakeCase(string input)
        => string.Concat(input.Select((c, i) => char.IsUpper(c) && i > 0 ? $"_{char.ToLower(c)}" : char.ToLower(c).ToString()));


        public bool UpdateMobileEmailVerifyStatus(int id, string type)
        {
            if (type == "mobile")
            {
                return NpgSQL.NonQuery(R.ConnectionString, $@"update {TABLE_NAME} set is_mobile_verified = true where id = @id;", new Dictionary<string, object> {
                    { "@id", id }
                }) > 0;
            }
            else if(type == "email")
            {
                return NpgSQL.NonQuery(R.ConnectionString, $@"update {TABLE_NAME} set is_email_verified = true where id = @id;", new Dictionary<string, object> {
                    { "@id", id }
                }) > 0;
            }
            else
            {
                throw new ArgumentException("Invalid type. Use 'mobile' or 'email'.");
            }
        }
    }
}
