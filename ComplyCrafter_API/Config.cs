using AlphaUtil.Core.Models;
using AlphaUtil.Core;
using ComplyCrafter_Data;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;
using System.Net;
using ComplyCrafter_BL;

namespace ComplyCrafter_API
{
    public static class Config
    {
        public static void InitServices(IServiceCollection services)
        {
            services.AddTransient<IUser, UserRepository>();
            services.AddTransient<ICompany, CompanyRepository>();
            services.AddTransient<IDirector, DirectorRepository>();
            services.AddTransient<IShareholder, ShareholderRepository>();
            services.AddTransient<IDebenture, DebentureRepository>();
            services.AddTransient<IAuditor, AuditorRepository>();
            services.AddTransient<IOtherAuditor, OtherAuditorRepository>();
            services.AddTransient<IResolution, ResolutionRepository>();
            services.AddTransient<IApiLog, ApiLogRepository>();

            services.AddTransient<ICompanyNotice, CompanyNoticeRepository>();
            services.AddTransient<IMeeting, MeetingRepository>();
            services.AddTransient<IMeetingAgendaDetail, MeetingAgendaDetailRepository>();
            services.AddTransient<ICapital, CapitalRepository>();
            services.AddTransient<IShareholderManagement, ShareholderManagementRepository>();


            // Forms Start 
            // CHG
            services.AddTransient<ICHG1, CHG1Repository>();
            services.AddTransient<ICHG4, CHG4Repository>();
            services.AddTransient<ICHG6, CHG6Repository>();
            services.AddTransient<ICHG8, CHG8Repository>();
            services.AddTransient<ICHG9, CHG9Repository>();
            //DPT
            services.AddTransient<IDPT3, DPT3Repository>();
            services.AddTransient<IDPT4, DPT4Repository>();
            //DIR
            services.AddTransient<IDIR3, DIR3Repository>();
            services.AddTransient<IDIR5, DIR5Repository>();
            services.AddTransient<IDIR6, DIR6Repository>();
            services.AddTransient<IDIR9, DIR9Repository>();
            services.AddTransient<IDIR11, DIR11Repository>();
            services.AddTransient<IDIR12, DIR12Repository>();
            //Change relate
            services.AddTransient<IINC22, INC22Repository>();
            services.AddTransient<ISH7, SH7Repository>();
            services.AddTransient<IMR1, MR1Repository>();
            // Forms End 
            services.AddTransient<IINC20A, INC20ARepository>();
            services.AddTransient<IINC28, INC28Repository>();

            services.AddTransient<IINC24, INC24Repository>();

            services.AddTransient<ISTK2, STK2Repository>();

            services.AddTransient<IINC23, INC23Repository>();
            services.AddTransient<IMGT14, MGT14Repository>();
            services.AddTransient<IPAS6, PAS6Repository>();
            services.AddTransient<IGNL2, GNL2Repository>();
            services.AddTransient<IGNL3, GNL3Repository>();
            services.AddTransient<IPAS3, PAS3Repository>();
            services.AddTransient<ISH8, SH8Repository>();
            services.AddTransient<ISH9, SH9Repository>();
            services.AddTransient<IAOC5, AOC5Repository>();
            services.AddTransient<IRUNLLP, RUNLLPRepository>();
            services.AddTransient<IRUN, RUNRepository>();
            services.AddTransient<IIEPF5, IEPF5Repository>();
            services.AddTransient<IFORM4, FORM4Repository>();




            services.AddTransient<ISH9, SH9Repository>();
            services.AddTransient<IMGT6, MGT6Repository>();
            services.AddTransient<IBEN2, BEN2Repository>();
            services.AddTransient<IMSME, MSMERepository>();
            services.AddTransient<ISH11, SH11Repository>();
            services.AddTransient<IFORM3, FORM3Repository>();
            services.AddTransient<IFORM5, FORM5Repository>();
            services.AddTransient<IAOCCUNTNSOLVENCYFORM, AOCCUNTNSOLVENCYFORMRepository>();
            services.AddTransient<ICHARGE, CHARGERepository>();
            services.AddTransient<IFORM11, FORM11Repository>();
            services.AddTransient<IFORM12, FORM12Repository>();
            services.AddTransient<IFORM15, FORM15Repository>();
            services.AddTransient<IFORM22, FORM22Repository>();


            services.AddTransient<IINC12, INC12Repository>();
            services.AddTransient<IIEPF2, IEPF2Repository>();
            services.AddTransient<IFORM23, FORM23Repository>();
            services.AddTransient<IFORM24, FORM24Repository>();
            services.AddTransient<IINC4, INC4Repository>();
            services.AddTransient<IADT1, ADT1Repository>();
            services.AddTransient<IADT3, ADT3Repository>();
            services.AddTransient<IGNL1, GNL1Repository>();
            services.AddTransient<IMGT7A,MGT7ARepository>();
            services.AddTransient<IMGT8, MGT8Repository>();
            services.AddTransient<IMGT9, MGT9Repository>();
            services.AddTransient<IAOC4CFS, AOC4CFSRepository>();
            services.AddTransient<IDMS, DMSRepository>();
            services.AddTransient<IBOARDREPORT, BOARDREPORTRepository>();
            services.AddTransient<IAOC4, AOC4Repository>();
            services.AddTransient<IActionDirectorAppointment, ActionDirectorAppointmentRepository>();

            services.AddTransient<IActionChangeOfficeAddress, ActionChangeOfficeAddressRepository>();
            services.AddTransient<IActionGeneral, ActionGeneralRepository>();

            services.AddTransient<ICustomEmail, CustomEmailRepository>();
            services.AddTransient<ILoginTracker, LoginTrackerRepository>();
            services.AddTransient<IPaymentDetails, PaymentDetailsRepository>();
            services.AddTransient<ISubscriptionPlans, SubscriptionPlansRepository>();
            services.AddTransient<IUserSubscriptions, UserSubscriptionsRepository>();
            services.AddTransient<IClassMaster, ClassMasterRespository>();

        }

