using System;
using System.Threading.Tasks;
using Microsoft.AspNet.SignalR;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Singlar_Scaleout.App_Start.Startup))]

namespace Singlar_Scaleout.App_Start
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            GlobalHost.DependencyResolver.UseRedis("127.0.0.1" , 6379, string.Empty, "測試");
            app.MapSignalR();
        }
    }
}
