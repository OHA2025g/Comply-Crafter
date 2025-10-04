using ComplyCrafter_UI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ComplyCrafter_UI.Controllers
{
    public class FormController : Controller
    {
        private readonly ILogger<FormController> _logger;

        public FormController(ILogger<FormController> logger)
        {
            _logger = logger;
        }
        // CHG Forms
        public IActionResult CHG1()
        {
            ViewBag.ctrl = "CHG1";
            return View();
        }

        [HttpGet("[controller]/CHG1/Add")]
        [HttpGet("[controller]/CHG1/Edit/{id}")]
        public IActionResult CHG1Form(int id = 0)
        {
            ViewBag.id = id;
            ViewBag.ctrl = "CHG1";
            return View();
        }
        public IActionResult CHG4()
        {
            ViewBag.ctrl = "CHG4";
            return View();
        }

        [HttpGet("[controller]/CHG4/Add")]
        [HttpGet("[controller]/CHG4/Edit/{id}")]
        public IActionResult CHG4Form(int id = 0)
        {
            ViewBag.id = id;
            ViewBag.ctrl = "CHG4";
            return View();
        }
        public IActionResult CHG6()
        {
            ViewBag.ctrl = "CHG6";
            return View();
        }

        [HttpGet("[controller]/CHG6/Add")]
        [HttpGet("[controller]/CHG6/Edit/{id}")]
        public IActionResult CHG6Form(int id = 0)
        {
            ViewBag.id = id;
            ViewBag.ctrl = "CHG6";
            return View();
        }
        public IActionResult CHG8()
        {
            ViewBag.ctrl = "CHG8";
            return View();
        }

        [HttpGet("[controller]/CHG8/Add")]
        [HttpGet("[controller]/CHG8/Edit/{id}")]
        public IActionResult CHG8Form(int id = 0)
        {
            ViewBag.id = id;
            ViewBag.ctrl = "CHG8";
            return View();
        }
        public IActionResult CHG9()
        {
            ViewBag.ctrl = "CHG9";
            return View();
        }

        [HttpGet("[controller]/CHG9/Add")]
        [HttpGet("[controller]/CHG9/Edit/{id}")]
        public IActionResult CHG9Form(int id = 0)
        {
            ViewBag.id = id;
            ViewBag.ctrl = "CHG9";
            return View();
        }

        // DPT Forms
        public IActionResult DPT3()
        {
            ViewBag.ctrl = "DPT3";
            return View();
        }

        [HttpGet("[controller]/DPT3/Add")]
        [HttpGet("[controller]/DPT3/Edit/{id}")]
        public IActionResult DPT3Form(int id = 0)
        {
            ViewBag.ctrl = "DPT3";
            ViewBag.id = id;
            return View();
        }
        public IActionResult DPT4()
        {
            ViewBag.ctrl = "DPT4";
            return View();
        }

        [HttpGet("[controller]/DPT4/Add")]
        [HttpGet("[controller]/DPT4/Edit/{id}")]
        public IActionResult DPT4Form(int id = 0)
        {
            ViewBag.ctrl = "DPT4";
            ViewBag.id = id;
            return View();
        }

        // DIR Forms

        public IActionResult DIR3()
        {
            ViewBag.ctrl = "DIR3";
            return View();
        }

        [HttpGet("[controller]/DIR3/Add")]
        [HttpGet("[controller]/DIR3/Edit/{id}")]
        public IActionResult DIR3Form(int id = 0)
        {
            ViewBag.ctrl = "DIR3";
            ViewBag.id = id;
            return View();
        }
        public IActionResult DIR5()
        {
            ViewBag.ctrl = "DIR5";
            return View();
        }

        [HttpGet("[controller]/DIR5/Add")]
        [HttpGet("[controller]/DIR5/Edit/{id}")]
        public IActionResult DIR5Form(int id = 0)
        {
            ViewBag.ctrl = "DIR5";
            ViewBag.id = id;
            return View();
        }
        public IActionResult DIR6()
        {
            ViewBag.ctrl = "DIR6";
            return View();
        }

        [HttpGet("[controller]/DIR6/Add")]
        [HttpGet("[controller]/DIR6/Edit/{id}")]
        public IActionResult DIR6Form(int id = 0)
        {
            ViewBag.ctrl = "DIR6";
            ViewBag.id = id;
            return View();
        }
        public IActionResult DIR9()
        {
            ViewBag.ctrl = "DIR9";
            return View();
        }

        [HttpGet("[controller]/DIR9/Add")]
        [HttpGet("[controller]/DIR9/Edit/{id}")]
        public IActionResult DIR9Form(int id = 0)
        {
            ViewBag.ctrl = "DIR9";
            ViewBag.id = id;
            return View();
        }
        public IActionResult DIR11()
        {
            ViewBag.ctrl = "DIR11";
            return View();
        }

        [HttpGet("[controller]/DIR11/Add")]
        [HttpGet("[controller]/DIR11/Edit/{id}")]
        public IActionResult DIR11Form(int id = 0)
        {
            ViewBag.ctrl = "DIR11";
            ViewBag.id = id;
            return View();
        }
        public IActionResult DIR12()
        {
            ViewBag.ctrl = "DIR12";
            return View();
        }

        [HttpGet("[controller]/DIR12/Add")]
        [HttpGet("[controller]/DIR12/Edit/{id}")]
        public IActionResult DIR12Form(int id = 0)
        {
            ViewBag.ctrl = "DIR12";
            ViewBag.id = id;
            return View();
        }
        public IActionResult NDH1()
        {
            return View();
        }
        public IActionResult NDH2()
        {
            return View();
        }

        public IActionResult INC4()
        {
            ViewBag.ctrl = "INC4";
            return View();
        }

        [HttpGet("[controller]/INC4/Add")]
        [HttpGet("[controller]/INC4/Edit/{id}")]
        public IActionResult INC4Form(int id = 0)
        {
            ViewBag.ctrl = "INC4";
            ViewBag.id = id;
            return View();
        }

        public IActionResult INC22()
        {
            ViewBag.ctrl = "INC22";
            return View();
        }

        [HttpGet("[controller]/INC22/Add")]
        [HttpGet("[controller]/INC22/Edit/{id}")]
        public IActionResult INC22Form(int id = 0)
        {
            ViewBag.ctrl = "INC22";
            ViewBag.id = id;
            return View();
        }

        public IActionResult SH7()
        {
            ViewBag.ctrl = "SH7";
            return View();
        }

        [HttpGet("[controller]/SH7/Add")]
        [HttpGet("[controller]/SH7/Edit/{id}")]
        public IActionResult SH7Form(int id = 0)
        {
            ViewBag.ctrl = "SH7";
            ViewBag.id = id;
            return View();
        }

        public IActionResult MR1()
        {
            ViewBag.ctrl = "MR1";
            return View();
        }

        [HttpGet("[controller]/MR1/Add")]
        [HttpGet("[controller]/MR1/Edit/{id}")]
        public IActionResult MR1Form(int id = 0)
        {
            ViewBag.ctrl = "MR1";
            ViewBag.id = id;
            return View();
        }
        public IActionResult INC20A()
        {
            ViewBag.ctrl = "INC20A";
            return View();
        }

        [HttpGet("[controller]/INC20A/Add")]
        [HttpGet("[controller]/INC20A/Edit/{id}")]
        public IActionResult INC20AForm(int id = 0)
        {
            ViewBag.ctrl = "INC20A";
            ViewBag.id = id;
            return View();
        }

        public IActionResult INC28()
        {
            ViewBag.ctrl = "INC28";
            return View();
        }

        [HttpGet("[controller]/INC28/Add")]
        [HttpGet("[controller]/INC28/Edit/{id}")]
        public IActionResult INC28Form(int id = 0)
        {
            ViewBag.ctrl = "INC28";
            ViewBag.id = id;
            return View();
        }
        public IActionResult PAS2()
        {
            ViewBag.ctrl = "PAS2";
            return View();
        }

        [HttpGet("[controller]/PAS2/Add")]
        [HttpGet("[controller]/PAS2/Edit/{id}")]
        public IActionResult PAS2Form(int id = 0)
        {
            ViewBag.ctrl = "PAS2";
            ViewBag.id = id;
            return View();
        }
        public IActionResult INC12()
        {
            ViewBag.ctrl = "INC12";
            return View();
        }

        [HttpGet("[controller]/INC12/Add")]
        [HttpGet("[controller]/INC12/Edit/{id}")]
        public IActionResult INC12Form(int id = 0)
        {
            ViewBag.ctrl = "INC12";
            ViewBag.id = id;
            return View();
        }
        public IActionResult INC24()
        {
            ViewBag.ctrl = "INC24";
            return View();
        }

        [HttpGet("[controller]/INC24/Add")]
        [HttpGet("[controller]/INC24/Edit/{id}")]
        public IActionResult INC24Form(int id = 0)
        {
            ViewBag.ctrl = "INC24";
            ViewBag.id = id;
            return View();
        }
        public IActionResult STK2()
        {
            ViewBag.ctrl = "STK2";
            return View();
        }

        [HttpGet("[controller]/STK2/Add")]
        [HttpGet("[controller]/STK2/Edit/{id}")]
        public IActionResult STK2Form(int id = 0)
        {
            ViewBag.ctrl = "STK2";
            ViewBag.id = id;
            return View();
        }

        public IActionResult INC23()
        {
            ViewBag.ctrl = "INC23";
            return View();
        }

        [HttpGet("[controller]/INC23/Add")]
        [HttpGet("[controller]/INC23/Edit/{id}")]
        public IActionResult INC23Form(int id = 0)
        {
            ViewBag.ctrl = "INC23";
            ViewBag.id = id;
            return View();
        }

        public IActionResult MGT14()
        {
            ViewBag.ctrl = "MGT14";
            return View();
        }

        [HttpGet("[controller]/MGT14/Add")]
        [HttpGet("[controller]/MGT14/Edit/{id}")]
        public IActionResult MGT14Form(int id = 0)
        {
            ViewBag.ctrl = "MGT14";
            ViewBag.id = id;
            return View();
        }
        public IActionResult MSC3()
        {
            ViewBag.ctrl = "MSC3";
            return View();
        }

        [HttpGet("[controller]/MSC3/Add")]
        [HttpGet("[controller]/MSC3/Edit/{id}")]
        public IActionResult MSC3Form(int id = 0)
        {
            ViewBag.ctrl = "MSC3";
            ViewBag.id = id;
            return View();
        }
        public IActionResult PAS3()
        {
            ViewBag.ctrl = "PAS3";
            return View();
        }

        [HttpGet("[controller]/PAS3/Add")]
        [HttpGet("[controller]/PAS3/Edit/{id}")]
        public IActionResult PAS3Form(int id = 0)
        {
            ViewBag.ctrl = "PAS3";
            ViewBag.id = id;
            return View();
        }
        public IActionResult PAS6()
        {
            ViewBag.ctrl = "PAS6";
            return View();
        }

        [HttpGet("[controller]/PAS6/Add")]
        [HttpGet("[controller]/PAS6/Edit/{id}")]
        public IActionResult PAS6Form(int id = 0)
        {
            ViewBag.ctrl = "PAS6";
            ViewBag.id = id;
            return View();
        }
        public IActionResult GNL2()
        {
            ViewBag.ctrl = "GNL2";
            return View();
        }

        [HttpGet("[controller]/GNL2/Add")]
        [HttpGet("[controller]/GNL2/Edit/{id}")]
        public IActionResult GNL2Form(int id = 0)
        {
            ViewBag.ctrl = "GNL2";
            ViewBag.id = id;
            return View();
        }
        public IActionResult GNL3()
        {
            ViewBag.ctrl = "GNL3";
            return View();
        }

        [HttpGet("[controller]/GNL3/Add")]
        [HttpGet("[controller]/GNL3/Edit/{id}")]
        public IActionResult GNL3Form(int id = 0)
        {
            ViewBag.ctrl = "GNL3";
            ViewBag.id = id;
            return View();
        }
        public IActionResult SH8()
        {
            ViewBag.ctrl = "SH8";
            return View();
        }

        [HttpGet("[controller]/SH8/Add")]
        [HttpGet("[controller]/SH8/Edit/{id}")]
        public IActionResult SH8Form(int id = 0)
        {
            ViewBag.ctrl = "SH8";
            ViewBag.id = id;
            return View();
        }
        public IActionResult SH9()
        {
            ViewBag.ctrl = "SH9";
            return View();
        }

        [HttpGet("[controller]/SH9/Add")]
        [HttpGet("[controller]/SH9/Edit/{id}")]
        public IActionResult SH9Form(int id = 0)
        {
            ViewBag.ctrl = "SH9";
            ViewBag.id = id;
            return View();
        }
        public IActionResult SH11()
        {
            ViewBag.ctrl = "SH11";
            return View();
        }

        [HttpGet("[controller]/SH11/Add")]
        [HttpGet("[controller]/SH11/Edit/{id}")]
        public IActionResult SH11Form(int id = 0)
        {
            ViewBag.ctrl = "SH11";
            ViewBag.id = id;
            return View();
        }
        public IActionResult MSME()
        {
            ViewBag.ctrl = "MSME";
            return View();
        }

        [HttpGet("[controller]/MSME/Add")]
        [HttpGet("[controller]/MSME/Edit/{id}")]
        public IActionResult MSMEForm(int id = 0)
        {
            ViewBag.ctrl = "MSME";
            ViewBag.id = id;
            return View();
        }
        public IActionResult MGT6()
        {
            ViewBag.ctrl = "MGT6";
            return View();
        }

        [HttpGet("[controller]/MGT6/Add")]
        [HttpGet("[controller]/MGT6/Edit/{id}")]
        public IActionResult MGT6Form(int id = 0)
        {
            ViewBag.ctrl = "MGT6";
            ViewBag.id = id;
            return View();
        }
        public IActionResult BEN2()
        {
            ViewBag.ctrl = "BEN2";
            return View();
        }

        [HttpGet("[controller]/BEN2/Add")]
        [HttpGet("[controller]/BEN2/Edit/{id}")]
        public IActionResult BEN2Form(int id = 0)
        {
            ViewBag.ctrl = "BEN2";
            ViewBag.id = id;
            return View();
        }


        public IActionResult AOC5()
        {
            ViewBag.ctrl = "AOC5";
            return View();
        }
        [HttpGet("[controller]/AOC5/Add")]
        [HttpGet("[controller]/AOC5/Edit/{id}")]
        public IActionResult AOC5Form(int id = 0)
        {
            ViewBag.ctrl = "AOC5";
            ViewBag.id = id;
            return View();
        }

        public IActionResult RUNLLP()
        {
            ViewBag.ctrl = "RUNLLP";
            return View();
        }
        [HttpGet("[controller]/RUNLLP/Add")]
        [HttpGet("[controller]/RUNLLP/Edit/{id}")]
        public IActionResult RUNLLPForm(int id = 0)
        {
            ViewBag.ctrl = "RUNLLP";
            ViewBag.id = id;
            return View();
        }


        public IActionResult RUN()
        {
            ViewBag.ctrl = "RUN";
            return View();
        }
        [HttpGet("[controller]/RUN/Add")]
        [HttpGet("[controller]/RUN/Edit/{id}")]
        public IActionResult RUNForm(int id = 0)
        {
            ViewBag.ctrl = "RUN";
            ViewBag.id = id;
            return View();
        }
        public IActionResult IEPF5()
        {
            ViewBag.ctrl = "IEPF5";
            return View();
        }
        [HttpGet("[controller]/IEPF5/Add")]
        [HttpGet("[controller]/IEPF5/Edit/{id}")]
        public IActionResult IEPF5Form(int id = 0)
        {
            ViewBag.ctrl = "IEPF5";
            ViewBag.id = id;
            return View();
        }
        public IActionResult IEPF2()
        {
            ViewBag.ctrl = "IEPF2";
            return View();
        }
        [HttpGet("[controller]/IEPF2/Add")]
        [HttpGet("[controller]/IEPF2/Edit/{id}")]
        public IActionResult IEPF2Form(int id = 0)
        {
            ViewBag.ctrl = "IEPF2";
            ViewBag.id = id;
            return View();
        }

        public IActionResult AOC4()
        {
            ViewBag.ctrl = "AOC4";
            return View();
        }
        [HttpGet("[controller]/AOC4/Add")]
        [HttpGet("[controller]/AOC4/Edit/{id}")]
        public IActionResult AOC4Form(int id = 0)
        {
            ViewBag.ctrl = "AOC4";
            ViewBag.id = id;
            return View();
        }


        public IActionResult MGT7A()
        {
            ViewBag.ctrl = "MGT7A";
            return View();
        }
        [HttpGet("[controller]/MGT7A/Add")]
        [HttpGet("[controller]/MGT7A/Edit/{id}")]
        public IActionResult MGT7AForm(int id = 0)
        {
            ViewBag.ctrl = "MGT7A";
            ViewBag.id = id;
            return View();
        }
        public IActionResult ADT1()
        {
            ViewBag.ctrl = "ADT1";
            return View();
        }
        [HttpGet("[controller]/ADT1/Add")]
        [HttpGet("[controller]/ADT1/Edit/{id}")]
        public IActionResult ADT1Form(int id = 0)
        {
            ViewBag.ctrl = "ADT1";
            ViewBag.id = id;
            return View();
        }


        public IActionResult AOC4CFS()
        {
            ViewBag.ctrl = "AOC4CFS";
            return View();
        }
        [HttpGet("[controller]/AOC4CFS/Add")]
        [HttpGet("[controller]/AOC4CFS/Edit/{id}")]
        public IActionResult AOC4CFSForm(int id = 0)
        {
            ViewBag.ctrl = "AOC4CFS";
            ViewBag.id = id;
            return View();
        }

        public IActionResult ADT3()
        {
            ViewBag.ctrl = "ADT3";
            return View();
        }
        [HttpGet("[controller]/ADT3/Add")]
        [HttpGet("[controller]/ADT3/Edit/{id}")]
        public IActionResult ADT3Form(int id = 0)
        {
            ViewBag.ctrl = "ADT3";
            ViewBag.id = id;
            return View();
        }
        public IActionResult MSME1()
        {
            ViewBag.ctrl = "MSME1";
            return View();
        }
        [HttpGet("[controller]/MSME1/Add")]
        [HttpGet("[controller]/MSME1/Edit/{id}")]
        public IActionResult MSME1Form(int id = 0)
        {
            ViewBag.ctrl = "MSME1";
            ViewBag.id = id;
            return View();
        }


        public IActionResult GNL1()
        {
            ViewBag.ctrl = "GNL1";
            return View();
        }
        [HttpGet("[controller]/GNL1/Add")]
        [HttpGet("[controller]/GNL1/Edit/{id}")]
        public IActionResult GNL1Form(int id = 0)
        {
            ViewBag.ctrl = "GNL1";
            ViewBag.id = id;
            return View();
        }

        public IActionResult Form3()
        {
            ViewBag.ctrl = "Form3";
            return View();
        }
        [HttpGet("[controller]/Form3/Add")]
        [HttpGet("[controller]/Form3/Edit/{id}")]
        public IActionResult Form3Form(int id = 0)
        {
            ViewBag.ctrl = "Form3";
            ViewBag.id = id;
            return View();
        }
        public IActionResult Form4()
        {
            ViewBag.ctrl = "Form4";
            return View();
        }
        [HttpGet("[controller]/Form4/Add")]
        [HttpGet("[controller]/Form4/Edit/{id}")]
        public IActionResult Form4Form(int id = 0)
        {
            ViewBag.ctrl = "Form4";
            ViewBag.id = id;
            return View();
        }

        public IActionResult Form5()
        {
            ViewBag.ctrl = "Form5";
            return View();
        }
        [HttpGet("[controller]/Form5/Add")]
        [HttpGet("[controller]/Form5/Edit/{id}")]
        public IActionResult Form5Form(int id = 0)
        {
            ViewBag.ctrl = "Form5";
            ViewBag.id = id;
            return View();
        }

        public IActionResult AccountnSolvency()
        {
            ViewBag.ctrl = "AccountnSolvency";
            return View();
        }
        [HttpGet("[controller]/AccountnSolvency/Add")]
        [HttpGet("[controller]/AccountnSolvency/Edit/{id}")]
        public IActionResult AccountnSolvencyForm(int id = 0)
        {
            ViewBag.ctrl = "AccountnSolvency";
            ViewBag.id = id;
            return View();
        }


        public IActionResult CHARGE()
        {
            ViewBag.ctrl = "CHARGE";
            return View();
        }
        [HttpGet("[controller]/CHARGE/Add")]
        [HttpGet("[controller]/CHARGE/Edit/{id}")]
        public IActionResult CHARGEFORM(int id = 0)
        {
            ViewBag.ctrl = "CHARGE";
            ViewBag.id = id;
            return View();
        }


        public IActionResult Form11()
        {
            ViewBag.ctrl = "Form11";
            return View();
        }
        [HttpGet("[controller]/Form11/Add")]
        [HttpGet("[controller]/Form11/Edit/{id}")]
        public IActionResult Form11Form(int id = 0)
        {
            ViewBag.ctrl = "Form11";
            ViewBag.id = id;
            return View();
        }


        public IActionResult Form12()
        {
            ViewBag.ctrl = "Form12";
            return View();
        }
        [HttpGet("[controller]/Form12/Add")]
        [HttpGet("[controller]/Form12/Edit/{id}")]
        public IActionResult Form12Form(int id = 0)
        {
            ViewBag.ctrl = "Form12";
            ViewBag.id = id;
            return View();
        }


        public IActionResult Form15()
        {
            ViewBag.ctrl = "Form15";
            return View();
        }
        [HttpGet("[controller]/Form15/Add")]
        [HttpGet("[controller]/Form15/Edit/{id}")]
        public IActionResult Form15Form(int id = 0)
        {
            ViewBag.ctrl = "Form15";
            ViewBag.id = id;
            return View();
        }


        public IActionResult Form22()
        {
            ViewBag.ctrl = "Form22";
            return View();
        }
        [HttpGet("[controller]/Form22/Add")]
        [HttpGet("[controller]/Form22/Edit/{id}")]
        public IActionResult Form22Form(int id = 0)
        {
            ViewBag.ctrl = "Form22";
            ViewBag.id = id;
            return View();
        }

        public IActionResult Form23()
        {
            ViewBag.ctrl = "Form23";
            return View();
        }
        [HttpGet("[controller]/Form23/Add")]
        [HttpGet("[controller]/Form23/Edit/{id}")]
        public IActionResult Form23Form(int id = 0)
        {
            ViewBag.ctrl = "Form23";
            ViewBag.id = id;
            return View();
        }
        public IActionResult Form24()
        {
            ViewBag.ctrl = "Form24";
            return View();
        }
        [HttpGet("[controller]/Form24/Add")]
        [HttpGet("[controller]/Form24/Edit/{id}")]
        public IActionResult Form24Form(int id = 0)
        {
            ViewBag.ctrl = "Form24";
            ViewBag.id = id;
            return View();
        }
        public IActionResult MGT8()
        {
            ViewBag.ctrl = "MGT8";
            return View();
        }
        [HttpGet("[controller]/MGT8/Add")]
        [HttpGet("[controller]/MGT8/Edit/{id}")]
        public IActionResult MGT8Form(int id = 0)
        {
            ViewBag.ctrl = "MGT8";
            ViewBag.id = id;
            return View();
        }
        public IActionResult MGT9()
        {
            ViewBag.ctrl = "MGT9";
            return View();
        }
        [HttpGet("[controller]/MGT9/Add")]
        [HttpGet("[controller]/MGT9/Edit/{id}")]
        public IActionResult MGT9Form(int id = 0)
        {
            ViewBag.ctrl = "MGT9";
            ViewBag.id = id;
            return View();
        }



        public IActionResult boardreport()
        {
            ViewBag.ctrl = "boardreport";
            return View();
        }
        [HttpGet("[controller]/boardreport/Add")]
        [HttpGet("[controller]/boardreport/Edit/{id}")]
        public IActionResult boardreportForm(int id = 0)
        {
            ViewBag.ctrl = "boardreport";
            ViewBag.id = id;
            return View();
        }





        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
