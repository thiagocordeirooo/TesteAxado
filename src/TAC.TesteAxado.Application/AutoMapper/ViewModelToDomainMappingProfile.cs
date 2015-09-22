using AutoMapper;
using TAC.TesteAxado.Application.ViewModels;
using TAC.TesteAxado.Domain.Entities;

namespace TAC.TesteAxado.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<TransportadoraViewModel, Transportadora>();
        }
    }
}