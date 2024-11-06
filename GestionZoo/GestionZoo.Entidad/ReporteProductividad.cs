using GestionZoo.Entidad.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionZoo.Entidad
{
    public class ReporteProductividad
    {
        //private static ReporteProductividad _instance;
        private List<Tarea> _tareas = new List<Tarea>();
        private ReporteProductividad() { }
        private static readonly Lazy<ReporteProductividad> _instance = new Lazy<ReporteProductividad>(() => new ReporteProductividad());
        public static ReporteProductividad Instance => _instance.Value;

        public void AgregarTarea(Tarea tarea)
        {
            _tareas.Add(tarea);
        }

        public List<Tarea> ObtenerReporte()
        {
            return _tareas;
        }
    }
}
