using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Entity_Framework_APP.Startup))]
namespace Entity_Framework_APP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
