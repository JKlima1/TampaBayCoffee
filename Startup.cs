using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TampaBayCoffee.Startup))]
namespace TampaBayCoffee
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
