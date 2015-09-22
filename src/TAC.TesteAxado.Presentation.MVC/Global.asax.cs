using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using TAC.TesteAxado.Application.AutoMapper;

namespace TAC.TesteAxado.Presentation.MVC
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            AutoMapperConfig.RegisterMappings();
        }

        protected void Application_EndRequest()
        {
            const string contextKey = "ContextManager.Context";
        }
    }
}