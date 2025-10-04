using AlphaUtil.Core;
using BunnyCDN.Net.Storage;
using ComplyCrafter_Data;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Net.Http.Json;
using System.Threading.Channels;
using static QRCoder.PayloadGenerator;

namespace ComplyCrafter_BL
{
    public interface IDirector : BaseInterface<Director, DirectorView>
    {
        bool ChangeActiveStatus(Director obj);
        DirectorDetails GetDirectorDetails(int id = 0);
        DirectorDetails GetDirectorAddressDetails(int id = 0);
        Task UploadImage(IFormFileCollection files, int id, bool deletePan, bool deleteAadhar, bool deletePassport, bool deleteVoterId, bool deleteDrivingLicence);
        DirectorView GetByDin(string din = "");
        Director? SyncDIN(Director obj, string data);
        IEnumerable<DirectorViewCompany> GetByCompany(int id);
        IEnumerable<DirectorViewCompany> GetByCompanyWithoutAppointmentDate(int id);
        IEnumerable<DirectorView> GetList(int userId, int companyId = 0);
    }

    public class DirectorRepository : BaseRepository<Director, DirectorView>, IDirector
    {
        const string DETAILS_TABLE_NAME = "tbl_director_details";

        public IEnumerable<DirectorView> GetList(int userId,int companyId = 0)
        {
            if (companyId > 0)
            {
                var dt = NpgSQL.Query(R.ConnectionString, $@"select * from {VIEW_NAME} where ref_user = @userId and company_id = @companyId;",
                   new Dictionary<string, object>
                   {
                    { "@userId", userId },
                    { "@companyId", companyId },
                   }, ThrowError: true)
                   .ParseList<DirectorView>().ToList();

                return dt;
            }
            else
            {
                var dt = NpgSQL.Query(R.ConnectionString, $@"select * from {VIEW_NAME} where ref_user = @userId;",
                   new Dictionary<string, object>
                   {
                    { "@userId", userId },
                   }, ThrowError: true)
                   .ParseList<DirectorView>().ToList();
                return dt;
            }
        }

        public new DirectorView GetById(int id = 0)
        {
            var dt = NpgSQL.Query(R.ConnectionString, $@"select * from {VIEW_NAME} where id = @id",
               new Dictionary<string, object>
               {
                    { "@id", id },
               }, ThrowError: true)
               .ParseList<DirectorView>().FirstOrDefault();
            if (dt != null)
            {
                dt.Details = GetDirectorDetails(id);
            }
            return dt;
        }

        public DirectorDetails GetDirectorDetails(int id = 0)
        {
            var dt = NpgSQL.Query(R.ConnectionString, $@"select * from {DETAILS_TABLE_NAME} where director_id = @id",
               new Dictionary<string, object>
               {
                    { "@id", id },
               })
               .ParseList<DirectorDetails>().FirstOrDefault();
            return dt;
        }

        public DirectorDetails GetDirectorAddressDetails(int id = 0)
        {
            var dt = NpgSQL.Query(R.ConnectionString, $@"select address, country, state, city, pincode, permanent_address, gender, marital_status from {DETAILS_TABLE_NAME} where director_id = @id",
               new Dictionary<string, object>
               {
                    { "@id", id },
               })
               .ParseList<DirectorDetails>().FirstOrDefault();
            return dt;
        }

        public new Director Save(Director obj)
        {
            if (obj.Id > 0)
            {
                obj.UpdateIntoDB(R.ConnectionString, TABLE_NAME, "id", obj.Id);
                var obj1 = GetById(obj.Id);
                obj.Details.DirectorId = obj.Id;

                obj.Details.UpdateIntoDB(R.ConnectionString, DETAILS_TABLE_NAME, "id", obj1.Details.Id);
            }
            else
            {
                obj.Id = obj.InsertIntoDBOutIdentity(R.ConnectionString, TABLE_NAME, "id");
                if (obj.Id == 0)
                    return null;

                obj.Details.DirectorId = obj.Id;

                obj.Details.Id = obj.Details.InsertIntoDBOutIdentity(R.ConnectionString, DETAILS_TABLE_NAME, "id");
            }
            return obj;
        }
       
        public DirectorView GetByDin(string din = "")
        {
            var dt = NpgSQL.Query(R.ConnectionString, $@"select * from {VIEW_NAME} where din = @din",
               new Dictionary<string, object>
               {
                    { "@din", din },
               }, ThrowError: true)
               .ParseList<DirectorView>().FirstOrDefault();
            if (dt != null)
            {
                dt.Details = GetDirectorDetails(dt.Id);
            }
            return dt;
        }

