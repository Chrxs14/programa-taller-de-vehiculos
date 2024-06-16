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
        /// Obtiene la lista de clientes
        /// </summary>
        /// <returns>Lista de clientes</returns>
        public IReadOnlyList<Cliente> ObtenerClientes()
        {
            return AlmacenDeDatos.ClientesList;
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
            if(Validador.CamposCliente(cedula, correo, numeroTelefono, nombres, apellidos, direccion, fechaNacimiento)) {
                int codigoCliente = AlmacenDeDatos.ClientesList.Count + 100;
                Cliente nuevoCliente = new Cliente(codigoCliente, cedula, nombres, apellidos, direccion, correo, 
                                                numeroTelefono, fechaNacimiento, referencia, DateTime.Now);
                AlmacenDeDatos.AgregarCliente(nuevoCliente);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Modifica un cliente existente en la lista de clientes
        /// </summary>
        /// <param name="codigoCliente" Codigo del cliente a modificar></param>
        /// <returns>True si se modifica el cliente, False si no se encuentra el cliente</returns>
        public bool ModificarCliente(
            int codigoCliente, string cedula, string nombres, string apellidos,
            string direccion, string correo, string numeroTelefono, DateTime fechaNacimiento,
            string referencia)
        {
            Cliente clienteExistente = AlmacenDeDatos.ClientesList.FirstOrDefault(c => c.CodigoCliente == codigoCliente);

            if (clienteExistente != null)
            {
                if (Validador.CamposCliente(cedula, correo, numeroTelefono, nombres, apellidos, direccion, fechaNacimiento))
                {
                    clienteExistente.Cedula = cedula;
                    clienteExistente.Nombres = nombres;
                    clienteExistente.Apellidos = apellidos;
                    clienteExistente.Direccion = direccion;
                    clienteExistente.Correo = correo;
                    clienteExistente.NumeroTelefono = numeroTelefono;
                    clienteExistente.FechaNacimiento = fechaNacimiento;
                    clienteExistente.Referencia = referencia;
                    return true;
                }
            }
            return false;
        }
        #endregion
    }
}