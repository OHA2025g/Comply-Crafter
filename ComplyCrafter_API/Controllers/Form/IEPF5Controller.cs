using AlphaUtil.Core;
using AlphaUtil.Core.Models;
using Microsoft.AspNetCore.Mvc;
using ComplyCrafter_BL;
using ComplyCrafter_Data;

namespace ComplyCrafter_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class IEPF5Controller : BaseController<IEPF5, IEPF5View>
    {
        private readonly IIEPF5 _impl;

        public IEPF5Controller(IIEPF5 impl) : base(impl)
        {
            this._impl = impl;
        }

        [HttpGet("{id}/Status/{status}")]
        public Response? ChangeActiveStatus(int id = 0, bool status = false)
        {
            IEPF5? obj = _impl.GetById(id);
            if (obj.IsNull())
                return new Response(false, "Entry not found");
            obj.IsActive = status;
            var r = _impl.ChangeActiveStatus(obj!);
            if (r.IsNull())
                return new Response(false, CONST.ChangeStatusError);
            return new Response(true, CONST.ChangeStatusSuccess);
        }

        [HttpGet("GetByCompany/{id}")]
        public IEnumerable<IEPF5View> GetByCompany(int id = 0)
        {
            IEnumerable<IEPF5View> res = _impl.GetByCompany(id);
            return res;

        }
    }

}