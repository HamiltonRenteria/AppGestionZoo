using Business.Services;
using Models.Classes;
using Models.Derivadas;
using Models.Enums;
using System;
using System.Data;
using System.Windows.Forms;

namespace GestionZooUI.Formularios
{
    public partial class FrmRegistroEmpleados : Form
    {
        private readonly EmpleadoService _empleadoService;
        private readonly TareaService _tareaService;
        private Empleado _empleadoSelecionado;
        private readonly DataTable empleados = new DataTable("Empleados");
        private readonly ErrorProvider _errorProvider;
        private bool _success = false;

        public FrmRegistroEmpleados()
        {
            InitializeComponent();
            _empleadoService = new EmpleadoService();
            _tareaService = new TareaService();
            _errorProvider = new ErrorProvider();
            IniciarComboSectores();
        }

        private void IniciarComboSectores()
        {
            cboSector.DataSource = Enum.GetValues(typeof(Sector));
            cboSector.SelectedIndex = -1;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarEntradas())
            {
                string nombre = char.ToUpper(txtNombre.Text[0]) + txtNombre.Text.Substring(1);
                string apellido = char.ToUpper(txtApellido.Text[0]) + txtApellido.Text.Substring(1);
                int numeroEmpleado = int.Parse(txtNumeroEmpleado.Text);
                Sector sector = (Sector)cboSector.SelectedItem;
                int numeroSeguroMedico = int.Parse(txtNumeroSeguro.Text);

                Empleado empleado = CrearEmpleadoPorSector(nombre, apellido, numeroEmpleado, sector, numeroSeguroMedico);

                if (_empleadoService.AgregarEmpleado(empleado))
                {
                    LimpiarCampos();
                    ActualizarDataGridEmpleados();
                }
                else
                {
                    _ = MessageBox.Show("Error: El empleado ya existe.");
                }
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtNumeroEmpleado.Clear();
            cboSector.SelectedIndex = -1;
            txtNumeroSeguro.Clear();
        }

        private bool ValidarEntradas()
        {
            bool esValido = true;
            _errorProvider.Clear();

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                _errorProvider.SetError(txtNombre, "El nombre es obligatorio.");
                esValido = false;
            }

            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                _errorProvider.SetError(txtApellido, "El apellido es obligatorio.");
                esValido = false;
            }

            if (string.IsNullOrWhiteSpace(txtNumeroEmpleado.Text))
            {
                _errorProvider.SetError(txtNumeroEmpleado, "El número de empleado es obligatorio.");
                esValido = false;
            }
            else if (!int.TryParse(txtNumeroEmpleado.Text, out _))
            {
                _errorProvider.SetError(txtNumeroEmpleado, "El número de empleado debe ser un valor numérico.");
                esValido = false;
            }

            if (cboSector.SelectedIndex == -1)
            {
                _errorProvider.SetError(cboSector, "Debe seleccionar un sector.");
                esValido = false;
            }

