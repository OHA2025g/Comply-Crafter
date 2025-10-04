using AlphaUtil.Core;
using AlphaUtil.Core.Models;
using ComplyCrafter_Data;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http.Json;
using System.Threading.Channels;
using static QRCoder.PayloadGenerator;

namespace ComplyCrafter_BL
{
    public interface IUser
    {
        IEnumerable<AppUserView> Get();
        AppUserView? GetById(int id = 0);
        AppUser? Save(AppUser obj);
        bool SaveDataQuery(int id, string sKey, string sValue);// Use to update single query with dynamic column and value
        bool Delete(AppUser obj);
        bool UpdateCCPIN(int id, string CCPIN);
        AppUser? GetByEmail(string? email);
        AppUser? GetByMobile(string? mobile, bool for_auth = false);
        AppUser? GetUserByEmailSecretKey(string key); // to get user by email secret key to resend email

        //AppUserView? GetByMemberNo(string id = "");

        //Task UploadImage(byte[] fileBytes, int userId);
        //bool UpdateToken(int id, string token);
        //IEnumerable<AppUser> GetActiveMembers();

        bool GenerateOtp(int id);
        bool ValidateOtp(int id, string otp);
        bool UpdateOTPExpired(string mobile);// update OTP expired
        int OTPCount(string mobile);// total OTP count of current day

        //AppUser GuestEntry(AppUser guest, AppUser user);

        bool UpdatePassword(int id, string password);

        //bool MemberNoAvailable(int no);
        //int NextMemberNo();

        bool SaveEmailVerified(int id);
        bool SaveMobileVerified(int id);

        IEnumerable<AppUserView> GetSubUserByParentId(int id); //Get Sub user list

        bool DeleteSubUserById(int subUserId, int companyUserId);// delete sub user

        bool MakeAdminToSubUser(int subUserId, int companyUserId); //to switch admin role between subuser and admin
    }

    public class UserRepository : IUser
    {
        private const string TABLE_NAME = "tbl_user_details"; //"tbl_user"
        private const string VIEW_NAME = "vw_user_details";
        private const string OTP_TABLE_NAME = "tbl_company_otp";

        public IEnumerable<AppUserView> Get()
        {
            var dt = NpgSQL.Query(R.ConnectionString, $@"select * from {VIEW_NAME}", ThrowError: true)
                .ParseList<AppUserView>().Select(q => q.WithoutPassword());
            return dt;
        }
        public IEnumerable<AppUserView> GetSubUserByParentId(int id)
        {
            var dt = NpgSQL.Query(R.ConnectionString, $@"select * from {VIEW_NAME} where parent_user_id = @id",
               new Dictionary<string, object>
               {
                    { "@id", id },
               }, ThrowError: true)
                .ParseList<AppUserView>().Select(q => q.WithoutPassword());
            return dt;
        }

        public AppUserView? GetById(int id = 0)
        {
            var dt = NpgSQL.Query(R.ConnectionString, $@"select * from {VIEW_NAME} where id = @id",
               new Dictionary<string, object>
               {
                    { "@id", id },
               }, ThrowError: true)
               .ParseList<AppUserView>().FirstOrDefault()?.WithoutPassword();
            return dt;
        }
        
        //public AppUserView? GetByMemberNo(string id = "")
        //{
        //    var dt = NpgSQL.Query(R.ConnectionString, $@"select * from {VIEW_NAME} where member_id = @id",
        //       new Dictionary<string, object>
        //       {
        //            { "@id", id },
        //       })
        //       .ParseList<AppUserView>().FirstOrDefault()?.WithoutPassword();
        //    return dt;
        //}

        public AppUser? Save(AppUser obj)
        {
            if (obj.Id == 0)
            {
                obj.Id = obj.InsertIntoDBOutIdentity(R.ConnectionString, TABLE_NAME, "id");
                if (obj.Id > 0)
                    return obj;
                return null;
            }
            else
                obj.UpdateIntoDB(R.ConnectionString, TABLE_NAME, "id", obj.Id);
            return obj;
        }

