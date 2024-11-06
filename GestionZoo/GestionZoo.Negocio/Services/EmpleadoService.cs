using GestionZoo.Datos.Contexts;
using GestionZoo.Entidad;
using GestionZoo.Entidad.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GestionZoo.Negocio.Services
{
    public class EmpleadoService
    {
        private readonly ZooDbContext _context;

        public EmpleadoService()
        {
            _context = new ZooDbContext();
        }

        public void AgregarEmpleado(Empleado empleado)
        {
            if (_context.Empleados.Any(e => e.NumeroEmpleado == empleado.NumeroEmpleado))
            {
                throw new Exception("El número de empleado ya está registrado.");
            }

            _context.Empleados.Add(empleado);
            _context.SaveChanges();
        }

        public List<Empleado> ObtenerEmpleados()
        {
            try
            {
                var empleadosGenerales = _context.Empleados.ToList();
                
                return empleadosGenerales;
            }
            catch (Exception ex)
            {
                var message = ex.Message;
                throw new Exception(message);
            }
        }
    }
}
