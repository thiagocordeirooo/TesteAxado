using TAC.TesteAxado.Infra.Data.Interfaces;

namespace TAC.TesteAxado.Application.Interfaces
{
    public interface IAppServiceBase<TContext> where TContext : IDbContext
    {
        void BeginTransaction();
        void Commit();
    }
}