using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace BFStudio.Pages.ChatRoom.Signal
{
    public class ChatHub : Hub
    {
        public void CreateChatRoom()
        {

        }
        /// <summary>
        /// 蹴りだす
        /// </summary>
        /// <param name="id"></param>
        public void Kick(int id)
        {
        }

        /// <summary>
        /// 二度と入ってくるな
        /// </summary>
        /// <param name="id"></param>
        public void Ban(int id)
        {

        }

        /// <summary>
        /// 無視リストに追加する
        /// </summary>
        /// <param name="id"></param>
        public void Ignore(int id)
        {

        }

        /// <summary>
        /// 履歴を取得する
        /// </summary>
        public void GetHistory()
        {

        }
        /// <summary>
        /// チャットに入る
        /// </summary>
        public void Connect()
        {

        }

        /// <summary>
        /// チャットから離席する
        /// </summary>
        public void DisConnect()
        {

        }

        public void Update()
        {

        }
        
        public void Hello()
        {
            Clients.All.hello();
        }
    }
}