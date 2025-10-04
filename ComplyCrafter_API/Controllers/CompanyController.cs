using AlphaUtil.Core;
using AlphaUtil.Core.Models;
using Microsoft.AspNetCore.Mvc;
using ComplyCrafter_BL;
using ComplyCrafter_Data;
using static QRCoder.PayloadGenerator;
using Newtonsoft.Json;
using System.Xml.Linq;
using System.Web;

namespace ComplyCrafter_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CompanyController : BaseController<Company, CompanyView>
    {
        private readonly ICompany _impl;
        private readonly IApiLog _apiLog;
        private readonly IUserSubscriptions _userSub;

        public CompanyController(ICompany impl, IApiLog apiLog, IUserSubscriptions userSubscriptions) : base(impl)
        {
            this._impl = impl;
            _apiLog = apiLog;
            _userSub = userSubscriptions;
        }

        //Get Company List for logged in user
        [Authorize]
        [HttpGet("CompanyList")]
        public virtual IEnumerable<CompanyView> UserCompanyList()
        {
            IEnumerable<CompanyView> res = _impl.GetByUserId(User!.CompanyAdminUserId);
            return res;
        }

        [HttpGet("NameToCin/{name}")]
        public async Task<Response> NameToCin(string name = "")
        {
            if (string.IsNullOrWhiteSpace(name)) return new Response(false, "Company name is empty");

            var requestBody = new
            {
                company_name_search = name
            };
            //var a = await _apiLog.HitApi("https://localhost:7200/api/Company", null, HttpMethod.Get);
            //var a = await _apiLog.HitApi(R.AppSet("SurePass:NameToCin"), requestBody, HttpMethod.Post);
            var a = Http.GetString($@"http://45.142.237.183:8080/mca/search?search_type=company&id={HttpUtility.UrlEncode(name)}");
            return new Response(true, "Successfully", a);
        }

        [Authorize]
        [HttpGet("Create/{cin}")]
        public async Task<Response?> Create(string cin = "")
        {
            Company? obj = _impl.GetByCin(cin, User!.CompanyAdminUserId);
            if (!obj.IsNull())
                return new Response(false, "CIN already exists");
            if (string.IsNullOrWhiteSpace(cin)) return new Response(false, "Company name is empty");

            //Checking Trial pack and company used rules
            string sCompanyRule = ValidateEntityLimitRules();
            if (sCompanyRule != "success")
                return new Response(false, sCompanyRule);

            var requestBody = new
            {
                id_number = cin
            };
            //var a = await _apiLog.HitApi("https://localhost:7200/api/Company", null, HttpMethod.Get);
            //var a = await _apiLog.HitApi(R.AppSet("SurePass:CinToDetail"), requestBody, HttpMethod.Post);

            //var a = Http.GetString($@"https://dev.complycrafter.com/MCA_API/api/cin/{cin}");
            var a = Http.GetString($@"http://45.142.237.183:8080/mca/search?search_type=cin&id={cin}");
            if (a == null)
            {
                return new Response(false, "Unable to get data from API");
            }
            obj = new Company()
            {
                Details = new CompanyDetails() { },
                OtherDetails = new CompanyOtherDetails() { },
                FinancialDetails = new CompanyFinancialDetails() { }

            };
            obj.RefUser = User!.CompanyAdminUserId; //Company added on behalf of login user
            obj = _impl.SyncCIN(obj, a);
            if (obj.IsNull())
                return new Response(false, "Unable to get data from CIN API");

            if (User == null) User = new AppUser { Id = -1 };
            obj.PreInsert(User!);
            obj.IsDeleted = false;
            obj.CompanyType = obj.CompanyType.ToLower() == "comapny" ? "Entity" : obj.CompanyType;
            //var vCompany = _impl.GetByCIN(obj.RefUser, obj.Cin);
            //if(vCompany != null)
            //    return new Response(false, "Company already exists.");


            Company? obj1 = _impl.GetByCin(cin, User!.CompanyAdminUserId);
            if (!obj1.IsNull())
                return new Response(false, "CIN already exists");



            //Checking Trial pack and company used rules
            sCompanyRule = ValidateEntityLimitRules();
            if (sCompanyRule != "success")
                return new Response(false, sCompanyRule);



            var r = _impl.Save(obj);
            if (r.IsNull())
                return new Response(false, CONST.SaveError);
            _impl.SaveDirectors(r.Id, obj.Directors);
            _impl.SaveCharges(r.Id, obj.Charges);
            return new Response(true, a, r!.Id);
        }

        [Authorize(CompanyAdmin: true)]
        [HttpDelete("Delete")]
        public virtual Response? Delete(int id = 0)
        {
            var obj = _impl.GetById(id);
            if (obj.IsNull()) return new Response(false, "Entry not found");
            var r = _impl.Delete(obj!);
            if (r.IsNull())
                return new Response(false, CONST.DeleteError);
            return new Response(true, CONST.DeleteSuccess, obj!);

        }


        [HttpGet("{id}/Status/{status}")]
        public Response? ChangeActiveStatus(int id = 0, bool status = false)
        {
            Company? obj = _impl.GetById(id);
            if (obj.IsNull())
                return new Response(false, "Entry not found");
            obj.IsActive = status;
            //if (obj.User != User!.Id && User._Role != AppRole.Admin)
            //    return new Response(false, "You are not authorized to delete this booking");
            var r = _impl.ChangeActiveStatus(obj!);
            if (r.IsNull())
                return new Response(false, CONST.ChangeStatusError);
            return new Response(true, "Successfully " + (status ? "activated" : "disabled"));
        }

        [HttpGet("{id}/Sync")]
        public async Task<Response?> Sync(int id = 0)
        {
            Company? obj = _impl.GetById(id);
            if (obj.IsNull())
                return new Response(false, "Company does not exist");
            //var requestBody = new
            //{
            //    id_number = obj.Cin
            //};
            //var a = await _apiLog.HitApi(R.AppSet("SurePass:CinToDetail"), requestBody, HttpMethod.Post);
            //if (a == null) {
            //    return new Response(false, "Unable to get data from API");
            //}
            //var a = Http.GetString($@"https://dev.complycrafter.com/MCA_API/api/cin/{obj.Cin}");
            var a = Http.GetString($@"http://45.142.237.183:8080/mca/search?search_type=cin&id={obj.Cin}");
            if (a == null)
            {
                return new Response(false, "Unable to get data from API");
            }
            obj = _impl.SyncCIN(obj, a);
            if (obj.IsNull())
                return new Response(false, "Error while parsing CIN Data");

            if (User == null) User = new AppUser { Id = -1 };
            obj.PreInsert(User!);
            var r = _impl.Save(obj);
            if (r.IsNull())
                return new Response(false, CONST.SaveError);
            _impl.SaveDirectors(r.Id, obj.Directors);
            _impl.SaveCharges(r.Id, obj.Charges);
            return new Response(true, "Synced Successfully", r);
        }

        [Authorize]
        [HttpGet("S2")]
        public IEnumerable<CompanyView> AllSelect2(string query = "")
        {
            var list = _impl.GetByUserIdS2(User!.CompanyAdminUserId);
            list = list.Where(u => u.IsActive);
            if (!string.IsNullOrWhiteSpace(query))
                list = list.Where(u => (u.CompanyName?.ToLower().Contains(query.ToLower()) ?? false));
            return list;
            //var dict = users.OrderBy(q => q.Name).ToDictionary(u => u.Id, u => u.Name);
            //return JQuery.A_ServeSelect2(dict!, q, 20);
        }

        [HttpGet("{id}/charges")]
        public IEnumerable<CompanyIndexCharge> GetCharges(int id)
        {
            return _impl.GetCharges(id);
        }

        [HttpGet("PinCode/{pinCode}")]
        public ActionResult PinCode(string pinCode)
        {
            var a = Http.GetString($@"https://api.postalpincode.in/pincode/{HttpUtility.UrlEncode(pinCode)}");

            return Content(a, "application/json");
        }

        [Authorize]
        [HttpGet("CompanyUsedCount")]
        public ActionResult CompanyUsedCount()
        {
            var used = _userSub.UsedCompanyCount(User!.CompanyAdminUserId);
            var total = _userSub.TotalCompanyCount(User!.CompanyAdminUserId);
            total = total == 0 ? 3 : total;// for by default 3
            var result = $"{used} out of {total}";

            return Content(result, "text/plain");
        }

        [HttpGet("IsMCAReachable")]
        public async Task<bool> IsMCAReachable()
        {
            try
            {
                using var client = new HttpClient();
                client.Timeout = TimeSpan.FromSeconds(30); // optional timeout

                var response = await client.GetAsync(R.AppSet("MCA:MCAURL"));
                return response.IsSuccessStatusCode; // true for 200-299
            }
            catch
            {
                return false; // unreachable or error
            }
        }

        [NonAction]
        public string ValidateEntityLimitRules()
        {
            string sMessage = "success";
            if (User! != null)
            {
                //Code to check to company limits
                int iPlanCompanyCount = _impl.PurchaseCompanyLimit(User!.CompanyAdminUserId); // Company limits purchase from subscription
                int iUsedCompanyCount = _impl.UsedCompanyLimit(User!.CompanyAdminUserId); // Utilized company limit

                if (iPlanCompanyCount == 0 && iUsedCompanyCount == 0)
                {
                    UserSubscriptionsRepository _iuserSub = new UserSubscriptionsRepository();
                    var vCheckTrialPack = _iuserSub.GetTrialPackInfo(User!.CompanyAdminUserId);
                    if (vCheckTrialPack == null) // If trial pack not present then create entry
                    {
                        UserSubscriptions _us = new UserSubscriptions();

                        _us.SubscriptionId = 1;
                        _us.UserId = User!.CompanyAdminUserId;
                        _us.StartDate = DateTime.Now;
                        _us.EndDate = DateTime.Now.AddDays(13);
                        _us.PurchasedOn = DateTime.Now;
                        _us.IsActive = true;
                        var vTrialPacks = _iuserSub.PurchaseSubscription(_us);
                        if (vTrialPacks == null)
                            sMessage = "Trial activation failed. Please try again, or contact us if the problem continues.";
                    }
                }

                //Checking Trial Pack utilization
                var vTrialPack = _userSub.GetTrialPackInfo(User!.CompanyAdminUserId);
                if (vTrialPack != null)
                {
                    iPlanCompanyCount = iPlanCompanyCount + _impl.TrialCompanyCount(User!.CompanyAdminUserId); // trial Company limits purchase from subscription

                    if (Convert.ToDateTime(vTrialPack.EndDate.Date).Date == DateTime.Now.Date)
                        sMessage = "Your trial period has ended today. To keep enjoying full access, please upgrade to a subscription plan;";

                    if (iUsedCompanyCount >= iPlanCompanyCount)
                        sMessage = "You're on a free trial! You can add up to " + iPlanCompanyCount +
                            " companies during this period. To add more than " + iPlanCompanyCount + " companies, please upgrade to subscription plan.";
                }
                else
                {
                    // checking company limit utilized 
                    if (iPlanCompanyCount > 0 && (iPlanCompanyCount == iUsedCompanyCount || iPlanCompanyCount < iUsedCompanyCount))
                        sMessage = "You've reached your company limit of " + iPlanCompanyCount + ". To continue, please upgrade your subscription plan.";
                }
            }
            else sMessage = "Invalid company add request.";
            return sMessage;
        }
    }

}