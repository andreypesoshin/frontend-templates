using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FrontendTemplates.Startup))]
namespace FrontendTemplates
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
