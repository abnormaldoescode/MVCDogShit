using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Showroom.Startup))]
namespace Showroom
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
