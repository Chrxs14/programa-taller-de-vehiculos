using POE_proyecto.Datos;
using POE_proyecto.Modelo;
using POE_proyecto.Utilidades;

namespace POE_proyecto.Controlador
{
    public class CtlCliente
    {
        #region fields
        public CtlCliente() { }
        #endregion

        #region Methods
        public IReadOnlyDictionary<int, Cliente> ObtenerClientes()
        {
            return AlmacenDeDatos.Clientes;
        }

        public bool AgregarCliente(int codigoCliente, string nombres, string apellidos, string cedula, string direccion, string numeroTelefono)
        {
            if (Validador.ValidarCedula(cedula) && Validador.ValidarTelefono(numeroTelefono))
            {
                Cliente nuevoCliente = new Cliente
                {
                    CodigoCliente = codigoCliente,
                    Nombres = nombres,
                    Apellidos = apellidos,
                    Cedula = cedula,
                    Direccion = direccion,
                    NumeroTelefono = numeroTelefono
                };

                // Agregar cliente al almacen de datos
                AlmacenDeDatos.AgregarCliente(codigoCliente, nuevoCliente);
                return true;
            }
            else
            {
                // Manejar el caso de datos inválidos
                return false;
            }
        }
        #endregion
    }
}