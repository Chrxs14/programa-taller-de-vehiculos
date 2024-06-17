namespace POE_proyecto.Modelo
{
    public class Empleado : Persona
    {
        #region fields
        public DateTime FechaIngreso { get; set; }
        #endregion

        #region constructors
        public Empleado() { }

        public Empleado(string cedula, string nombres, string apellidos, string direccion, string correo, string numeroTelefono, DateTime fechaNacimiento, DateTime fechaIngreso)
            : base(cedula, nombres, apellidos, direccion, correo, numeroTelefono, fechaNacimiento)
        {
            FechaIngreso = fechaIngreso;
        }
        #endregion
    }
}
