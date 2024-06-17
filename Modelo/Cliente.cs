namespace POE_proyecto.Modelo
{
    public class Cliente : Persona
    {
        #region fields
        public string? Referencia { get; set; }
        public DateTime FechaRegistro { get; set; }
        #endregion

        #region constructors
        public Cliente() {}
        public Cliente(string cedula, string nombres, string apellidos, string direccion, string correo
                       , string numeroTelefono, DateTime fechaNacimiento, string referencia, DateTime fechaRegistro)
            : base(cedula, nombres, apellidos, direccion, correo, numeroTelefono, fechaNacimiento)
        {
            Referencia = referencia;
            FechaRegistro = fechaRegistro;
        }
        #endregion
    }
}
