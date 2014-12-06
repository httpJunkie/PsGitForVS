using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RenderLib.Startup))]
namespace RenderLib
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
