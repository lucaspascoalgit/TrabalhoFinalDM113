using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace EstoqueService
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da interface "IService1" no arquivo de código e configuração ao mesmo tempo.
    [ServiceContract(Namespace = "http://projetoavaliativo.dm113/01", Name = "IServicoEstoque")]
    public interface IServicoEstoque
    {

        [OperationContract]
        List<string> ListarProdutos();

        [OperationContract]
        bool IncluirProduto(Produto produto);

        [OperationContract]
        bool RemoverProduto(string numeroProduto);

        [OperationContract]
        int ConsultarEstoque(string numeroProduto);

        [OperationContract]
        bool AdicionarEstoque(string numeroProduto, int quantidade);

        [OperationContract]
        bool RemoverEstoque(string numeroProduto, int quantidade);

        [OperationContract]
        Produto VerProduto(string numeroProduto);
    }

    [ServiceContract(Namespace = "http://projetoavaliativo.dm113/02", Name = "IServicoEstoqueV2")]
    public interface IServicoEstoqueV2
    {
        [OperationContract]
        bool AdicionarEstoque(string numeroProduto, int quantidade);

        [OperationContract]
        bool RemoverEstoque(string numeroProduto, int quantidade);

        [OperationContract]
        int ConsultarEstoque(string numeroProduto);
    }

    // Use um contrato de dados como ilustrado no exemplo abaixo para adicionar tipos compostos a operações de serviço.
    [DataContract]
    public class Produto
    {
        [DataMember]
        public string numeroProduto;

        [DataMember]
        public string nomeProduto;

        [DataMember]
        public string descricaoProduto;

        [DataMember]
        public int estoqueProduto;
    }
}
