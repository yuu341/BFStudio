using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BFStudio.Entity
{
    public class UserManageEntities : DBManageEntities, IdentityDbContext<MST_USER>
    {
        public static UserManageEntities Create()
        {
            return new UserManageEntities();
        }
    }
}