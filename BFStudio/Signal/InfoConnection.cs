using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.SignalR;
using System.Diagnostics;
using Newtonsoft.Json;
using BFStudio.Entity;

namespace BFStudio.Signal
{
    public class InfoConnection : PersistentConnection
    {
        protected override Task OnConnected(IRequest request, string connectionId)
        {
            Debug.WriteLine("Info Connected:" + connectionId);
            return Connection.Send(connectionId, "Welcome!");
        }

        protected override Task OnReceived(IRequest request, string connectionId, string data)
        {
            Debug.WriteLine("Info OnReceived:" + connectionId);
            Debug.WriteLine("Info data:" + data);
            var test = JsonConvert.DeserializeObject<DBA_COLUMN>(data);

            return Connection.Broadcast(test);
        }
    }
}