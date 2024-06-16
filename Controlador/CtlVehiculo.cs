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
        public IReadOnlyList<Vehiculo> ObtenerVehiculos()
        {
            return AlmacenDeDatos.VehiculosList;
        }

        public bool AgregarVehiculo(string placa, string marca, string modelo, string anio, string kilometraje)
        {
            if (Validador.CamposVehiculo(placa, marca, modelo, anio, kilometraje))
            {
                Vehiculo nuevoVehiculo = new Vehiculo(placa, marca, modelo, anio, kilometraje);
                AlmacenDeDatos.AgregarVehiculo(nuevoVehiculo);
                return true;
            }
            return false;
        }

        public bool ModificarVehiculoByPlaca(string placa, string marca, string modelo, string anio, string kilometraje)
        {
            Vehiculo vehiculoExistente = AlmacenDeDatos.VehiculosList.FirstOrDefault(v => v.Placa == placa);

            if (vehiculoExistente != null)
            {
                if (Validador.CamposVehiculo(placa, marca, modelo, anio, kilometraje))
                {
                    vehiculoExistente.Marca = marca;
                    vehiculoExistente.Modelo = modelo;
                    vehiculoExistente.Anio = anio;
                    vehiculoExistente.Kilometraje = kilometraje;
                    return true;
                }
            }
            return false;
        }
        #endregion
    }
}
