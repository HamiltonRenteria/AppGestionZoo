using GestionZoo.Entidad;
using GestionZoo.Entidad.Entities;
using GestionZoo.Negocio.Services;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AppGestionZoo
{
    public partial class FrmEmpleados : Form
    {
        private readonly EmpleadoService _empleadoService;

        public FrmEmpleados()
        {
            _empleadoService = new EmpleadoService();
            InitializeComponent();
            CargarSector();
            CargarEmpleados();
        }

        private void CargarSector()
        {
            cboSector.DataSource = Enum.GetValues(typeof(Sector));
        }

        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            Empleado nuevoEmpleado;
            Sector sectorSeleccionado = (Sector)cboSector.SelectedItem;

            switch (sectorSeleccionado)
            {
                case Sector.Acuatico:
                    nuevoEmpleado = new EmpleadoAcuatico(
                        txtNombres.Text.Trim(),
                        txtApellidos.Text.Trim(),
                        int.Parse(txtNumeroEmpleado.Text.Trim()),
                        cboSector.SelectedItem.ToString(),
                        int.Parse(txtNumeroSeguroMedico.Text.Trim())
                    );
                    break;
                case Sector.Felinos:
                    nuevoEmpleado = new EmpleadoFelino(
                        txtNombres.Text.Trim(),
                        txtApellidos.Text.Trim(),
                        int.Parse(txtNumeroEmpleado.Text.Trim()),
                        cboSector.SelectedItem.ToString(),
                        int.Parse(txtNumeroSeguroMedico.Text.Trim())
                    );
                    break;
                case Sector.Aves:
                    nuevoEmpleado = new EmpleadoAves(
                        txtNombres.Text.Trim(),
                        txtApellidos.Text.Trim(),
                        int.Parse(txtNumeroEmpleado.Text.Trim()),
                        cboSector.SelectedItem.ToString(),
                        int.Parse(txtNumeroSeguroMedico.Text.Trim())
                    );
                    break;
                default:
                    throw new Exception("Sector no válido.");
            }

            try
            {
                _empleadoService.AgregarEmpleado(nuevoEmpleado);
                _ = MessageBox.Show("Empleado agregado correctamente.");
                CargarEmpleados();
            }
            catch (Exception ex)
            {
                _ = MessageBox.Show("Error: ", ex.Message);
            }
        }

        private void CargarEmpleados()
        {
            var empleados = _empleadoService.ObtenerEmpleados();

            dgvEmpleados.DataSource = empleados;
        }

        private void txtNombres_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!String.IsNullOrEmpty(textBox.Text) && textBox.Text.Trim().Length >= 3)
            {
                string expression = @"[\. ]+([a-z])";
                char[] charArray = textBox.Text.ToCharArray();
                foreach (Match match in Regex.Matches(textBox.Text, expression, RegexOptions.Singleline))
                {
                    charArray[match.Groups[1].Index] = Char.ToUpper(charArray[match.Groups[1].Index]);
                }
                string output = new string(charArray);
                textBox.Text = output;
                //textBox.CaretIndex = textBox.Text.Length;
            }
        }

        private void btnReporteProductividad_Click(object sender, EventArgs e)
        {
            FrmReporteProductividad frmReporteProductividad = new FrmReporteProductividad();
            frmReporteProductividad.ShowDialog();
            this.Hide();
        }
    }
}
