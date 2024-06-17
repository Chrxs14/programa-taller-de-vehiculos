using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POE_proyecto.Modelo;

namespace POE_proyecto.Vista
{
    public partial class FormGestionClientes : Form
    {
        private List<Cliente> clientes;
        public FormGestionClientes()
        {
            InitializeComponent();
        }

        private void FormGestionClientes_Load(object sender, EventArgs e)
        {

        }

        private void LoadClientes()
        {
            clientes = new List<Cliente>() {
                new Cliente(1, "1234567890", "Juan", "Perez", "Calle Falsa 123", "juan.perez@example.com", "0987654321", new DateTime(1985, 5, 10), "Referencia A", DateTime.Now),
                new Cliente(2, "2345678901", "Maria", "Gomez", "Avenida Siempreviva 456", "maria.gomez@example.com", "0987654322", new DateTime(1990, 8, 15), "Referencia B", DateTime.Now),
                new Cliente(3, "3456789012", "Carlos", "Ruiz", "Boulevard de los Sueños 789", "carlos.ruiz@example.com", "0987654323", new DateTime(1982, 12, 20), "Referencia C", DateTime.Now),
                new Cliente(4, "4567890123", "Ana", "Martinez", "Calle de la Amargura 101", "ana.martinez@example.com", "0987654324", new DateTime(1978, 3, 25), "Referencia D", DateTime.Now),
                new Cliente(5, "5678901234", "Luis", "Ramirez", "Camino del Rey 102", "luis.ramirez@example.com", "0987654325", new DateTime(1995, 7, 30), "Referencia E", DateTime.Now),
        };


            dataGridViewClientes.DataSource = clientes;
        }

        private void buttonBuscarCliente_Click(object sender, EventArgs e)
        {
            string cedulaBuscado = textBoxBuscarCliente.Text;

            Console.WriteLine(cedulaBuscado);

            //var clientesFiltrados = clientes
            //    .Where(c => c.Nombres.ToLower().Contains(nombreBuscado))
            //    .ToList();

            //dataGridViewClientes.DataSource = clientesFiltrados;
        }

        private void textBoxBuscarCliente_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
