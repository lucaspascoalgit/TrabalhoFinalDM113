﻿//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EstoqueClient.EstoqueService
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Produto", Namespace="http://schemas.datacontract.org/2004/07/EstoqueService")]
    public partial class Produto : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string descricaoProdutoField;
        
        private int estoqueProdutoField;
        
        private string nomeProdutoField;
        
        private string numeroProdutoField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string descricaoProduto
        {
            get
            {
                return this.descricaoProdutoField;
            }
            set
            {
                this.descricaoProdutoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int estoqueProduto
        {
            get
            {
                return this.estoqueProdutoField;
            }
            set
            {
                this.estoqueProdutoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string nomeProduto
        {
            get
            {
                return this.nomeProdutoField;
            }
            set
            {
                this.nomeProdutoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string numeroProduto
        {
            get
            {
                return this.numeroProdutoField;
            }
            set
            {
                this.numeroProdutoField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://projetoavaliativo.dm113/01", ConfigurationName="EstoqueClient.EstoqueService.IServicoEstoque")]
    public interface IServicoEstoque
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IServicoEstoque/ListarProdutos", ReplyAction="http://projetoavaliativo.dm113/01/IServicoEstoque/ListarProdutosResponse")]
        string[] ListarProdutos();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IServicoEstoque/ListarProdutos", ReplyAction="http://projetoavaliativo.dm113/01/IServicoEstoque/ListarProdutosResponse")]
        System.Threading.Tasks.Task<string[]> ListarProdutosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IServicoEstoque/IncluirProduto", ReplyAction="http://projetoavaliativo.dm113/01/IServicoEstoque/IncluirProdutoResponse")]
        bool IncluirProduto(EstoqueClient.EstoqueService.Produto produto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IServicoEstoque/IncluirProduto", ReplyAction="http://projetoavaliativo.dm113/01/IServicoEstoque/IncluirProdutoResponse")]
        System.Threading.Tasks.Task<bool> IncluirProdutoAsync(EstoqueClient.EstoqueService.Produto produto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IServicoEstoque/RemoverProduto", ReplyAction="http://projetoavaliativo.dm113/01/IServicoEstoque/RemoverProdutoResponse")]
        bool RemoverProduto(string numeroProduto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IServicoEstoque/RemoverProduto", ReplyAction="http://projetoavaliativo.dm113/01/IServicoEstoque/RemoverProdutoResponse")]
        System.Threading.Tasks.Task<bool> RemoverProdutoAsync(string numeroProduto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IServicoEstoque/ConsultarEstoque", ReplyAction="http://projetoavaliativo.dm113/01/IServicoEstoque/ConsultarEstoqueResponse")]
        int ConsultarEstoque(string numeroProduto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IServicoEstoque/ConsultarEstoque", ReplyAction="http://projetoavaliativo.dm113/01/IServicoEstoque/ConsultarEstoqueResponse")]
        System.Threading.Tasks.Task<int> ConsultarEstoqueAsync(string numeroProduto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IServicoEstoque/AdicionarEstoque", ReplyAction="http://projetoavaliativo.dm113/01/IServicoEstoque/AdicionarEstoqueResponse")]
        bool AdicionarEstoque(string numeroProduto, int quantidade);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IServicoEstoque/AdicionarEstoque", ReplyAction="http://projetoavaliativo.dm113/01/IServicoEstoque/AdicionarEstoqueResponse")]
        System.Threading.Tasks.Task<bool> AdicionarEstoqueAsync(string numeroProduto, int quantidade);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IServicoEstoque/RemoverEstoque", ReplyAction="http://projetoavaliativo.dm113/01/IServicoEstoque/RemoverEstoqueResponse")]
        bool RemoverEstoque(string numeroProduto, int quantidade);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IServicoEstoque/RemoverEstoque", ReplyAction="http://projetoavaliativo.dm113/01/IServicoEstoque/RemoverEstoqueResponse")]
        System.Threading.Tasks.Task<bool> RemoverEstoqueAsync(string numeroProduto, int quantidade);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IServicoEstoque/VerProduto", ReplyAction="http://projetoavaliativo.dm113/01/IServicoEstoque/VerProdutoResponse")]
        EstoqueClient.EstoqueService.Produto VerProduto(string numeroProduto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://projetoavaliativo.dm113/01/IServicoEstoque/VerProduto", ReplyAction="http://projetoavaliativo.dm113/01/IServicoEstoque/VerProdutoResponse")]
        System.Threading.Tasks.Task<EstoqueClient.EstoqueService.Produto> VerProdutoAsync(string numeroProduto);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServicoEstoqueChannel : EstoqueClient.EstoqueService.IServicoEstoque, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicoEstoqueClient : System.ServiceModel.ClientBase<EstoqueClient.EstoqueService.IServicoEstoque>, EstoqueClient.EstoqueService.IServicoEstoque
    {
        
        public ServicoEstoqueClient()
        {
        }
        
        public ServicoEstoqueClient(string endpointConfigurationName) : 
                base(endpointConfigurationName)
        {
        }
        
        public ServicoEstoqueClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public ServicoEstoqueClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public ServicoEstoqueClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public string[] ListarProdutos()
        {
            return base.Channel.ListarProdutos();
        }
        
        public System.Threading.Tasks.Task<string[]> ListarProdutosAsync()
        {
            return base.Channel.ListarProdutosAsync();
        }
        
        public bool IncluirProduto(EstoqueClient.EstoqueService.Produto produto)
        {
            return base.Channel.IncluirProduto(produto);
        }
        
        public System.Threading.Tasks.Task<bool> IncluirProdutoAsync(EstoqueClient.EstoqueService.Produto produto)
        {
            return base.Channel.IncluirProdutoAsync(produto);
        }
        
        public bool RemoverProduto(string numeroProduto)
        {
            return base.Channel.RemoverProduto(numeroProduto);
        }
        
        public System.Threading.Tasks.Task<bool> RemoverProdutoAsync(string numeroProduto)
        {
            return base.Channel.RemoverProdutoAsync(numeroProduto);
        }
        
        public int ConsultarEstoque(string numeroProduto)
        {
            return base.Channel.ConsultarEstoque(numeroProduto);
        }
        
        public System.Threading.Tasks.Task<int> ConsultarEstoqueAsync(string numeroProduto)
        {
            return base.Channel.ConsultarEstoqueAsync(numeroProduto);
        }
        
        public bool AdicionarEstoque(string numeroProduto, int quantidade)
        {
            return base.Channel.AdicionarEstoque(numeroProduto, quantidade);
        }
        
        public System.Threading.Tasks.Task<bool> AdicionarEstoqueAsync(string numeroProduto, int quantidade)
        {
            return base.Channel.AdicionarEstoqueAsync(numeroProduto, quantidade);
        }
        
        public bool RemoverEstoque(string numeroProduto, int quantidade)
        {
            return base.Channel.RemoverEstoque(numeroProduto, quantidade);
        }
        
        public System.Threading.Tasks.Task<bool> RemoverEstoqueAsync(string numeroProduto, int quantidade)
        {
            return base.Channel.RemoverEstoqueAsync(numeroProduto, quantidade);
        }
        
        public EstoqueClient.EstoqueService.Produto VerProduto(string numeroProduto)
        {
            return base.Channel.VerProduto(numeroProduto);
        }
        
        public System.Threading.Tasks.Task<EstoqueClient.EstoqueService.Produto> VerProdutoAsync(string numeroProduto)
        {
            return base.Channel.VerProdutoAsync(numeroProduto);
        }
    }
}
