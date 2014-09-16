using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CanvasApp.Startup))]
namespace CanvasApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
