using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SiteCore1.Controllers
{
    public class AdminPanelController : Controller
    {
        // GET: Admin
        //[Route("Admin/NewEvent/{secret:values(sitecore)}")]
        public ActionResult Admin()
        {
            return View();
        }
    }
}