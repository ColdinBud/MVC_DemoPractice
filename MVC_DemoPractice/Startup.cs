using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_DemoPractice.Startup))]
namespace MVC_DemoPractice
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
