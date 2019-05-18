namespace TaNaMao.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Reservas", "ClienteReserva_Id", "dbo.Clientes");
            DropIndex("dbo.Reservas", new[] { "ClienteReserva_Id" });
            AlterColumn("dbo.Produtoes", "DescricaoProduto_TextoDescricao", c => c.String(nullable: false));
            AlterColumn("dbo.Produtoes", "NomeProduto", c => c.String(nullable: false, maxLength: 11, fixedLength: true));
            AlterColumn("dbo.Reservas", "ClienteReserva_Id", c => c.Guid(nullable: false));
            CreateIndex("dbo.Reservas", "ClienteReserva_Id");
            AddForeignKey("dbo.Reservas", "ClienteReserva_Id", "dbo.Clientes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reservas", "ClienteReserva_Id", "dbo.Clientes");
            DropIndex("dbo.Reservas", new[] { "ClienteReserva_Id" });
            AlterColumn("dbo.Reservas", "ClienteReserva_Id", c => c.Guid());
            AlterColumn("dbo.Produtoes", "NomeProduto", c => c.String());
            AlterColumn("dbo.Produtoes", "DescricaoProduto_TextoDescricao", c => c.String());
            CreateIndex("dbo.Reservas", "ClienteReserva_Id");
            AddForeignKey("dbo.Reservas", "ClienteReserva_Id", "dbo.Clientes", "Id");
        }
    }
}
