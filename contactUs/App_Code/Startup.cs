using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(contactUs.Startup))]
namespace contactUs
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
