using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hui.Startup))]
namespace Hui
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
