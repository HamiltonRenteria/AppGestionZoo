using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Classes
{
    public class ReporteProductividad
    {
        private static ReporteProductividad _instancia;
        private List<Tarea> _tareasRealizadas;

        private ReporteProductividad()
        {
            _tareasRealizadas = new List<Tarea>();
        }

        public static ReporteProductividad Instancia
        {
            get
            {
                if (_instancia == null)
                    _instancia = new ReporteProductividad();
                return _instancia;
            }
        }

        public void RegistrarTarea(Tarea tarea)
        {
            _tareasRealizadas.Add(tarea);
        }

        public List<object> GenerarReporte()
        {
            return _tareasRealizadas
                .GroupBy(t => new
                {
                    t.EmpleadoAsignado.Nombre,
                    t.EmpleadoAsignado.Apellido,
                    Sector = t.EmpleadoAsignado.SectorEmpleado.ToString()
                })
                .Select(g => new
                {
                    Nombre = g.Key.Nombre,
                    Apellido = g.Key.Apellido,
                    Sector = g.Key.Sector,
                    TotalTareas = g.Count(),
                    TotalTiempo = g.Sum(t => t.Duracion)
                })
                .ToList<object>();
        }

        public int TotalTareasCompletadas()
        {
            return _tareasRealizadas.Count;
        }

        public double TiempoTotalTrabajado()
        {
            return _tareasRealizadas.Sum(t => t.Duracion);
        }
    }
}
