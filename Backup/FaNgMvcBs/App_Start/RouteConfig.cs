using System.Web.Mvc;
using System.Web.Routing;

namespace FaNgMvcBs
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            //To assess session from Api. 
            //routes.MapRoute(
            //	name: "DefaultApi",
            //	url: "api/{controller}/{id}",
            //	defaults: new {id = RouteParameter.Optional}
            //);

            //apiRoute.RouteHandler = new ApiContollerRouteHandler();
        }
    }
}