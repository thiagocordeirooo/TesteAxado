using System;
using System.Collections.Generic;
using TAC.TesteAxado.Application.ViewModels;

namespace TAC.TesteAxado.Application.Interfaces
{
    public interface ITransportadoraAppService : IDisposable
    {
        void Add(TransportadoraViewModel transportadoraViewModel);
        TransportadoraViewModel GetById(Guid id);
        IEnumerable<TransportadoraViewModel> GetAll();
        void Update(TransportadoraViewModel transportadoraViewModel);
        void Remove(TransportadoraViewModel transportadoraViewModel);
    }
}