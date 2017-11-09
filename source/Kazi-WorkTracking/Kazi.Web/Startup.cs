using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Kazi.Web.Startup))]
namespace Kazi.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
