using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using FdaService;
using FdaService.Models.Drug.Event;
using FaNgMvcBs2.ViewModels;

namespace FaNgMvcBs2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var drugEventViewModel = new DrugEventViewModel();
            drugEventViewModel.SearchCriteria = SearchLookups.GetResultFields().ToList();

            return View(drugEventViewModel);
        }
        [HttpPost]
        public IActionResult Index(DrugEventViewModel model)
        {
            var drugEventViewModel = new DrugEventViewModel();
            drugEventViewModel.SearchCriteria = SearchLookups.GetResultFields().ToList();

            drugEventViewModel.RootObject = ServiceHelper.GetData<RootObject>("https://api.fda.gov",
                "/drug/event.json?",
                string.Format("search={0}:\"{1}\"&limit=50", model.SearchCriteriaSelected, model.SearchInfo)); //"search=patient.drug.openfda.pharm_class_epc:\"nonsteroidal+anti-inflammatory+drug\"");
                                                                                //"search=patient.drug.openfda.brand_name:\"allegra\"&limit=50");

            drugEventViewModel.RootObject.results = drugEventViewModel.RootObject.results.Take<Result>(5).ToList();
            return View(drugEventViewModel);
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
