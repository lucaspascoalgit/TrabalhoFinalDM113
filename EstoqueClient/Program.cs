using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ServiceModel;
using EstoqueClient.EstoqueService;

namespace EstoqueClient
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Press ENTER when the service has started");
            Console.ReadLine();

            ServicoEstoqueClient proxy = new ServicoEstoqueClient("BasicHttpBinding_IServicoEstoque");

            Console.WriteLine("EstoqueClient");
          
            Console.WriteLine();
            Console.WriteLine("Novo produto");

            Produto p = new Produto();
            p.numeroProduto = "11000";
            p.nomeProduto = "Produto 11";
            p.descricaoProduto = "Este é o produto 11";
            p.estoqueProduto = 400;

            if (proxy.IncluirProduto(p))
            {
                Console.WriteLine("Produto adicionado");
            } else
            {
                Console.WriteLine("Falha ao adicionar produto");
            }

            Console.WriteLine();
            Console.WriteLine("Remove Produto");

            if (proxy.RemoverProduto("10000"))
            {
                Console.WriteLine("Produto removido");
            } else
            {
                Console.WriteLine("Falha ao remover produto");
            }

            Console.WriteLine();
            Console.WriteLine("Lista de Produtos");

            List<string> produtos = proxy.ListarProdutos().ToList();
            foreach (string nome in produtos)
            {
                Console.WriteLine(nome);
            }

            Console.WriteLine();
            Console.WriteLine("Produto 2");

            Produto prod = proxy.VerProduto("2000");
            Console.WriteLine("Numero do Produto: {0}", prod.numeroProduto);
            Console.WriteLine("Nome do Produto: {0}", prod.nomeProduto);
            Console.WriteLine("Descrição do Produto: {0}", prod.descricaoProduto);
            Console.WriteLine("Estoque do Produto: {0}", prod.estoqueProduto);

            Console.WriteLine();
            Console.WriteLine("Adicionar Unidade");

            if (proxy.AdicionarEstoque("2000", 10))
            {
                Console.WriteLine("Estoque adicionado");
            } else
            {
                Console.WriteLine("Falha ao adicionar estoque");
            }

            Console.WriteLine();
            Console.WriteLine("Estoque do Produto 2");

            int estoque = proxy.ConsultarEstoque("2000");
            Console.WriteLine("Quantidade no estoque: {0}", estoque);

            Console.WriteLine();
            Console.WriteLine("Estoque do Produto 1");

            estoque = proxy.ConsultarEstoque("1000");
            Console.WriteLine("Quantidde no estoque: {0}", estoque);

            Console.WriteLine("Decrementar Estoque");

            if (proxy.RemoverEstoque("1000", 20))
            {
                Console.WriteLine("Quantidade removida");
            } else
            {
                Console.WriteLine("Falha ao remover quantidade");
            }

            Console.WriteLine();
            Console.WriteLine("Estoque do Produto 1");

            estoque = proxy.ConsultarEstoque("1000");
            Console.WriteLine("Quantidde no estoque: {0}", estoque);

            proxy.Close();
            Console.WriteLine("Press ENTER to finish");
            Console.ReadLine();
        }
    }
}
