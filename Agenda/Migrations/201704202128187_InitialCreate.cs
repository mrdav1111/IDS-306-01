namespace Agenda.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.atributos",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Telefono = c.Int(nullable: false),
                        Nombre = c.String(),
                        Fecha = c.DateTime(nullable: false),
                        Correo = c.String(),
                        Direccion = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.atributos");
        }
    }
}
