using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Diversify.Umbraco.MVC.Startup))]
namespace Diversify.Umbraco.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
