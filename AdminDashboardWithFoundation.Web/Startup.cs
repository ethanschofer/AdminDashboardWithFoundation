using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AdminDashboardWithFoundation.Web.Startup))]
namespace AdminDashboardWithFoundation.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
