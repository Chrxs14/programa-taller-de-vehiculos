using POE_proyecto.Controlador;
using POE_proyecto.Modelo;
using POE_proyecto.Utilidades;
using System.Data;

namespace POE_proyecto.Vista
{
    public partial class FormGestionMantenimientos : Form
    {
        private CtlPrincipal CtlPrincipal;

        public FormGestionMantenimientos(CtlPrincipal ctlPrincipal)
        {
            CtlPrincipal = ctlPrincipal;
            InitializeComponent();
            dgvMantenimientos.ReadOnly = true;
            ConfigurarComboBox();
            LoadMantenimientos();
            LoadData();
            InitClbServicios();
        }

        private void InitClbServicios()
        {
            clbServicios.Items.Clear();
            foreach (Servicio servicio in CtlPrincipal.CtlServicio.ObtenerServicios())
            {
                clbServicios.Items.Add(servicio.Codigo + " / " + servicio.Nombre);
            }
        }

        private void ConfigurarComboBox()
        {
            cmbCliente.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbCliente.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbMecanico.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbMecanico.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbVehiculo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbVehiculo.AutoCompleteSource = AutoCompleteSource.ListItems;

            cmbCliente.Click += (sender, e) => cmbCliente.DroppedDown = true;
            cmbMecanico.Click += (sender, e) => cmbMecanico.DroppedDown = true;
            cmbVehiculo.Click += (sender, e) => cmbVehiculo.DroppedDown = true;
        }
        private void LoadData()
        {
            cmbCliente.Items.Clear();
            cmbMecanico.Items.Clear();
            cmbVehiculo.Items.Clear();

            foreach (Cliente cliente in CtlPrincipal.CtlCliente.ObtenerClientes())
            {
                string clienteString = $"{cliente.Cedula} / {cliente.Nombres} {cliente.Apellidos}";
                cmbCliente.Items.Add(clienteString);
            }

            foreach (Mecanico mecanico in CtlPrincipal.CtlMecanico.ObtenerMecanicos())
            {
                string mecanicoString = $"{mecanico.Cedula} / {mecanico.Nombres} {mecanico.Apellidos}";
                cmbMecanico.Items.Add(mecanicoString);
            }

            foreach (Vehiculo vehiculo in CtlPrincipal.CtlVehiculo.ObtenerVehiculos())
            {
                string vehiculoString = $"{vehiculo.Placa} / {vehiculo.Marca} {vehiculo.Modelo}";
                cmbVehiculo.Items.Add(vehiculoString);
            }
        }
        private void LoadMantenimientos() 
        {
            var mantenimientos = ObtenerMantenimientosProyectados(CtlPrincipal.CtlMantenimiento.ObtenerMantenimientos());

            dgvMantenimientos.Columns.Clear();
            dgvMantenimientos.AutoGenerateColumns = true;
            dgvMantenimientos.DataSource = mantenimientos;
            dgvMantenimientos.Refresh();
        }


