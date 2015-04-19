using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
//using BFStudio.Entity;
using BFStudio.MainPages.Top.Models;

namespace BFStudio.MainPages.Top.Controllers
{
    public class TopController : Controller
    {

        // GET: Top
        public ActionResult Index()
        {
            TopModel model = new TopModel();

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
