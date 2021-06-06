using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SGMSS430.Startup))]
namespace SGMSS430
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
