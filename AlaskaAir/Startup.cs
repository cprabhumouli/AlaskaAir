using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AlaskaAir.Startup))]
namespace AlaskaAir
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
