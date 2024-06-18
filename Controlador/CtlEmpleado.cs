using POE_proyecto.Modelo;
using POE_proyecto.Utilidades;
using POE_proyecto.Datos;

namespace POE_proyecto.Controlador
{
    public class CtlEmpleado
    {
        #region constructors
        public CtlEmpleado() { }
        #endregion

        #region Methods
        /// <summary>
        /// Obtiene la lista de empleados con estado activo
        /// </summary>
        /// <returns>Lista de empleados</returns>
        public List<Empleado> ObtenerEmpleados()
        {
            return AlmacenDeDatos.EmpleadosList
                                 .Where(e => e.Estado)
                                 .ToList();
        }

        /// <summary>
        /// Obtener un empleado mediante su cedula
        /// </summary>
        /// <returns>
        /// <c>Empleado</c> si se encuentra el empleado; de lo contrario, <c>null</c> si el empleado no fue encontrado.
        /// </returns>
        public Empleado ObtenerEmpleadoByCedula(string cedula)
        {
            if (Validador.ValidarCedula(cedula)){
                return AlmacenDeDatos.BuscarEmpleado(cedula);
            }
            return null;
        }

        /// <summary>
        /// Agrega un empleado a la lista de empleados
        /// </summary>
        /// <returns>True si se agrega el empleado, False si no se agrega</returns>
        public bool AgregarEmpleado
            (
            string cedula, string nombres, string apellidos, 
            string direccion, string correo, string numeroTelefono, DateTime fechaNacimiento
            )
        {
            if(Validador.ValidarCamposEmpleado(cedula, correo, numeroTelefono, nombres, apellidos, direccion, fechaNacimiento)) {
                Empleado nuevoEmpleado = new(cedula, nombres, apellidos, direccion, correo, numeroTelefono, 
                                            fechaNacimiento, DateTime.Now);
                AlmacenDeDatos.AgregarEmpleado(nuevoEmpleado);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Actualiza un empleado en la lista de empleados
        /// </summary>
        /// <returns>True si se actualiza el empleado, False si no se actualiza</returns>
        public bool ActualizarEmpleadoByCedula
            (
            string cedula, string nombres, string apellidos,
            string direccion, string correo, string numeroTelefono, DateTime fechaNacimiento
            )
        {
            if(AlmacenDeDatos.BuscarEmpleado(cedula) != null)
            {
                if (Validador.ValidarCamposEmpleado(cedula, nombres, apellidos, direccion, correo, numeroTelefono, fechaNacimiento))
                {
                    Empleado empleado = new(cedula, nombres, apellidos, direccion, correo, numeroTelefono, fechaNacimiento, DateTime.Now);
                    AlmacenDeDatos.ModificarEmpleado(cedula, empleado);
                    return true;
                }
            }
            return false;
        }
        #endregion
    }
}