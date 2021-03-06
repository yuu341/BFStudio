﻿using BFStudio.Pages.UserSettings.Models;
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

namespace BFStudio.Pages.UserSettings.Controllers
{
    [Authorize]
    public class UserSettingsController : BaseController
    {

        public ActionResult Index()
        {
            UserSettingsModel model = new UserSettingsModel();

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
