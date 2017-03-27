using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AGRS1.Startup))]
namespace AGRS1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
