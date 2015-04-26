using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.SignalR;
using System.Threading;
using System.Diagnostics;
using BFStudio.Entity;
using Newtonsoft.Json;
using Microsoft.AspNet.Identity;
using System.Web.Configuration;
using BFStudio.Utility.MVC;

namespace BFStudio.Pages.ChatRoom.Signal
{
    public class ChatConnection : PersistentConnection
    {
        public static string Path
        {
            get
            {
                return "/signal/chat";
            }
        }
        int conId = 0;
        protected override Task OnConnected(IRequest request, string connectionId)
        {
            Interlocked.Increment(ref conId);
            Debug.WriteLine("Echo Connected:" + conId);
            return base.OnConnected(request, connectionId);
            //return Connection.Send(connectionId, "Welcome!");
        }

        protected override Task OnDisconnected(IRequest request, string connectionId,bool stopCalled)
        {
            Interlocked.Decrement(ref conId);
            Debug.WriteLine("Echo Disconnected:" + conId);
            return base.OnDisconnected(request, connectionId,stopCalled);
            //return Connection.Send(connectionId, "Welcome!");
        }

        protected override Task OnReceived(IRequest request, string connectionId, string data)
        {
            var chat = JsonConvert.DeserializeObject<V_CHATMSG>(data);
            
            using (var ent = new DBManageEntities())
            {
                
                var id = request.User.Identity.GetUserId();


                var user = SystemCacheManager.GetUser(id);
                
                var user_id = user.USER_ID;
                var user_nm = user.LOGIN_NM;

                ent.DBA_CHAT.Add(new DBA_CHAT() {
                    ROOM_ID = 0 , SEND_USER_ID = user_id , USER_MSG = chat.USER_MSG });

                //chat.SEND_USER_ID = user_id;
                chat.SEND_USER_NM = user_nm;
                ent.SaveChanges();
            }
            return Connection.Broadcast(chat);
        }
    }
}