using Microsoft.AspNet.Identity.EntityFramework;
using System;
using TAC.TesteAxado.Infra.CrossCuting.Identity.Model;

namespace TAC.TesteAxado.Infra.CrossCuting.Identity.Context
{
    public class ApplicationUserContext : IdentityDbContext<ApplicationUser>, IDisposable
    {
        public ApplicationUserContext()
            : base("TesteAxadoContext", throwIfV1Schema: false)
        {
        }

        public static ApplicationUserContext Create()
        {
            return new ApplicationUserContext();
        }
    }
}