        public bool UpdateCCPIN(int id, string CCPIN)
        {
            return NpgSQL.NonQuery(R.ConnectionString, $@"update {TABLE_NAME} set ccpin = @ccpin, is_ccpinset = true, last_ccpin_changed_date = now(), updated_on = now() where id = @id", new Dictionary<string, object> {
                { "@id", id },
                { "@ccpin", CCPIN }
            }) > 0;
        }

        public bool Delete(AppUser obj)
        {
            return NpgSQL.NonQuery(R.ConnectionString, $@"update {TABLE_NAME} set is_deleted = 1, updated_on = now() where id = @id", new Dictionary<string, object> {
                { "@id", obj.Id }
            }) > 0;
        }

        public AppUser? GetByEmail(string? email)
        {
            var dt = NpgSQL.Query(R.ConnectionString, $@"select * from {VIEW_NAME} where email_id = @email",
               new Dictionary<string, object>
               {
                    { "@email", email ?? "" },
               }, ThrowError: true)
               .ParseList<AppUser>().FirstOrDefault();
            return dt;
        }

        public AppUser? GetByMobile(string? mobile, bool for_auth = false)
        {
            var dt = NpgSQL.Query(R.ConnectionString, $@"select * from {VIEW_NAME} where mobile_number = @mobile",
               new Dictionary<string, object>
               {
                    { "@mobile", mobile ?? "" },
               })
               .ParseList<AppUser>().FirstOrDefault();
            return dt;
        }

        public bool UpdateToken(int id, string token)
        {
            var i = NpgSQL.NonQuery(R.ConnectionString, $@"update {TABLE_NAME} set token = @token where id = @id", new Dictionary<string, object>
            {
                { "@id", id },
                { "@token", token },
            });
            return i > 0;
        }

        public bool GenerateOtp(int id)
        {
            var u = GetById(id);
            if (u == null) return false;
            if (u.Mobile.IsBlank()) return false;
            Random rand = new Random(id);
            var otp = rand.Next(1000, 9999).ToString().PadLeft(4, '0');
            string orderId = "";
            if (R.AppSet<bool>("OTP:Bypass"))
                otp = u.Mobile!.Substring(u.Mobile.Length - 4);
            else if(R.AppSet<string>("OTP:BypassNo").Split(',').Contains(u.Mobile))
                otp = u.Mobile!.Substring(u.Mobile.Length - 4);
            else
                orderId = SendOtp(u.Mobile!, otp);
            var i = new UserOtp
            {
                Otp = orderId.IsBlank() ? otp : orderId,
                OtpType = 1,
                User = id,
                Mobile = u.Mobile,
                IsValid = true,
                ValidTill = DateTime.Now.AddMinutes(R.AppSet<int>("OTP:ValidityInMin"))
            }.InsertIntoDB(R.ConnectionString, OTP_TABLE_NAME);
            return i > 0;
        }

        public bool ValidateOtp(int id, string otp)
        {
            bool res = false;
            var u = GetById(id);
            if (u == null) res = false;
            if (u.Mobile.IsBlank()) res = false;
            var obj = NpgSQL.Query(R.ConnectionString, $@"select * from {OTP_TABLE_NAME} where ""user"" = @user and is_valid = true and valid_till > now() order by id desc limit 1",
                new Dictionary<string, object> { { "@user", u.Id } }).ParseList<UserOtp>().FirstOrDefault();
            if (obj != null)
            {
                if (obj.Otp.StartsWith("Otp_"))
                    res = VerifyOtp(u.Mobile, obj.Otp, otp);
                else if (otp == obj.Otp)
                    res = true;
                else
                    res = false;
            }
            if (obj != null)
            {
                NpgSQL.NonQuery(R.ConnectionString, $@"update {OTP_TABLE_NAME} set is_valid = false where id = @id",
                    new Dictionary<string, object> { { "@id", obj.Id } });

                NpgSQL.NonQuery(R.ConnectionString, $@"update {TABLE_NAME} set is_mobile_verified = true where id = @id",
                    new Dictionary<string, object> { { "@id", u.Id } });

            }
            return res;
        }

