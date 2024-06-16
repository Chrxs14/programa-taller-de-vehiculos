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
        public IReadOnlyList<Mantenimiento> ObtenerMantenimientos()
        {
            return AlmacenDeDatos.MantenimientosList;
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
            Mantenimiento mantenimientoExistente = AlmacenDeDatos.MantenimientosList.FirstOrDefault(m => m.Codigo == codigoMantenimiento);

            if (mantenimientoExistente != null)
            {
                if (Validador.ValidarCamposMantenimiento(fechaMantenimiento, diagnostico, trabajosRealizados))
                {
                    mantenimientoExistente.Cliente = cliente;
                    mantenimientoExistente.Mecanico = mecanico;
                    mantenimientoExistente.FechaMantenimiento = fechaMantenimiento;
                    mantenimientoExistente.Vehiculo = vehiculo;
                    mantenimientoExistente.Diagnostico = diagnostico;
                    mantenimientoExistente.TrabajosRealizados = trabajosRealizados;
                    mantenimientoExistente.EsCorrectivo = esCorrectivo;
                    mantenimientoExistente.ListaServiciosRealizados = listaServiciosRealizados;
                    return true;
                }
            }
            return false;
        }
        #endregion
    }
}
