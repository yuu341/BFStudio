using BFStudio.MainPages.Login.Models;
using BFStudio.Utility.Manager;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using System.Web;
using System.Web.Mvc;
using BFStudio.Entity;
using BFStudio.Utility.MVC;
using System;

namespace BFStudio.MainPages.Login.Controllers
{
    [Authorize]
    public class LoginController : BaseController
    {

        public ActionResult Action()
        {
            return View();
        }
        private ActionResult RedirectToLocal(string returnUrl)
        {
            //if (Url.IsLocalUrl(returnUrl))
            //{
            //    return Redirect(returnUrl);
            //}
            return RedirectToAction("Top", "Top");
        }

        [AllowAnonymous]
        public ActionResult Index(string returnUrl)
        {
            if (Request.IsAuthenticated)
            {
                return RedirectToLocal(returnUrl);
            }
            return View(new LoginModel());
        }


        public ActionResult LogOff()
        {
            var authentication = this.HttpContext.GetOwinContext().Authentication;
            authentication.SignOut();

            return Redirect("/");
            //return RedirectToLocal("/");
            
        }

        [HttpGet]
        [AllowAnonymous]
        public ActionResult Create(CreateUserModel model)
        {
            this.ModelState.Clear();
            return PartialView(model);
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Register(CreateUserModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return PartialView(model);
            }

            using (var ent = new DBManageEntities())
            {
                try
                {
                    PasswordHasher hash = new PasswordHasher();
                    ent.MST_USER.Add(new MST_USER()
                    {
                        LOGIN_ID = model.LoginId,
                        LOGIN_NM = model.UserName,
                        PASSWORD = hash.HashPassword(model.Password),
                        LOCKOUT_FLG = false,
                        LOCKOUT_CNT = 0,
                    });

                    ent.SaveChanges();
                }
                catch (Exception e)
                {
                    var test = e.InnerException;
                    var test2 = e.Message;

                }
            }
            return new EmptyResult();
        }
        

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Authentication(LoginModel model, string returnUrl)
        {
            Logging.Logger.Info( "[" + model.LoginId + "]がログインを試行...");
            if (!ModelState.IsValid)
            {
                return View("Index",model);
            }

            PasswordHasher hash = new PasswordHasher();
            var result = hash.HashPassword(model.Password);


            ApplicationUserManager manager = new ApplicationUserManager(new BFStudioUserStore());

            var user = await manager.FindAsync(model.LoginId,model.Password);

            if (user != null)
            {
                Logging.Logger.Info("[" + model.LoginId + "]がログインしました。");
                var authentication = this.HttpContext.GetOwinContext().Authentication;
                var identify = await manager.CreateIdentityAsync(
                    user,
                    DefaultAuthenticationTypes.ApplicationCookie);
                authentication.SignOut(DefaultAuthenticationTypes.ExternalCookie);
                authentication.SignIn(new AuthenticationProperties() { IsPersistent = false }, identify);

                return RedirectToLocal(returnUrl);
            }
            else
            {
                Logging.Logger.Info("[" + model.LoginId + "]がログインを失敗しました。");
                ModelState.AddModelError("", "ログイン認証に失敗しました。");
            }
            return View("Index",model);
        }


    }
}