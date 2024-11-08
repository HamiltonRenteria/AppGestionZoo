using Models.Classes;
using System;
using System.Collections.Generic;

namespace Business.Services
{
    public class TareaService
    {
        private readonly List<Tarea> _tareas;
        private readonly ReporteProductividad _reporteProductividad;

        public TareaService()
        {
            _tareas = new List<Tarea>();
            _reporteProductividad = ReporteProductividad.Instancia;
        }

        public void IniciarTarea(Empleado empleado, string nombreTarea)
        {
            empleado.IniciarTarea(nombreTarea);
            Console.WriteLine($"Tarea '{nombreTarea}' iniciada por {empleado.Nombre} {empleado.Apellido} en sector {empleado.SectorEmpleado}.");
        }

        public void FinalizarTarea(Empleado empleado)
        {
            empleado.FinalizarTarea();
            TimeSpan duracion = DateTime.Now - empleado.InicioTarea;

            Tarea tarea = new Tarea(empleado.NombreTarea, duracion.TotalMinutes, empleado);
            _tareas.Add(tarea);
            _reporteProductividad.RegistrarTarea(tarea);

            Console.WriteLine($"Tarea '{empleado.NombreTarea}' finalizada por {empleado.Nombre} {empleado.Apellido}. Duración: {duracion.TotalMinutes} minutos.");
        }

        public List<Tarea> ObtenerTareasCompletadas()
        {
            return _tareas;
        }
    }
}
