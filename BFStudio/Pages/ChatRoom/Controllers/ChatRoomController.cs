using BFStudio.Pages.ChatRoom.Models;
using BFStudio.Utility.MVC;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace BFStudio.Pages.ChatRoom.Controllers
{
    public class ChatRoomController : BaseController
    {

        public ActionResult Index()
        {
            ChatRoomModel model = new ChatRoomModel();

            return PartialView(model);
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
