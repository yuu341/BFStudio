using BFStudio.Utility.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BFStudio.Utility.MVC
{
    public class BaseController : Controller
    {
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);

            var routes = filterContext.RequestContext.RouteData.Values;
            Logging.Logger.Info(string.Format("controller:[{0}]\taction[{1}]", routes["controller"] , routes["action"]));
        }
    }
}