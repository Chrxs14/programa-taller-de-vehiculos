using POE_proyecto.Modelo;
using POE_proyecto.Utilidades;
using POE_proyecto.Datos;

namespace POE_proyecto.Controlador
{
    public class CtlMecanico
    {
        #region constructors
        public CtlMecanico() { }
        #endregion

        #region methods
        /// <summary>
        /// Obtiene la lista de mecanicos
        /// </summary> 
        /// <returns>Lista de mecanicos</returns>
        public List<Mecanico> ObtenerMecanicos()
        {
            return AlmacenDeDatos.EmpleadosList
                                 .Where(e => e.Estado && e is Mecanico)
                                 .Cast<Mecanico>()
                                 .ToList();
        }

        /// <summary>
        /// Obtiene un mecanico mediante su cedula
        /// </summary>
        /// <returns>
        /// <c>true</c> si se encuentra el mecanico; de lo contrario, <c>false</c> si el mecanico no fue encontrado.
        /// </returns>
        public Mecanico ObtenerMecanicoByCedula(string cedula)
        {
            if (Validador.ValidarCedula(cedula))
            {
                var empleado = AlmacenDeDatos.BuscarEmpleado(cedula);
                if (empleado is Mecanico mecanico && mecanico.Estado)
                {
                    return mecanico;
                }
            }
            return null;
        }

        /// <summary>
        /// Agrega un mecanico a la lista de mecanicos
        /// </summary>
        /// <returns>True si se agrega el mecanico, False si no se agrega</returns></returns>
        public bool AgregarMecanico
            (
                string cedula, string nombres, string apellidos, string direccion, string correo, string numeroTelefono
                , DateTime fechaNacimiento, string especialidad, string nivelDeExperiencia
            )
        {
            if (Validador.ValidarCamposMecanico(cedula, nombres, apellidos, direccion, correo, numeroTelefono, fechaNacimiento, especialidad, nivelDeExperiencia))
            {
                Mecanico nuevoMecanico = new(cedula, nombres, apellidos, direccion, correo, numeroTelefono, fechaNacimiento, 
                                             DateTime.Now, especialidad, nivelDeExperiencia);
                AlmacenDeDatos.AgregarEmpleado(nuevoMecanico);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Modifica un mecanico existente en la lista de mecanicos mediante codigo de mecanico
        /// </summary>
        /// <returns>
        /// <c>true</c> si se modifica el mecanico; de lo contrario, <c>false</c>.
        /// </returns>
        public bool ModificarMecanicoByCedula(string cedula, string nombres, string apellidos, string direccion, string correo, string numeroTelefono
                                                      , DateTime fechaNacimiento, string especialidad, string nivelDeExperiencia)
        {
            if (AlmacenDeDatos.BuscarEmpleado(cedula) != null)
            {
                if (Validador.ValidarCamposMecanico(cedula, nombres, apellidos, direccion, correo, numeroTelefono, fechaNacimiento,  especialidad, nivelDeExperiencia))
                {
                    Mecanico mecanicoEditado = new(cedula, nombres, apellidos, direccion, correo, numeroTelefono, fechaNacimiento, DateTime.Now, especialidad, nivelDeExperiencia);
                    AlmacenDeDatos.ModificarEmpleado(cedula, mecanicoEditado);
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Modifica el estado de un mecanico existente en la lista de mecanicos mediante codigo de mecanico
        /// </summary>
        /// <returns>
        /// <c>true</c> si se modifica el estado del mecanico; de lo contrario, <c>false</c>.
        /// </returns>
        public bool EliminarMecanicoByCedula(string cedula, bool estado)
        {
            Mecanico mecanico = (Mecanico) AlmacenDeDatos.BuscarEmpleado(cedula);
            if (mecanico != null)
            {
                mecanico.Estado = estado;
                return true;
            }
            return false;
        }
        #endregion
    }
}