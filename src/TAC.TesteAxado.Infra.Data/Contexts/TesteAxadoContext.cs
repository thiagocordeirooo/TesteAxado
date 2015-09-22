using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using TAC.TesteAxado.Domain.Entities;
using TAC.TesteAxado.Infra.Data.EntityConfig;

namespace TAC.TesteAxado.Infra.Data.Contexts
{
    public class TesteAxadoContext : BaseDbContext
    {
        public TesteAxadoContext()
            : base("TesteAxadoContext")
        {
        }

        public DbSet<Transportadora> Transportadoras { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            /*Configurações gerais do banco de dados*/
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties().Where(p => p.Name == p.ReflectedType.Name + "Id").Configure(p => p.IsKey());
            modelBuilder.Properties<string>().Configure(p => p.HasColumnType("varchar"));
            modelBuilder.Properties<string>().Configure(p => p.HasMaxLength(100));
            
            modelBuilder.Configurations.Add(new TransportadoraConfig());

            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if (entry.State == EntityState.Added)
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;

                if (entry.State == EntityState.Modified)
                    entry.Property("DataCadastro").IsModified = false;
            }

            return base.SaveChanges();
        }
    }
}