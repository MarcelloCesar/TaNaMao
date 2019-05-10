namespace TaNaMao.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class V1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        NomePessoa_NomePessoa = c.String(),
                        NomePessoa_SobrenomePessoa = c.String(),
                        Sexo = c.String(),
                        Telefone = c.String(),
                        Endereco = c.String(),
                        Idade = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Produtoes",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        DescricaoProduto_TextoDescricao = c.String(),
                        PrecoProduto_Valor = c.Single(nullable: false),
                        PrecoProduto_Moeda = c.String(),
                        Disponivel = c.Boolean(nullable: false),
                        NomeProduto = c.String(),
                        TipoProduto = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Reservas",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        PeriodoReserva_HorarioInicio = c.DateTime(nullable: false),
                        PeriodoReserva_HorarioFinal = c.DateTime(nullable: false),
                        NumeroMesa = c.Int(nullable: false),
                        DataConfirmacao = c.DateTime(nullable: false),
                        ClienteReserva_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clientes", t => t.ClienteReserva_Id)
                .Index(t => t.ClienteReserva_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reservas", "ClienteReserva_Id", "dbo.Clientes");
            DropIndex("dbo.Reservas", new[] { "ClienteReserva_Id" });
            DropTable("dbo.Reservas");
            DropTable("dbo.Produtoes");
            DropTable("dbo.Clientes");
        }
    }
}
