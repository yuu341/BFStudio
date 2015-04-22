using BFStudio.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BFStudio.Pages.TicketList.Models
{
    public class TicketListModel
    {
        DBManageEntities db = new DBManageEntities();

        public TicketListModel()
        {
            Initialize();
        }

        private void Initialize()
        {
            using (var ent = new DBManageEntities())
            {
                TicketList = ent.V_TICKETLIST.ToList();
            }
        }

        public List<V_TICKETLIST> TicketList
        {
            get;
            set;
        }

        public DBA_TICKET Target
        {
            get;
            set;
        }
    }
}