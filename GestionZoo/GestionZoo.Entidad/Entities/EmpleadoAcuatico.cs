using GestionZoo.Entidad.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionZoo.Entidad.Entities
{
    public class EmpleadoAcuatico : Empleado
    {
        public EmpleadoAcuatico() { }
        public EmpleadoAcuatico(string nombres, string apellidos, int numeroEmpleado, string sector, int numeroSeguroMedico) 
            : base(nombres, apellidos, numeroEmpleado, sector, numeroSeguroMedico) { }

        public override void FinalizarTarea(string tarea)
        {
            Console.WriteLine($"{Nombres} {Apellidos} ha finalizado la tarea '{tarea}' en el sector acuático.");
        }

        public override void IniciarTarea(string tarea)
        {
            Console.WriteLine($"{Nombres} {Apellidos} ha iniciado la tarea '{tarea}' en el sector acuático.");
        }
    }
}
