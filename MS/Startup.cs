using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MS.Startup))]
namespace MS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
