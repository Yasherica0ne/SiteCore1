using SiteCore1.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SiteCore1.Controllers
{
    public class HomeController : Controller
    {
        //[Route("Home/Index/{secret:values(sitecore)}")]

        public ActionResult Index(string secret)
        {
            string eventsString = EventStorage.GetMarkup();
            @ViewBag.eventList = new HtmlString(eventsString);
            return View();
        }
    }
}