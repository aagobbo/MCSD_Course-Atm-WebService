using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace Mind.Atm.Service.Host
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new ServiceHost(typeof(BankingTransaction), new Uri(@"http://localhost:5050"));
            host.AddServiceEndpoint(typeof(IBankingTransaction), new BasicHttpBinding(), "IBankingTransaction");
            host.Description.Behaviors.Add(new ServiceMetadataBehavior { HttpGetEnabled = true });

            host.Open();

            Console.WriteLine("Listening...");
            Console.ReadLine();
        }
    }
}