            return esValido;
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            FrmReporteProductividad frmReporteProductividad = new FrmReporteProductividad();
            frmReporteProductividad.Show();
            Hide();
        }

        private Empleado CrearEmpleadoPorSector(string nombre, string apellido, int numeroEmpleado, Sector sector, int numeroSeguroMedico)
        {
            Empleado empleado;

            switch (sector)
            {
                case Models.Enums.Sector.Acuatico:
                    empleado = new EmpleadoAcuatico
                    {
                        Nombre = nombre,
                        Apellido = apellido,
                        NumeroEmpleado = numeroEmpleado,
                        NumeroSeguroMedico = numeroSeguroMedico
                    };
                    break;

                case Models.Enums.Sector.Felinos:
                    empleado = new EmpleadoFelino
                    {
                        Nombre = nombre,
                        Apellido = apellido,
                        NumeroEmpleado = numeroEmpleado,
                        NumeroSeguroMedico = numeroSeguroMedico
                    };
                    break;

                case Models.Enums.Sector.Aves:
                    empleado = new EmpleadoAves
                    {
                        Nombre = nombre,
                        Apellido = apellido,
                        NumeroEmpleado = numeroEmpleado,
                        NumeroSeguroMedico = numeroSeguroMedico
                    };
                    break;

                default:
                    empleado = null;
                    break;
            }

            return empleado;
        }

        private void ActualizarDataGridEmpleados()
        {
            dgvEmpleados.DataSource = null;
            dgvEmpleados.Rows.Clear();
            ConfigurarDataGridView();
            dgvEmpleados.DataSource = _empleadoService.ObtenerEmpleados();
        }

        private void ConfigurarDataGridView()
        {
            dgvEmpleados.AutoGenerateColumns = false;

            _ = dgvEmpleados.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Nombre",
                HeaderText = "Nombre"
            });

            _ = dgvEmpleados.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Apellido",
                HeaderText = "Apellido"
            });

            _ = dgvEmpleados.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NumeroEmpleado",
                HeaderText = "N° Empleado"
            });

            _ = dgvEmpleados.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "SectorEmpleado",
                HeaderText = "Sector"
            });

            _ = dgvEmpleados.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NumeroSeguroMedico",
                HeaderText = "N° Seg. Medico"
            });
        }

        private void dgvEmpleados_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEmpleados.SelectedRows.Count > 0)
            {
                _empleadoSelecionado = (Empleado)dgvEmpleados.SelectedRows[0].DataBoundItem;
                HabilitarTareas();
            }
        }

        private void HabilitarTareas()
        {
            if (_empleadoSelecionado.SectorEmpleado == Sector.Acuatico)
            {
                // Acuativo = True
                btnLimpiarEstanque.Enabled = true;
                btnAlimentarPeces.Enabled = true;

                // Felinos = False
                btnLimpiarJaula.Enabled = false;
                btnAlimentarFelinos.Enabled = false;
                btnLiberarFelinos.Enabled = false;
                btnEnjaularFelinos.Enabled = false;

                // Aves = False
                btnLimpiarBebederos.Enabled = false;
                btnLimpiarPasillo.Enabled = false;
            }

            if (_empleadoSelecionado.SectorEmpleado == Sector.Felinos)
            {
                // Acuativo = False
                btnLimpiarEstanque.Enabled = false;
                btnAlimentarPeces.Enabled = false;

                // Felinos = True
                btnLimpiarJaula.Enabled = true;
                btnAlimentarFelinos.Enabled = true;
                btnLiberarFelinos.Enabled = true;
                btnEnjaularFelinos.Enabled = true;

                // Aves = False
                btnLimpiarBebederos.Enabled = false;
                btnLimpiarPasillo.Enabled = false;
            }

            if (_empleadoSelecionado.SectorEmpleado == Sector.Aves)
            {
                // Acuativo = False
                btnLimpiarEstanque.Enabled = false;
                btnAlimentarPeces.Enabled = false;

                // Felinos = False
                btnLimpiarJaula.Enabled = false;
                btnAlimentarFelinos.Enabled = false;
                btnLiberarFelinos.Enabled = false;
                btnEnjaularFelinos.Enabled = false;

                // Aves = False
                btnLimpiarBebederos.Enabled = true;
                btnLimpiarPasillo.Enabled = true;
            }
        }

        private void btnLimpiarEstanque_Click(object sender, EventArgs e)
        {
            if (!_success)
            {
                string nombreTarea = ((ButtonBase)sender).Text;
                IniciarTarea(nombreTarea);
                _success = true;
                return;
            }
            else
            {
                FinalizarTarea();
                return;
            }
        }

        private void btnAlimentarPeces_Click(object sender, EventArgs e)
        {
            if (!_success)
            {
                string nombreTarea = ((ButtonBase)sender).Text;
                IniciarTarea(nombreTarea);
                _success = true;
                return;
            }
            else
            {
                FinalizarTarea();
                return;
            }
        }

        private void btnLimpiarJaula_Click(object sender, EventArgs e)
        {
            if (!_success)
            {
                string nombreTarea = ((ButtonBase)sender).Text;
                IniciarTarea(nombreTarea);
                _success = true;
                return;
            }
            else
            {
                FinalizarTarea();
                return;
            }
        }

        private void btnAlimentarFelinos_Click(object sender, EventArgs e)
        {
            if (!_success)
            {
                string nombreTarea = ((ButtonBase)sender).Text;
                IniciarTarea(nombreTarea);
                _success = true;
                return;
            }
            else
            {
                FinalizarTarea();
                return;
            }
        }

        private void btnLiberarFelinos_Click(object sender, EventArgs e)
        {
            if (!_success)
            {
                string nombreTarea = ((ButtonBase)sender).Text;
                IniciarTarea(nombreTarea);
                _success = true;
                return;
            }
            else
            {
                FinalizarTarea();
                return;
            }
        }

        private void btnEnjaularFelinos_Click(object sender, EventArgs e)
        {
            if (!_success)
            {
                string nombreTarea = ((ButtonBase)sender).Text;
                IniciarTarea(nombreTarea);
                _success = true;
                return;
            }
            else
            {
                FinalizarTarea();
                return;
            }
        }

        private void btnLimpiarBebederos_Click(object sender, EventArgs e)
        {
            if (!_success)
            {
                string nombreTarea = ((ButtonBase)sender).Text;
                IniciarTarea(nombreTarea);
                _success = true;
                return;
            }
            else
            {
                FinalizarTarea();
                return;
            }            
        }

        private void btnLimpiarPasillo_Click(object sender, EventArgs e)
        {
            if (!_success)
            {
                string nombreTarea = ((ButtonBase)sender).Text;
                IniciarTarea(nombreTarea);
                _success = true;
                return;
            }
            else
            {
                FinalizarTarea();
                return;
            }
        }

        private void IniciarTarea(string nombreTarea)
        {
            _tareaService.IniciarTarea(_empleadoSelecionado, nombreTarea);
        }

        private void FinalizarTarea()
        {
            _tareaService.FinalizarTarea(_empleadoSelecionado);
        }

        private void FrmRegistroEmpleados_Load(object sender, EventArgs e)
        {
            _ = empleados.Columns.Add("Nombre", Type.GetType("System.String"));
            _ = empleados.Columns.Add("Apellido", Type.GetType("System.String"));
            _ = empleados.Columns.Add("N° Empleado", Type.GetType("System.Int32"));
            _ = empleados.Columns.Add("Sector", Type.GetType("System.String"));
            _ = empleados.Columns.Add("N° Seg. Medico", Type.GetType("System.Int32"));
            dgvEmpleados.DataSource = empleados;
        }
    }
}
