using Ninject.Modules;
using TAC.TesteAxado.Domain.Interfaces.Service;
using TAC.TesteAxado.Domain.Services;
using TAC.TesteAxado.Infra.Data.Contexts;
using TAC.TesteAxado.Infra.Data.Interfaces;
using TAC.TesteAxado.Infra.Data.UoW;

namespace TAC.TesteAxado.Infra.CrossCuting.IoC
{
    public class NinjectModulo : NinjectModule
    {
        public override void Load()
        {
            // service
            Bind(typeof(IServiceBase<>)).To(typeof(ServiceBase<>));

            // data configs
            Bind(typeof(IContextManager<>)).To(typeof(ContextManager<>));
            Bind(typeof(IUnitOfWork<>)).To(typeof(UnitOfWork<>));
        }
    }
}