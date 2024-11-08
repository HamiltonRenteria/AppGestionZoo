using Models.Classes;

namespace Models.Derivadas
{
    public class EmpleadoAves : Empleado
    {
        public EmpleadoAves()
        {
            SectorEmpleado = Enums.Sector.Aves;
        }
    }
}
