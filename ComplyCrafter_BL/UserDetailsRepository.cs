using AlphaUtil.Core;
using ComplyCrafter_Data;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http.Json;
using System.Threading.Channels;
using static QRCoder.PayloadGenerator;

namespace ComplyCrafter_BL
{
    public interface IUserDetails
    {
        IEnumerable<AppUserDetailsView> Get();
        AppUserDetailsView? GetById(int UserId = 0);
        AppUserDetails? Save(AppUserDetails obj);
        bool Delete(AppUserDetails obj);
        AppUserDetails? GetByEmail(string? email);
        AppUserDetails? GetByMobile(string? mobile, bool for_auth = false);

        bool GenerateOtp(int UserId);
        bool ValidateOtp(int UserId, string otp);

        bool UpdatePassword(int UserId, string password);

    }

    public class UserDetailsRepository : IUserDetails
    {
        private const string TABLE_NAME = "tbl_user";
        private const string VIEW_NAME = "vw_user";
        private const string OTP_TABLE_NAME = "tbl_user_otp";

        public IEnumerable<AppUserDetailsView> Get()
        {
            var dt = NpgSQL.Query(R.ConnectionString, $@"select * from {VIEW_NAME}", ThrowError: true)
                .ParseList<AppUserDetailsView>().Select(q => q.WithoutPassword());
            return dt;
        }

        public AppUserDetailsView? GetById(int UserId = 0)
        {
            var dt = NpgSQL.Query(R.ConnectionString, $@"select * from {VIEW_NAME} where UserId = @UserId",
               new Dictionary<string, object>
               {
                    { "@UserId", UserId },
               }, ThrowError: true)
               .ParseList<AppUserDetailsView>().FirstOrDefault()?.WithoutPassword();
            return dt;
        }


        public AppUserDetails? Save(AppUserDetails obj)
        {
            if (obj.UserId == 0)
            {
                obj.UserId = obj.InsertIntoDBOutIdentity(R.ConnectionString, TABLE_NAME, "UserId");
                if (obj.UserId > 0)
                    return obj;
                return null;
            }
            else
                obj.UpdateIntoDB(R.ConnectionString, TABLE_NAME, "UserId", obj.UserId);
            return obj;
        }

        public bool Delete(AppUserDetails obj)
        {
            return NpgSQL.NonQuery(R.ConnectionString, $@"delete from {TABLE_NAME} where UserId = @UserId", new Dictionary<string, object> {
                { "@UserId", obj.UserId }
            }) > 0;
        }

        public AppUserDetails? GetByEmail(string? email)
        {
            var dt = NpgSQL.Query(R.ConnectionString, $@"select * from {TABLE_NAME} where email = @email",
               new Dictionary<string, object>
               {
                    { "@email", email ?? "" },
               }, ThrowError: true)
               .ParseList<AppUserDetails>().FirstOrDefault();
            return dt;
        }

        public AppUserDetails? GetByMobile(string? mobile, bool for_auth = false)
        {
            var dt = NpgSQL.Query(R.ConnectionString, $@"select * from {TABLE_NAME} where mobile = @mobile ",
               new Dictionary<string, object>
               {
                    { "@mobile", mobile ?? "" },
               })
               .ParseList<AppUserDetails>().FirstOrDefault();
            return dt;
        }
        public bool UpdateToken(int UserId, string token)
        {
            var i = NpgSQL.NonQuery(R.ConnectionString, $@"update {TABLE_NAME} set token = @token where UserId = @UserId", new Dictionary<string, object>
            {
                { "@UserId", UserId },
                { "@token", token },
            });
            return i > 0;
        }

        public bool GenerateOtp(int UserId)
        {
            var u = GetById(UserId);
            if (u == null) return false;
            if (u.MobileNumber.IsBlank()) return false;
            Random rand = new Random(UserId);
            var otp = rand.Next(1000, 9999).ToString().PadLeft(4, '0');
            string orderId = "";
            //if (R.AppSet<bool>("OTP:Bypass"))
            //    otp = u.MobileNumber!.Substring(u.MobileNumber.Length - 4);
            //else if (R.AppSet<string>("OTP:BypassNo").Split(',').Contains(u.MobileNumber))
            //    otp = u.MobileNumber!.Substring(u.MobileNumber.Length - 4);
            //else
            //    orderId = SendOtp(u.MobileNumber!, otp);

            otp = u.MobileNumber!.Substring(u.MobileNumber.Length - 4);

            var i = new UserOtp
            {
                Otp = orderId.IsBlank() ? otp : orderId,
                OtpType = 1,
                User = UserId,
                IsValid = true,
                ValidTill = DateTime.Now.AddMinutes(R.AppSet<int>("OTP:ValidityInMin"))
            }.InsertIntoDB(R.ConnectionString, OTP_TABLE_NAME);
            return i > 0;
        }

        public bool ValidateOtp(int UserId, string otp)
        {
            bool res = false;
            var u = GetById(UserId);
            if (u == null) res = false;
            if (u.MobileNumber.IsBlank()) res = false;
            var obj = NpgSQL.Query(R.ConnectionString, $@"select * from {OTP_TABLE_NAME} where ""user"" = @user and is_valid = true and valid_till > now() order by UserId desc limit 1",
                new Dictionary<string, object> { { "@user", u.UserId } }).ParseList<UserOtp>().FirstOrDefault();
            if (obj != null)
            {
                if (obj.Otp.StartsWith("Otp_"))
                    res = VerifyOtp(u.MobileNumber, obj.Otp, otp);
                else if (otp == obj.Otp)
                    res = true;
                else
                    res = false;
            }
            if (obj != null)
                NpgSQL.NonQuery(R.ConnectionString, $@"update {OTP_TABLE_NAME} set is_valid = false where UserId = @UserId",
                    new Dictionary<string, object> { { "@UserId", obj.Id } });
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
        public bool UpdatePassword(int UserId, string password)
        {
            var i = NpgSQL.NonQuery(R.ConnectionString, $@"update {TABLE_NAME} set password = @password where UserId = @UserId",
               new Dictionary<string, object>
               {
                    { "@UserId", UserId },
                    { "@password", password.A_Hash_SHA256() }
               });
            return i > 0;
        }

    }
}
