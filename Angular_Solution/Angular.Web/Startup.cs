using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Angular.Web.Startup))]
namespace Angular.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
