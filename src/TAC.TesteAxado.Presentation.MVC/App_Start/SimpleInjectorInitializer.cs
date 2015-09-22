using Microsoft.Owin;
using SimpleInjector;
using SimpleInjector.Advanced;
using SimpleInjector.Integration.Web;
using SimpleInjector.Integration.Web.Mvc;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using TAC.TesteAxado.Infra.CrossCuting.IoC;


[assembly: WebActivator.PostApplicationStartMethod(typeof(TAC.TesteAxado.Presentation.MVC.SimpleInjectorInitializer), "Initialize")]
namespace TAC.TesteAxado.Presentation.MVC
{
    public static class SimpleInjectorInitializer
    {
        public static void Initialize()
        {
            var container = new SimpleInjector.Container();
            container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();

            // Chamada dos m�dulos do Simple Injector
            InitializeContainer(container);

            // Necess�rio para registrar o ambiente do Owin que � depend�ncia do Identity
            // Feito fora da camada de IoC para n�o levar o System.Web para fora
            container.RegisterPerWebRequest(() =>
            {
                if (HttpContext.Current != null && HttpContext.Current.Items["owin.Environment"] == null && container.IsVerifying())
                {
                    return new OwinContext().Authentication;
                }
                return HttpContext.Current.GetOwinContext().Authentication;

            });

            //container.RegisterMvcControllers(Assembly.GetExecutingAssembly());

            //container.Verify();

            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
        }

        private static void InitializeContainer(SimpleInjector.Container container)
        {
            BootStrapper.RegisterServices(container);
        }
    }
}