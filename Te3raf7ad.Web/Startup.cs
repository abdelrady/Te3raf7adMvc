using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Te3raf7ad.Web.Startup))]
namespace Te3raf7ad.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
