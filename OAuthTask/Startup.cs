using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OAuthTask.Startup))]
namespace OAuthTask
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
