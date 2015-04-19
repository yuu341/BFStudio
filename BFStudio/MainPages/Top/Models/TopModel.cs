using BFStudio.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BFStudio.MainPages.Top.Models
{
    public class TopModel
    {
        DBManageEntities db = new DBManageEntities();
        public List<MST_MENU> Menues
        {
            get
            {
                return db.MST_MENU.ToList();
            }
        }
    }
}