        public static void AddSwaggerGenWithBearer(this IServiceCollection services)
        {
            services.AddSwaggerGen(s =>
            {
                s.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    In = ParameterLocation.Header,
                    Description = "Please enter a valid token",
                    Name = "Authorization",
                    Type = SecuritySchemeType.Http,
                    BearerFormat = "JWT",
                    Scheme = "Bearer"
                });
                s.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type=ReferenceType.SecurityScheme,
                                Id="Bearer"
                            }
                        },
                         Array.Empty<string>()
                    }
                });
            });
        }
    }
    public static class CONST
    {
        public const string SaveSuccess = "Saved Successfully";
        public const string SaveError = "An error occurred while saving";
        public const string DeleteSuccess = "Deleted Successfully";
        public const string DeleteError = "An error occurred while deleting";
        public const string ChangeStatusSuccess = "Successfully changed status";
        public const string ChangeStatusError = "An error occurred while changing status";

        public const string EmailSuccess = "Email sent successfully.";
        public const string EmailValidateSuccess = "Email successfully verified!";
        public const string InvalidLink = "Invalid verification link.";
        public const string ExpiredLink = "This verification link has expired.";
    }

    public class Auth(AppUser? User = null, DateTime? SessionExpiry = null)
    {
        public AppUser? User { get; set; } = User;
        public DateTime SessionExpiry { get; set; } = SessionExpiry ?? DateTime.MinValue;

        public static Auth CreateSession(AppUser user, DateTime? sessionExpiry = null)
        {
            return new Auth(user, sessionExpiry ?? DateTime.UtcNow.AddMinutes(R.AppSet<int>("Auth:TimeoutInMinutes")));
        }

        public string Token()
        {
            var json = JsonConvert.SerializeObject(this);
            var enc = json.A_PasswordEncrypt(R.AppSet("Auth:Encryption:Key")!);
            var zip = enc.Zip();
            return zip;

            //var tokenPayload = new
            //{
            //    Data = this, // 'this' refers to the current object
            //    Expiry = DateTime.UtcNow.AddHours(4) // or .AddHours(1), etc.
            //};

            //var json = JsonConvert.SerializeObject(tokenPayload);
            //var enc = json.A_PasswordEncrypt(R.AppSet("Auth:Encryption:Key")!);
            //var zip = enc.Zip();
            //return zip;
        }

        public static Auth? Parse(string token)
        {
            var auth = JsonConvert.DeserializeObject<Auth>(token.Unzip().A_PasswordDecrypt(R.AppSet("Auth:Encryption:Key")!));
            return auth;
        }

        public bool IsValid()
        {
            return this.SessionExpiry >= DateTime.UtcNow;
        }
    }

    public class ApiController : ControllerBase
    {
        public new AppUser? User { get; set; }
    }

    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, Inherited = true)]
    public class Authorize(bool CompanyAdmin = false, bool Staff = false) : ActionFilterAttribute
    {
        private const string HEADER_NAME = "Authorization";
        //private readonly bool adminRequired = CompanyAdmin;
        private readonly bool companyAdminRequired = CompanyAdmin;
        private readonly bool staffRequired = Staff; // Staff means Sub User

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            try
            {
                if ((context.ActionDescriptor as ControllerActionDescriptor)!.MethodInfo.GetCustomAttributes(true).Any(q => q.GetType() == typeof(NoAuthorize))) return;
                if ((context.ActionDescriptor as ControllerActionDescriptor)!.MethodInfo.GetCustomAttributes(true).Any(q => q.GetType() == typeof(CompanyAuthorize))) return;
                var hasHeader = context.HttpContext.Request.Headers.ContainsKey(HEADER_NAME);
                if (!hasHeader) context.Result = Unauthorized("Token required!");
                else
                {
                    string header = (context.HttpContext.Request.Headers[HEADER_NAME].FirstOrDefault() ?? "1 1").Split(" ")[1];
                    var auth = Auth.Parse(header);

                    //checking token
                    if (auth == null || !auth.IsValid()) 
                        context.Result = Unauthorized("Token expired!");

                    //Company Admin is true and app role not match then unauthorized
                    else if (companyAdminRequired && auth.User!._Role != AppRole.CompanyAdmin) 
                        context.Result = Unauthorized("Unauthorized");


                    //When Sub user/ staff is true and app roles not contains from Company Admin and Subuser then Unauthorized
                    else if (staffRequired && !new List<AppRole> { AppRole.CompanyAdmin, AppRole.SubUser }.
                        Contains(auth.User!._Role)) context.Result = Unauthorized("Unauthorized");

                    //When CompanyAdmin is role then unauthorized
                    //else if (auth.User!._Role == AppRole.CompanyAdmin) 
                    //    context.Result = Unauthorized("Unauthorized");

                    else (context.Controller as ApiController)!.User = auth.User;
                }
            }
            catch (Exception)
            {
                context.Result = Unauthorized("Failed to parse token");
            }
            base.OnActionExecuting(context);
        }

        private readonly Func<string, ContentResult> Unauthorized = (reason) => new ContentResult()
        {
            StatusCode = (int)HttpStatusCode.Unauthorized,
            ContentType = "application/json",
            Content = JsonConvert.SerializeObject(new Response(false, reason))
        };
    }

    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, Inherited = true)]
    public class NoAuthorize : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            try
            {
                (context.Controller as ApiController)!.User = null;
            }
            catch (Exception)
            {
                // Controller is not of type ApiController
            }
        }
    }

    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, Inherited = true)]
    public class CompanyAuthorize() : ActionFilterAttribute
    {
        private const string HEADER_NAME = "Authorization";

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            try
            {
                var hasHeader = context.HttpContext.Request.Headers.ContainsKey(HEADER_NAME);
                if (!hasHeader) context.Result = Unauthorized("Token required!");
                else
                {
                    string header = (context.HttpContext.Request.Headers[HEADER_NAME].FirstOrDefault() ?? "1 1").Split(" ")[1];
                    var auth = Auth.Parse(header);
                    if (auth == null || !auth.IsValid()) context.Result = Unauthorized("Token expired!");
                    else if (auth.User!._Role != AppRole.CompanyAdmin) context.Result = Unauthorized("Unauthorized");
                    else (context.Controller as ApiController)!.User = auth.User;
                }
            }
            catch (Exception)
            {
                context.Result = Unauthorized("Failed to parse token");
            }
            base.OnActionExecuting(context);
        }

        private readonly Func<string, ContentResult> Unauthorized = (reason) => new ContentResult()
        {
            StatusCode = (int)HttpStatusCode.Unauthorized,
            ContentType = "application/json",
            Content = JsonConvert.SerializeObject(new Response(false, reason))
        };
    }


}
