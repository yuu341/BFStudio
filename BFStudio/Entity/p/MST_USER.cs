using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BFStudio.Entity
{
    [MetadataType(typeof(MST_USERMetadata))]
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

        public string PasswordConfirm_Form
        {
            get;
            set;
        }
    }

    public class MST_USERMetadata
    {
        [Required]
        [Display(Name = "ログインID")]
        public string Login_Id_Form { get; set; }

        [Required]
        [Display(Name = "パスワード")]
        public string Password_Form { get; set; }

        [Required]
        [Display(Name = "パスワード（確認）")]
        public string PasswordConfirm_Form { get; set; }
    }
}