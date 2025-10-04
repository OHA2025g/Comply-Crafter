using AlphaUtil.Core.Models;
using ComplyCrafter_BL;
using ComplyCrafter_Data;
using Microsoft.AspNetCore.Mvc;

namespace ComplyCrafter_API.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/[controller]")]
    public class SubscriptionPlansController : ApiController
    {
        private readonly ISubscriptionPlans _sPlans;

        public SubscriptionPlansController(ISubscriptionPlans sPlans)
        {
            this._sPlans = sPlans;
        }

        [HttpGet]
        public IEnumerable<SubscriptionPlans> Get()
        {
            return _sPlans.Get();
        }

        [HttpGet("PlanList")]
        public List<SubscriptionPlans> GetAll()
        {
            return _sPlans.GetList().ToList();
        }

        [HttpGet("PlanById")]
        public SubscriptionPlans? GetById(int PlanId)
        {
            return _sPlans.GetById(PlanId);
        }
    }
}
