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
        #endregion

        #region constructors
        public CtlPrincipal()
        {
            ctlCliente = new();
            ctlMecanico = new();
            ctlMantenimiento = new();
            ctlVehiculo = new();
        }
        #endregion

        #region Properties
        public CtlCliente CtlCliente { get { return ctlCliente; } }
        public CtlMecanico CtlMecanico { get { return ctlMecanico; } }
        public CtlMantenimiento CtlMantenimiento { get { return ctlMantenimiento; } }
        public CtlVehiculo CtlVehiculo { get { return ctlVehiculo; } }
        #endregion
    }
}
