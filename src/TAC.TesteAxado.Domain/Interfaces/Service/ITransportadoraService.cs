using System;
using System.Collections.Generic;
using TAC.TesteAxado.Domain.Entities;

namespace TAC.TesteAxado.Domain.Interfaces.Service
{
    public interface ITransportadoraService : IDisposable
    {
        void Add(Transportadora transportadora);
        Transportadora GetById(Guid id);
        IEnumerable<Transportadora> GetAll();
        void Update(Transportadora transportadora);
        void Remove(Guid id);
    }
}