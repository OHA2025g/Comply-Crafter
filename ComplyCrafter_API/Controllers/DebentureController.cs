using AlphaUtil.Core;
using AlphaUtil.Core.Models;
using Microsoft.AspNetCore.Mvc;
using ComplyCrafter_BL;
using ComplyCrafter_Data;

namespace ComplyCrafter_API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class DebentureController : ApiController
    {
        private readonly IDebenture _impl;
        private readonly IApiLog _apiLog;

        public DebentureController(IDebenture impl, IApiLog apiLog)
        {
            this._impl = impl;
            _apiLog = apiLog;
        }

        [HttpGet("List")]
        public IEnumerable<DebentureView> List(int companyId)
        {
            return _impl.Gets(companyId);
        }

        [HttpGet("ById")]
        public DebentureView? GetById(int id)
        {
            return _impl.GetById(id);
        }

        [HttpPost("Save")]
        public virtual Response Save(Debenture obj)
        {
            obj.RefUser = User?.CompanyAdminUserId;
            if (User == null) User = new AppUser { Id = -1 };
            obj.PreInsert(User!);
            var r = _impl.Save(obj);
            if (r.IsNull())
                return new Response(false, CONST.SaveError);
            return new Response(true, CONST.SaveSuccess, r!);
        }
        //[HttpGet]
        //public new IEnumerable<DebentureView> Get(string query = "")
        //{
        //    var res = _impl.Get();
        //    return string.IsNullOrEmpty(query) ? res : res.Where(x => x.Type == query)
        //}
        [HttpGet("{id}/Status/{status}")]
        public Response? ChangeActiveStatus(int id = 0, bool status = false)
        {
            Debenture? obj = _impl.GetById(id);
            if (obj.IsNull())
                return new Response(false, "Entry not found");
            obj.IsActive = status;
            //if (obj.User != User!.Id && User._Role != AppRole.Admin)
            //    return new Response(false, "You are not authorized to delete this booking");
            var r = _impl.ChangeActiveStatus(obj!);
            if (r.IsNull())
                return new Response(false, CONST.ChangeStatusError);
            return new Response(true, CONST.ChangeStatusSuccess);
        }

        //[HttpGet("Create/{din}")]
        //public async Task<Response?> Create(string din = "")
        //{
        //    Debenture? obj = _impl.GetByDin(din);
        //    if (!obj.IsNull())
        //        return new Response(false, "CIN already exists");
        //    if (string.IsNullOrWhiteSpace(din)) return new Response(false, "DIN is empty");

        //    var requestBody = new
        //    {
        //        id_number = din
        //    };
        //    //var a = await _apiLog.HitApi("https://localhost:7200/api/Company", null, HttpMethod.Get);
        //    var a = await _apiLog.HitApi(R.AppSet("SurePass:DinToDetail"), requestBody, HttpMethod.Post);
        //    if (a == null)
        //    {
        //        return new Response(false, "Unable to get data from API");
        //    }
        //    obj = new Debenture()
        //    {
        //        Details = new DebentureDetails() { },

        //    };
        //    obj = _impl.SyncDIN(obj, a);
        //    if (obj.IsNull())
        //        return new Response(false, "Unable to get data from DIN API");

        //    if (User == null) User = new AppUser { Id = -1 };
        //    obj.PreInsert(User!);
        //    var r = _impl.Save(obj);
        //    if (r.IsNull())
        //        return new Response(false, CONST.SaveError);
        //    return new Response(true, CONST.SaveSuccess, r!.Id);
        //}

        //[HttpGet("{id}/Sync")]
        //public async Task<Response?> Sync(int id = 0)
        //{
        //    Debenture? obj = _impl.GetById(id);
        //    if (obj.IsNull())
        //        return new Response(false, "Company does not exist");
        //    var requestBody = new
        //    {
        //        id_number = obj.Din
        //    };
        //    var a = await _apiLog.HitApi(R.AppSet("SurePass:DinToDetail"), requestBody, HttpMethod.Post);
        //    if (a == null)
        //    {
        //        return new Response(false, "Unable to get data from API");
        //    }
        //    obj = _impl.SyncDIN(obj, a);
        //    if (obj.IsNull())
        //        return new Response(false, "Unable to get data from CIN API");

        //    if (User == null) User = new AppUser { Id = -1 };
        //    obj.PreInsert(User!);
        //    var r = _impl.Save(obj);
        //    if (r.IsNull())
        //        return new Response(false, CONST.SaveError);
        //    return new Response(true, CONST.SaveSuccess, r!.Id);
        //}
        //[Authorize(Admin: true)]
        
        [HttpPost("{id}/image/{deletePan}/{deleteAadhar}")]
        public async Task<Response> UploadImage(int id = 0, bool deletePan = false, bool deleteAadhar = false)
        {
            if (id <= 0) return new Response(false, "Bad Request");
            var obj = _impl.GetDetails(id);
            if (obj == null) return new Response(false, "Bad Request");
            var files = Request.Form.Files;
            //if (files.Count == 0 ) return new Response(false, "File is required");
            //if (file.Length > R.AppSet<long>("FileUpload:SizeInKb") * 1024)
            //    return new Response(false, "File size is too big");
            //if (!R.AppSet("FileUpload:Extensions")!.Split(',').Any(e => file.FileName.EndsWith(e)))
            //    return new Response(false, "Incorrect extension");
            await _impl.UploadImage(files, id, deletePan, deleteAadhar);
            return new Response(true, "Uploaded Successfully");
        }
        //[HttpGet("S2")]
        //public IEnumerable<DebentureView> AllSelect2(string q = "")
        //{
        //    var list = _impl.Get();
        //    list = list.Where(u => u.IsActive);
        //    if (!string.IsNullOrWhiteSpace(q))
        //        list = list.Where(u => ((u.FirstName + " " + u.MiddleName + " " + u.LastName)?.ToLower().Contains(q.ToLower()) ?? false) || (u.Mobile?.ToLower().Contains(q.ToLower()) ?? false));
        //    return list;
        //    //var dict = users.OrderBy(q => q.Name).ToDictionary(u => u.Id, u => u.Name);
        //    //return JQuery.A_ServeSelect2(dict!, q, 20);
        //}
    }

}