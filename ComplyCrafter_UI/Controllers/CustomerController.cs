using ComplyCrafter_UI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ComplyCrafter_UI.Controllers
{
    public class CustomerController : Controller
    {

        public IActionResult DMS()
        {
            ViewBag.ctrl = "DMS";
            return View();
        }

    }
}
