using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AssiPart2.Startup))]
namespace AssiPart2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
