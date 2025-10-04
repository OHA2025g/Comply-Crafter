using AlphaUtil.Core;
using AlphaUtil.Core.Models;
using Microsoft.AspNetCore.Mvc;
using ComplyCrafter_BL;
using ComplyCrafter_Data;

namespace ComplyCrafter_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SH11Controller : BaseController<SH11, SH11View>
    {
        private readonly ISH11 _impl;

        public SH11Controller(ISH11 impl) : base(impl)
        {
            this._impl = impl;
        }

        [HttpGet("{id}/Status/{status}")]
        public Response? ChangeActiveStatus(int id = 0, bool status = false)
        {
            SH11? obj = _impl.GetById(id);
            if (obj.IsNull())
                return new Response(false, "Entry not found");
            obj.IsActive = status;
            var r = _impl.ChangeActiveStatus(obj!);
            if (r.IsNull())
                return new Response(false, CONST.ChangeStatusError);
            return new Response(true, CONST.ChangeStatusSuccess);
        }

        [HttpGet("GetByCompany/{id}")]
        public IEnumerable<SH11View> GetByCompany(int id = 0)
        {
            IEnumerable<SH11View> res = _impl.GetByCompany(id);
            return res;

        }
    }

}