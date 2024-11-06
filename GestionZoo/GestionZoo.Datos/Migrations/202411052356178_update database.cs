namespace GestionZoo.Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tarea",
                c => new
                    {
                        TareaId = c.Int(nullable: false, identity: true),
                        NombreTarea = c.String(nullable: false),
                        HoraInicio = c.DateTime(nullable: false),
                        HoraFin = c.DateTime(nullable: false),
                        Duracion = c.Time(nullable: false, precision: 7),
                        EmpleadoAsignado_EmpleadoId = c.Int(),
                    })
                .PrimaryKey(t => t.TareaId)
                .ForeignKey("dbo.Empleado", t => t.EmpleadoAsignado_EmpleadoId)
                .Index(t => t.EmpleadoAsignado_EmpleadoId);
            
            AlterColumn("dbo.Empleado", "Nombres", c => c.String(nullable: false));
            AlterColumn("dbo.Empleado", "Apellidos", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tarea", "EmpleadoAsignado_EmpleadoId", "dbo.Empleado");
            DropIndex("dbo.Tarea", new[] { "EmpleadoAsignado_EmpleadoId" });
            AlterColumn("dbo.Empleado", "Apellidos", c => c.String());
            AlterColumn("dbo.Empleado", "Nombres", c => c.String());
            DropTable("dbo.Tarea");
        }
    }
}
