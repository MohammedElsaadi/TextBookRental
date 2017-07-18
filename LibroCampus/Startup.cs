using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LibroCampus.Startup))]
namespace LibroCampus
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
