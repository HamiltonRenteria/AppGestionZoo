using GestionZoo.Negocio.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppGestionZoo
{
    public partial class FrmReporteProductividad : Form
    {
        private readonly ReporteService _reporteService;

        public FrmReporteProductividad()
        {
            _reporteService = new ReporteService();
            InitializeComponent();
            CargarReporte();
        }

        private void CargarReporte()
        {
            var reporte = _reporteService.GenerarReporte();
            gbvReporteProductividad.DataSource = reporte;
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog
            {
                Filter = "JSON Files (*.json)|*.json",
                Title = "Exportar reporte a JSON"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                _reporteService.ExportarReporteJSON(saveFileDialog.FileName);
                MessageBox.Show("Reporte exportado a JSON exitosamente.");
            }
        }
    }
}
