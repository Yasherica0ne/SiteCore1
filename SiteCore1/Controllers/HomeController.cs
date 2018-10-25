using SiteCore1.Controllers.CustomRouteAttribute;
using SiteCore1.Storage;
using System.Web;
using System.Web.Mvc;

namespace SiteCore1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string eventsString = EventStorage.GetMarkup();
            @ViewBag.eventList = new HtmlString(eventsString);
            return View();
        }
    }
}