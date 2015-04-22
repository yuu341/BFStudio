using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BFStudio.MainPages.Login.Models
{
    public class LoginModel
    {
        [Required]
        [Display( Name = "ログインID")]
        public string LoginId { get; set; }

        
        [Required]
        [Display( Name = "パスワード")]
        public string Password { get; set; }

        [Display(Name = "ログイン情報を覚える")]
        public bool RememberMe { get; set; }
    }
}