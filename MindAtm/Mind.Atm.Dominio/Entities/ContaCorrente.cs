using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mind.Atm.Dominio.Entities
{
    public class ContaCorrente
    {
        public int Id { get; set; }
        public string Agencia { get; set; }
        public string Numero { get; set; }
        public decimal Saldo { get; set; }

        public void Depositar(decimal valor)
        {
            this.Saldo += valor;
        }
        public void Sacar(decimal valor)
        {
            this.Saldo -= valor;
        }
    }
}
