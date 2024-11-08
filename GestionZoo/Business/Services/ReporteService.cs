using Models.Classes;
using System;
using System.Collections.Generic;
using System.Text.Json;

namespace Business.Services
{
    public class ReporteService
    {
        private readonly ReporteProductividad _reporteProductividad;

        public ReporteService()
        {
            _reporteProductividad = ReporteProductividad.Instancia;
        }

        public List<object> GenerarReporteGeneral()
        {
            return _reporteProductividad.GenerarReporte();
        }

        public double ObtenerTiempoTotalTrabajado()
        {
            return _reporteProductividad.TiempoTotalTrabajado();
        }

        public int ObtenerTotalTareasCompletadas()
        {
            return _reporteProductividad.TotalTareasCompletadas();
        }

        public void ExportarReporteJSON(string rutaArchivo)
        {
            var tareasAgrupadas = GenerarReporteGeneral();
            string jsonData = JsonSerializer.Serialize(tareasAgrupadas, new JsonSerializerOptions { WriteIndented = true });
            System.IO.File.WriteAllText(rutaArchivo, jsonData);
            Console.WriteLine($"Reporte exportado exitosamente en {rutaArchivo}");
        }
    }
}
