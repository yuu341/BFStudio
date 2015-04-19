using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BFStudio.App_Start
{
    public class TicketAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Ticket";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute("Ticket_default",
                "Ticket/{controller}/{action}/{id}",
                new { action = "Index", id = "" });
        }
    }
}