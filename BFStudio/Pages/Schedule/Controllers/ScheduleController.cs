using BFStudio.Pages.Schedule.Models;
using BFStudio.Utility.MVC;
using System.Web.Mvc;
//using BFStudio.Entity;

namespace BFStudio.Pages.Schedule.Controllers
{
    [Authorize]
    public class ScheduleController : BaseController
    {

        public ActionResult Index()
        {
            ScheduleModel model = new ScheduleModel();

            return View(model);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
            }
            base.Dispose(disposing);
        }
    }
}
