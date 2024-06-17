namespace POE_proyecto.Modelo
{
    public class Mecanico : Empleado
    {
        #region fields
        public string? Especialidad { get; set; }
        public string? NivelDeExperiencia { get; set; }
        public bool Estado { get; set; }
        #endregion

        #region constructors
        public Mecanico() { }

        public Mecanico(string cedula, string nombres, string apellidos, string direccion, string correo, string numeroTelefono
                        , DateTime fechaNacimiento, DateTime fechaIngreso, string especialidad, string nivelDeExperiencia)
            : base(cedula, nombres, apellidos, direccion, correo, numeroTelefono, fechaNacimiento, fechaIngreso)
        {
            Especialidad = especialidad;
            NivelDeExperiencia = nivelDeExperiencia;
            Estado = true;
        }
        #endregion
    }
}