        private void buscarMantenimiento()
        {
            string codigoBuscado = txtBuscar.Text.ToUpper();

            if (!string.IsNullOrEmpty(codigoBuscado))
            {
                var mantenimientosFiltrados = CtlPrincipal.CtlMantenimiento.ObtenerMantenimientos()
                    .Where(m => m.Codigo.ToString().Contains(codigoBuscado) ||
                                m.Mecanico != null && (m.Mecanico.Nombres.Contains(codigoBuscado) ||
                                                       m.Mecanico.Apellidos.Contains(codigoBuscado) ||
                                                       m.Mecanico.Cedula.Contains(codigoBuscado)) ||
                                m.Vehiculo != null && (m.Vehiculo.Placa.Contains(codigoBuscado)))
                    .ToList();

                if (mantenimientosFiltrados.Any())
                {
                    dgvMantenimientos.DataSource = ObtenerMantenimientosProyectados(mantenimientosFiltrados);
                }
                else
                {
                    MessageBox.Show("No se encontraron mantenimientos con el ID, mecánico o placa especificados.", "Mantenimiento no encontrado");
                }
            }
            else
            {
                LoadMantenimientos();
            }
        }
        private List<object> ObtenerMantenimientosProyectados(List<Mantenimiento> listaMantenimientos)
        {
            return listaMantenimientos.Select(m => new
            {
                Codigo = m.Codigo,
                Cliente = m.Cliente != null ? $"{m.Cliente.Nombres} {m.Cliente.Apellidos}" : "Sin Asignar",
                Mecanico = m.Mecanico != null ? $"{m.Mecanico.Nombres} {m.Mecanico.Apellidos}" : "Sin asignar",
                Fecha_Mantenimiento = m.FechaMantenimiento,
                Vehiculo = m.Vehiculo != null ? m.Vehiculo.Placa : "Sin asignar",
                Diagnostico = m.Diagnostico,
                TrabajosRealizados = m.TrabajosRealizados,
                EsCorrectivo = m.EsCorrectivo ? "Sí" : "No",
                ListaServiciosRealizados = ObtenerNombresServicios(m.ListaServiciosRealizados),
                Estado = m.Estado ? "Activo" : "Inactivo"
            }).ToList<object>();
        }

        private string ObtenerNombresServicios(List<Servicio> listaServicios)
        {
            List<string> nombresServicios = listaServicios.Where(s => s != null).Select(s => s.Nombre).ToList(); 
            return string.Join(", ", nombresServicios);
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buscarMantenimiento();
                e.SuppressKeyPress = true;
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscarMantenimiento();
        }
        private void dgvMantenimientos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            if (rowIndex >= 0)
            {
                DataGridViewRow row = dgvMantenimientos.Rows[rowIndex];

                string codigo = row.Cells["Codigo"].Value.ToString();
                string cliente = row.Cells["Cliente"].Value.ToString();
                string mecanico = row.Cells["Mecanico"].Value.ToString();
                DateTime fechaMantenimiento = (DateTime)row.Cells["Fecha_Mantenimiento"].Value;
                string vehiculo = row.Cells["Vehiculo"].Value.ToString();
                string diagnostico = row.Cells["Diagnostico"].Value.ToString();
                string trabajosRealizados = row.Cells["TrabajosRealizados"].Value.ToString();
                bool esCorrectivo = row.Cells["EsCorrectivo"].Value.ToString() == "Sí";
                string serviciosRealizados = row.Cells["ListaServiciosRealizados"].Value.ToString();

                cmbCliente.Text = cliente;
                cmbMecanico.Text = mecanico;
                cmbVehiculo.Text = vehiculo;
                dtbFechaMantenimiento.Value = fechaMantenimiento;
                txtDiagnostico.Text = diagnostico;
                txtTrabajosRealizados.Text = trabajosRealizados;
                cbEsCorrectivo.Checked = esCorrectivo;

                string[] servicios = serviciosRealizados.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < clbServicios.Items.Count; i++)
                {
                    clbServicios.SetItemChecked(i, false);
                }

                foreach (string servicio in servicios)
                {
                    int index = clbServicios.FindStringExact(servicio.Trim());
                    if (index != -1)
                    {
                        clbServicios.SetItemChecked(index, true);
                    }
                }
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            var camposInvalidos = ValidarCampos();

