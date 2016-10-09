using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DemoDeployment.Startup))]
namespace DemoDeployment
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
