using BFStudio.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BFStudio.Pages.UserSettings.Models
{
    public class UserSettingsModel
    {
        DBManageEntities db = new DBManageEntities();

        public UserSettingsModel()
        {
            Initialize();
        }

        private void Initialize()
        {
            using (var ent = new DBManageEntities())
            {
                UserList = ent.MST_USER.ToList();
            }
        }

        public List<MST_USER> UserList
        {
            get;
            set;
        }

        public MST_USER UpdateTarget { get; set; }
    }
}