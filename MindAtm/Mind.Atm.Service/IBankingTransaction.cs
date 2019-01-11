using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Mind.Atm.Service
{
    [ServiceContract]
    public interface IBankingTransaction
    {
        [OperationContract]
        void DepositarContaCorrente(string agencia, string conta, decimal valor);
        [OperationContract]
        void SacarContaCorrente(string agencia, string conta, decimal valor);
    }
}
