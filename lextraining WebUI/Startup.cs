using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lextraining_WebUI.Startup))]
namespace lextraining_WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
