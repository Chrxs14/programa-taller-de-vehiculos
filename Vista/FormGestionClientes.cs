using POE_proyecto.Controlador;
using POE_proyecto.Modelo;

namespace POE_proyecto.Vista
{
    public partial class FormGestionClientes : Form
    {
        private List<Cliente> clientes;
        private CtlPrincipal CtlPrincipal;
        private int c = 1;
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
        }

        private void buttonBuscarCliente_Click(object sender, EventArgs e)
        {
            if (textBoxBuscarCliente.Text == null)
            {

            }

            string cedulaBuscado = textBoxBuscarCliente.Text;

            List<Cliente> clienteEncontrado = new List<Cliente>() { CtlPrincipal.CtlCliente.ObtenerClienteByCedula(cedulaBuscado) };

            dataGridViewClientes.DataSource = clienteEncontrado;
        }
        
        private void dataGridViewClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
