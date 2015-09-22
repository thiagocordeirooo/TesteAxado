using TAC.TesteAxado.Domain.Entities;
using TAC.TesteAxado.Domain.Interfaces.Repository;
using TAC.TesteAxado.Infra.Data.Contexts;

namespace TAC.TesteAxado.Infra.Data.Repository
{
    public class TransportadoraRepository : RepositoryBase<Transportadora, TesteAxadoContext>, ITransportadoraRepository
    {
    }
}
