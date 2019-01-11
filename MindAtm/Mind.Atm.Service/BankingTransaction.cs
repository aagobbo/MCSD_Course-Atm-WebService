using Mind.Atm.Aplicacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mind.Atm.Service
{
    public class BankingTransaction : IBankingTransaction
    {
        private readonly IAtm applicationService;

        public BankingTransaction()
        {
            this.applicationService = new AtmService();
        }

        public void DepositarContaCorrente(string agencia, string conta, decimal valor)
        {
            this.applicationService.Depositar(agencia, conta, valor);
        }

        public void SacarContaCorrente(string agencia, string conta, decimal valor)
        {
            this.applicationService.Sacar(agencia, conta, valor);
        }
    }
}
