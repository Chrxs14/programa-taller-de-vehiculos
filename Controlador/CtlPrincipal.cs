using POE_proyecto.Datos;
using POE_proyecto.Modelo;

namespace POE_proyecto.Controlador
{
    public class CtlPrincipal
    {
        #region fields
        private readonly CtlCliente ctlCliente;
        private readonly CtlMecanico ctlMecanico;
        private readonly CtlMantenimiento ctlMantenimiento;
        private readonly CtlVehiculo ctlVehiculo;
        private readonly CtlServicio ctlServicio;
        private readonly CtlEmpleado ctlEmpleado;
        #endregion

        #region constructors
        public CtlPrincipal()
        {
            ctlCliente = new();
            ctlMecanico = new();
            ctlMantenimiento = new();
            ctlVehiculo = new();
            ctlServicio = new();
            ctlEmpleado = new();
        }
        #endregion

        #region Properties
        public CtlCliente CtlCliente { get { return ctlCliente; } }
        public CtlMecanico CtlMecanico { get { return ctlMecanico; } }
        public CtlMantenimiento CtlMantenimiento { get { return ctlMantenimiento; } }
        public CtlVehiculo CtlVehiculo { get { return ctlVehiculo; } }
        public CtlServicio CtlServicio { get { return ctlServicio; } }
        public CtlEmpleado CtlEmpleado { get { return ctlEmpleado; } }
        #endregion
    }
}
