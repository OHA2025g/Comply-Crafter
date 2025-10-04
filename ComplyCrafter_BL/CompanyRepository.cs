using AlphaUtil.Core;
using AlphaUtil.Core.Models;
using ComplyCrafter_Data;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Npgsql;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Channels;
using static QRCoder.PayloadGenerator;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ComplyCrafter_BL
{
    public interface ICompany : BaseInterface<Company, CompanyView>
    {
        CompanyView GetByCin(string cin = "", int userId = 0);// Get added company list by userid
        bool ChangeActiveStatus(Company obj);
        Company? SyncCIN(Company obj, string data);
        CompanyDetails GetCompanyDetails(int id = 0);

        CompanyView GetByMobile(string mobile = "");
        bool GenerateOtp(int id, string mobile, string type = "mobile");
        bool ValidateOtp(int id, string mobile, string otp, string type = "mobile");
        void SaveDirectors(int company, IEnumerable<Director> directors);
        void SaveCharges(int company, IEnumerable<CompanyIndexCharge> charges);
        IEnumerable<CompanyIndexCharge> GetCharges(int company);

        IEnumerable<CompanyView> GetByUserId(int id = 0); //Company List by user logged in
        IEnumerable<CompanyView> GetByUserIdS2(int id = 0); //Company List by user logged in without deleted companies
        int CompanyCountByUserId(int id = 0); //Company Count by user logged in
        int UsedCompanyLimit(int userId); // Utilized company limit
        int TrialCompanyCount(int userId); // Trial pack total company count
        int PurchaseCompanyLimit(int userId); // Company limits purchase from subscription
    }

    public class CompanyRepository : BaseRepository<Company, CompanyView>, ICompany
    {

        const string DETAILS_TABLE_NAME = "tbl_company_details";
        const string OTHER_DETAILS_TABLE_NAME = "tbl_company_other_details";
        const string FINANCIAL_DETAILS_TABLE_NAME = "tbl_company_financial_details";
        private const string OTP_TABLE_NAME = "tbl_company_otp";
        private const string DIRECTOR_TABLE_NAME = "tbl_company_director";
        private const string COMPANY_IOC_TABLE_NAME = "tbl_company_ioc";

        private readonly IDirector _director;

        public CompanyRepository(IDirector director)
        {
            this._director = director;
        }

        public new CompanyView GetById(int id = 0)
        {
            var dt = NpgSQL.Query(R.ConnectionString, $@"select * from {VIEW_NAME} where id = @id",
               new Dictionary<string, object>
               {
                    { "@id", id },
               }, ThrowError: true)
               .ParseList<CompanyView>().FirstOrDefault();
            if (dt != null)
            {
                dt.Details = GetCompanyDetails(id);
                dt.OtherDetails = GetCompanyOtherDetails(id);
                dt.FinancialDetails = GetCompanyFinancialDetails(id);
                dt.Charges = GetIndexChargeDetails(id);
                dt.Directors = GetCompanyDirectorList(id);
            }
            return dt;
        }

        public CompanyView GetByCin(string cin = "", int userId=0)
        {
            var dt = NpgSQL.Query(R.ConnectionString, $@"select * from {VIEW_NAME} where cin = @cin and ref_user = @UserId;",
               new Dictionary<string, object>
               {
                    { "@cin", cin },
                    { "@UserId", userId },
               }, ThrowError: true)
               .ParseList<CompanyView>().FirstOrDefault();
            return dt;
        }

        public Company? SyncCIN(Company obj, string data)
        {
            JObject jsonObj = JObject.Parse(data);
            var cd = jsonObj["results"]["data"]["companyData"];

            obj.Cin = cd["CIN"].ToString();
            obj.CinUpdatedOn = DateTime.Now;

            obj.CompanyName = cd["company"].ToString();
            obj.CompanyType = cd["companyType"].ToString() ?? "LLP";
            obj.Details.RegistrationNumber = cd["registrationNumber"].ToString().IsBlank() ? 0 : int.Parse(cd["registrationNumber"].ToString());
            //obj.IncorporationDate = DateTime.ParseExact(cd["dateOfIncorporation"].ToString(), "MM/dd/yyyy", CultureInfo.InvariantCulture);

            //Fixed code
            obj.IncorporationDate = SafeParseDate(cd.Value<string>("dateOfIncorporation"));

            obj.Email = cd["emailAddress"].ToString();
            obj.Details.WhetherListed = cd["whetherListedOrNot"].ToString() == "N" ? "Unlisted" : "Listed";
            obj.Details.Category = cd["companyCategory"].ToString();
            obj.Details.SubCategory = cd["companySubcategory"].ToString();
            obj.Details.CompanyClass = cd["classOfCompany"].ToString();
            obj.Details.AuthorizedCapital = cd["registrationNumber"].ToString().IsBlank() ? 0 : Convert.ToDecimal(cd["authorisedCapital"].ToString());
            obj.Details.PaidUpCapital = cd["registrationNumber"].ToString().IsBlank() ? 0 : Convert.ToDecimal(cd["paidUpCapital"].ToString());

            // AGM & Balance Sheet
            obj.Details.LastAgmDate = SafeParseDate(cd.Value<string>("dateOfLastAGM"));
            obj.Details.DateOfLastBalanceSheet = SafeParseDate(cd.Value<string>("balanceSheetDate"));

            obj.Details.Roc = cd["rocName"].ToString();


            try
            {
                string sAddress = "";
                foreach (var objAdd in cd["MCAMDSCompanyAddress"][0])
                {
                    sAddress += objAdd["streetAddress"].ToString() + " " + objAdd["streetAddress2"].ToString() + " "
                         + objAdd["streetAddress3"].ToString() + " "
                          + objAdd["streetAddress4"].ToString() + " "
                           //+ objAdd["addressType"].ToString() + " "
                            + objAdd["locality"].ToString() + " "
                            + objAdd["district"].ToString() + " "
                            + objAdd["city"].ToString() + " "
                            + objAdd["state"].ToString() + " "
                            + objAdd["country"].ToString() + "-"
                            + objAdd["postalCode"].ToString();
                }
                obj.Address = sAddress;
            }
            catch (Exception ex)
            {
            }


            try
            {
                foreach (var objDir in jsonObj["results"]["data"]["directorData"])
                {
                    if (objDir["DirectorDisqualified"].ToString() == "Y" || objDir["DIN"].ToString() == "") continue;
                    var din = objDir["DIN"].ToString();
                        var director = _director.GetByDin(din) as Director;
                    if (director == null)
                    {
                        director = new Director()
                        {
                            Id = 0,
                            Din = objDir["DIN"].ToString(),
                            Details = new DirectorDetails()
                        };
                    }
                    director.FirstName = objDir["FirstName"].ToString();
                    director.MiddleName = objDir["MiddleName"].ToString();
                    director.LastName = objDir["LastName"].ToString();

                    // inside director loop
                    var appointStr = objDir.Value<string>("dateOfAppointment");
                    director.AppointmentDate = SafeParseDate(appointStr);

                    var roles = objDir["MCAUserRole"] as JArray;
                    if (roles != null && roles.Count > 0)
                    {
                        director.Mobile = roles[0].Value<string>("mobileNumber");
                        director.Email = roles[0].Value<string>("emailAddress");
                    }
                    director.RefUser = obj.RefUser;
                    director.PreInsert(new AppUser() { Id = obj.CreatedBy });
                    _director.Save(director);
                    obj.Directors.Add(director);

                }
            }
            catch (Exception ex)
            {
            }

            try
            {
                if (jsonObj["results"]["data"]["indexChargesData"] != null)
            {
                // inside SyncCIN
                var chargeArray = jsonObj["results"]?["data"]?["indexChargesData"] as JArray;
                if (chargeArray != null)
                {
                    foreach (var objIoc in chargeArray)
                    {
                        var ioc = new CompanyIndexCharge
                        {
                            Id = 0,
                            CompanyId = obj.Id,
                            SRN = objIoc.Value<string>("SRN"),
                            ChargeId = objIoc.Value<string>("chargeId"),
                            Name = objIoc.Value<string>("chName"),
                            Status = objIoc.Value<string>("chargeStatus"),
                            HolderName = objIoc.Value<string>("chargeHolderName"),

                            // parse amount safely
                            Amount = objIoc.Value<string>("amount") is string amtStr &&
                                     int.TryParse(amtStr, out var amt)
                                       ? amt
                                       : (int?)null,

                            // use your SafeParseDate helper everywhere
                            CreationDate = SafeParseDate(objIoc.Value<string>("dateOfCreation")),
                            ModificationDate = SafeParseDate(objIoc.Value<string>("dateOfModification")),

                            Address1 = objIoc.Value<string>("StreetAddress"),
                            Address2 = string.Join(" ",
                                                objIoc.Value<string>("StreetAddress2"),
                                                objIoc.Value<string>("StreetAddress3"),
                                                objIoc.Value<string>("StreetAddress4"),
                                                objIoc.Value<string>("City"),
                                                objIoc.Value<string>("State"),
                                                objIoc.Value<string>("Country") + " -",
                                                objIoc.Value<string>("PostalCode"))
                        };

                        obj.Charges.Add(ioc);
                    }
                }

            }
            }
            catch (Exception ex)
            {
            }

            //obj.Status = "data.details.company_info.company_status";

            return obj;
        }

        public void SaveDirectors(int company, IEnumerable<Director> directors)
        {
            var i = NpgSQL.NonQuery(R.ConnectionString, $@"delete from {DIRECTOR_TABLE_NAME} where company_id = @cid", new Dictionary<string, object> { { "@cid", company } });
            NpgSQL.NonQuery(R.ConnectionString, $@"insert into {DIRECTOR_TABLE_NAME} values " + string.Join(',', directors.Select(d => $@"(default, {company}, {d.Id}, '{(d.AppointmentDate ?? new DateTime(1990, 1, 1)).ToString("yyyy-MM-dd")}', now())")));
        }

        public void SaveCharges(int company, IEnumerable<CompanyIndexCharge> charges)
        {
            var i = NpgSQL.NonQuery(R.ConnectionString, $@"delete from tbl_company_ioc where company_id = @cid", new Dictionary<string, object> { { "@cid", company } });
            foreach(var c in charges)
            {
                c.CompanyId = company;
                c.InsertIntoDB(R.ConnectionString, "tbl_company_ioc");
            }
        }

        public CompanyDetails GetCompanyDetails(int id = 0)
        {
            var dt = NpgSQL.Query(R.ConnectionString, $@"select * from {DETAILS_TABLE_NAME} where company_id = @id",
               new Dictionary<string, object>
               {
                    { "@id", id },
               })
               .ParseList<CompanyDetails>().FirstOrDefault();
            return dt;
        }

        public CompanyOtherDetails GetCompanyOtherDetails(int id = 0)
        {
            var dt = NpgSQL.Query(R.ConnectionString, $@"select * from {OTHER_DETAILS_TABLE_NAME} where company_id = @id",
               new Dictionary<string, object>
               {
                    { "@id", id },
               })
               .ParseList<CompanyOtherDetails>().FirstOrDefault();
            return dt;
        }

        public List<Director> GetCompanyDirectorList(int id = 0)
        {
            var dt = NpgSQL.Query(R.ConnectionString, $@"select d.*, cd.appointment_date from tbl_company_director cd
inner join tbl_director d on cd.director_id = d.id where cd.company_id = @id;",
               new Dictionary<string, object>
               {
                    { "@id", id },
               })
               .ParseList<Director>().ToList();
            return dt;
        }

        public CompanyFinancialDetails GetCompanyFinancialDetails(int id = 0)
        {
            var dt = NpgSQL.Query(R.ConnectionString, $@"select * from {FINANCIAL_DETAILS_TABLE_NAME} where company_id = @id",
               new Dictionary<string, object>
               {
                    { "@id", id },
               })
               .ParseList<CompanyFinancialDetails>().FirstOrDefault();
            return dt;
        }

        public List<CompanyIndexCharge> GetIndexChargeDetails(int id = 0)
        {
            var dt = NpgSQL.Query(R.ConnectionString, $@"select * from {COMPANY_IOC_TABLE_NAME} where company_id = @id;",
               new Dictionary<string, object>
               {
                    { "@id", id },
               })
               .ParseList<CompanyIndexCharge>().ToList();
            return dt;
        }

        public new Company Save(Company obj)
        {
            if (obj.Id > 0)
            {
                obj.UpdateIntoDB(R.ConnectionString, TABLE_NAME, "id", obj.Id);
                var obj1 = GetById(obj.Id);
                obj.Details.CompanyId = obj.Id;
                obj.OtherDetails.CompanyId = obj.Id;
                obj.FinancialDetails.CompanyId = obj.Id;

                obj.Details.UpdateIntoDB(R.ConnectionString, DETAILS_TABLE_NAME, "id", obj1.Details.Id);
                obj.OtherDetails.UpdateIntoDB(R.ConnectionString, OTHER_DETAILS_TABLE_NAME, "id", obj1.OtherDetails.Id);
                obj.FinancialDetails.UpdateIntoDB(R.ConnectionString, FINANCIAL_DETAILS_TABLE_NAME, "id", obj1.FinancialDetails.Id);
            }
            else
            {
                obj.Id = obj.InsertIntoDBOutIdentity(R.ConnectionString, TABLE_NAME, "id");
                if (obj.Id == 0)
                    //return null;
                        throw new InvalidOperationException("Failed to insert Company record.");

                obj.Details.CompanyId = obj.Id;
                obj.OtherDetails.CompanyId = obj.Id;
                obj.FinancialDetails.CompanyId = obj.Id;

                obj.Details.Id = obj.Details.InsertIntoDBOutIdentity(R.ConnectionString, DETAILS_TABLE_NAME, "id");
                obj.OtherDetails.Id = obj.OtherDetails.InsertIntoDBOutIdentity(R.ConnectionString, OTHER_DETAILS_TABLE_NAME, "id");
                obj.FinancialDetails.Id = obj.FinancialDetails.InsertIntoDBOutIdentity(R.ConnectionString, FINANCIAL_DETAILS_TABLE_NAME, "id");
            }
            return obj;
        }

        public new bool Delete(Company obj)
        {
            return NpgSQL.NonQuery(R.ConnectionString, $@"update {TABLE_NAME} set is_deleted = true, deleted_on = @deleted_on, deleted_by = @deleted_by, is_active = false where id = @id", new Dictionary<string, object>
            {
                { "@deleted_on", DateTime.Now },
                { "@id", obj.Id },
                { "@deleted_by", obj.RefUser }
            }, ThrowError: true) > 0;
        }

        public bool ChangeActiveStatus(Company obj)
        {
            return NpgSQL.NonQuery(R.ConnectionString, $@"update {TABLE_NAME} set is_active = @is_active where id = @id", new Dictionary<string, object>
            {
                { "@is_active", obj.IsActive },
                { "@id", obj.Id }
            }, ThrowError: true) > 0;
        }

        public CompanyView GetByMobile(string mobile = "")
        {
            var dt = NpgSQL.Query(R.ConnectionString, $@"select * from {VIEW_NAME} where company_contact_no = @mobile",
               new Dictionary<string, object>
               {
                    { "@mobile", mobile },
               }, ThrowError: true)
               .ParseList<CompanyView>().FirstOrDefault();
            return dt;
        }

        public bool GenerateOtp(int id, string mobile, string type = "mobile")
        {
            var u = GetById(id);
            int seed = type == mobile ? int.Parse(mobile.Substring(mobile.Length - 4)) : new Random().Next(1000);
            Random rand = new Random(seed);
            var otp = rand.Next(1000, 9999).ToString().PadLeft(4, '0');
            string orderId = "";
            if (R.AppSet<bool>("OTP:Bypass"))
                otp = type == "mobile" ? mobile!.Substring(mobile.Length - 6) : "123456";
            else if (R.AppSet<string>("OTP:BypassNo").Split(',').Contains(mobile))
                otp = mobile!.Substring(mobile.Length - 4);
            else
                orderId = SendOtp(u?.CompanyContactNo ?? mobile, otp);
            var i = new UserOtp
            {
                Otp = orderId.IsBlank() ? otp : orderId,
                OtpType = type == "mobile" ? 1 : 2,
                User = id,
                Mobile = mobile,
                IsValid = true,
                ValidTill = DateTime.Now.AddMinutes(R.AppSet<int>("OTP:ValidityInMin")),
                Verified = false
            }.InsertIntoDB(R.ConnectionString, OTP_TABLE_NAME);
            return i > 0;
        }

        public bool ValidateOtp(int id, string mobile, string otp, string type = "mobile")
        {
            bool res = false;
            var u = GetById(id);
            var obj = NpgSQL.Query(R.ConnectionString, $@"select * from {OTP_TABLE_NAME} where (""user"" = @user or mobile = @mobile) and is_valid = true and otp_type = @type order by id desc limit 1",
                new Dictionary<string, object> { { "@user", id }, { "@mobile", (u?.CompanyContactNo ?? mobile) }, { "@type", type == "mobile" ? 1 : 2 } }, ThrowError: true).ParseList<UserOtp>().FirstOrDefault();
            if (obj != null)
            {
                if (obj.Otp.StartsWith("Otp_"))
                    res = true; // VerifyOtp(u.Mobile, obj.Otp, otp);
                else if (otp == obj.Otp)
                    res = true;
                else
                    res = false;
            }
            if (res == true)
                NpgSQL.NonQuery(R.ConnectionString, $@"update {OTP_TABLE_NAME} set is_valid = false, verified = true where id = @id",
                    new Dictionary<string, object> { { "@id", obj.Id } });
            else
                NpgSQL.NonQuery(R.ConnectionString, $@"update {OTP_TABLE_NAME} set is_valid = false, verified = false where id = @id",
                    new Dictionary<string, object> { { "@id", obj.Id } });
            return res;
        }

        public string SendOtp(string mobile, string otp)
        {
            using HttpClient hc = new HttpClient();
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Post, "https://control.msg91.com/api/v5/flow");
            request.Headers.Add("authkey", R.AppSet("MSG91:AuthKey"));
            request.Headers.Add("accept", "application/json");
            var payload = JsonConvert.SerializeObject(new MSG91_Message
            {
                template_id = R.AppSet("MSG91:AuthTemplate"),
                short_url = "0",
                short_url_expiry = (string?)null,
                realTimeResponse = (string?)null,
                recipients = new List<MSG91_MessageRecipient>{
                    new MSG91_MessageRecipient{
                        mobiles = $@"91{mobile}",
                        VAR1 = otp
                    }
                }
            });
            Console.WriteLine(payload);
            var content = new StringContent(payload, Encoding.UTF8, "application/json");
            request.Content = content;
            var response = client.SendAsync(request).Result;
            response.EnsureSuccessStatusCode();
            Console.WriteLine(response.Content.ReadAsStringAsync().Result);
            return "";
        }

        public IEnumerable<CompanyIndexCharge> GetCharges(int company)
        {
            return NpgSQL.Query(R.ConnectionString, $@"select * from tbl_company_ioc where id = @id", new Dictionary<string, object> { { "@id", company } }).ParseList<CompanyIndexCharge>();
        }


        private DateTime? SafeParseDate(string? input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return null;

            var formats = new[] { "MM/dd/yyyy", "M/d/yyyy", "yyyy-MM-dd", "dd-MM-yyyy" };
            if (DateTime.TryParseExact(input.Trim(),
                                       formats,
                                       CultureInfo.InvariantCulture,
                                       DateTimeStyles.None,
                                       out var exactDt))
            {
                return exactDt;
            }

            if (DateTime.TryParse(input,
                                  CultureInfo.InvariantCulture,
                                  DateTimeStyles.AssumeLocal,
                                  out var generalDt))
            {
                return generalDt;
            }

            // Log or swallow
            return null;
        }

        public IEnumerable<CompanyView> GetByUserId(int id = 0)
        {
            var dt = NpgSQL.Query(R.ConnectionString, $@"select * from tbl_company where ref_user = @id order by (is_deleted = 'false')::boolean DESC , id desc;",
               new Dictionary<string, object>
               {
                    { "@id", id },
               })
               .ParseList<CompanyView>();
            return dt;
        }

        public IEnumerable<CompanyView> GetByUserIdS2(int id = 0)
        {
            var dt = NpgSQL.Query(R.ConnectionString, $@"select * from tbl_company where ref_user = @id and is_deleted = 'false';",
               new Dictionary<string, object>
               {
                    { "@id", id },
               })
               .ParseList<CompanyView>();
            return dt;
        }

        public int CompanyCountByUserId(int id = 0)
        {
            var i = NpgSQL.Query(R.ConnectionString, $@"select count(1) as company_count from {VIEW_NAME} where ref_user = @id",
               new Dictionary<string, object>
               {
                    { "@id", id },
               });
            return Convert.ToInt32(i.Rows[0].ItemArray[0] == System.DBNull.Value ? 0 : i.Rows[0].ItemArray[0]);
        }

        public int TrialCompanyCount(int userId)
        {
            var i = NpgSQL.Query(R.ConnectionString, $@"select sum(sp.no_of_company) as total_company_limit from tbl_user_subscriptions us inner join tbl_subscription_plans sp on us.subscription_id = sp.id
                where us.subscription_id = 1 and us.is_active = true and us.user_id = @userId;",
               new Dictionary<string, object>
               {
                    { "@userId", userId },
               });
            return Convert.ToInt32(i.Rows[0].ItemArray[0] == System.DBNull.Value ? 0 : i.Rows[0].ItemArray[0]);
        }

        public int PurchaseCompanyLimit(int userId)
        {
            var i = NpgSQL.Query(R.ConnectionString, $@"select sum(sp.no_of_company) as total_company_limit from tbl_user_subscriptions us inner join tbl_subscription_plans sp on us.subscription_id = sp.id
                where us.subscription_id > 1 and us.is_active = true and us.user_id = @userId;",
               new Dictionary<string, object>
               {
                    { "@userId", userId },
               });
            return Convert.ToInt32(i.Rows[0].ItemArray[0] == System.DBNull.Value ? 0 : i.Rows[0].ItemArray[0]);
        }

        public int UsedCompanyLimit(int userId)
        {
            var i = NpgSQL.Query(R.ConnectionString, $@"select count(1) as used_company_limit from tbl_company where ref_user = @userId;",
               new Dictionary<string, object>
               {
                    { "@userId", userId },
               });
            return Convert.ToInt32(i.Rows[0].ItemArray[0] == System.DBNull.Value ? 0 : i.Rows[0].ItemArray[0]);
        }
    }
}
