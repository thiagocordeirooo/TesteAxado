using System.Data.Entity.Migrations;
using TAC.TesteAxado.Infra.Data.Contexts;

namespace TAC.TesteAxado.Infra.Data.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<TesteAxadoContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(TAC.TesteAxado.Infra.Data.Contexts.TesteAxadoContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}