            if (camposInvalidos.Count == 0)
            {
                List<int> serviciosIds = new List<int>();
                foreach (string servicio in clbServicios.CheckedItems)
                {
                    int servicioId = int.Parse(servicio.Split('/')[0].Trim());
                    serviciosIds.Add(servicioId);
                }

                List<Servicio> serviciosSeleccionados = new List<Servicio>();
                foreach (int servicioId in serviciosIds)
                {
                    Servicio servicio = CtlPrincipal.CtlServicio.ObtenerServicioById(servicioId);
                    if (servicio != null)
                    {
                        serviciosSeleccionados.Add(servicio);
                    }
                }

                bool mantenimientoAgregado = CtlPrincipal.CtlMantenimiento.AgregarMantenimiento(
                    CtlPrincipal.CtlCliente.ObtenerClienteByCedula(cmbCliente.Text.Split('/')[0].Trim()),
                    CtlPrincipal.CtlMecanico.ObtenerMecanicoByCedula(cmbMecanico.Text.Split('/')[0].Trim()),
                    dtbFechaMantenimiento.Value,
                    CtlPrincipal.CtlVehiculo.ObtenerVehiculoByPlaca(cmbVehiculo.Text.Split('/')[0].Trim()),
                    txtDiagnostico.Text,
                    txtTrabajosRealizados.Text,
                    cbEsCorrectivo.Checked,
                    serviciosSeleccionados
                );

                if (mantenimientoAgregado)
                {
                    MessageBox.Show("Mantenimiento agregado correctamente", "Éxito");
                    LoadMantenimientos();
                    resetTextBoxes();
                }
                else
                {
                    MessageBox.Show("No se pudo agregar el mantenimiento, verifica los datos e intenta nuevamente", "Error");
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

        private List<Control> ValidarCampos()
        {
            var camposInvalidos = new List<Control>();

            //if (!Validador.ValidarCedula(GetCedulaFromCombo(cmbCliente)))
            //{
            //    cmbCliente.BackColor = Color.White;
            //}
            //else
            //{
            //    cmbCliente.BackColor = Color.Gray;
            //    camposInvalidos.Add(cmbCliente);
            //}

            //if (!Validador.ValidarCedula(GetCedulaFromCombo(cmbMecanico)))
            //{
            //    cmbMecanico.BackColor = Color.White;
            //}
            //else
            //{
            //    cmbMecanico.BackColor = Color.Gray;
            //    camposInvalidos.Add(cmbMecanico);
            //}

            //if (!Validador.ValidarPlaca(GetPlacaFromCombo(cmbVehiculo)))
            //{
            //    cmbVehiculo.BackColor = Color.White;
            //}
            //else
            //{
            //    cmbVehiculo.BackColor = Color.Gray;
            //    camposInvalidos.Add(cmbVehiculo);
            //}

            ValidarCampoNoVacio(txtDiagnostico, camposInvalidos);

            ValidarCampoNoVacio(txtTrabajosRealizados, camposInvalidos);

            if (!Validador.ValidarFechaNacimiento(dtbFechaMantenimiento.Value))
            {
                dtbFechaMantenimiento.CalendarMonthBackground = Color.Gray;
                camposInvalidos.Add(dtbFechaMantenimiento);
            }
            else
            {
                dtbFechaMantenimiento.CalendarMonthBackground = Color.White;
            }

            return camposInvalidos;
        }
        private string GetCedulaFromCombo(ComboBox combo)
        {
            return combo.Text.Split('/')[0].Trim();
        }

        private string GetPlacaFromCombo(ComboBox combo)
        {
            return combo.Text.Split('/')[0].Trim();
        }

        private void ValidarCampoNoVacio(TextBox textBox, List<Control> camposInvalidos)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                textBox.BackColor = Color.Gray;
                camposInvalidos.Add(textBox);
            }
            else
            {
                textBox.BackColor = Color.White;
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

        private void resetTextBoxes()
        {
            cmbCliente.Text = "";
            cmbMecanico.Text = "";
            cmbVehiculo.Text = "";
            txtDiagnostico.Text = "";
            dtbFechaMantenimiento.Value = DateTime.Now;
            for (int i = 0; i < clbServicios.Items.Count; i++)
            {
                clbServicios.SetItemChecked(i, false);
            }
            txtTrabajosRealizados.Text = "";
            cbEsCorrectivo.Checked = false;
        }
    }
}