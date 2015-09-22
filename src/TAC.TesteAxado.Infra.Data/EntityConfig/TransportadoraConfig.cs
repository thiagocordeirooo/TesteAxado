using System.Data.Entity.ModelConfiguration;
using TAC.TesteAxado.Domain.Entities;

namespace TAC.TesteAxado.Infra.Data.EntityConfig
{
    public class TransportadoraConfig : EntityTypeConfiguration<Transportadora>
    {
        public TransportadoraConfig()
        {
            ToTable("transportadora");

            HasKey(k => k.Id);

            Property(p => p.Nome).IsRequired();
            Property(p => p.Observacao).HasMaxLength(400);
            Property(p => p.DataCadastro).IsRequired();
            Property(p => p.Ativo).IsRequired();
        }
    }
}