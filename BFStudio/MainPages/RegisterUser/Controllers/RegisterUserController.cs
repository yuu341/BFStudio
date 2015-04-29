using BFStudio.Utility.MVC;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace BFStudio.MainPages.RegisterUser.Controllers
{
    [Authorize]
    public class RegisterUserController : BaseController
    {
        //private Entities db = new Entities();

        //// GET: RegisterUser
        //public ActionResult Index()
        //{
        //    return View(db.DBA_USER.ToList());
        //}

        //// GET: RegisterUser/Details/5
        //public ActionResult Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    DBA_USER dBA_USER = db.DBA_USER.Find(id);
        //    if (dBA_USER == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(dBA_USER);
        //}

        // GET: RegisterUser/Createxs

        //[HttpPost]
        //public PartialViewResult Create(CreateUserModel model)
        //{
        //    return PartialView(model);
        //}

        // POST: RegisterUser/Create
        // 過多ポスティング攻撃を防止するには、バインド先とする特定のプロパティを有効にしてください。
        // 詳細については、http://go.microsoft.com/fwlink/?LinkId=317598 を参照してください。
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "ID,LOGIN_ID,PASSWORD,USER_NM")] DBA_USER dBA_USER)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.DBA_USER.Add(dBA_USER);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    return View(dBA_USER);
        //}

        //// GET: RegisterUser/Edit/5
        //public ActionResult Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    DBA_USER dBA_USER = db.DBA_USER.Find(id);
        //    if (dBA_USER == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(dBA_USER);
        //}

        // POST: RegisterUser/Edit/5
        // 過多ポスティング攻撃を防止するには、バインド先とする特定のプロパティを有効にしてください。
        // 詳細については、http://go.microsoft.com/fwlink/?LinkId=317598 を参照してください。
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "ID,LOGIN_ID,PASSWORD,USER_NM")] DBA_USER dBA_USER)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(dBA_USER).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(dBA_USER);
        //}

        //// GET: RegisterUser/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    DBA_USER dBA_USER = db.DBA_USER.Find(id);
        //    if (dBA_USER == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(dBA_USER);
        //}

        //// POST: RegisterUser/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    DBA_USER dBA_USER = db.DBA_USER.Find(id);
        //    db.DBA_USER.Remove(dBA_USER);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        protected override void Dispose(bool disposing)
        {
            //if (disposing)
            //{
            //    db.Dispose();
            //}
            base.Dispose(disposing);
        }
    }
}
