using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCMultiLanguageSite.Startup))]
namespace MVCMultiLanguageSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
