using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FaNgMvcBs1.Startup))]
namespace FaNgMvcBs1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
