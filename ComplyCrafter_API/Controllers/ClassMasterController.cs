using AlphaUtil.Core.Models;
using ComplyCrafter_BL;
using ComplyCrafter_Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ComplyCrafter_API.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/[controller]")]
    public class ClassMasterController : ApiController
    {
        private readonly IClassMaster _classMaster;

        public ClassMasterController(IClassMaster ClassMaster)
        {
            this._classMaster = ClassMaster;
        }

        [HttpGet("List")]
        public IEnumerable<ClassMaster> Get(int companyId, string classType)
        {
            return _classMaster.Get(User!.CompanyAdminUserId, companyId, classType);
        }

        [HttpGet("ById")]
        public ClassMaster? GetById(int companyId, int id, string classType)
        {
            return _classMaster.GetById(User!.CompanyAdminUserId, companyId, id, classType);
        }

        [HttpPost("Save")]
        public Response Save(ClassMaster obj)
        {
            obj.UserId= User!.CompanyAdminUserId;
            obj.PreInsert(User!);
            var saved = _classMaster.Save(obj);
            if (saved == null)
                return new Response(false, CONST.SaveError);

            return new Response(true, CONST.SaveSuccess);
        }

        [HttpDelete("Delete/{id}")]
        public Response MarkDelete(int id)
        {
            if (id <= 0)
                return new Response(false, "Id filed required.");

            var vResult = _classMaster.MarkDelete(id);

            return new Response(vResult, vResult ? CONST.DeleteSuccess:CONST.DeleteError);
        }
    }
}