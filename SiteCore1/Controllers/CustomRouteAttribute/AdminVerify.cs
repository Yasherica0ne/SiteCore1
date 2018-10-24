using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SiteCore1.Controllers.CustomRouteAttribute
{
    public class AdminVerify : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var user = filterContext.HttpContext.Session["secret"];
            string result = user.ToString();
            //if (user == null)
            //    filterContext.Result = new RedirectResult(string.Format("/User/Login?targetUrl={0}", filterContext.HttpContext.Request.Url.AbsolutePath));
        }
    }
}