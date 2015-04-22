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

namespace BFStudio.MainPages.Login.Controllers
{
    [Authorize]
    public class LoginController : BaseController
    {
        private ActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            return RedirectToAction("Index", "Top");
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


        [AllowAnonymous]
        public ActionResult LogOff()
        {
            var authentication = this.HttpContext.GetOwinContext().Authentication;
            authentication.SignOut();

            return RedirectToLocal("/");
            
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