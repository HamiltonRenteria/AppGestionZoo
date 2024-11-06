using GestionZoo.Entidad;
using GestionZoo.Entidad.Entities;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace GestionZoo.Datos.Contexts
{
    public class ZooDbContext : DbContext
    {
        public ZooDbContext() : base("name=ZooDbContext") { }

        public DbSet<Empleado> Empleados { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            base.OnModelCreating(modelBuilder);
        }
    }
}
