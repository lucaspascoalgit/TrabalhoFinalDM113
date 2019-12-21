using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ServiceModel;
using EstoqueClient2.EstoqueService;

namespace EstoqueClient2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press ENTER when the service has started");
            Console.ReadLine();

            ServicoEstoqueV2Client proxy = new ServicoEstoqueV2Client("WS2007HttpBinding_IServicoEstoque");

            Console.WriteLine("EstoqueClient2");

            Console.WriteLine();
            Console.WriteLine("Estoque do Produto 1");

            int estoque = proxy.ConsultarEstoque("1000");
            Console.WriteLine("Quantidade no estoque: {0}", estoque);

            Console.WriteLine();
            Console.WriteLine("Adicionar Unidade");

            if (proxy.AdicionarEstoque("1000", 20))
            {
                Console.WriteLine("Estoque adicionado");
            }
            else
            {
                Console.WriteLine("Falha ao adicionar estoque");
            }

            Console.WriteLine();
            Console.WriteLine("Estoque do Produto 1");

            estoque = proxy.ConsultarEstoque("1000");
            Console.WriteLine("Quantidade no estoque: {0}", estoque);

            Console.WriteLine();
            Console.WriteLine("Estoque do Produto 5");

            estoque = proxy.ConsultarEstoque("5000");
            Console.WriteLine("Quantidade no estoque: {0}", estoque);

            Console.WriteLine();
            Console.WriteLine("Remove Produto");

            if (proxy.RemoverEstoque("5000", 10))
            {
                Console.WriteLine("Quantidade removida");
            }
            else
            {
                Console.WriteLine("Falha ao decrementar estoque");
            }

            Console.WriteLine();
            Console.WriteLine("Estoque do Produto 5");

            estoque = proxy.ConsultarEstoque("5000");
            Console.WriteLine("Quantidade no estoque: {0}", estoque);

            Console.WriteLine();

            proxy.Close();
            Console.WriteLine("Press ENTER to finish");
            Console.ReadLine();
        }
    }
}
