using GestionZoo.Datos.Contexts;
using GestionZoo.Entidad;
using GestionZoo.Entidad.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionZoo.Negocio.Services
{
    public  class TareaService
    {
        private readonly ZooDbContext _context;

        public Tarea IniciarTarea(Empleado empleado, string nombreTarea)
        {
            var tarea = new Tarea(nombreTarea, empleado);
            empleado.IniciarTarea(nombreTarea);
            return tarea;
        }

        public void FinalizarTarea(Tarea tarea)
        {
            tarea.FinalizarTarea();
            ReporteProductividad.Instance.AgregarTarea(tarea);
            tarea.EmpleadoAsignado.FinalizarTarea(tarea.NombreTarea);
        }
    }
}
