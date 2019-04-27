using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RepoApp.Startup))]
namespace RepoApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
