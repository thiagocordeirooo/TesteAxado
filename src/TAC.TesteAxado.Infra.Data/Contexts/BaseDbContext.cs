using System.Data.Entity;
using TAC.TesteAxado.Infra.Data.Interfaces;

namespace TAC.TesteAxado.Infra.Data.Contexts
{
    public class BaseDbContext : DbContext, IDbContext
    {
        public BaseDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {
        }

        public new IDbSet<T> Set<T>() where T : class
        {
            return base.Set<T>();
        }
    }
}