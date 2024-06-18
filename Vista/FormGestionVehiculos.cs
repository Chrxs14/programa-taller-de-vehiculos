using POE_proyecto.Controlador;
using System.Data;
using POE_proyecto.Modelo;
using POE_proyecto.Utilidades;


namespace POE_proyecto.Vista
{
    public partial class FormGestionVehiculos : Form
    {
        private CtlPrincipal CtlPrincipal;
        public FormGestionVehiculos(CtlPrincipal ctlPrincipal)
        {
            CtlPrincipal = ctlPrincipal;
            InitializeComponent();
            CargarVehiculos();
            dgvVehiculos.ReadOnly = true;
        }

        private void CargarVehiculos()
        {
            var vehiculos = ObtenerVehiculosProyectados(CtlPrincipal.CtlVehiculo.ObtenerVehiculos());

            dgvVehiculos.Columns.Clear();
            dgvVehiculos.AutoGenerateColumns = true;
            dgvVehiculos.DataSource = vehiculos;
            dgvVehiculos.Refresh();
        }

        private List<object> ObtenerVehiculosProyectados(List<Vehiculo> vehiculos)
        {
            return vehiculos.Select(v => new
            {
                Placa = v.Placa,
                Marca = v.Marca,
                Modelo = v.Modelo,
                Anio = v.Anio,
                Kilometraje = v.Kilometraje,
                Estado = v.Estado ? "Activo" : "Inactivo"
            }).ToList<object>();
        }

        private void BuscarVehiculo()
        {
            string placaBuscada = txtSearchByPlaca.Text.Trim().ToLower();
            string marcaBuscada = txtSearchByMarca.Text.Trim().ToLower();

            List<Vehiculo> vehiculosFiltrados = new List<Vehiculo>();

            if (!string.IsNullOrEmpty(placaBuscada))
            {
                vehiculosFiltrados = CtlPrincipal.CtlVehiculo.ObtenerVehiculos()
                    .Where(vehiculo => vehiculo.Placa.ToLower().Contains(placaBuscada))
                    .ToList();
            }
            else if (!string.IsNullOrEmpty(marcaBuscada))
            {
                vehiculosFiltrados = CtlPrincipal.CtlVehiculo.ObtenerVehiculos()
                    .Where(vehiculo => vehiculo.Marca.ToLower().Contains(marcaBuscada))
                    .ToList();
            }
            else
            {
                CargarVehiculos();
                return;
            }

            dgvVehiculos.DataSource = vehiculosFiltrados.Select(v => new
            {
                Placa = v.Placa,
                Marca = v.Marca,
                Modelo = v.Modelo,
                Anio = v.Anio,
                Kilometraje = v.Kilometraje,
                Estado = v.Estado ? "Activo" : "Inactivo"
            }).ToList<object>();

            if (vehiculosFiltrados.Any())
            {
                dgvVehiculos.DataSource = ObtenerVehiculosProyectados(vehiculosFiltrados);
            }
            else
            {
                MessageBox.Show("No se encontraron vehículos con la placa o marca especificadas.", "Vehículo no encontrado");
            }
        }


        private void FormGestionVehiculos_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarVehiculo();
        }

        private void txtSearchByPlaca_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BuscarVehiculo();
                e.SuppressKeyPress = true;
            }
        }

        private void txtSearchByMarca_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BuscarVehiculo();
                e.SuppressKeyPress = true;
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            var camposInvalidos = ValidarCampos();

            if (camposInvalidos.Count == 0)
            {
                bool vehiculoAgregado = CtlPrincipal.CtlVehiculo.AgregarVehiculo(
                    txtPlaca.Text,
                    txtMarca.Text,
                    txtModelo.Text,
                    txtAnio.Text,
                    txtKilometraje.Text
                );

                if (vehiculoAgregado)
                {
                    MessageBox.Show("Vehículo agregado correctamente.", "Operación exitosa");
                    CargarVehiculos();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se pudo agregar el vehículo.", "Error");
                }
            }
            else
            {
                foreach (var campo in camposInvalidos)
                {
                    campo.BackColor = Color.Red;
                }
                MessageBox.Show("Por favor llena todos los campos correctamente.", "Alerta");
                camposInvalidos.First().Focus();
            }
        }

        private List<TextBox> ValidarCampos()
        {
            var camposInvalidos = new List<TextBox>();

            var validaciones = new Dictionary<TextBox, Func<string, bool>>
    {
        { txtPlaca, Validador.ValidarPlaca },
        { txtMarca, Validador.ValidarCadena },
        { txtModelo, Validador.ValidarCadena }
    };

            foreach (var campo in validaciones)
            {
                var resultado = ValidarCampo(campo.Key, campo.Value);
                if (resultado != null)
                {
                    camposInvalidos.Add(resultado);
                }
            }

            if (!Validador.ValidarAnio(txtAnio.Text))
            {
                txtAnio.BackColor = Color.Gray;
                camposInvalidos.Add(txtAnio);
            }
            else
            {
                txtAnio.BackColor = Color.White;
            }

            if (!Validador.ValidarKilometraje(txtKilometraje.Text))
            {
                txtKilometraje.BackColor = Color.Gray;
                camposInvalidos.Add(txtKilometraje);
            }
            else
            {
                txtKilometraje.BackColor = Color.White;
            }

            return camposInvalidos;
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

        private void LimpiarCampos()
        {
            txtPlaca.Text = "";
            txtMarca.Text = "";
            txtModelo.Text = "";
            txtAnio.Text = "";
            txtKilometraje.Text = "";
        }

        private void dgvVehiculos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvVehiculos.Rows[e.RowIndex];
                string placa = row.Cells["Placa"].Value.ToString();
                Vehiculo vehiculo = CtlPrincipal.CtlVehiculo.ObtenerVehiculoByPlaca(placa);

                txtPlaca.Text = vehiculo.Placa;
                txtMarca.Text = vehiculo.Marca;
                txtModelo.Text = vehiculo.Modelo;
                txtAnio.Text = vehiculo.Anio;
                txtKilometraje.Text = vehiculo.Kilometraje;
            }
        }
    }
}
