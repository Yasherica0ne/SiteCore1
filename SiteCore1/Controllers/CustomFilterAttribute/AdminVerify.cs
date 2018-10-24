using System.Web.Mvc;
using System.Web.Routing;

namespace SiteCore1.Controllers.CustomRouteAttribute
{
    public class AdminVerify : ActionFilterAttribute
    {
        private const string secretKey = "sitecore";

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var key = filterContext.ActionParameters["secret"];
            if (key == null || !secretKey.Equals(key))
            {
                filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary(new { controller = "Home", action = "Index" }));
            }
        }
    }
}