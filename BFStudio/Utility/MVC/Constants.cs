using BFStudio.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;

namespace BFStudio.Utility.MVC
{
    public class Constants
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