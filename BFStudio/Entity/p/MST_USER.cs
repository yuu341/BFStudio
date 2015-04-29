using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BFStudio.Entity
{
    public partial class MST_USER : IUser<string>
    {
        public string Id
        {
            get
            {
                return LOGIN_ID;
            }
        }

        public string UserName
        {
            get
            {
                return LOGIN_NM;
            }
            set
            {
                LOGIN_NM = value;
            }
        }
    }
}