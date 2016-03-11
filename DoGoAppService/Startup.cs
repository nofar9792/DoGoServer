using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(DoGoAppService.Startup))]

namespace DoGoAppService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}