using ComplyCrafter_UI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ComplyCrafter_UI.Controllers
{
    public class ActionsController : Controller
    {

        [HttpGet("[controller]/Office/Change")]
        public IActionResult ChangeOfficeAddress()
        {
            ViewBag.ctrl = "ChangeOfficeAddress";
            return View();
        }

        [HttpGet("[controller]/Office/Change/Add")]
        [HttpGet("[controller]/Office/Change/Edit/{id}")]
        public IActionResult ChangeOfficeAddressForm(int id = 0)
        {
            ViewBag.id = id;
            ViewBag.ctrl = "ChangeOfficeAddress";
            return View();
        }

        [HttpGet("[controller]/Director/appointment")]
        public IActionResult Directorappointment()
        {
            ViewBag.ctrl = "Directorappointment";
            return View();
        }

        [HttpGet("[controller]/Director/appointment/Add")]
        [HttpGet("[controller]/Director/appointment/Edit/{id}")]
        public IActionResult DirectorappointmentForm(int id = 0)
        {
            ViewBag.id = id;
            ViewBag.ctrl = "Directorappointment";
            return View();
        }




    }
}
