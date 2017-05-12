using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Chinookweb.Startup))]
namespace Chinookweb
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
