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
                        SetCache(ent.MST_MENU.ToList());
                    }
                }
                return GetCache() as List<MST_MENU>;
            }
        }

        public static List<MST_USER> UserList
        {
            get
            {
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