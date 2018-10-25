using SiteCore1.Controllers.CustomRouteAttribute;
using SiteCore1.Storage;
using System.Web.Mvc;

namespace SiteCore1.Controllers
{
    public class AdminPanelController : Controller
    {
        // GET: Admin
        [AdminVerify]
        public ActionResult NewEvent(string secret)
        {
            return View();
        }

        [HttpPost]
        public void AddEventForm(Models.EventModel eventModel)
        {
            eventModel.SetParameters();
            //EventStorage
            //Do something with formData
        }
    }
}