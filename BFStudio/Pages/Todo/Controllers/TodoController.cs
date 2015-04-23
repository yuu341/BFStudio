using BFStudio.Pages.Todo.Models;
using BFStudio.Utility.MVC;
using System.Web.Mvc;
//using BFStudio.Entity;

namespace BFStudio.Pages.Todo.Controllers
{
    [Authorize]
    public class TodoController : BaseController
    {

        public ActionResult Index()
        {
            TodoModel model = new TodoModel();

            return View(model);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
            }
            base.Dispose(disposing);
        }
    }
}
