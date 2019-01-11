using Mind.Atm.Dominio.Entities;
using Mind.Atm.Infra.Repositories;
using System;

namespace Mind.Atm.Aplicacao
{
    public class AtmService : IAtm
    {
        private readonly IRepository<ContaCorrente> repository;

        public AtmService()
        {
            this.repository = new Repository<ContaCorrente>();
        }

        public void Depositar(string agencia, string numeroConta, decimal valor)
        {
            var conta = this.repository.Get(c => c.Agencia == agencia && c.Numero == numeroConta);
            if (conta == null)
                throw new Exception("Conta inválida");
            conta.Depositar(valor);

            this.repository.Save(conta);
        }

        public void Sacar(string agencia, string numeroConta, decimal valor)
        {
            var conta = this.repository.Get(c => c.Agencia == agencia && c.Numero == numeroConta);
            if (conta == null)
                throw new Exception("Conta inválida");
            conta.Sacar(valor);

            this.repository.Save(conta);
        }
    }
}
