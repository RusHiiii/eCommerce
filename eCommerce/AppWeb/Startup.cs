using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AppWeb.Startup))]
namespace AppWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
