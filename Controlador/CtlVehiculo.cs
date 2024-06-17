using POE_proyecto.Modelo;
using POE_proyecto.Utilidades;
using POE_proyecto.Datos;

namespace POE_proyecto.Controlador
{
    /// <summary>
    /// Cntrolador de la clase Vehiculo
    /// </summary>
    public class CtlVehiculo
    {
        #region constructors
        public CtlVehiculo() { }
        #endregion

        #region methods
        /// <summary>
        /// Obtiene la lista de vehiculos
        /// </summary>
        /// <returns>
        /// Lista de vehiculos
        /// </returns>
        public List<Vehiculo> ObtenerVehiculos()
        {
            return AlmacenDeDatos.VehiculosList.Where(v => v.Estado).ToList();
        }

        /// <summary>
        /// Obtiene un objeto vehiculo mediante su placa
        /// </summary>
        /// <returns>
        /// <c>true</c> si se encuentra el vehiculo; de lo contrario, <c>false</c> si el vehiculo no fue encontrado.
        /// </returns>
        public Vehiculo ObtenerVehiculoByPlaca(string placa)
        {
            if (Validador.ValidarPlaca(placa))
            {
                return AlmacenDeDatos.BuscarVehiculo(placa);
            }
            return null;
        }

        /// <summary>
        /// Metodo para agregar un vehiculo a la lista de vehiculos
        /// </summary>
        /// <returns>
        /// <c>true</c> si se agrega el vehiculo; de lo contrario, <c>false</c>.
        /// </returns>
        public bool AgregarVehiculo(string placa, string marca, string modelo, string anio, string kilometraje)
        {
            if (Validador.ValidarCamposVehiculo(placa, marca, modelo, anio, kilometraje))
            {
                Vehiculo nuevoVehiculo = new Vehiculo(placa, marca, modelo, anio, kilometraje);
                AlmacenDeDatos.AgregarVehiculo(nuevoVehiculo);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Metodo para modificar un vehiculo mediante su placa
        /// </summary>
        /// <returns>
        /// <c>true</c> si se modifica el vehiculo; de lo contrario, <c>false</c> si el vehiculo no fue encontrado.
        /// </returns>
        public bool ModificarVehiculoByPlaca(string placa, string marca, string modelo, string anio, string kilometraje)
        {
            if (AlmacenDeDatos.BuscarVehiculo(placa) != null)
            {
                if (Validador.ValidarCamposVehiculo(placa, marca, modelo, anio, kilometraje))
                {
                    Vehiculo vehiculoEditado = new Vehiculo(placa, marca, modelo, anio, kilometraje);
                    AlmacenDeDatos.ModificarVehiculo(placa, vehiculoEditado);
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Borrado Logico: Cambia el estado del vehiculo a false
        /// </summary>
        /// <returns>
        /// <c>true</c> si se elimina el vehiculo; de lo contrario, <c>false</c> si el vehiculo no fue encontrado.
        /// </returns>
        public bool EliminarVehiculoByPlaca(string placa)
        {
            Vehiculo vehiculo = AlmacenDeDatos.BuscarVehiculo(placa);
            if (vehiculo != null)
            {
                vehiculo.Estado = false;
                return true;
            }   
            return false;
        }
        #endregion
    }
}
