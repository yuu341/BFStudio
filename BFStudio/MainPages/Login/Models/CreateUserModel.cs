using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BFStudio.MainPages.Login.Models
{
    public class CreateUserModel
    {
        [Display(Name = "ログインID")]
        [Required]
        public string LoginId { get; set; }

        [Display( Name="ユーザ名" )]
        [Required]
        public string UserName { get; set; }

        [Display( Name="パスワード")]
        [Required]
        public string Password { get; set; }

        [Display( Name="パスワード（確認）")]
        [Required]
        
        public string ConformPassword { get; set; }

        //[Display( Name="メールアドレス" )]
        //[Required]
        //public string Mail { get; set; }
    }
}