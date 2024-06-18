using POE_proyecto.Datos;
using POE_proyecto.Modelo;
using POE_proyecto.Utilidades;

namespace POE_proyecto.Controlador
{
    /// <summary>
    /// Controlador de la clase Servicio
    /// </summary>
    public class CtlServicio
    {
        #region constructors
        public CtlServicio() { }
        #endregion

        #region methods

        /// <summary>
        /// Obtiene la lista de servicios con estado activo
        /// </summary>
        /// <returns>
        /// Lista de servicios
        /// </returns>
        public List<Servicio> ObtenerServicios()
        {
            return AlmacenDeDatos.ServiciosList
                                 .Where(s => s.Estado)
                                 .ToList();
        }

        /// <summary>
        /// Obtiene un servicio mediante su id
        /// </summary>
        /// <returns>
        /// Objeto de tipo <c>Servicio</c> si se encuentra el servicio; de lo contrario, <c>null</c> si el servicio no fue encontrado.
        /// </returns>
        public Servicio ObtenerServicioById(int id)
        {
            if (Validador.ValidarIdServicio(id))
            {
                return AlmacenDeDatos.BuscarServicio(id);
            }
            return null;
        }

        /// <summary>
        /// Metodo para agregar un servicio a la lista de servicios
        /// </summary>
        /// <returns>
        /// <c>true</c> si se agrega el servicio, de lo contrario, <c>false</c>.
        /// </returns>
        public bool AgregarServicio(string nombre, float precio, string descripcion)
        {
            if (Validador.ValidarCamposServicio(nombre, precio, descripcion))
            {
                int codigo = AlmacenDeDatos.ServiciosList.Count + 1;
                Servicio nuevoServicio = new(codigo, nombre, precio, descripcion);
                AlmacenDeDatos.AgregarServicio(nuevoServicio);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Metodo para actualizar la informacion de un servicio mediante su Id
        /// </summary>
        /// <returns>
        /// <c>true</c> si se actualiza el servicio, de lo contrario, <c>false</c>.
        /// </returns>
        public bool ActualizarServicioById(int id, string nombre, float precio, string descripcion)
        {
            if (Validador.ValidarIdServicio(id) && Validador.ValidarCamposServicio(nombre, precio, descripcion))
            {
                Servicio servicio = AlmacenDeDatos.BuscarServicio(id);
                if (servicio != null)
                {
                    servicio.Nombre = nombre;
                    servicio.Precio = precio;
                    servicio.Descripcion = descripcion;
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Borrado Logico: Cambia el estado de un servicio a inactivo
        /// </summary>
        /// <returns>
        /// <c>true</c> si se elimina el servicio, de lo contrario, <c>false</c>.
        /// </returns>
        public bool EliminarServicioById(int id)
        {
            if (Validador.ValidarIdServicio(id))
            {
                Servicio servicio = AlmacenDeDatos.BuscarServicio(id);
                if (servicio != null)
                {
                    servicio.Estado = false;
                    return true;
                }
            }
            return false;
        }
        #endregion
    }
}