using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TAC.TesteAxado.Presentation.MVC.Startup))]
namespace TAC.TesteAxado.Presentation.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}