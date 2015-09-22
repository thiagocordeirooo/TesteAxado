using AutoMapper;
using System;
using System.Collections.Generic;
using TAC.TesteAxado.Application.Interfaces;
using TAC.TesteAxado.Application.ViewModels;
using TAC.TesteAxado.Domain.Entities;
using TAC.TesteAxado.Domain.Interfaces.Service;
using TAC.TesteAxado.Infra.Data.Contexts;

namespace TAC.TesteAxado.Application
{
    public class TransportadoraAppService : AppServiceBase<TesteAxadoContext>, ITransportadoraAppService
    {
        private readonly ITransportadoraService _transportadoraService;

        public TransportadoraAppService(ITransportadoraService transportadoraService)
        {
            _transportadoraService = transportadoraService;
        }

        public void Add(TransportadoraViewModel transportadoraViewModel)
        {
            var transportadora = Mapper.Map<TransportadoraViewModel, Transportadora>(transportadoraViewModel);
            
            BeginTransaction();
            _transportadoraService.Add(transportadora);
            Commit();
        }

        public IEnumerable<TransportadoraViewModel> GetAll()
        {
            return Mapper.Map<IEnumerable<Transportadora>, IEnumerable<TransportadoraViewModel>>(_transportadoraService.GetAll());
        }

        public TransportadoraViewModel GetById(Guid id)
        {
            return Mapper.Map<Transportadora, TransportadoraViewModel>(_transportadoraService.GetById(id));
        }

        public void Remove(TransportadoraViewModel transportadoraViewModel)
        {
            var transportadora = Mapper.Map<TransportadoraViewModel, Transportadora>(transportadoraViewModel);

            BeginTransaction();
            _transportadoraService.Remove(transportadora.Id);
            Commit();
        }

        public void Update(TransportadoraViewModel transportadoraViewModel)
        {
            var transportadora = Mapper.Map<TransportadoraViewModel, Transportadora>(transportadoraViewModel);

            BeginTransaction();
            _transportadoraService.Update(transportadora);
            Commit(); 
        }

        public void Dispose()
        {
            _transportadoraService.Dispose();
        }
    }
}
