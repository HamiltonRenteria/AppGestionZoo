using Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Derivadas
{
    public class EmpleadoAcuatico : Empleado
    {
        public EmpleadoAcuatico()
        {
            SectorEmpleado = Enums.Sector.Acuatico;
        }
    }
}
