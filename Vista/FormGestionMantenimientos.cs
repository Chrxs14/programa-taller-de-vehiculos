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
        }

        private void ConfigurarComboBox()
        {
            cmbCliente.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbCliente.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbMecanico.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbMecanico.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbVehiculo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbVehiculo.AutoCompleteSource = AutoCompleteSource.ListItems;
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

            dgvMantenimientos.AutoGenerateColumns = false;

            dgvMantenimientos.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Codigo",
                HeaderText = "Código"
            });

            dgvMantenimientos.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Cliente",
                HeaderText = "Cliente"
            });

            dgvMantenimientos.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Mecanico",
                HeaderText = "Mecánico"
            });

            dgvMantenimientos.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Fecha_Mantenimiento",
                HeaderText = "Fecha de Mantenimiento"
            });

            dgvMantenimientos.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Vehiculo",
                HeaderText = "Vehículo"
            });

            dgvMantenimientos.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Diagnostico",
                HeaderText = "Diagnóstico"
            });

            dgvMantenimientos.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "TrabajosRealizados",
                HeaderText = "Trabajos Realizados"
            });

            dgvMantenimientos.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "EsCorrectivo",
                HeaderText = "Es Correctivo"
            });

            dgvMantenimientos.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "ListaServiciosRealizados",
                HeaderText = "Servicios Realizados"
            });

            dgvMantenimientos.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Estado",
                HeaderText = "Estado"
            });

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
                EsCorrectivo = m.EsCorrectivo,
                ListaServiciosRealizados = ObtenerNombresServicios(m.ListaServiciosRealizados),
                Estado = m.Estado
            }).ToList<object>();
        }

        private string ObtenerNombresServicios(List<Servicio> listaServicios)
        {
            List<string> nombresServicios = listaServicios.Select(s => s.Nombre).ToList();
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
            int celdaSeleccionada = e.RowIndex;
            if (celdaSeleccionada >= 0)
            {
                DataGridViewRow filaSeleccionada = dgvMantenimientos.Rows[celdaSeleccionada];

            }
        }
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            var camposInvalidos = ValidarCampos();

            if (camposInvalidos.Count == 0)
            {
                bool clienteAgregado = CtlPrincipal.CtlMantenimiento.AgregarMantenimiento(
                    CtlPrincipal.CtlCliente.ObtenerClienteByCedula(cmbCliente.Text.Split('/')[0].Trim()),
                    CtlPrincipal.CtlMecanico.ObtenerMecanicoByCedula(cmbMecanico.Text.Split('/')[0].Trim()),
                    dtbFechaMantenimiento.Value,
                    CtlPrincipal.CtlVehiculo.ObtenerVehiculoByPlaca(cmbVehiculo.Text.Split('/')[0].Trim()),
                    txtDiagnostico.Text,
                    txtTrabajosRealizados.Text,
                    cbEsCorrectivo.Checked,
                    clbServicios.CheckedItems.Cast<Servicio>().ToList() // arreglarlo
                );

                if (clienteAgregado)
                {
                    MessageBox.Show("Cliente creado correctamente", "Cliente Creado");
                    LoadMantenimientos();
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

            if (!Validador.ValidarFechaNacimiento(dtbFechaMantenimiento.Value))
            {
                dtbFechaMantenimiento.CalendarMonthBackground = Color.Gray;
                camposInvalidos.Add(new TextBox { Name = "FechaNacimiento" });
            }
            else
            {
                dtbFechaMantenimiento.CalendarMonthBackground = Color.White;
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