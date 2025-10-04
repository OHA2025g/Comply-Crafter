using AlphaUtil.Core;
using AlphaUtil.Core.Models;
using Microsoft.AspNetCore.Mvc;
using ComplyCrafter_BL;
using ComplyCrafter_Data;

namespace ComplyCrafter_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DMSController : BaseController<DMS, DMS>
    {
        private readonly IDMS _impl;

        public DMSController(IDMS impl) : base(impl)
        {
            this._impl = impl;
        }


        [HttpGet("GetByCompany/{id}")]
        public IEnumerable<DMS> GetByCompany(int id = 0)
        {
            IEnumerable<DMS> res = _impl.GetByCompany(id);
            return res;

        }

        [CompanyAuthorize]
        [HttpGet("Company")]
        public IEnumerable<DMS> GetByCompany2()
        {
            IEnumerable<DMS> res = _impl.GetByCompany(User!.Id);
            return res;

        }

        [HttpGet("{id}/Status/{status}")]
        public Response? ChangeActiveStatus(int id = 0, bool status = false)
        {
            var obj = _impl.GetById(id);
            if (obj.IsNull())
                return new Response(false, "Entry not found");
            obj.IsActive = status;
            var r = _impl.ChangeActiveStatus(obj!);
            if (r.IsNull())
                return new Response(false, CONST.ChangeStatusError);
            return new Response(true, CONST.ChangeStatusSuccess);
        }

        [HttpPost("{id}/Upload/{file_type}")]
        public async Task<Response> UploadFile(int id = 0, string file_type = "form")
        {
            if (id <= 0) return new Response(false, "Bad Request");
            var bc = _impl.GetById(id);
            if (bc == null) return new Response(false, "Bad Request");
            var file = Request.Form.Files.FirstOrDefault();
            if (file == null) return new Response(false, "File is required");
            if (!file.FileName.EndsWith(".pdf"))
                return new Response(false, "Incorrect extension");
            using MemoryStream ms = new MemoryStream();
            file.CopyTo(ms);
            await _impl.UploadFile(ms.ToArray(), id, file_type + "_original");
            return new Response(true, "Uploaded Successfully");
        }

        [CompanyAuthorize]
        [HttpPost("{id}/ClientUpload/{file_type}")]
        public async Task<Response> UploadClientFile(int id = 0, string file_type = "form")
        {
            if (id <= 0) return new Response(false, "Bad Request");
            var bc = _impl.GetById(id);
            if (bc == null) return new Response(false, "Bad Request");
            var file = Request.Form.Files.FirstOrDefault();
            if (file == null) return new Response(false, "File is required");
            if (!file.FileName.EndsWith(".pdf"))
                return new Response(false, "Incorrect extension");
            using MemoryStream ms = new MemoryStream();
            file.CopyTo(ms);
            await _impl.UploadFile(ms.ToArray(), id, file_type + "_client");
            return new Response(true, "Uploaded Successfully");
        }
    }
}