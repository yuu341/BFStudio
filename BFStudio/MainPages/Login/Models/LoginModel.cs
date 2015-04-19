using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BFStudio.MainPages.Login.Models
{
    public class LoginModel
    {
        
        [Display( Name = "ログインID")]
        public string LoginId { get; set; }

        
        [Display( Name = "パスワード")]
        public string Password { get; set; }

        public bool RememberMe
        {
            get
            {
                return false;
            }
        }
    }
}