using System.Web.Mvc;

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
            return View();
        }
    }
}
