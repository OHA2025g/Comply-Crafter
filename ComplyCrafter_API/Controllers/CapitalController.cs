using AlphaUtil.Core;
using AlphaUtil.Core.Models;
using Microsoft.AspNetCore.Mvc;
using ComplyCrafter_BL;
using ComplyCrafter_Data;

namespace ComplyCrafter_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CapitalController : BaseController<Capital, CapitalView>
    {
        private readonly ICapital _impl;
        private readonly ICompany _company;

        public CapitalController(ICapital impl, ICompany company) : base(impl)
        {
            this._impl = impl;
            this._company = company;
        }

        [HttpPost]
        public override Response Save(Capital obj)
        {
            if (obj.Type == "Authorized")
            {
                var cTotalCapital = _company.GetCompanyDetails(obj.CompanyId??0).AuthorizedCapital ?? 0;
                var sum = _impl.GetSumOfTotalCapital("Authorized", obj.CompanyId ?? 0, obj.Id);
                sum += obj.TotalCapital;
                if (sum > cTotalCapital) return new Response(false, "Exceeding Total Authorized Capital");
            }
            else if (obj.Type == "Paid-up")
            {
                var cTotalCapital = _company.GetCompanyDetails(obj.CompanyId ?? 0).PaidUpCapital ?? 0;
                var sum = _impl.GetSumOfTotalCapital("Paid-up", obj.CompanyId ?? 0, obj.Id);
                sum += obj.TotalCapital;
                if (sum > cTotalCapital) return new Response(false, "Exceeding Total Paid-up Capital");
            }
            else if (obj.Type == "Issued") {
                var cTotalCapital = _impl.GetSumOfTotalCapital("Authorized", obj.CompanyId ?? 0) ?? 0;
                var sum = _impl.GetSumOfTotalCapital("Issued", obj.CompanyId ?? 0, obj.Id);
                sum += obj.TotalCapital;
                if (sum > cTotalCapital) return new Response(false, "Exceeding Total Authorized Capital");
            }
            else if (obj.Type == "Subscribed")
            {
                var cTotalCapital = _impl.GetSumOfTotalCapital("Issued", obj.CompanyId ?? 0) ?? 0;
                var sum = _impl.GetSumOfTotalCapital("Subscribed", obj.CompanyId ?? 0, obj.Id);
                sum += obj.TotalCapital;
                if (sum > cTotalCapital) return new Response(false, "Exceeding Total Issued Capital");
            }
            else return new Response(false, CONST.SaveError);
            if (User == null) User = new AppUser { Id = -1 };
            obj.PreInsert(User!);
            var r = _impl.Save(obj);
            if (r.IsNull())
                return new Response(false, CONST.SaveError);
            return new Response(true, CONST.SaveSuccess, r!);
        }

        [HttpGet("{id}/Status/{status}")]
        public Response? ChangeActiveStatus(int id = 0, bool status = false)
        {
            Capital? obj = _impl.GetById(id);
            if (obj.IsNull())
                return new Response(false, "Entry not found");
            obj.IsActive = status;
            var r = _impl.ChangeActiveStatus(obj!);
            if (r.IsNull())
                return new Response(false, CONST.ChangeStatusError);
            return new Response(true, CONST.ChangeStatusSuccess);
        }

        [HttpGet("GetByCompanyAndType/{id}/{type}")]
        public IEnumerable<CapitalView> GetByCompanyAndType(int id = 0,string type="")
        {
            IEnumerable<CapitalView> res = _impl.GetByCompanyAndType(id,type);
            return res;

        }
    }

}