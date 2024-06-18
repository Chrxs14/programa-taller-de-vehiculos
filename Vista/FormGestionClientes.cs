using POE_proyecto.Controlador;
using POE_proyecto.Datos;
using POE_proyecto.Modelo;
using POE_proyecto.Utilidades;

namespace POE_proyecto.Vista
{
    public partial class FormGestionClientes : Form
    {
        private CtlPrincipal CtlPrincipal;
        public FormGestionClientes(CtlPrincipal ctlPrincipal)
        {
            CtlPrincipal = ctlPrincipal;
            InitializeComponent();
            LoadClientes();
            dataGridViewClientes.ReadOnly = true;
        }

        private void FormGestionClientes_Load(object sender, EventArgs e)
        {

        }

        private void LoadClientes()
        {
            dataGridViewClientes.DataSource = CtlPrincipal.CtlCliente.ObtenerClientes();
            dataGridViewClientes.Refresh();
        }

        private void buttonBuscarCliente_Click(object sender, EventArgs e)
        {
            buscarCliente();
        }

        private void buscarCliente()
        {
            string cedulaBuscada = txtSearchByCedula.Text.Trim();

            if (!string.IsNullOrEmpty(cedulaBuscada))
            {
                var clientesFiltrados = CtlPrincipal.CtlCliente.ObtenerClientes()
                    .Where(cliente => cliente.Cedula.Contains(cedulaBuscada))
                    .ToList();

                if (clientesFiltrados.Any())
                {
                    dataGridViewClientes.DataSource = clientesFiltrados;
                }
                else
                {
                    MessageBox.Show("No se encontraron clientes con la cédula especificada.", "Cliente no encontrado");
                }
            }
            else
            {
                LoadClientes();
            }
        }

        private void btnCrearCliente_Click(object sender, EventArgs e)
        {
            var camposInvalidos = ValidarCampos();

            if (camposInvalidos.Count == 0)
            {
                bool clienteAgregado = CtlPrincipal.CtlCliente.AgregarCliente(
                    txtCedula.Text,
                    txtNombres.Text,
                    txtApellidos.Text,
                    txtDireccion.Text,
                    txtCorreo.Text,
                    txtTelefono.Text,
                    dtpFechaNacimiento.Value,
                    txtReferencia.Text
                );

                if (clienteAgregado)
                {
                    MessageBox.Show("Cliente creado correctamente", "Cliente Creado");
                    LoadClientes();
                    resetTextBoxes();
                }
                else
                {
                    MessageBox.Show("No se pudo agregar el cliente, verifica que no se encuentre registrado e intenta nuevamente", "Error");
                }
            }
            else
            {
                foreach (var campo in camposInvalidos)
                {
                    campo.BackColor = Color.Red;
                }
                MessageBox.Show("Por favor llena todos los campos correctamente", "Alerta");
                camposInvalidos.First().Focus();
            }
        }

        private TextBox ValidarCampo(TextBox textBox, Func<string, bool> validar)
        {
            if (string.IsNullOrEmpty(textBox.Text) || !validar(textBox.Text))
            {
                textBox.BackColor = Color.Gray;
                return textBox;
            }
            textBox.BackColor = Color.White;
            return null;
        }

        private List<TextBox> ValidarCampos()
        {
            var camposInvalidos = new List<TextBox>();

            var validaciones = new Dictionary<TextBox, Func<string, bool>>
            {
                { txtCedula, Validador.ValidarCedula },
                { txtNombres, Validador.ValidarNombres },
                { txtApellidos, Validador.ValidarNombres },
                { txtDireccion, Validador.ValidarCadena },
                { txtCorreo, Validador.ValidarCorreo },
                { txtTelefono, Validador.ValidarTelefono },
                { txtReferencia, Validador.ValidarCadena }
            };

            foreach (var campo in validaciones)
            {
                var resultado = ValidarCampo(campo.Key, campo.Value);
                if (resultado != null)
                {
                    camposInvalidos.Add(resultado);
                }
            }

            if (!Validador.ValidarFechaNacimiento(dtpFechaNacimiento.Value))
            {
                dtpFechaNacimiento.CalendarMonthBackground = Color.Gray;
                camposInvalidos.Add(new TextBox { Name = "FechaNacimiento" });
            }
            else
            {
                dtpFechaNacimiento.CalendarMonthBackground = Color.White;
            }

            return camposInvalidos;
        }

        private void dataGridViewClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int celdaSeleccionada = e.RowIndex;
            if (celdaSeleccionada >= 0)
            {
                DataGridViewRow filaSeleccionada = dataGridViewClientes.Rows[celdaSeleccionada];

                txtCedula.Text = filaSeleccionada.Cells["Cedula"].Value.ToString();
                txtNombres.Text = filaSeleccionada.Cells["Nombres"].Value.ToString();
                txtApellidos.Text = filaSeleccionada.Cells["Apellidos"].Value.ToString();
                txtDireccion.Text = filaSeleccionada.Cells["Direccion"].Value.ToString();
                txtCorreo.Text = filaSeleccionada.Cells["Correo"].Value.ToString();
                txtTelefono.Text = filaSeleccionada.Cells["NumeroTelefono"].Value.ToString();
                dtpFechaNacimiento.Value = Convert.ToDateTime(filaSeleccionada.Cells["FechaNacimiento"].Value);
                txtReferencia.Text = filaSeleccionada.Cells["Referencia"].Value.ToString();
            }
        }

        private void resetTextBoxes()
        {
            txtCedula.Text = "";
            txtNombres.Text = "";
            txtApellidos.Text = "";
            txtDireccion.Text = "";
            txtCorreo.Text = "";
            txtTelefono.Text = "";
            dtpFechaNacimiento.Value = DateTime.Now;
            txtReferencia.Text = "";
        }

        private void txtSearchByCedula_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buscarCliente();
                e.SuppressKeyPress = true;
            }
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
