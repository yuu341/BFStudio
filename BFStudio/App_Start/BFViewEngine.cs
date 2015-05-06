using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BFStudio.App_Start
{
    public class BFViewEngine : RazorViewEngine
    {
        public BFViewEngine()
        {
            this.MasterLocationFormats = base.MasterLocationFormats;
            this.ViewLocationFormats = new string[]{
                "~/Pages/{1}/Views/{0}.cshtml",
                "~/MainPages/{1}/Views/{0}.cshtml"
            };

            this.PartialViewLocationFormats = new string[]{
                "~/MainPages/{1}/Shared/{0}.cshtml",
                "~/MainPages/{1}/Views/{0}.cshtml",
                "~/Pages/{1}/Views/{0}.cshtml",
                "~/MainPages/Shared/{0}.cshtml",
                "~/Pages/{1}/Shared/{0}.cshtml",
            };
        }
    }
}