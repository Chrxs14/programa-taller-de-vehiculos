using POE_proyecto.Utilidades;
using POE_proyecto.Modelo;
using POE_proyecto.Datos;

namespace POE_proyecto.Controlador
{
    public class CtlMantenimiento
    {
        #region constructors
        public CtlMantenimiento() { }
        #endregion

        #region methods
        /// <summary>
        /// Obtiene la lista de mantenimientos que se han realizado
        /// </summary>
        /// <returns>
        /// Lista de Mantenimientos
        /// </returns>
        public List<Mantenimiento> ObtenerMantenimientos()
        {
            return AlmacenDeDatos.MantenimientosList
                                 .Where(m => m.Estado)
                                 .ToList();
        }

        /// <summary>
        /// Obtener un mantenimiento mediante su codigo de mantenimiento
        /// </summary>
        /// <returns>
        /// <c>true</c> si se encuentra el mantenimiento; de lo contrario, <c>false</c> si el mantenimiento no fue encontrado.
        /// </returns>
        public Mantenimiento ObtenerMantenimientoByCodigoMantenimiento(string codigoMantenimiento)
        {
            if (Validador.ValidarCodigoMantenimiento(codigoMantenimiento))
            {
                return AlmacenDeDatos.BuscarMantenimiento(codigoMantenimiento);
            }
            return null;
        }

        /// <summary>
        /// Método para agregar un mantenimiento a la lista de mantenimientos, los objetos Cliente, Mecanico, Vehiculo y Servicio deben existir o ser creados previamente
        /// </summary>
        /// <returns>
        /// <c>true</c> si se agrega el mantenimiento; de lo contrario, <c>false</c>.
        /// </returns>
        public bool AgregarMantenimiento
            (
                Cliente cliente, Mecanico mecanico, DateTime fechaMantenimiento, Vehiculo vehiculo,
                string diagnostico, string trabajosRealizados, bool esCorrectivo, List<Servicio> listaServiciosRealizados
            )
        {
            if (Validador.ValidarCamposMantenimiento(fechaMantenimiento, diagnostico, trabajosRealizados))
            {
                string codigoMantenimiento = "M" + AlmacenDeDatos.MantenimientosList.Count.ToString();
                Mantenimiento nuevoMantenimiento = new Mantenimiento(codigoMantenimiento, cliente, mecanico, fechaMantenimiento, vehiculo, diagnostico, trabajosRealizados, esCorrectivo, listaServiciosRealizados);
                AlmacenDeDatos.AgregarMantenimiento(nuevoMantenimiento);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Método para modificar un mantenimiento existente en la lista de mantenimientos
        /// </summary>
        /// <returns>
        /// <c>true</c> si se modifica el mantenimiento; de lo contrario, <c>false</c>.
        /// </returns>
        public bool ModificarMantenimientoByCodigoMantenimiento
            (
                string codigoMantenimiento, Cliente cliente, Mecanico mecanico, DateTime fechaMantenimiento, Vehiculo vehiculo,
                string diagnostico, string trabajosRealizados, bool esCorrectivo, List<Servicio> listaServiciosRealizados
            )
        {
            if (AlmacenDeDatos.BuscarMantenimiento != null)
            {
                if (Validador.ValidarCamposMantenimiento(fechaMantenimiento, diagnostico, trabajosRealizados))
                {
                    Mantenimiento mantenimientoEditado = new Mantenimiento(codigoMantenimiento, cliente, mecanico, fechaMantenimiento, vehiculo, diagnostico, trabajosRealizados, esCorrectivo, listaServiciosRealizados);
                    AlmacenDeDatos.ModificarMantenimiento(codigoMantenimiento, mantenimientoEditado);
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Eliminado logico: Modifica estado de un mantenimiento existente en la lista de mantenimientos mediante codigo de mantenimiento
        /// </summary>
        /// <returns>
        /// <c>true</c> si se elimina el mantenimiento; de lo contrario, <c>false</c>.
        /// </returns>
        public bool EliminarMantenimientoByCodigoMantenimiento(string codigoMantenimiento)
        {
            Mantenimiento mantenimiento = AlmacenDeDatos.BuscarMantenimiento(codigoMantenimiento);

            if (mantenimiento != null)
            {
                mantenimiento.Estado = false;
                return true;
            }
            return false;
        }
        #endregion
    }
}
