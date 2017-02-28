using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FinalStraw.Startup))]
namespace FinalStraw
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
