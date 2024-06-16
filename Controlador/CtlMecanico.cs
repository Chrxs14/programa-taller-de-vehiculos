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
        public IReadOnlyList<Mecanico> ObtenerMecanicos()
        {
            return AlmacenDeDatos.MecanicosList;
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
                int codigoMecanico = AlmacenDeDatos.MecanicosList.Count + 100;

                Mecanico nuevoMecanico = new Mecanico(cedula, nombres, apellidos, direccion, correo, numeroTelefono, fechaNacimiento, 
                                                      codigoMecanico, DateTime.Now, especialidad, nivelDeExperiencia);
                AlmacenDeDatos.AgregarMecanico(nuevoMecanico);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Modifica un mecanico existente en la lista de mecanicos mediante codigo de mecanico
        /// </summary>
        /// <param name="codigoMecanico" Codigo del mecanico a modificar></param>
        /// <returns>
        /// <c>true</c> si se modifica el mecanico; de lo contrario, <c>false</c>.
        /// </returns>
        public bool ModificarMecanicoByCodigoMecanico(int codigoMecanico, string cedula, string nombres, string apellidos, string direccion, string correo, string numeroTelefono
                                                      , DateTime fechaNacimiento, string especialidad, string nivelDeExperiencia)
        {
            Mecanico mecanicoExistente = AlmacenDeDatos.MecanicosList.FirstOrDefault(m => m.CodigoEmpleado == codigoMecanico);
            if (mecanicoExistente != null)
            {
                if (Validador.ValidarCamposMecanico(cedula, nombres, apellidos, direccion, correo, numeroTelefono, fechaNacimiento,  especialidad, nivelDeExperiencia))
                {
                    mecanicoExistente.Cedula = cedula;
                    mecanicoExistente.Nombres = nombres;
                    mecanicoExistente.Apellidos = apellidos;
                    mecanicoExistente.Direccion = direccion;
                    mecanicoExistente.Correo = correo;
                    mecanicoExistente.NumeroTelefono = numeroTelefono;
                    mecanicoExistente.FechaNacimiento = fechaNacimiento;
                    mecanicoExistente.Especialidad = especialidad;
                    mecanicoExistente.NivelDeExperiencia = nivelDeExperiencia;
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Modifica el estado de un mecanico existente en la lista de mecanicos mediante codigo de mecanico
        /// </summary>
        /// <param name="codigoMecanico"></param>
        /// <param name="estado"> TRUE - HABILITADO, FALSE - INHABILITADO</param>
        /// <returns>
        /// <c>true</c> si se modifica el estado del mecanico; de lo contrario, <c>false</c>.
        /// </returns>
        public bool ModificarEstadoMecanicoByCodigoMecanico(int codigoMecanico, bool estado)
        {
            Mecanico mecanicoExistente = AlmacenDeDatos.MecanicosList.FirstOrDefault(m => m.CodigoEmpleado == codigoMecanico);
            if (mecanicoExistente != null)
            {
                mecanicoExistente.EstaActivo = estado;
                return true;
            }
            return false;
        }
        #endregion
    }
}