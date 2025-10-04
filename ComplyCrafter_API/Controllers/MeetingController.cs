using AlphaUtil.Core;
using AlphaUtil.Core.Models;
using Microsoft.AspNetCore.Mvc;
using ComplyCrafter_BL;
using ComplyCrafter_Data;

namespace ComplyCrafter_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MeetingController : BaseController<Meeting, MeetingView>
    {
        private readonly IMeeting _impl;

        public MeetingController(IMeeting impl) : base(impl)
        {
            this._impl = impl;
        }

        [HttpGet("{id}/Status/{status}")]
        public Response? ChangeActiveStatus(int id = 0, bool status = false)
        {
            Meeting? obj = _impl.GetById(id);
            if (obj.IsNull())
                return new Response(false, "Entry not found");
            obj.IsActive = status;
            var r = _impl.ChangeActiveStatus(obj!);
            if (r.IsNull())
                return new Response(false, CONST.ChangeStatusError);
            return new Response(true, CONST.ChangeStatusSuccess);
        }

        [HttpGet("GetByCompanyAndType/{id}/{type}/{finYear}")]
        public IEnumerable<MeetingView> GetByCompanyAndType(int id = 0, string type = "", string finYear = "")
        {
            IEnumerable<MeetingView> res = _impl.GetByCompanyAndType(id, type, finYear);
            return res;

        }

        [HttpPost("{id}/image")]
        public async Task<Response> UploadImage(int id = 0)
        {
            if (id <= 0) return new Response(false, "Bad Request");
            var obj = _impl.GetById(id);
            if (obj == null) return new Response(false, "Bad Request");
            var files = Request.Form.Files;
            if (files.Count == 0) return new Response(false, "File is required");
            //if (file.Length > R.AppSet<long>("FileUpload:SizeInKb") * 1024)
            //    return new Response(false, "File size is too big");
            //if (!R.AppSet("FileUpload:Extensions")!.Split(',').Any(e => file.FileName.EndsWith(e)))
            //    return new Response(false, "Incorrect extension");
            await _impl.UploadImage(files, id);
            return new Response(true, "Uploaded Successfully");
        }

        [HttpGet("{id}/resolution")]
        public IEnumerable<MeetingResolution> GetResolutions(int id = 0)
        {
            return _impl.GetResolutions(id);
        }

        [HttpPost("{id}/resolution")]
        public Response AddResolution(int id, MeetingResolution resolution)
        {
            resolution.Meeting = id;
            var r = _impl.AddResolution(resolution);
            return new Response(r != null, r != null ? CONST.SaveSuccess : CONST.SaveError, r);
        }

        [HttpGet("{id}/resolution/{rid}/delete")]
        public Response DeleteResolution(int id, int rid)
        {
            var r = _impl.DeleteResolution(id, rid);
            return new Response(r, r ? CONST.DeleteSuccess : CONST.DeleteError);
        }
    }

}