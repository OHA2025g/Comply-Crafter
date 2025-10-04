using ComplyCrafter_BL;
using ComplyCrafter_Data;
using ComplyCrafter_UI.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
using System.Net.Http;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Transactions;

namespace ComplyCrafter_UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        //private static readonly HttpClient _client = new HttpClient();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Login(string? message)
        {
            //For message return in url
            if (!string.IsNullOrEmpty(message))
                ViewBag.Message = message;

            ViewBag.SessionValidity = Convert.ToInt16(R.AppSessionTime) * 60 * 60 * 1000;
            ViewBag.BrowserId = Guid.NewGuid();
            return View();
        }
        public IActionResult Logout()
        {
            AppUtilities.AppUserEmailId = string.Empty;
            AppUtilities.AppUserRole = string.Empty;
            TempData.Clear();
            return View();
        }
        public IActionResult Signup(string? message)
        {
            //For message return in url
            if (!string.IsNullOrEmpty(message))
                ViewBag.Message = message;

            return View();
        }

        public IActionResult ResetPassword(string? Key)
        {
            if (string.IsNullOrEmpty(Key))
                return RedirectToAction("Login", "Home");
            ViewBag.Key = Key;
            return View();
        }

        public IActionResult ResetCCPIN(string? Key)
        {
            if (string.IsNullOrEmpty(Key))
                return RedirectToAction("Login", "Home");
            ViewBag.Key = Key;
            return View();
        }

        public async Task<IActionResult> Subscription()
        {

            string? token = Request.Cookies["ComplyCrafterSessionId"];

            if (!string.IsNullOrEmpty(token))
            {
                // Use the sessionId for further logic (e.g., authorization, API calls, etc.)
                Console.WriteLine($"Session ID: {token}");
            }

            using var httpClient = new HttpClient();
            var apiUrl = @R.ApiUrl + "/SubscriptionPlans/PlanList";

            try
            {
                if (!string.IsNullOrEmpty(token))
                {
                    httpClient.DefaultRequestHeaders.Authorization =
                    new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
                }

                var response = await httpClient.GetAsync(apiUrl);
                response.EnsureSuccessStatusCode();

                var json = await response.Content.ReadAsStringAsync();


                var plans = JsonSerializer.Deserialize<List<SubscriptionPlans>>(json, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

                return View(plans);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return View(new List<SubscriptionPlans>());
            }
        }

        public IActionResult PlanDetails()
        {
            return View();
        }

        public IActionResult PaymentSuccess(string? TransactionId)
        {
            if (string.IsNullOrEmpty(TransactionId))
                return RedirectToAction("Subscription", "Home");
            ViewBag.TransactionId = TransactionId;
            return View();
        }

        public IActionResult PaymentFailed(string? TransactionId)
        {
            if (string.IsNullOrEmpty(TransactionId))
                return RedirectToAction("Subscription", "Home");
            ViewBag.TransactionId = TransactionId;
            return View();
        }


        public IActionResult Profile()
        {
            return View();
        }
        public IActionResult CustomerLogin()
        {
            return View();
        }
        public async Task<IActionResult> Index()
        {
            try
            {
                var apiUrl = @R.ApiUrl + "/Auth/UserInfo";
                String sResult = await GetAPIResult(apiUrl, "GET", null);
                APIResponse? _apiResponse = new APIResponse();
                if (!String.IsNullOrEmpty(sResult))
                {
                    _apiResponse = System.Text.Json.JsonSerializer.Deserialize<APIResponse>(sResult, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
                }
                if (_apiResponse != null)
                {
                    if (_apiResponse.status)
                    {
                        ViewBag.Message = _apiResponse.message;
                        APIResponseUserDetails? _apiResponseUD = new APIResponseUserDetails();
                        _apiResponseUD = System.Text.Json.JsonSerializer.Deserialize<APIResponseUserDetails>(_apiResponse.responseObject.ToString(), new JsonSerializerOptions
                        {
                            PropertyNameCaseInsensitive = true
                        });
                        TempData["EmailId"] = _apiResponseUD.Email;
                        TempData["RoleName"] = _apiResponseUD.RoleName;
                        AppUtilities.AppUserEmailId = _apiResponseUD.Email;
                        AppUtilities.AppUserRole = _apiResponseUD.RoleName;
                    }
                }
            }
            catch (Exception ex)
            {
            }

            return View();
        }
        public IActionResult Company()
        {
            return View();
        }

        [HttpGet("[controller]/Company/{id}")]
        public IActionResult ViewCompany(int id = 0)
        {
            if (id <= 0) return RedirectToAction("Company");
            ViewBag.id = id;
            return View();
        }

        [HttpGet("[controller]/Company/Add/{id}")]
        [HttpGet("[controller]/Company/Edit/{id}", Name = "CompanyEdit")]
        public IActionResult AddCompany(int id = 0)
        {
            if (id <= 0) return RedirectToAction("Company");
            ViewBag.id = id;
            return View();
        }

        [HttpGet("[controller]/Company/{cid}/Notice")]
        public IActionResult CompanyNotice(int cid = 0)
        {
            if (cid <= 0) return RedirectToAction("Company");
            ViewBag.cid = cid;
            ViewBag.ctrl = "CompanyNotice";
            return View();
        }

        [HttpGet("[controller]/Company/{cid}/Notice/Add")]
        [HttpGet("[controller]/Company/{cid}/Notice/Edit/{id}")]
        public IActionResult AddCompanyNotice(int cid = 0, int id = 0)
        {
            if (cid <= 0) return RedirectToAction("Company");
            ViewBag.id = id;
            ViewBag.cid = cid;
            ViewBag.ctrl = "CompanyNotice";
            return View();
        }

        [HttpGet("[controller]/CompanyNoticePrint/{id}")]
        public IActionResult CompanyNoticePrint(int id = 0)
        {
            if (id <= 0) return RedirectToAction("Company");
            ViewBag.id = id;
            ViewBag.ctrl = "CompanyNotice";
            return View();
        }
        public IActionResult Director()
        {
            return View();
        }


        [HttpGet("[controller]/Director/Details/{id}")]
        public IActionResult ViewDirector(int id = 0)
        {
            if (id <= 0) return RedirectToAction("Director");
            ViewBag.id = id;
            return View();
        }

        [HttpGet("[controller]/Director/Add")]
        [HttpGet("[controller]/Director/Add/{id}")]
        [HttpGet("[controller]/Director/Edit/{id}")]
        //[HttpGet("[controller]/Director/View/{id}")] 
        public IActionResult AddDirector(int id = 0, string mode = "edit")
        {
            ViewBag.id = id;
            ViewBag.mode = mode; 
            return View();
        }
        public IActionResult Shareholder()
        {
            ViewBag.ctrl = "Shareholder";
            return View();
        }

        [HttpGet("[controller]/Shareholder/Add")]
        [HttpGet("[controller]/Shareholder/Add/{id}")]
        [HttpGet("[controller]/Shareholder/Edit/{id}")]
        public IActionResult AddShareholder(int id = 0)
        {
            ViewBag.id = id;
            ViewBag.ctrl = "Shareholder";
            return View();
        }
        public IActionResult Debenture()
        {
            ViewBag.ctrl = "Debenture";
            return View();
        }

        [HttpGet("[controller]/Debenture/Add")]
        [HttpGet("[controller]/Debenture/Add/{id}")]
        [HttpGet("[controller]/Debenture/Edit/{id}")]
        public IActionResult AddDebenture(int id = 0)
        {
            ViewBag.id = id;
            ViewBag.ctrl = "Debenture";
            return View();
        }
        public IActionResult Auditor()
        {
            ViewBag.ctrl = "Auditor";
            return View();
        }

        [HttpGet("[controller]/Auditor/Add")]
        [HttpGet("[controller]/Auditor/Add/{id}")]
        [HttpGet("[controller]/Auditor/Edit/{id}")]
        public IActionResult AddAuditor(int id = 0)
        {
            ViewBag.id = id;
            ViewBag.ctrl = "Auditor";
            return View();
        }

        public IActionResult OtherAuditor()
        {
            ViewBag.ctrl = "OtherAuditor";
            return View();
        }

        [HttpGet("[controller]/OtherAuditor/Add")]
        [HttpGet("[controller]/OtherAuditor/Add/{id}")]
        [HttpGet("[controller]/OtherAuditor/Edit/{id}")]
        public IActionResult AddOtherAuditor(int id = 0)
        {
            ViewBag.id = id;
            ViewBag.ctrl = "OtherAuditor";
            return View();
        }

        [HttpGet("[controller]/Meeting/{type}")]
        public IActionResult Meeting(string type = "")
        {
            ViewBag.ctrl = "Meeting";
            ViewBag.type = type.ToLower();
            return View();
        }

        [HttpGet("[controller]/Meeting/{type}/Add")]
        [HttpGet("[controller]/Meeting/{type}/Edit/{id}")]
        public IActionResult AddMeeting(int id = 0, string type = "")
        {
            ViewBag.id = id;
            ViewBag.ctrl = "Meeting";
            ViewBag.type = type.ToLower();
            return View();
        }

        [HttpPost]
        public IActionResult MeetingAckPrint(string query)
        {
            ViewBag.Query = query;
            return View();
        }

        public IActionResult Sharecertificate()
        {
            return View();
        }

        public IActionResult Process()
        {
            return View();
        }
        [HttpGet("[controller]/Process/{id}")]
        public IActionResult ViewProcess(int id = 0)
        {
            if (id <= 0) return RedirectToAction("Process");
            ViewBag.id = id;
            return View();
        }

        public IActionResult CapitalAddclass()
        {
            ViewBag.ctrl = "CapitalAddclass";

            return View();
        }


        [HttpGet("[controller]/Capital/{type}")]
        public IActionResult Capital(string type = "")
        {
            ViewBag.ctrl = "Capital";
            ViewBag.type = type;

            if (type == "CapitalAddclass")
                return View("CapitalAddclass"); 
            else
                return View("Capital");
        }

        [HttpGet("[controller]/Capital/{type}/Add")]
        [HttpGet("[controller]/Capital/{type}/Edit/{id}")]
        public IActionResult AddCapital(int id = 0, string type = "")
        {
            ViewBag.id = id;
            ViewBag.ctrl = "Capital";
            ViewBag.type = type;
            return View();
        }
        public IActionResult ShareholderManagement()
        {
            ViewBag.ctrl = "ShareholderManagement";
            return View();
        }

        [HttpGet("[controller]/ShareholderManagement/Add")]
        [HttpGet("[controller]/ShareholderManagement/Edit/{id}")]
        public IActionResult AddShareholderManagement(int id = 0)
        {
            ViewBag.id = id;
            ViewBag.ctrl = "ShareholderManagement";
            return View();
        }
        public IActionResult Resolution()
        {
            ViewBag.ctrl = "Resolution";
            return View();
        }

        [HttpGet("[controller]/Resolution/{id}")]
        public IActionResult ViewResolution(int id = 0)
        {
            if (id <= 0) return RedirectToAction("Resolution");
            ViewBag.id = id;
            return View();
        }




        public IActionResult Standardchecklist()
        {
            ViewBag.ctrl = "Standardchecklist";
            return View();
        }


        public IActionResult DMS()
        {
            ViewBag.ctrl = "DMS";
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        public async Task GoogleSignup()
        {
            await HttpContext.ChallengeAsync(GoogleDefaults.AuthenticationScheme, new AuthenticationProperties
            {
                RedirectUri = Url.Action("GoogleResponse")
            });
        }

        //public async Task<IActionResult> GoogleResponse()
        //{
        //    var results = await HttpContext.AuthenticateAsync(CookieAuthenticationDefaults.AuthenticationScheme);

        //    if (!results.Succeeded)
        //    {
        //        return RedirectToAction("Signup", "Home");
        //    }


        //    var vEmailId = results.Principal.Identities.FirstOrDefault().Claims.FirstOrDefault(claim => claim.Type.Contains("claims/emailaddress")).Value;
        //    //var vFullName = results.Principal.Identities.FirstOrDefault().Claims.FirstOrDefault(claim => claim.Type.Contains("claims/name")).Value;

        //    var vFullName = results.Principal.Identities
        //    .FirstOrDefault()?
        //    .Claims
        //    .Where(claim => claim.Type.Contains("claims/name"))
        //    .Skip(1)
        //    .FirstOrDefault()?.Value;
        //    var vFirstName = results.Principal.Identities.FirstOrDefault().Claims.FirstOrDefault(claim => claim.Type.Contains("claims/givenname")).Value;
        //    var vLastName = results.Principal.Identities.FirstOrDefault().Claims.FirstOrDefault(claim => claim.Type.Contains("claims/surname")).Value;

        //    TempData["GoogleEmailAddress"] = vEmailId;
        //    TempData["GoogleFullName"] = vFullName;
        //    TempData["GoogleFirstName"] = vFirstName;
        //    TempData["GoogleLastName"] = vLastName;
        //    return RedirectToAction("GoogleSignUpSuccess", "Home");
        //}

        public async Task<IActionResult> GoogleResponse()
        {
            var result = await HttpContext.AuthenticateAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            if (!result.Succeeded || result.Principal is null)
                return RedirectToAction("Signup", "Home");

            var p = result.Principal;

            // helpers to safely read claims with fallbacks
            string? Get(params string[] types) =>
                types.Select(t => p.FindFirst(t)?.Value).FirstOrDefault(v => !string.IsNullOrWhiteSpace(v));

            var vEmailId = Get(ClaimTypes.Email, "email");
            var vFirstName = Get(ClaimTypes.GivenName, "given_name");
            var vLastName = Get(ClaimTypes.Surname, "family_name");
            var vFullName = Get(ClaimTypes.Name, "name")
                             ?? $"{vFirstName} {vLastName}".Trim();

            // (Optional) if email is mandatory, redirect if missing
            if (string.IsNullOrWhiteSpace(vEmailId))
                return RedirectToAction("Signup", "Home");

            TempData["GoogleEmailAddress"] = vEmailId ?? "";
            TempData["GoogleFullName"] = vFullName ?? "";
            TempData["GoogleFirstName"] = vFirstName ?? "";
            TempData["GoogleLastName"] = vLastName ?? "";

            return RedirectToAction("GoogleSignUpSuccess", "Home");
        }


        public IActionResult GoogleSignUpSuccess()
        {
            ViewBag.IsGoogleSignUpSuccess = true;
            ViewBag.EmailAddress = TempData["GoogleEmailAddress"];
            ViewBag.FirstName = TempData["GoogleFirstName"];
            ViewBag.LastName = TempData["GoogleLastName"];
            ViewBag.FullName = TempData["GoogleFullName"];
            ViewBag.IsEmailVerified = true;
            ViewBag.SignUpBy = "GoogleAuth";
            ViewBag.Password = "Pass@1234";
            TempData.Clear();
            return View();
        }

        public IActionResult VerifyEmail()
        {
            ViewBag.ctrl = "VerifyEmail";
            return View();
        }

        public IActionResult ValidateEmail(string Key)
        {
            if (!string.IsNullOrEmpty(Key))
            {
                ViewBag.ctrl = "Validate Email";
                ViewBag.Key = Key;
                return View();
            }
            else
                return RedirectToAction("Login");

        }

        public IActionResult VerifyOTP(string? emailId, string? mobileNumber, string? message)
        {
            ViewBag.OTPValidity = Convert.ToInt16(R.AppOTPTime) * 60;
            ViewBag.ctrl = "Verify OTP";
            ViewBag.EmailAddress = emailId;
            ViewBag.MobileNumber = mobileNumber;
            ViewBag.Message = message;
            ViewBag.MobileVerify = message;
            return View();
        }

        public IActionResult SetCCPIN(string? emailId, string? key)
        {
            ViewBag.IsReset = false;
            if (!string.IsNullOrEmpty(key))
                ViewBag.IsReset = true;

            ViewBag.EmailAddress = emailId;
            ViewBag.Key = key;
            ViewBag.ctrl = "SetCCPIN";
            return View();
        }

        public IActionResult RedirectToActionName(string sActionName)
        {
            return RedirectPermanent(sActionName);
        }

        public IActionResult ResetEmail()
        {
            return View();
        }

        public async Task<IActionResult> SetSubUserPassword(string? emailId, string? key)
        {
            if (string.IsNullOrEmpty(key) || string.IsNullOrEmpty(emailId))
                return RedirectToAction("Login", "Home");

            ViewBag.EmailAddress = emailId;
            ViewBag.Key = key;

            // For sub user from email link
            if (!string.IsNullOrEmpty(key) && !string.IsNullOrEmpty(emailId))
            {
                if (!CustomValidations.IsValidEmail(emailId))
                    ViewBag.Message = "Invalid link. Please contact support team.";

                var apiUrl = @R.ApiUrl + "/Email/ValidateRegistrationEmail?Key=" + key + "&email=" + emailId;
                String sResult = await GetAPIResult(apiUrl, "GET", null);
                APIResponse? _apiResponse = new APIResponse();
                if (!String.IsNullOrEmpty(sResult))
                {
                    _apiResponse = System.Text.Json.JsonSerializer.Deserialize<APIResponse>(sResult, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
                }
                if (_apiResponse != null)
                {
                    ViewBag.Message = _apiResponse.message;
                }
            }

            return View();
        }

        #region GetAPIResult
        public async Task<string> GetAPIResult(string sAPIUrl, string sMethod, object? requestBody)
        {
            string sResult = string.Empty;
            string? token = Request.Cookies["ComplyCrafterSessionId"];

            using var httpClient = new HttpClient();

            try
            {
                // Serialize object to JSON
                var json = JsonSerializer.Serialize(requestBody);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                if (!string.IsNullOrEmpty(token))
                {
                    httpClient.DefaultRequestHeaders.Authorization =
                    new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
                }

                HttpResponseMessage _response = new HttpResponseMessage();
                switch (sMethod)
                {
                    case "GET":
                        _response = await httpClient.GetAsync(sAPIUrl);
                        break;

                    case "POST":
                        _response = await httpClient.PostAsync(sAPIUrl, content);
                        break;

                    case "PATCH":
                        _response = await httpClient.PatchAsync(sAPIUrl, content);
                        break;

                    case "PUT":
                        _response = await httpClient.PutAsync(sAPIUrl, content);
                        break;

                    case "DELETE":
                        _response = await httpClient.DeleteAsync(sAPIUrl);
                        break;
                }

                // Handle response
                sResult = await _response.Content.ReadAsStringAsync();
            }
            catch (Exception ex)
            {
            }

            return sResult;
        }
        #endregion

        [HttpGet]
        public async Task GoogleSignIn()
        {
            await HttpContext.ChallengeAsync(GoogleDefaults.AuthenticationScheme, new AuthenticationProperties
            {
                RedirectUri = Url.Action("GoogleSignInResponse")
            });
        }

        //public async Task<IActionResult> GoogleSignInResponse()
        //{
        //    var results = await HttpContext.AuthenticateAsync(CookieAuthenticationDefaults.AuthenticationScheme);

        //    if (!results.Succeeded)
        //    {
        //        return RedirectToAction("Login", "Home");
        //    }

        //    var vEmailId = results.Principal.Identities.FirstOrDefault().Claims.FirstOrDefault(claim => claim.Type.Contains("claims/emailaddress")).Value;
        //    //var vFullName = results.Principal.Identities.FirstOrDefault().Claims.FirstOrDefault(claim => claim.Type.Contains("claims/name")).Value;

        //    var vFullName = results.Principal.Identities
        //    .FirstOrDefault()?
        //    .Claims
        //    .Where(claim => claim.Type.Contains("claims/name"))
        //    .Skip(1)
        //    .FirstOrDefault()?.Value;
        //    var vFirstName = results.Principal.Identities.FirstOrDefault().Claims.FirstOrDefault(claim => claim.Type.Contains("claims/givenname")).Value;
        //    var vLastName = results.Principal.Identities.FirstOrDefault().Claims.FirstOrDefault(claim => claim.Type.Contains("claims/surname")).Value;

        //    TempData["GoogleEmailAddress"] = vEmailId;
        //    TempData["GoogleFullName"] = vFullName;
        //    TempData["GoogleFirstName"] = vFirstName;
        //    TempData["GoogleLastName"] = vLastName;
        //    return RedirectToAction("GoogleSignInSuccess", "Home");
        //}


        public async Task<IActionResult> GoogleSignInResponse()
        {
            var result = await HttpContext.AuthenticateAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            if (!result.Succeeded || result.Principal is null)
                return RedirectToAction("Login", "Home");

            var p = result.Principal;

            string? Get(params string[] types) =>
                types.Select(t => p.FindFirst(t)?.Value).FirstOrDefault(v => !string.IsNullOrWhiteSpace(v));

            var vEmailId = Get(ClaimTypes.Email, "email");
            var vFirstName = Get(ClaimTypes.GivenName, "given_name");
            var vLastName = Get(ClaimTypes.Surname, "family_name");
            var vFullName = Get(ClaimTypes.Name, "name") ?? $"{vFirstName} {vLastName}".Trim();

            // If email is mandatory for sign-in, bounce back gracefully
            if (string.IsNullOrWhiteSpace(vEmailId))
                return RedirectToAction("Login", "Home");

            TempData["GoogleEmailAddress"] = vEmailId ?? "";
            TempData["GoogleFullName"] = vFullName ?? "";
            TempData["GoogleFirstName"] = vFirstName ?? "";
            TempData["GoogleLastName"] = vLastName ?? "";

            return RedirectToAction("GoogleSignInSuccess", "Home");
        }


        public IActionResult GoogleSignInSuccess()
        {
            ViewBag.IsGoogleSignUpSuccess = true;
            ViewBag.EmailAddress = TempData["GoogleEmailAddress"];
            ViewBag.SessionValidity = Convert.ToInt16(R.AppSessionTime) * 60 * 60 * 1000;
            ViewBag.BrowserId = Guid.NewGuid();
            ViewBag.SignUpBy = "GoogleAuth";
            TempData.Clear();
            return View();
        }


       

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult ViewCompanyPDF(int companyId)
        {
            if (companyId <= 0)
                return RedirectToAction("Login", "Home");
            ViewBag.CompanyId = companyId;
            return View();
        }
    }
}
