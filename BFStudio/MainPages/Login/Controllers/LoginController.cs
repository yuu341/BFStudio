using BFStudio.MainPages.Login.Models;
using BFStudio.Utility.Manager;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using System.Web;
using System.Web.Mvc;
using BFStudio.Entity;

namespace BFStudio.MainPages.Login.Controllers
{
    public class LoginController : Controller
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
            return View(new MST_USER());
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Authentication(MST_USER model, string returnUrl)
        {
            PasswordHasher hash = new PasswordHasher();
            var result = hash.HashPassword(model.Password_Form);

            if (!ModelState.IsValid)
            {
                return View("Index",model);
            }

            // これは、アカウント ロックアウトの基準となるログイン失敗回数を数えません。
            // パスワード入力失敗回数に基づいてアカウントがロックアウトされるように設定するには、shouldLockout: true に変更してください。
            //var result = await SignInManager.PasswordSignInAsync(model.LoginId, model.Password, model.RememberMe, shouldLockout: false);
            //switch (result)
            //{
            //    case SignInStatus.Success:
            //        return View("Top");
            //    //case SignInStatus.LockedOut:
            //    //    return View("Lockout");
            //    case SignInStatus.RequiresVerification:
            //        return RedirectToAction("SendCode", new { ReturnUrl = returnUrl, RememberMe = model.RememberMe });
            //    case SignInStatus.Failure:
            //    default:
            //        ModelState.AddModelError("", "無効なログイン試行です。");
            //        return View(model);
            //}

            ApplicationUserManager manager = new ApplicationUserManager(new BFStudioUserStore());

            var user = await manager.FindAsync(model.Login_Id_Form,model.Password_Form);

            if (user != null)
            {
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
                ModelState.AddModelError("", "ログイン認証に失敗しました。");
            }
            return View("Index",model);
        }


    }
}