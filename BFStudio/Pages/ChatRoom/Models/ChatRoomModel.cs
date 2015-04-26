using BFStudio.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BFStudio.Pages.ChatRoom.Models
{
    public class ChatRoomModel
    {
        DBManageEntities db = new DBManageEntities();

        public ChatRoomModel()
        {
            Initialize();
        }

        private void Initialize()
        {
            using (var ent = new DBManageEntities())
            {
                MessageList = ent.V_CHATMSG.ToList();
            }
        }

        public List<V_CHATMSG> MessageList
        {
            get;
            set;
        }

    }
}