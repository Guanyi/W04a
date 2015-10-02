using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(W04a.Startup))]
namespace W04a
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
