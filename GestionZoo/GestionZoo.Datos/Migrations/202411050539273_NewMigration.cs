namespace GestionZoo.Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Empleado", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Empleado", "Sector", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Empleado", "Sector", c => c.Int(nullable: false));
            DropColumn("dbo.Empleado", "Discriminator");
        }
    }
}
