using BFStudio.Pages.ChatRoom.Signal;
using BFStudio.Signal;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BFStudio.Startup))]
namespace BFStudio
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            app.MapSignalR<ChatConnection>(ChatConnection.Path);
            app.MapSignalR<InfoConnection>("/info");
        }
    }
}
