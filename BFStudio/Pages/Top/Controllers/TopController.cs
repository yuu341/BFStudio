using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
//using BFStudio.Entity;
using BFStudio.Pages.Top.Models;
using BFStudio.Utility.MVC;

namespace BFStudio.Pages.Top.Controllers
{
    [Authorize]
    public class TopController : BaseController
    {
        public ActionResult Top()
        {
            return View("Index",new TopModel());
        }
        // GET: Top
        public ActionResult Index()
        {
            TopModel model = new TopModel();

            return PartialView(model);
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
