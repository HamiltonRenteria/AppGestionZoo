using Models.Classes;

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
