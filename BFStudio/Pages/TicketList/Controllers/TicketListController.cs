using BFStudio.Pages.TicketList.Models;
using BFStudio.Utility.MVC;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
//using BFStudio.Entity;

namespace BFStudio.Pages.TicketList.Controllers
{
    [Authorize]
    public class TicketListController : BaseController
    {

        public ActionResult Index()
        {
            TicketListModel model = new TicketListModel();

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
