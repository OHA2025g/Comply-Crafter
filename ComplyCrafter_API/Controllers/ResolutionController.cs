using AlphaUtil.Core;
using AlphaUtil.Core.Models;
using Microsoft.AspNetCore.Mvc;
using ComplyCrafter_BL;
using ComplyCrafter_Data;

namespace ComplyCrafter_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ResolutionController : BaseController<Resolution, ResolutionView>
    {
        private readonly IResolution _impl;
        public ResolutionController(IResolution impl) : base(impl)
        {
            this._impl = impl;
        }

        [HttpGet("{id}/Status/{status}")]
        public Response? ChangeActiveStatus(int id = 0, bool status = false)
        {
            Resolution? obj = _impl.GetById(id);
            if (obj.IsNull())
                return new Response(false, "Entry not found");
            obj.IsActive = status;
            var r = _impl.ChangeActiveStatus(obj!);
            if (r.IsNull())
                return new Response(false, CONST.ChangeStatusError);
            return new Response(true, CONST.ChangeStatusSuccess);
        }
        [HttpGet("S2")]
        public IEnumerable<ResolutionView> AllSelect2(string q = "")
        {
            var list = _impl.Get();
            list = list.Where(u => u.IsActive);
            if (!string.IsNullOrWhiteSpace(q))
                list = list.Where(u => ((u.Title)?.ToLower().Contains(q.ToLower()) ?? false));
            return list;
            //var dict = users.OrderBy(q => q.Name).ToDictionary(u => u.Id, u => u.Name);
            //return JQuery.A_ServeSelect2(dict!, q, 20);
        }
    }

}