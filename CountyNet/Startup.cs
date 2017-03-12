using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CountyNet.Startup))]
namespace CountyNet
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
