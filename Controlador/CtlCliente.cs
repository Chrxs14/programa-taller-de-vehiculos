using POE_proyecto.Datos;
using POE_proyecto.Modelo;
using POE_proyecto.Utilidades;

namespace POE_proyecto.Controlador
{
    /// <summary>
    /// Cntrolador de la clase Cliente
    /// </summary>
    public class CtlCliente
    {
        #region constructors
        public CtlCliente() { }
        #endregion

        #region Methods
        /// <summary>
        /// Obtiene la lista de clientes con estado activo
        /// </summary>
        /// <returns>Lista de clientes</returns>
        public List<Cliente> ObtenerClientes()
        {
            return AlmacenDeDatos.ClientesList
                                 .Where(c => c.Estado)
                                 .ToList();
        }

        /// <summary>
        /// Obtener un cliente mediante su cedula
        /// </summary>
        /// <returns>
        /// <c>Cliente</c> si se encuentra el cliente; de lo contrario, <c>null</c> si el cliente no fue encontrado.
        /// </returns>
        public Cliente ObtenerClienteByCedula(string cedula)
        {
            if (Validador.ValidarCedula(cedula)){
                return AlmacenDeDatos.BuscarCliente(cedula);
            }
            return null;
        }

        /// <summary>
        /// Agrega un cliente a la lista de clientes
        /// </summary>
        /// <returns>True si se agrega el cliente, False si no se agrega</returns>
        public bool AgregarCliente
            (
            string cedula, string nombres, string apellidos, 
            string direccion, string correo, string numeroTelefono, DateTime fechaNacimiento, 
            string referencia
            )
        {
            if (AlmacenDeDatos.BuscarCliente(cedula) != null)
            {
                Cliente nuevoCliente = new Cliente(cedula, nombres, apellidos, direccion, correo, numeroTelefono, fechaNacimiento, referencia, DateTime.Now);
                AlmacenDeDatos.ModificarCliente(cedula,nuevoCliente);
                return true;
            }

            if (Validador.ValidarCamposCliente(cedula, correo, numeroTelefono, nombres, apellidos, direccion, fechaNacimiento)) {
                Cliente nuevoCliente = new(cedula, nombres, apellidos, direccion, correo, numeroTelefono, 
                                            fechaNacimiento, referencia, DateTime.Now);
                AlmacenDeDatos.AgregarCliente(nuevoCliente);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Modifica un cliente existente en la lista de clientes mediante codigo de cliente
        /// </summary>
        /// <param name="cedula" Cedula del cliente a modificar></param>
        /// <returns>True si se modifica el cliente, False si no se encuentra el cliente</returns>
        public bool ModificarClienteByCedula(
            string cedula, string nombres, string apellidos,
            string direccion, string correo, string numeroTelefono, DateTime fechaNacimiento,
            string referencia)
        {
            if (AlmacenDeDatos.BuscarCliente(cedula) != null)
            {
                if (Validador.ValidarCamposCliente(cedula, correo, numeroTelefono, nombres, apellidos, direccion, fechaNacimiento))
                {
                    Cliente clienteEditado = new Cliente(cedula, nombres, apellidos, direccion, correo, numeroTelefono, fechaNacimiento, referencia, DateTime.Now);
                    AlmacenDeDatos.ModificarCliente(cedula, clienteEditado);
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Eliminado logico: Modifica estado de un cliente existente en la lista de clientes mediante cedula
        /// </summary>
        /// <returns>
        /// <c>true</c> si se elimina el cliente; de lo contrario, <c>false</c>.
        /// </returns>
        public bool EliminarClienteByCedula(string cedula)
        {
            Cliente cliente = AlmacenDeDatos.BuscarCliente(cedula);

            if (cliente != null)
            {
                cliente.Estado = false;
                return true;
            }
            return false;
        }
        #endregion
    }
}