using AlphaUtil.Core;
using AlphaUtil.Core.Models;
using Microsoft.AspNetCore.Mvc;
using ComplyCrafter_BL;
using ComplyCrafter_Data;

namespace ComplyCrafter_API.Controllers
{
    [ApiController]
    [Route("api/Action/ChangeOfficeAddress")]
    public class ActionChangeOfficeAddressController : BaseController<ChangeOfficeAddress, ChangeOfficeAddress>
    {
        private readonly IActionChangeOfficeAddress _impl;

        public ActionChangeOfficeAddressController(IActionChangeOfficeAddress impl) : base(impl)
        {
            this._impl = impl;
        }

        [HttpGet("{id}/Status/{status}")]
        public Response? ChangeActiveStatus(int id = 0, bool status = false)
        {
            var obj = _impl.GetById(id);
            if (obj == null)
                return new Response(false, "Entry not found");
            obj.IsActive = status;
            var r = _impl.ChangeActiveStatus(obj!);
            if (r.IsNull())
                return new Response(false, CONST.ChangeStatusError);
            return new Response(true, CONST.ChangeStatusSuccess);
        }

        [HttpGet("GetByCompany/{id}")]
        public IEnumerable<ChangeOfficeAddress> GetByCompany(int id = 0)
        {
            var res = _impl.GetByCompany(id);
            return res;

        }
    }

}