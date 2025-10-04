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
    public class DirectorController : ApiController
    {
        private readonly IDirector _impl;
        private readonly IApiLog _apiLog;

        public DirectorController(IDirector impl, IApiLog apiLog)
        {
            this._impl = impl;
            _apiLog = apiLog;
        }


        [HttpGet("List")]
        public IEnumerable<DirectorView> List(int companyId)
        {
            return _impl.GetList(User.CompanyAdminUserId, companyId);
        }

        [HttpGet("ById/{id}")]
        public DirectorView? GetById(int id)
        {
            return _impl.GetById(id);
        }

        [HttpPost("Save")]
        public virtual Response Save(Director obj)
        {
            obj.RefUser = User?.CompanyAdminUserId;
            if (User == null) User = new AppUser { Id = -1 };
            obj.PreInsert(User!);
            var r = _impl.Save(obj);
            if (r.IsNull())
                return new Response(false, CONST.SaveError);
            return new Response(true, CONST.SaveSuccess, r!);
        }

        [HttpGet("{id}/Status/{status}")]
        public Response? ChangeActiveStatus(int id = 0, bool status = false)
        {
            Director? obj = _impl.GetById(id);
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

        [HttpGet("Create/{din}")]
        public async Task<Response?> Create(string din = "")
        {
            if (string.IsNullOrWhiteSpace(din)) return new Response(false, "DIN is empty");

            Director? obj = _impl.GetByDin(din);
            if (!obj.IsNull())
                return new Response(false, "DIN already exists");

            var requestBody = new
            {
                id_number = din
            };
            //var a = await _apiLog.HitApi("https://localhost:7200/api/Company", null, HttpMethod.Get);
            //var a = await _apiLog.HitApi(R.AppSet("SurePass:DinToDetail"), requestBody, HttpMethod.Post);
            //var a = Http.GetString($@"https://dev.complycrafter.com/MCA_API/api/Din/{din}");
            var a = Http.GetString($@"http://45.142.237.183:8080/mca/search?search_type=din&id={din}");
            if (a == null)
            {
                return new Response(false, "Unable to get data from API");
            }
            obj = new Director()
            {
                Details = new DirectorDetails() { },

            };
            obj = _impl.SyncDIN(obj, a);
            if (obj.IsNull())
                return new Response(false, "Unable to get data from DIN API");

            if (User == null) User = new AppUser { Id = -1 };
            obj.PreInsert(User!);
            var r = _impl.Save(obj);
            if (r.IsNull())
                return new Response(false, CONST.SaveError);
            return new Response(true, CONST.SaveSuccess, r!.Id);
        }


        [HttpPost("CreateBlank")]
        public Response? CreateBlank(Director obj)
        {
            if (string.IsNullOrWhiteSpace(obj.Din)) return new Response(false, "DIN is empty");

            Director? obj1 = _impl.GetByDin(obj.Din);
            if (!obj1.IsNull())
                return new Response(false, "DIN already exists");

            obj.Details = new DirectorDetails() { };

            if (User == null) User = new AppUser { Id = -1 };
            obj.PreInsert(User!);
            obj.RefUser = User.Id;
            var r = _impl.Save(obj);
            if (r.IsNull())
                return new Response(false, CONST.SaveError);
            return new Response(true, CONST.SaveSuccess, r!.Id);
        }
        [HttpGet("{id}/Sync")]
        public async Task<Response?> Sync(int id = 0)
        {
            Director? obj = _impl.GetById(id);
            if (obj.IsNull())
                return new Response(false, "Director does not exist");
            var requestBody = new
            {
                id_number = obj.Din
            };
            //var a = await _apiLog.HitApi("https://localhost:7200/api/Company", null, HttpMethod.Get);
            //var a = await _apiLog.HitApi(R.AppSet("SurePass:DinToDetail"), requestBody, HttpMethod.Post);
            //var a = Http.GetString($@"https://dev.complycrafter.com/MCA_API/api/Din/{obj.Din}");
            var a = Http.GetString($@"http://45.142.237.183:8080/mca/search?search_type=din&id={obj.Din}");
            if (a == null)
            {
                return new Response(false, "Unable to get data from API");
            }
            obj = _impl.SyncDIN(obj, a);
            if (obj.IsNull())
                return new Response(false, "Unable to get data from DIN API");

            if (User == null) User = new AppUser { Id = -1 };
            obj.PreInsert(User!);
            var r = _impl.Save(obj);
            if (r.IsNull())
                return new Response(false, CONST.SaveError);
            return new Response(true, CONST.SaveSuccess, r!.Id);
        }

        [HttpPost("{id}/image/{deletePan}/{deleteAadhar}/{deletePassport}/{deleteVoterId}/{deleteDrivingLicence}")]
        public async Task<Response> UploadImage(int id = 0, bool deletePan = false, bool deleteAadhar = false, bool deletePassport = false, bool deleteVoterId = false, bool deleteDrivingLicence = false)
        {
            if (id <= 0) return new Response(false, "Bad Request");
            var obj = _impl.GetDirectorDetails(id);
            if (obj == null) return new Response(false, "Bad Request");
            var files = Request.Form.Files;
            //if (files.Count == 0 ) return new Response(false, "File is required");
            //if (file.Length > R.AppSet<long>("FileUpload:SizeInKb") * 1024)
            //    return new Response(false, "File size is too big");
            //if (!R.AppSet("FileUpload:Extensions")!.Split(',').Any(e => file.FileName.EndsWith(e)))
            //    return new Response(false, "Incorrect extension");
            await _impl.UploadImage(files, id, deletePan, deleteAadhar, deletePassport, deleteVoterId, deleteDrivingLicence);
            return new Response(true, "Uploaded Successfully");
        }

        [HttpGet("S2")]
        public IEnumerable<DirectorView> AllSelect2(string q = "")
        {
            var list = _impl.Get();
            list = list.Where(u => u.IsActive);
            if (!string.IsNullOrWhiteSpace(q))
                list = list.Where(u => ((u.FirstName + " " + u.MiddleName + " " + u.LastName)?.ToLower().Contains(q.ToLower()) ?? false) || (u.Mobile?.ToLower().Contains(q.ToLower()) ?? false));
            return list;
            //var dict = users.OrderBy(q => q.Name).ToDictionary(u => u.Id, u => u.Name);
            //return JQuery.A_ServeSelect2(dict!, q, 20);
        }

        [HttpGet("ByCompany/{id}")]
        [HttpGet("ByCompany/{id}/{withAppointment}")]
        public IEnumerable<DirectorViewCompany> GetDirectorsByCompany(int id, bool withAppointment = false)
        {
            if(withAppointment)
            {
                return _impl.GetByCompany(id);
            }
            return _impl.GetByCompanyWithoutAppointmentDate(id);
        }

        [HttpGet("ByCompanyAddressDetails/{id}")]
        [HttpGet("ByCompanyAddressDetails/{id}/{withAppointment}")]
        public IEnumerable<DirectorViewCompany> GetDirectorsByCompanyAddressDetails(int id, bool withAppointment = false)
        {
            IEnumerable<DirectorViewCompany> directors;
            if (withAppointment)
            {
                directors = _impl.GetByCompany(id);
            }
            directors = _impl.GetByCompanyWithoutAppointmentDate(id);

            foreach (var director in directors)
            {
                var details = _impl.GetDirectorAddressDetails(director.Id);
                director.Details = details;
            }

            return directors;
        }
    }

}