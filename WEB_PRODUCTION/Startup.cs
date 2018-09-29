using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WEB_PRODUCTION.Startup))]
namespace WEB_PRODUCTION
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
