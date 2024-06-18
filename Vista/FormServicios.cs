using POE_proyecto.Controlador;
using POE_proyecto.Modelo;
using POE_proyecto.Utilidades;

namespace POE_proyecto.Vista
{
    public partial class FormServicios : Form
    {
        private CtlPrincipal CtlPrincipal;
        public FormServicios(CtlPrincipal ctlPrincipal)
        {
            CtlPrincipal = ctlPrincipal;
            InitializeComponent();
            CargarServicios();
            dgvServicios.ReadOnly = true;
        }

        private void CargarServicios()
        {
            var servicios = ObtenerServiciosProyectados(CtlPrincipal.CtlServicio.ObtenerServicios());

            dgvServicios.Columns.Clear();
            dgvServicios.AutoGenerateColumns = true;
            dgvServicios.DataSource = servicios;
            dgvServicios.Refresh();
        }

        private List<object> ObtenerServiciosProyectados(List<Servicio> servicios)
        {
            return servicios.Select(s => new
            {
                Codigo = s.Codigo,
                Nombre = s.Nombre,
                Precio = s.Precio,
                Descripcion = s.Descripcion,
                Estado = s.Estado ? "Activo" : "Inactivo"
            }).ToList<object>();
        }

        private void BuscarServicio()
        {
            string nombreBuscado = txtSearchByNombre.Text.Trim().ToLower(); // Convertir a minúsculas
            string codigoBuscadoStr = txtSearchByCodigo.Text.Trim();

            List<Servicio> serviciosFiltrados = new List<Servicio>();

            if (!string.IsNullOrEmpty(nombreBuscado))
            {
                serviciosFiltrados = CtlPrincipal.CtlServicio.ObtenerServicios()
                    .Where(servicio => servicio.Nombre.ToLower().Contains(nombreBuscado)) // Convertir a minúsculas
                    .ToList();
            }
            else if (!string.IsNullOrEmpty(codigoBuscadoStr))
            {
                if (int.TryParse(codigoBuscadoStr, out int codigoBuscado))
                {
                    Servicio servicioEncontrado = CtlPrincipal.CtlServicio.ObtenerServicioById(codigoBuscado);
                    if (servicioEncontrado != null)
                    {
                        serviciosFiltrados.Add(servicioEncontrado);
                    }
                    else
                    {
                        MessageBox.Show("No se encontró ningún servicio con el código especificado.", "Servicio no encontrado");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("El código debe ser un valor numérico válido.", "Error de búsqueda");
                    return;
                }
            }
            else
            {
                CargarServicios();
                return;
            }

            if (serviciosFiltrados.Any())
            {
                dgvServicios.DataSource = ObtenerServiciosProyectados(serviciosFiltrados);
            }
            else
            {
                MessageBox.Show("No se encontraron servicios con el nombre o código especificados.", "Servicio no encontrado");
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarServicio();
        }

        private void txtSearchByCodigo_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void txtSearchByCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BuscarServicio();
                e.SuppressKeyPress = true;
            }
        }

        private void txtSearchByNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BuscarServicio();
                e.SuppressKeyPress = true;
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            var camposInvalidos = ValidarCampos();

            if (camposInvalidos.Count == 0)
            {
                bool servicioAgregado = CtlPrincipal.CtlServicio.AgregarServicio(
                    txtNombre.Text,
                    float.Parse(txtPrecio.Text),
                    txtDescripcion.Text
                );

                if (servicioAgregado)
                {
                    MessageBox.Show("Servicio agregado correctamente.", "Operación exitosa");
                    CargarServicios();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se pudo agregar el servicio.", "Error");
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
                { txtNombre, Validador.ValidarNombres },
                { txtDescripcion, Validador.ValidarCadena }
            };

            foreach (var campo in validaciones)
            {
                var resultado = ValidarCampo(campo.Key, campo.Value);
                if (resultado != null)
                {
                    camposInvalidos.Add(resultado);
                }
            }
            try
            {
                if (!Validador.ValidarPrecio(float.Parse(txtPrecio.Text)))
                {
                    txtPrecio.BackColor = Color.Gray;
                    camposInvalidos.Add(txtPrecio);
                }
                else
                {
                    txtPrecio.BackColor = Color.White;
                }
            }
            catch (Exception)
            {
                txtPrecio.BackColor = Color.Gray;
                camposInvalidos.Add(txtPrecio);
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
            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtDescripcion.Text = "";
        }

        private void dgvServicios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int celdaSeleccionada = e.RowIndex;
            if (celdaSeleccionada >= 0)
            {
                DataGridViewRow filaSeleccionada = dgvServicios.Rows[celdaSeleccionada];

                txtNombre.Text = filaSeleccionada.Cells["Nombre"].Value.ToString();
                txtPrecio.Text = filaSeleccionada.Cells["Precio"].Value.ToString();
                txtDescripcion.Text = filaSeleccionada.Cells["Descripcion"].Value.ToString();
            }

        }
    }
}
