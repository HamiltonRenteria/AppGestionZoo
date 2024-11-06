namespace GestionZoo.Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Empleado",
                c => new
                    {
                        EmpleadoId = c.Int(nullable: false, identity: true),
                        Nombres = c.String(),
                        Apellidos = c.String(),
                        NumeroEmpleado = c.Int(nullable: false),
                        Sector = c.Int(nullable: false),
                        NumeroSeguroMedico = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EmpleadoId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Empleado");
        }
    }
}
