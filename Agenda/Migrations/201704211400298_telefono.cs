namespace Agenda.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class telefono : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.atributos", "Telefono", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.atributos", "Telefono", c => c.Int(nullable: false));
        }
    }
}
