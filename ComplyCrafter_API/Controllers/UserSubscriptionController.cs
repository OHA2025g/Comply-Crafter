using AlphaUtil.Core.Models;
using ComplyCrafter_BL;
using ComplyCrafter_Data;
using Microsoft.AspNetCore.Mvc;

namespace ComplyCrafter_API.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/Subscription")]

    public class UserSubscriptionController : ApiController
    {
        private readonly IUserSubscriptions _userSub;

        public UserSubscriptionController(IUserSubscriptions user)
        {
            this._userSub = user;
        }

        [HttpGet("List")]
        public List<UserSubscriptionDetails> GetByUser()
        {
            var uS = _userSub.GetByUser(User!.Id);
            return uS;
        }

        [HttpGet("Invoice")]
        public List<UserSubscriptionDetails> GetInvoiceById(int InvoiceId)
        {
            var uS = _userSub.GetInvoiceById(InvoiceId);
            return uS;
        }

        [HttpPost("Purchase")]
        public Response PurchaseSubscription(UserSubscriptions obj)
        {
            if (obj == null) return new Response(false, "Request body empty.");

            // check subscription plans
            if (obj.SubscriptionId == 0) return new Response(false, "Please select atleast one plan.");

            //if plan is not trial and payment id is missing
            if (obj.SubscriptionId != 0 && obj.PaymentId == 0) return new Response(false, "Please enter payment id.");

            obj.PreInsert(User!);
            obj.UserId = User!.ParentUserId > 0 ? User!.ParentUserId : User!.Id;
            obj.StartDate = DateTime.Now;
            obj.EndDate = obj.SubscriptionId == 1 ? DateTime.Now.AddDays(13) :
                DateTime.Now.AddDays(364);
            obj.PurchasedOn = DateTime.Now;
            obj.CreatedOn = DateTime.Now;
            obj.IsActive = true;

            var vPS = _userSub.PurchaseSubscription(obj);

            var vTrialPack = _userSub.GetTrialPackInfo(User!.ParentUserId > 0 ? User!.ParentUserId : User!.Id);
            if (vTrialPack != null) {
                //checking wether trial pack is not expire before expire date
                if (Convert.ToDateTime(vTrialPack.EndDate.Date).Date >= DateTime.Now.Date)
                    _userSub.CancelTrialPack(User!.ParentUserId > 0 ? User!.ParentUserId : User!.Id);
            }
            if (vPS == null) return new Response(false, "Failed to purchase plan.");
            return new Response(true, "Subscription purchased successfully", vPS);
        }

        [HttpGet("CompanyCount")]
        public Response CompanyCount()
        {
            return new Response(true, _userSub.TotalCompanyCount(User!.ParentUserId > 0 ? User!.ParentUserId : User!.Id).ToString());
        }

        //[Authorize(CompanyAdmin:true)]
        [HttpGet("UsedCompanyCount")]
        public Response UsedCompanyCount()
        {
            return new Response(true, _userSub.UsedCompanyCount(User!.ParentUserId > 0 ? User!.ParentUserId : User!.Id).ToString());
        }

        //[Authorize(CompanyAdmin:true)]
        [HttpGet("GetTrialPackInfo")]
        public Response GetTrialPackInfo()
        {
            var TrialPack = _userSub.GetTrialPackInfo(User!.ParentUserId > 0 ? User!.ParentUserId : User!.Id);
            if (TrialPack != null)
                return new Response(true, "success", TrialPack);

            return new Response(false, "Trial pack not found");
        }

        [Authorize]
        [HttpGet("PlanExpiryInDaysById")]
        public ActionResult PlanExpiryInDaysById(int planId)
        {
            int iExpiryDays = _userSub.PlanExpiryInDaysById(planId);
            var vTrialPack = _userSub.GetTrialPackInfo(User!.ParentUserId > 0 ? User!.ParentUserId : User!.Id);
            if (vTrialPack != null)
            {
                //checking wether trial pack is not expire before expire date and cancelling on 14th day
                if (Convert.ToDateTime(vTrialPack.EndDate.Date).Date == DateTime.Now.Date)
                    _userSub.CancelTrialPack(User!.ParentUserId > 0 ? User!.ParentUserId : User!.Id);
            }
            return Content(iExpiryDays.ToString(), "text/plain");
        }
    }
}
