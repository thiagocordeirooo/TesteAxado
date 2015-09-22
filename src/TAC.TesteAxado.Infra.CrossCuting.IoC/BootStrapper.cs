using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using SimpleInjector;
using TAC.TesteAxado.Application;
using TAC.TesteAxado.Application.Interfaces;
using TAC.TesteAxado.Domain.Interfaces.Repository;
using TAC.TesteAxado.Domain.Interfaces.Service;
using TAC.TesteAxado.Domain.Services;
using TAC.TesteAxado.Infra.CrossCuting.Identity.Configuration;
using TAC.TesteAxado.Infra.CrossCuting.Identity.Context;
using TAC.TesteAxado.Infra.CrossCuting.Identity.Model;
using TAC.TesteAxado.Infra.Data.Contexts;
using TAC.TesteAxado.Infra.Data.Interfaces;
using TAC.TesteAxado.Infra.Data.Repository;

namespace TAC.TesteAxado.Infra.CrossCuting.IoC
{
    public class BootStrapper
    {
        public static void RegisterServices(SimpleInjector.Container container)
        {
            container.Register<ApplicationUserContext>(Lifestyle.Scoped);
            container.RegisterPerWebRequest<IUserStore<ApplicationUser>>(() => new UserStore<ApplicationUser>(new ApplicationUserContext()));

            container.Register<ApplicationUserManager>(Lifestyle.Scoped);
            container.Register<ApplicationSignInManager>(Lifestyle.Scoped);

            container.Register<ITransportadoraAppService, TransportadoraAppService>();
            container.Register<ITransportadoraService, TransportadoraService>();
            container.Register<ITransportadoraRepository, TransportadoraRepository>();

            container.Register<IDbContext, TesteAxadoContext>();
        }
    }
}