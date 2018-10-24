using SiteCore1.Controllers.CustomRouteAttribute;
using System.Web.Mvc;
using System.Web.Mvc.Routing;
using System.Web.Routing;

namespace SiteCore1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{secret}",
                defaults: new { controller = "Home", action = "Index" },
                constraints: new { secret = new AdminVerify("sitecore") }
            );

        }
    }
}
