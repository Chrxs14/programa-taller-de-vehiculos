using POE_proyecto.Datos;
using POE_proyecto.Modelo;

namespace POE_proyecto.Controlador
{
    public class CtlPrincipal
    {
        #region fields
        private readonly CtlCliente ctlCliente;
        #endregion

        #region constructors
        public CtlPrincipal()
        {
            ctlCliente = new CtlCliente();
        }
        #endregion

        #region Properties

        public CtlCliente CtlCliente { get { return ctlCliente; } }
        #endregion
    }
}
