using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace Singlar_Scaleout
{
    public class ServiceHub :Hub
    {

        [HubMethodName("SendMessage")]
        public void SendMessage(string msg) {

            Clients.All.goPage(msg);
        }
    }
}