        public string SendOtp(string mobile, string otp)
        {
            using HttpClient hc = new HttpClient();
            hc.DefaultRequestHeaders.Add("clientId", R.AppSet("OtpLess:ClientId"));
            hc.DefaultRequestHeaders.Add("clientSecret", R.AppSet("OtpLess:ClientSecret"));
            hc.BaseAddress = new Uri(R.AppSet("OtpLess:Url"));
            var res = hc.PostAsJsonAsync("send", new
            {
                phoneNumber = "91" + mobile,
                otpLength = 4,
                channel = "WHATSAPP",
                expiry = R.AppSet<int>("OTP:ValidityInMin") * 60
            }).Result;
            var json = res.Content.ReadAsStringAsync().Result;
            var obj = JsonConvert.DeserializeAnonymousType(json, new { orderId = "" });
            return obj.orderId;
        }
        public bool VerifyOtp(string mobile, string orderId, string otp)
        {
            using HttpClient hc = new HttpClient();
            hc.DefaultRequestHeaders.Add("clientId", R.AppSet("OtpLess:ClientId"));
            hc.DefaultRequestHeaders.Add("clientSecret", R.AppSet("OtpLess:ClientSecret"));
            hc.BaseAddress = new Uri(R.AppSet("OtpLess:Url"));
            var res = hc.PostAsJsonAsync("verify", new
            {
                phoneNumber = "91" + mobile,
                otp = otp,
                orderId = orderId,
            }).Result;
            var json = res.Content.ReadAsStringAsync().Result;
            var obj = JsonConvert.DeserializeAnonymousType(json, new { isOTPVerified = false });
            return obj?.isOTPVerified ?? false;
        }

        public bool UpdatePassword(int id, string password)
        {
            var i = NpgSQL.NonQuery(R.ConnectionString, $@"update {TABLE_NAME} set password = @password, last_password_changed_date = now(), updated_on = now() where id = @id",
               new Dictionary<string, object>
               {
                    { "@id", id },
                    { "@password", password.A_Hash_SHA256() }
               });
            return i > 0;
        }

        public bool SaveDataQuery(int id, string sKey, string sValue)
        {
            var i = NpgSQL.NonQuery(R.ConnectionString, $@"update {TABLE_NAME} set {sKey} = {sValue}, updated_on = now() where id = @id",
               new Dictionary<string, object>
               {
                    { "@id", id },
               });
            return i > 0;
        }

        public AppUser? GetUserByEmailSecretKey(string key)
        {
            var obj = NpgSQL.Query(R.ConnectionString, $@"select ud.* from tbl_user_details ud inner join tbl_email_tracker et on ud.id = et.user_id where et.secret_id = @secret_key limit 1",
                new Dictionary<string, object> { { "@secret_key", key } }).ParseList<AppUser>().FirstOrDefault();
            return obj;
        }
        public bool UpdateOTPExpired(string mobile)
        {
            var i = NpgSQL.NonQuery(R.ConnectionString, $@"UPDATE {OTP_TABLE_NAME} SET is_valid = false WHERE is_valid = true AND valid_till > NOW() - INTERVAL '1 hour' and mobile= @mobile",
               new Dictionary<string, object>
               {
                    { "@mobile", mobile },
               });
            return i > 0;
        }
        public int OTPCount(string mobile)
        {
            var i = NpgSQL.Query(R.ConnectionString, $@"select count(1) as otp_count from {OTP_TABLE_NAME} where valid_till::date = CURRENT_DATE and mobile= @mobile",
               new Dictionary<string, object>
               {
                    { "@mobile", mobile },
               });
            return Convert.ToInt32(i.Rows[0].ItemArray[0] == System.DBNull.Value ? 0 : i.Rows[0].ItemArray[0]);
        }

        public bool SaveEmailVerified(int id)
        {
            return NpgSQL.NonQuery(R.ConnectionString, $@"update {TABLE_NAME} set is_email_verified = true where id = @id", new Dictionary<string, object> {
                { "@id", id }
            }) > 0;
        }

        public bool SaveMobileVerified(int id)
        {
            return NpgSQL.NonQuery(R.ConnectionString, $@"update {TABLE_NAME} set is_mobile_verified = true where id = @id", new Dictionary<string, object> {
                { "@id", id }
            }) > 0;
        }

