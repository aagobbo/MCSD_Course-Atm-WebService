using Mind.Atm.Dominio.Entities;
using Mind.Atm.Infra.Configurations;
using System.Data.Entity;

namespace Mind.Atm.Infra
{
    public class DataContext : DbContext
    {
        public DbSet<ContaCorrente> Contas { get; set; }

        public DataContext() : base("name=conn")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new ContaCorrenteConfiguration());
        }
    }
}
