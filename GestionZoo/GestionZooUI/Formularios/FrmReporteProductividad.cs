using Business.Services;
using Models.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GestionZooUI.Formularios
{
    public partial class FrmReporteProductividad : Form
    {
        private readonly ReporteService _reporteService;
        private readonly DataTable reportes = new DataTable("Reportes");
        public FrmReporteProductividad()
        {
            InitializeComponent();
            _reporteService = new ReporteService();
            ConfigurarDataGridView();
        }

        public void FrmReporteProductividad_Load()
        {
            GenerarReporte();
        }

        private void ConfigurarDataGridView()
        {
            dgvReporte.AutoGenerateColumns = false;

            dgvReporte.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Nombre",
                HeaderText = "Nombre"
            });

            dgvReporte.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Apellido",
                HeaderText = "Apellido"
            });

            dgvReporte.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Sector",
                HeaderText = "Sector"
            });

            dgvReporte.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TotalTareas",
                HeaderText = "Total de Tareas"
            });

            dgvReporte.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TotalTiempo",
                HeaderText = "Tiempo Total (minutos)"
            });
        }

        private void GenerarReporte()
        {
            List<object> reporte = _reporteService.GenerarReporteGeneral();

            if (reporte != null && reporte.Count > 0) 
            {
                dgvReporte.DataSource = null;
                dgvReporte.DataSource = _reporteService.GenerarReporteGeneral();
            }
            else
            {
                MessageBox.Show("No hay datos para mostrar en el reporte.", "Reporte vacío", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Archivo JSON|*.json",
                Title = "Guardar Reporte de Productividad"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var datos = ObtenerDatosDelDataGridView();
                _reporteService.ExportarReporteJSON(saveFileDialog.FileName, datos);
                _ = MessageBox.Show("Reporte exportado exitosamente.");
            }
        }

        private object ObtenerDatosDelDataGridView()
        {
            var lista = new List<dynamic>();

            foreach (DataGridViewRow fila in dgvReporte.Rows)
            {
                if (!fila.IsNewRow) // Evita incluir la fila vacía al final del DataGridView
                {
                    var objeto = new System.Dynamic.ExpandoObject() as IDictionary<string, Object>;
                    foreach (DataGridViewCell celda in fila.Cells)
                    {
                        string nombreColumna = dgvReporte.Columns[celda.ColumnIndex].HeaderText;
                        objeto[nombreColumna] = celda.Value;
                    }
                    lista.Add(objeto);
                }
            }
            return lista;
        }

        private void FrmReporteProductividad_Load(object sender, EventArgs e)
        {
            _ = reportes.Columns.Add("Nombre", Type.GetType("System.String"));
            _ = reportes.Columns.Add("Apellido", Type.GetType("System.String"));
            _ = reportes.Columns.Add("Sector", Type.GetType("System.String"));
            _ = reportes.Columns.Add("Total Tareas", Type.GetType("System.Int32"));
            _ = reportes.Columns.Add("Tiempo Total (minutos)", Type.GetType("System.Int32"));
            dgvReporte.DataSource = reportes;
        }
    }
}
