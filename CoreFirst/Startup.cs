using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CoreFirst.Startup))]
namespace CoreFirst
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
