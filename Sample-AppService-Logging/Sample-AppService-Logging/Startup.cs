using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sample_AppService_Logging.Startup))]
namespace Sample_AppService_Logging
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