        public bool MakeAdminToSubUser(int subUserId, int companyUserId)
        {
            //Destorying current session of both user
            NpgSQL.NonQuery(R.ConnectionString,
                $@"update tbl_login_tracker set is_valid = false where user_id in (@subUserId, @companyUserId) and is_valid = true",
            new Dictionary<string, object> {
                { "@subUserId", subUserId },
                { "@companyUserId", companyUserId }
            });

            // updating sub user list of admin to new admin
            var i = NpgSQL.NonQuery(R.ConnectionString,
                $@"update {TABLE_NAME} set parent_user_id = @subUserId where parent_user_id = @companyUserId;",
            new Dictionary<string, object> {
                { "@id", subUserId },
                { "@subUserId", subUserId },
                { "@companyUserId", companyUserId },
                { "@companyAdminRole", (int)AppRole.CompanyAdmin },
                { "@subUserRole", (int)AppRole.SubUser }
            });

            // updating admin to sub user
            var j = NpgSQL.NonQuery(R.ConnectionString,
                $@"update {TABLE_NAME} set role = @companyAdminRole, is_sub_user = false, parent_user_id = 0, updated_by = @companyUserId, updated_on = now() where id = @id;",
            new Dictionary<string, object> {
                { "@id", subUserId },
                { "@subUserId", subUserId },
                { "@companyUserId", companyUserId },
                { "@companyAdminRole", (int)AppRole.CompanyAdmin },
                { "@subUserRole", (int)AppRole.SubUser }
            });

            //Switching subscriptions from admin to sub user
            NpgSQL.NonQuery(R.ConnectionString,
                $@"update tbl_user_subscriptions set user_id = @subUserId, updated_by = @companyUserId, updated_on = now() where user_id = @companyUserId and is_active = true;",
            new Dictionary<string, object> {
                { "@id", subUserId },
                { "@subUserId", subUserId },
                { "@companyUserId", companyUserId },
                { "@companyAdminRole", (int)AppRole.CompanyAdmin },
                { "@subUserRole", (int)AppRole.SubUser }
            });


            //Switching payments from admin to sub user
            NpgSQL.NonQuery(R.ConnectionString,
                $@"update tbl_payment_details set user_id = @subUserId where user_id =@companyUserId;",
            new Dictionary<string, object> {
                { "@id", subUserId },
                { "@subUserId", subUserId },
                { "@companyUserId", companyUserId },
                { "@companyAdminRole", (int)AppRole.CompanyAdmin },
                { "@subUserRole", (int)AppRole.SubUser }
            });


            //Switching company added from admin to sub user
            NpgSQL.NonQuery(R.ConnectionString,
                $@"update tbl_company set ref_user = @subUserId where ref_user =@companyUserId;",
            new Dictionary<string, object> {
                { "@id", subUserId },
                { "@subUserId", subUserId },
                { "@companyUserId", companyUserId },
                { "@companyAdminRole", (int)AppRole.CompanyAdmin },
                { "@subUserRole", (int)AppRole.SubUser }
            });

            // updating sub user to admin
            return NpgSQL.NonQuery(R.ConnectionString,
                $@"update {TABLE_NAME} set role = @subUserRole, is_sub_user = true, parent_user_id = @subUserId, updated_by = @companyUserId, updated_on = now() where id = @companyUserId;",
            new Dictionary<string, object> {
                { "@id", subUserId },
                { "@subUserId", subUserId },
                { "@companyUserId", companyUserId },
                { "@companyAdminRole", (int)AppRole.CompanyAdmin },
                { "@subUserRole", (int)AppRole.SubUser }
            }) > 0;
        }

        public bool DeleteSubUserById(int subUserId, int companyUserId)
        {
            return NpgSQL.NonQuery(R.ConnectionString, $@"update {TABLE_NAME} set is_deleted = true, deleted_on = now(), deleted_by = @deletedBy where id = @id;", new Dictionary<string, object> {
                { "@id", subUserId },
                { "@deletedBy", companyUserId }
            }) > 0;
        }

    }
}
