namespace EstoqueEntityModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Criacao_do_Banco : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProdutoEstoques",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        numeroProduto = c.String(),
                        nomeProduto = c.String(),
                        descricaoProduto = c.String(),
                        estoqueProduto = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ProdutoEstoques");
        }
    }
}
