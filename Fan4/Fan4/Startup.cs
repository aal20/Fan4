using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Fan4.Startup))]
namespace Fan4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
