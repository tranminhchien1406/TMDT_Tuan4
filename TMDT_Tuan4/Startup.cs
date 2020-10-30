using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TMDT_Tuan4.Startup))]
namespace TMDT_Tuan4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
