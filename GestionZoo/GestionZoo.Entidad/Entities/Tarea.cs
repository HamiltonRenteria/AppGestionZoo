using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionZoo.Entidad.Entities
{
    public class Tarea
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TareaId { get; set; }
        [Required]
        public string NombreTarea { get; set; }
        public DateTime HoraInicio { get; set; }
        public DateTime HoraFin { get; set; }
        public Empleado EmpleadoAsignado { get; set; }
        public TimeSpan Duracion { get; set; }

        public Tarea(string nombreTarea, Empleado empleado)
        {
            NombreTarea = nombreTarea;
            EmpleadoAsignado = empleado;
            HoraInicio = DateTime.Now;
        }

        public void FinalizarTarea()
        {
            HoraFin = DateTime.Now;
            Duracion = HoraFin - HoraInicio;
        }
    }
}
