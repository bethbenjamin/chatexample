using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ChatterEx.Startup))]
namespace ChatterEx
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
