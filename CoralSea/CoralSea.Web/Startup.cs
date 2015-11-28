using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CoralSea.Web.Startup))]
namespace CoralSea.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
