using AlphaUtil.Core.Models;
using ComplyCrafter_BL;
using ComplyCrafter_Data;
using Microsoft.AspNetCore.Mvc;
using Org.BouncyCastle.Tsp;

namespace ComplyCrafter_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MeetingAgendaDetailController : BaseController<MeetingAgendaDetail, MeetingAgendaDetail>
    {
        private readonly IMeetingAgendaDetail _impl;
        public MeetingAgendaDetailController(IMeetingAgendaDetail impl) : base(impl)
        {
            this._impl = impl;
        }

        [HttpGet("GetByMeetingAndResoln/{meetingId}/{resolution}")]
        public MeetingAgendaDetail GetByCompanyAndType(int meetingId, int resolution)
        {
            MeetingAgendaDetail res = _impl.GetMeetingAgendaDetail(meetingId, resolution);
            return res;
        }

        [HttpGet("Remove/{meetingId}/{resolution}")]
        public Response DeleteResolution(int meetingId, int resolution)
        {
            var r = _impl.DeleteMeetingAgendaDetail(meetingId, resolution);
            return new Response(r, r ? CONST.DeleteSuccess : CONST.DeleteError);
        }
    }
}
