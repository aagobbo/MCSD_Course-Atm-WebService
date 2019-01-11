using Mind.Atm.Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mind.Atm.Infra.Configurations
{
    class ContaCorrenteConfiguration : EntityTypeConfiguration<ContaCorrente>
    {
        public ContaCorrenteConfiguration()
        {
            ToTable("ContaCorrente");

            HasKey(c => c.Id);

            Property(c => c.Agencia).HasColumnName("Agencia");
            Property(c => c.Numero).HasColumnName("Numero");
            Property(c => c.Saldo).HasColumnName("Saldo");
        }
    }
}
