using Business.Services;
using System;
using System.Collections.Generic;
using System.Data;
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

            _ = dgvReporte.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Nombre",
                HeaderText = "Nombre"
            });

            _ = dgvReporte.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Apellido",
                HeaderText = "Apellido"
            });

            _ = dgvReporte.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Sector",
                HeaderText = "Sector"
            });

            _ = dgvReporte.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TotalTareas",
                HeaderText = "Total de Tareas"
            });

            _ = dgvReporte.Columns.Add(new DataGridViewTextBoxColumn
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
                dgvReporte.DataSource = reporte;
            }
            else
            {
                _ = MessageBox.Show("No hay datos para mostrar en el reporte.", "Reporte vacío", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                _reporteService.ExportarReporteJSON(saveFileDialog.FileName);
                _ = MessageBox.Show("Reporte exportado exitosamente.");
            }
        }

        private object ObtenerDatosDelDataGridView()
        {
            List<dynamic> lista = new List<dynamic>();

            foreach (DataGridViewRow fila in dgvReporte.Rows)
            {
                if (!fila.IsNewRow) // Evita incluir la fila vacía al final del DataGridView
                {
                    IDictionary<string, object> objeto = new System.Dynamic.ExpandoObject();
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

        private void button1_Click(object sender, EventArgs e)
        {
            GenerarReporte();
        }
    }
}
