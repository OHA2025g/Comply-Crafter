using AlphaUtil.Core.Models;
using ComplyCrafter_BL;
using ComplyCrafter_Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ComplyCrafter_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<T1, T2> : ApiController
        where T1 : BaseModel, new()
        where T2 : BaseModel, T1, new()
    {
        private readonly BaseInterface<T1, T2> _impl;

        public BaseController(BaseInterface<T1,T2> impl)
        {
            _impl = impl;
        }

        [HttpGet]
        public virtual IEnumerable<T2> Get()
        {
            var res = _impl.Get();
            return res;
        }

        [HttpGet("{id}")]
        public virtual T2? GetById(int id = 0)
        {
            var obj = _impl.GetById(id);
            return obj;
        }

        [HttpPost]
        public virtual Response Save(T1 obj)
        {
            if (User == null) User = new AppUser { Id = -1 };
            obj.PreInsert(User!);
            var r = _impl.Save(obj);
            if (r.IsNull())
                return new Response(false, CONST.SaveError);
            return new Response(true, CONST.SaveSuccess, r!);
        }

        [Authorize(CompanyAdmin: true)]
        [HttpGet("{id}/Delete")]
        public virtual Response? Delete(int id = 0)
        {
            T1? obj = _impl.GetById(id);
            if (obj.IsNull()) return new Response(false, "Entry not found");
            var r = _impl.Delete(obj!);
            if (r.IsNull())
                return new Response(false, CONST.DeleteError);
            return new Response(true, CONST.DeleteSuccess, obj!);

        }

    }
}
