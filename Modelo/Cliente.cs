namespace POE_proyecto.Modelo
{
    public class Cliente : Persona
    {
        #region fields
        public int CodigoCliente { get; set; }
        public string? Referencia { get; set; }
        public DateTime FechaRegistro { get; set; }
        #endregion

        #region constructors
        public Cliente()
        {

        }
        public Cliente(int codigoCliente, string cedula, string nombres, string apellidos, string direccion, string correo, string numeroTelefono, DateTime fechaNacimiento, string referencia, DateTime fechaRegistro)
            : base(cedula, nombres, apellidos, direccion, correo, numeroTelefono, fechaNacimiento)
        {
            CodigoCliente = codigoCliente;
            Referencia = referencia;
            FechaRegistro = fechaRegistro;
        }
        #endregion
    }
}
