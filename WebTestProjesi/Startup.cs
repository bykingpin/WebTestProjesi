using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebTestProjesi.Startup))]
namespace WebTestProjesi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
