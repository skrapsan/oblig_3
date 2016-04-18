using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(oblig_3_ASP.Startup))]
namespace oblig_3_ASP
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
