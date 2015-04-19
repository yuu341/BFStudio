using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BFStudio.Entity
{
    public partial class MST_USER : IUser
    {
        #region Interfaces

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

        #endregion

        public string Login_Id_Form
        {
            get;
            set;
        }
        public string Password_Form
        {
            get;
            set;
        }
    }
}