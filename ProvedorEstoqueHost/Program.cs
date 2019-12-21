using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ServiceModel;
using EstoqueService;

namespace ProvedorEstoqueHost
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost serviceEstoqueHost = new ServiceHost(typeof(EstoqueService.EstoqueService));
            serviceEstoqueHost.Open();
            Console.WriteLine("Service Running");

            Console.ReadLine();
            Console.WriteLine("Service Stopping");
            serviceEstoqueHost.Close();
        }
    }
}
