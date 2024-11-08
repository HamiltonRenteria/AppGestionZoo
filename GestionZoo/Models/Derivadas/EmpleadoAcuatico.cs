using Models.Classes;

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
