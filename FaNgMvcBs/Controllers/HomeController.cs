using System.Web.Mvc;
using FdaService;
using FdaService.Models.Drug.Event;

namespace FaNgMvcBs.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Sample()
        {
            var results = ServiceHelper.GetData<RootObject>("https://api.fda.gov",
                "/drug/event.json?",
                "search=receivedate:[20040101+TO+20150101]&count=receivedate");

            return View();
        }

    }
}
