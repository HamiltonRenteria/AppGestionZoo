using GestionZoo.Entidad.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionZoo.Entidad.Entities
{
    public class EmpleadoAves : Empleado
    {
        public EmpleadoAves() { }
        public EmpleadoAves(string nombres, string apellidos, int numeroEmpleado, string sector, int numeroSeguroMedico) 
            : base(nombres, apellidos, numeroEmpleado, sector, numeroSeguroMedico) { }

        public override void FinalizarTarea(string tarea)
        {
            throw new NotImplementedException();
        }

        public override void IniciarTarea(string tarea)
        {
            throw new NotImplementedException();
        }
    }
}
