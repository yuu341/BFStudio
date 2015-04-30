using BFStudio.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;

namespace BFStudio.Utility.MVC
{
    public class SystemCacheManager
    {
        public static List<MST_MENU> MenuList
        {
            get
            {
                if (GetCache() == null)
                {
                    using (var ent = new DBManageEntities())
                    {
                        SetCache(CreateTreeMenu(ent.MST_MENU.ToList()));
                    }
                }
                return GetCache() as List<MST_MENU>;
            }
        }

        private static List<MST_MENU> CreateTreeMenu(List<MST_MENU> menu)
        {
            List<MST_MENU> result = new List<MST_MENU>();

            result = menu.Where(p => p.PMENU_ID == null).OrderBy(p => p.SORT_NO).ToList();

            foreach (var each in result)
            {
                CreateChild(each);
            }

            return result;
        }
        private static void CreateChild(MST_MENU menu)
        {
            if (menu.MST_MENU1.Count == 0)
                return;
         
            menu.ChildMenu = menu.MST_MENU1.OrderBy(p => p.SORT_NO).ToList();
            foreach (var each in menu.ChildMenu)
            {
                CreateChild(each);
            }

        }

        public static List<MST_USER> UserList
        {
            get
            {
                return new DBManageEntities().MST_USER.ToList();
                if (GetCache() == null)
                {
                    using (var ent = new DBManageEntities())
                    {
                        SetCache(ent.MST_USER.ToList());
                    }
                }
                return GetCache() as List<MST_USER>;
            }
        }

        public static MST_USER GetUser(string login_id)
        {
            var user = UserList.SingleOrDefault(p => p.LOGIN_ID == login_id);

            if (user == null)
            {
                user = UserList.Single(p => p.LOGIN_ID == "empty");
            }
            return user;
        }

        private static object GetCache([CallerMemberName]string key = "")
        {
            return HttpContext.Current.Cache[key];
        }

        private static void SetCache(object value, [CallerMemberName]string key = "")
        {
            HttpContext.Current.Cache[key] = value;
        }
    }
}