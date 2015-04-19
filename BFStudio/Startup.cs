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
        }
    }
}
