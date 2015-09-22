using AutoMapper;
using TAC.TesteAxado.Application.ViewModels;
using TAC.TesteAxado.Domain.Entities;

namespace TAC.TesteAxado.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<Transportadora, TransportadoraViewModel>();
        }

    }
}