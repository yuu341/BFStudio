using BFStudio.Entity;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BFStudio.Utility.Manager
{
    // このアプリケーションで使用されるアプリケーション ユーザー マネージャーを設定します。UserManager は ASP.NET Identity の中で定義されており、このアプリケーションで使用されます。
    public class ApplicationUserManager : UserManager<MST_USER>
    {
        public ApplicationUserManager(IUserStore<MST_USER> store)
            : base(store)
        {
            this.PasswordHasher = new BFStudioPasswordHasher();
        }


        public class BFStudioPasswordHasher : PasswordHasher
        {
            public override string HashPassword(string password)
            {
                return base.HashPassword(password);
            }
            public override PasswordVerificationResult VerifyHashedPassword(string hashedPassword, string providedPassword)
            {
                return base.VerifyHashedPassword(hashedPassword, providedPassword);
            }
        }
    }
}