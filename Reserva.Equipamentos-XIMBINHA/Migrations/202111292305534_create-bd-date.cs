namespace Reserva.Equipamentos_XIMBINHA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createbddate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CadastroEquipamentoModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CadastroUsuarioModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(unicode: false),
                        Login = c.String(unicode: false),
                        Senha = c.String(unicode: false),
                        Perfil = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CadastroUsuarioModels");
            DropTable("dbo.CadastroEquipamentoModels");
        }
    }
}
