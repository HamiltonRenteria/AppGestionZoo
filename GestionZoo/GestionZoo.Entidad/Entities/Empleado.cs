using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionZoo.Entidad.Entities
{
    public abstract class Empleado
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmpleadoId { get; set; }
        [Required]
        public string Nombres { get; set; }
        [Required]
        public string Apellidos { get; set; }
        [Required]
        public int NumeroEmpleado { get; set; }
        public string Sector { get; set; }
        public int NumeroSeguroMedico { get; set; }

        public virtual ICollection<Tarea> Tareas { get; set; }

        protected Empleado() { }

        public Empleado(string nombres, string apellidos, int numeroEmpleado, string sector, int numeroSeguroMedico)
        {
            Nombres = nombres;
            Apellidos = apellidos;
            NumeroEmpleado = numeroEmpleado;
            Sector = sector;
            NumeroSeguroMedico = numeroSeguroMedico;
            Tareas = new List<Tarea>();
        }

        public abstract void IniciarTarea(string tarea);
        public abstract void FinalizarTarea(string tarea);
    }
}
