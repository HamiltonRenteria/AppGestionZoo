using GestionZoo.Datos.Contexts;
using GestionZoo.Entidad;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace GestionZoo.Negocio.Services
{
    public class ReporteService
    {
        private readonly ZooDbContext _context;

        public List<dynamic> GenerarReporte()
        {
            return ReporteProductividad.Instance.ObtenerReporte()
                .GroupBy(t => t.EmpleadoAsignado)
                .Select(g => new
                {
                    Nombre = g.Key.Nombres,
                    Apellido = g.Key.Apellidos,
                    TotalTareas = g.Count(),
                    TotalTiempo = g.Sum(t => t.Duracion.TotalMinutes)
                }).ToList<dynamic>();
        }

        public void ExportarReporteJSON(string path)
        {
            var reporte = GenerarReporte();
            string json = JsonConvert.SerializeObject(reporte, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(path, json);
        }
    }
}
