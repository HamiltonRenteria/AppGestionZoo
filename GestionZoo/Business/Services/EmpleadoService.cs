using Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Business.Services
{
    public class EmpleadoService
    {
        private readonly List<Empleado> _empleados;

        public EmpleadoService()
        {
            _empleados = new List<Empleado>();
        }

        public bool AgregarEmpleado(Empleado empleado)
        {
            if (_empleados.Any(e => e.NumeroEmpleado == empleado.NumeroEmpleado))
            {
                Console.WriteLine("Error: Ya existe un empleado con el mismo número de empleado.");
                return false;
            }

            _empleados.Add(empleado);
            Console.WriteLine($"Empleado {empleado.Nombre} {empleado.Apellido} agregado con éxito.");
            return true;
        }

        public bool EliminarEmpleado(int numeroEmpleado)
        {
            Empleado empleado = _empleados.FirstOrDefault(e => e.NumeroEmpleado == numeroEmpleado);
            if (empleado == null)
            {
                Console.WriteLine("Error: No se encontró el empleado para eliminar.");
                return false;
            }

            _ = _empleados.Remove(empleado);
            Console.WriteLine($"Empleado {empleado.Nombre} {empleado.Apellido} eliminado con éxito.");
            return true;
        }

        public Empleado ObtenerEmpleado(int numeroEmpleado)
        {
            return _empleados.FirstOrDefault(e => e.NumeroEmpleado == numeroEmpleado);
        }

        public List<Empleado> ObtenerEmpleados()
        {
            return _empleados;
        }
    }
}
