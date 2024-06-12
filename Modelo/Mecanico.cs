namespace POE_proyecto.Modelo
{
    internal class Mecanico : Empleado
    {
        #region fields
        public string? Especialidad { get; set; }
        public string? NivelDeExperiencia { get; set; }
        #endregion

        #region constructors
        public Mecanico(){}

        public Mecanico(string cedula, string nombres, string apellidos, string direccion, string correo, string numeroTelefono, DateTime fechaNacimiento, int codigoEmpleado, DateTime fechaIngreso, string especialidad, string nivelDeExperiencia)
            : base(cedula, nombres, apellidos, direccion, correo, numeroTelefono, fechaNacimiento, codigoEmpleado, fechaIngreso)
        {
            Especialidad = especialidad;
            NivelDeExperiencia = nivelDeExperiencia;
        }
        #endregion
    }
}
