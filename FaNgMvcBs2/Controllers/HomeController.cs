using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using FdaService;
using FdaService.Models.Drug.Event;

namespace FaNgMvcBs2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var results = ServiceHelper.GetData<RootObject>("https://api.fda.gov",
                "/drug/event.json?",
                "search=receivedate:[20040101+TO+20150101]&count=receivedate");

            results.results = results.results.Take<Result>(5).ToList();
            return View(results);
        }

        public IActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View("~/Views/Shared/Error.cshtml");
        }
    }
}
