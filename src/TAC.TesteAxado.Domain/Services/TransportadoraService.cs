using System;
using System.Collections.Generic;
using TAC.TesteAxado.Domain.Entities;
using TAC.TesteAxado.Domain.Interfaces.Repository;
using TAC.TesteAxado.Domain.Interfaces.Service;

namespace TAC.TesteAxado.Domain.Services
{
    public class TransportadoraService : ITransportadoraService
    {
        private readonly ITransportadoraRepository _transportadoraRepository;

        public TransportadoraService(ITransportadoraRepository transportadoraRepository)
        {
            _transportadoraRepository = transportadoraRepository;
        }

        public void Add(Transportadora transportadora)
        {
            _transportadoraRepository.Add(transportadora);
        }

        public Transportadora GetById(Guid id)
        {
            return _transportadoraRepository.GetById(id);
        }

        public IEnumerable<Transportadora> GetAll()
        {
            return _transportadoraRepository.GetAll();
        }

        public void Update(Transportadora transportadora)
        {
            _transportadoraRepository.Update(transportadora);
        }

        public void Remove(Guid id)
        {
            _transportadoraRepository.Remove(_transportadoraRepository.GetById(id));
        }

        public void Dispose()
        {
            _transportadoraRepository.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}