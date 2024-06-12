namespace POE_proyecto.Modelo
{
    internal class Empleado : Persona
    {
        #region fields
        public int CodigoEmpleado { get; set; }
        public DateTime FechaIngreso { get; set; }
        #endregion

        #region constructors
        public Empleado(){}

        public Empleado(string cedula, string nombres, string apellidos, string direccion, string correo, string numeroTelefono, DateTime fechaNacimiento, int codigoEmpleado, DateTime fechaIngreso)
            : base(cedula, nombres, apellidos, direccion, correo, numeroTelefono, fechaNacimiento)
        {
            CodigoEmpleado = codigoEmpleado;
            FechaIngreso = fechaIngreso;
        }
        #endregion
    }
}
