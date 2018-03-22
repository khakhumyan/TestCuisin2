using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(TestCuisin2Service.Startup))]

namespace TestCuisin2Service
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}