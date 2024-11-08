using Models.Enums;
using Models.Interfaces;
using System;

namespace Models.Classes
{
    public abstract class Empleado : ITareas
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int NumeroEmpleado { get; set; }
        public Sector SectorEmpleado { get; set; }
        public int NumeroSeguroMedico { get; set; }

        public DateTime InicioTarea { get; private set; }
        public DateTime FinTarea { get; private set; }
        public string NombreTarea { get; private set; }

        public virtual void IniciarTarea(string nombreTarea)
        {
            NombreTarea = nombreTarea;
            InicioTarea = DateTime.Now;
            Console.WriteLine($"{Nombre} {Apellido} ha iniciado la tarea: {nombreTarea}");
        }

        public virtual void FinalizarTarea()
        {
            FinTarea = DateTime.Now;
            TimeSpan duracion = FinTarea - InicioTarea;
            Console.WriteLine($"{Nombre} {Apellido} ha finalizado la tarea: {NombreTarea}. Duración: {duracion.TotalMinutes} minutos.");
        }
    }
}
