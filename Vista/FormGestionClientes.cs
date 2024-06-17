using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POE_proyecto.Controlador;
using POE_proyecto.Modelo;

namespace POE_proyecto.Vista
{
    public partial class FormGestionClientes : Form
    {
        private List<Cliente> clientes;
        private CtlPrincipal principal = new();
        private int c = 1;
        public FormGestionClientes()
        {
            InitializeComponent();
            MostrarClientes();
            dataGridViewClientes.ReadOnly = true;
            LoadClientes();
        }

        private void FormGestionClientes_Load(object sender, EventArgs e)
        {

        }

        private void LoadClientes()
        {
            clientes = new List<Cliente>() {
                new Cliente("1234567890", "Juan", "Perez", "Calle Falsa 123", "juan.perez@example.com", "0987654321", new DateTime(1985, 5, 10), "Referencia A", DateTime.Now),
                new Cliente("2345678901", "Maria", "Gomez", "Avenida Siempreviva 456", "maria.gomez@example.com", "0987654322", new DateTime(1990, 8, 15), "Referencia B", DateTime.Now),
                new Cliente("3456789012", "Carlos", "Ruiz", "Boulevard de los Sueños 789", "carlos.ruiz@example.com", "0987654323", new DateTime(1982, 12, 20), "Referencia C", DateTime.Now),
                new Cliente("4567890123", "Ana", "Martinez", "Calle de la Amargura 101", "ana.martinez@example.com", "0987654324", new DateTime(1978, 3, 25), "Referencia D", DateTime.Now),
                new Cliente("5678901234", "Luis", "Ramirez", "Camino del Rey 102", "luis.ramirez@example.com", "0987654325", new DateTime(1995, 7, 30), "Referencia E", DateTime.Now),
            };

            while (c <= 5)
            {
                principal.CtlCliente.AgregarCliente("123456789" + c, "Juan", "Perez", "Calle Falsa 123", "juan.perez@example.com", "0987654321", new DateTime(1985, 5, 10), "Referencia A");
                c++;
            }

            dataGridViewClientes.DataSource = clientes;
        }

        private void buttonBuscarCliente_Click(object sender, EventArgs e)
        {


            if (textBoxBuscarCliente.Text == null)
            {

            }

            string cedulaBuscado = textBoxBuscarCliente.Text;

            List<Cliente> clienteEncontrado = new List<Cliente>() { principal.CtlCliente.ObtenerClienteByCedula(cedulaBuscado) };

            dataGridViewClientes.DataSource = clienteEncontrado;


        }

        private void MostrarClientes()
        {
            LoadClientes();
            dataGridViewClientes.DataSource = principal.CtlCliente.ObtenerClientes();
        }

        private void textBoxBuscarCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxBuscarCliente_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void dataGridViewClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
