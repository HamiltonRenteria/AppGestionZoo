using Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Derivadas
{
    public class EmpleadoFelino : Empleado
    {
        public EmpleadoFelino()
        {
            SectorEmpleado = Enums.Sector.Felinos;
        }
    }
}
