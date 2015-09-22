using System.Web.Mvc;
using TAC.TesteAxado.Infra.CrossCuting.MvcFilters;

namespace TAC.TesteAxado.Presentation.MVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new GlobalErrorHandler());
            filters.Add(new AuthorizeAttribute());
        }
    }
}