using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace Crtz.SignalRSelfHost.Hubs
{
    [HubName("SuperChatHub")]
    public class ChatHub : Hub
    {
        public string Send(string message)
        {
            return message;
        }

        public void DoSomething(string something)
        {
            Clients.All.AddMessage(something);
        }
    }
}
