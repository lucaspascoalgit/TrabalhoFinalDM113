using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using EstoqueEntityModel;
using System.ServiceModel.Activation;

namespace EstoqueService
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da classe "Service1" no arquivo de código, svc e configuração ao mesmo tempo.
    // OBSERVAÇÃO: Para iniciar o cliente de teste do WCF para testar esse serviço, selecione Service1.svc ou Service1.svc.cs no Gerenciador de Soluções e inicie a depuração.
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class EstoqueService : IServicoEstoque, IServicoEstoqueV2
    {
        public bool AdicionarEstoque(string numeroProduto, int quantidade)
        {
            try
            {
                using (ProvedorEstoque database = new ProvedorEstoque())
                {
                    ProdutoEstoque produto = (from p in database.ProdutoEstoques
                                              where String.Compare(p.numeroProduto, numeroProduto) == 0
                                              select p).First();

                    produto.estoqueProduto = produto.estoqueProduto += quantidade;
                    database.SaveChanges();
                }
            }
            catch
            {
                return false;
            }
            return true;
        }

        public int ConsultarEstoque(string numeroProduto)
        {
            int estoque = 0;

            try
            {
                using (ProvedorEstoque database = new ProvedorEstoque())
                {
                    ProdutoEstoque produto = (from p in database.ProdutoEstoques
                                              where String.Compare(p.numeroProduto, numeroProduto) == 0
                                              select p).First();

                    estoque = produto.estoqueProduto;
                }
            }
            catch
            {
                return estoque;
            }
            return estoque;
        }

        public bool IncluirProduto(Produto produto)
        {
            try
            {
                using (ProvedorEstoque database = new ProvedorEstoque())
                {
                    ProdutoEstoque p = new ProdutoEstoque();
                    p.numeroProduto = produto.numeroProduto;
                    p.nomeProduto = produto.nomeProduto;
                    p.descricaoProduto = produto.descricaoProduto;
                    p.estoqueProduto = produto.estoqueProduto;
                    database.ProdutoEstoques.Add(p);
                    database.SaveChanges();
                }
            }
            catch
            {
                return false;
            }
            return true;
        }

        public List<string> ListarProdutos()
        {
            List<string> listaProdutos = new List<string>();
            try
            {
                using (ProvedorEstoque database = new ProvedorEstoque())
                {
                    List<ProdutoEstoque> produtos = (from p in database.ProdutoEstoques select p).ToList();
                    foreach (ProdutoEstoque p in produtos)
                    {
                        listaProdutos.Add(p.nomeProduto);
                    }
                }
            }
            catch
            {

            }
            return listaProdutos;
        }

        public bool RemoverEstoque(string numeroProduto, int quantidade)
        {
            try
            {
                using (ProvedorEstoque database = new ProvedorEstoque())
                {
                    ProdutoEstoque produto = (from p in database.ProdutoEstoques
                                              where String.Compare(p.numeroProduto, numeroProduto) == 0
                                              select p).First();

                    produto.estoqueProduto = produto.estoqueProduto - quantidade;
                    database.SaveChanges();
                }
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool RemoverProduto(string numeroProduto)
        {
            try
            {
                using (ProvedorEstoque database = new ProvedorEstoque())
                {
                    ProdutoEstoque produto = (from p in database.ProdutoEstoques
                                              where String.Compare(p.numeroProduto, numeroProduto) == 0
                                              select p).First();

                    database.ProdutoEstoques.Remove(produto);
                    database.SaveChanges();
                }
            }
            catch
            {
                return false;
            }
            return true;
        }

        public Produto VerProduto(string numeroProduto)
        {
            Produto prod = null;
            try
            {
                using (ProvedorEstoque database = new ProvedorEstoque())
                {
                    ProdutoEstoque produto = (from p in database.ProdutoEstoques
                                              where String.Compare(p.numeroProduto, numeroProduto) == 0
                                              select p).First();

                    prod = new Produto();
                    prod.numeroProduto = produto.numeroProduto;
                    prod.nomeProduto = produto.nomeProduto;
                    prod.descricaoProduto = produto.descricaoProduto;
                    prod.estoqueProduto = produto.estoqueProduto;
                }
            }
            catch
            {

            }
            return prod;
        }
    }
}