        public Director? SyncDIN(Director obj, string data)
        {
            JObject jObj = JObject.Parse(data);
            var jo = jObj["results"]["data"]["directorData"][0];

            obj.Din = jo["din"].ToString();
            obj.FirstName = jo["firstName"].ToString();
            obj.MiddleName = jo["middleName"].ToString();
            obj.LastName = jo["lastName"].ToString();
            obj.Mobile = obj.Mobile.IsBlank() ? jo["mobileNumber"].ToString() : obj.Mobile;
            obj.Email = obj.Mobile.IsBlank() ? jo["emailAddress"].ToString() : obj.Email;
            obj.Aadhar = obj.Aadhar.IsBlank() ? jo["aadhaarNumber"].ToString() : obj.Aadhar;
            obj.Pan = obj.Pan.IsBlank() ? jo["pan"].ToString() : obj.Pan;
            obj.DirKycStatus = jo["DIR3KYCFiledFlag"].ToString() == "Y" ? "Filed" : "Unfiled";
            obj.Details.Gender = jo["gender"].ToString();
            obj.Details.Occupation = jo["occupation"].ToString();
            obj.Details.Nationality = jo["nationality"].ToString();
            obj.Details.ResidentialStatus = jo["residentOfIndia"].ToString() == "Y" ? "Resident" : "Non Resident";
            obj.Details.Qualification = jo["educationalQualification"].ToString();
            obj.Details.Passport = jo["passportNumber"].ToString();

            //obj.Din = jsonObj["data"]["din_number"].ToString();
            //obj.DinUpdatedOn = DateTime.Now;

            //obj.FirstName = jsonObj["data"]["full_name"].ToString();
            //obj.MiddleName = jsonObj["data"]["father_name"].ToString();
            ////obj.LastName = jsonObj["data"]["full_name"].ToString();
            //obj.Email = jsonObj["data"]["email"].ToString();
            //obj.Pan = jsonObj["data"]["pan_number"]?.ToString();

            //obj.Details.DateOfBirth = DateTime.Parse(jsonObj["data"]["dob"].ToString());
            //obj.Details.Nationality = jsonObj["data"]["nationality"].ToString();
            //obj.Details.Address = jsonObj["data"]["present_address"].ToString();
            //obj.Details.FatherName = jsonObj["data"]["father_name"].ToString();


            return obj;
        }


        public new bool Delete(Director obj)
        {
            return NpgSQL.NonQuery(R.ConnectionString, $@"update {TABLE_NAME} set deleted_on = @deleted_on where id = @id", new Dictionary<string, object>
            {
                { "@deleted_on", DateTime.Now },
                { "@id", obj.Id }
            }, ThrowError: true) > 0;
        }
        public bool ChangeActiveStatus(Director obj)
        {
            return NpgSQL.NonQuery(R.ConnectionString, $@"update {TABLE_NAME} set is_active = @is_active where id = @id", new Dictionary<string, object>
            {
                { "@is_active", obj.IsActive },
                { "@id", obj.Id }
            }, ThrowError: true) > 0;
        }
        public async Task UploadImage(IFormFileCollection files, int id, bool deletePan, bool deleteAadhar, bool deletePassport, bool deleteVoterId, bool deleteDrivingLicence)
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
                if (deletePassport)
                {
                    var sql = $@"update {DETAILS_TABLE_NAME} set passport_url = null where id = @id";
                    NpgSQL.NonQuery(R.ConnectionString, sql, new Dictionary<string, object> {
                        { "@id", id },
                    }, ThrowError: true);
                }
                if (deleteVoterId)
                {
                    var sql = $@"update {DETAILS_TABLE_NAME} set voter_id_url = null where id = @id";
                    NpgSQL.NonQuery(R.ConnectionString, sql, new Dictionary<string, object> {
                        { "@id", id },
                    }, ThrowError: true);
                }
                if (deleteDrivingLicence)
                {
                    var sql = $@"update {DETAILS_TABLE_NAME} set driving_licence_url = null where id = @id";
                    NpgSQL.NonQuery(R.ConnectionString, sql, new Dictionary<string, object> {
                        { "@id", id },
                    }, ThrowError: true);
                }
                foreach (var file in files)
                {
                    string filePath = @$"/Director/{id}_{DateTime.Now.ToString("yyyyMMddHHmmss")}_{file.FileName}";
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

        public IEnumerable<DirectorViewCompany> GetByCompany(int id)
        {
            var dt = NpgSQL.Query(R.ConnectionString, $@"
                select a.*, b.appointment_date from {TABLE_NAME} a 
                left join tbl_company_director b on a.id = b.director_id and company_id = @id
                where a.deleted_on is null and a.id in (select director_id from tbl_company_director where company_id = @id)
            ", new Dictionary<string, object> {
                { "@id", id }
            }).ParseList<DirectorViewCompany>();
            return dt;
        }

        public IEnumerable<DirectorViewCompany> GetByCompanyWithoutAppointmentDate(int id)
        {
            //select distinct a.* from { TABLE_NAME}
            //a
            //    left join tbl_company_director b on a.id = b.director_id and company_id = @id
            //    where a.deleted_on is null and a.id in (select director_id from tbl_company_director where company_id = @id)
            var dt = NpgSQL.Query(R.ConnectionString, $@"
                select td.*, tcd.appointment_date from
                {TABLE_NAME} td
                inner join tbl_company_director tcd on td.id = tcd.director_id and company_id = @id
                where td.deleted_on is null
            ", new Dictionary<string, object> {
                { "@id", id }
            }).ParseList<DirectorViewCompany>();
            return dt;
        }
    }
}
