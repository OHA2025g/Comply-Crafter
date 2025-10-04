using AlphaUtil.Core;
using AlphaUtil.Core.Models;
using Microsoft.AspNetCore.Mvc;
using ComplyCrafter_BL;
using ComplyCrafter_Data;

namespace ComplyCrafter_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BOARDREPORTController : BaseController<BOARDREPORT, BOARDREPORTView>
    {
        private readonly IBOARDREPORT _impl;

        public BOARDREPORTController(IBOARDREPORT impl) : base(impl)
        {
            this._impl = impl;
        }

        [HttpGet("{id}/Status/{status}")]
        public Response? ChangeActiveStatus(int id = 0, bool status = false)
        {
            BOARDREPORT? obj = _impl.GetById(id);
            if (obj.IsNull())
                return new Response(false, "Entry not found");
            obj.IsActive = status;
            var r = _impl.ChangeActiveStatus(obj!);
            if (r.IsNull())
                return new Response(false, CONST.ChangeStatusError);
            return new Response(true, CONST.ChangeStatusSuccess);
        }

        [HttpGet("GetByCompany/{id}")]
        public IEnumerable<BOARDREPORTView> GetByCompany(int id = 0)
        {
            IEnumerable<BOARDREPORTView> res = _impl.GetByCompany(id);
            return res;

        }
    }

}