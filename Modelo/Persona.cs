namespace POE_proyecto.Modelo
{
    public class Persona
    {
        #region fields
        public string? Cedula { get; set; }
        public string? Nombres { get; set; }
        public string? Apellidos { get; set; }
        public string? Direccion { get; set; }
        public string? Correo { get; set; }
        public string? NumeroTelefono { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public bool Estado { get; set; }
        #endregion

        #region constructors
        public Persona() { }
        public Persona(string cedula, string nombres, string apellidos, string direccion, string correo, string numeroTelefono, DateTime fechaNacimiento)
        {
            Cedula = cedula;
            Nombres = nombres;
            Apellidos = apellidos;
            Direccion = direccion;
            Correo = correo;
            NumeroTelefono = numeroTelefono;
            FechaNacimiento = fechaNacimiento;
            Estado = true;
        }
        #endregion
    }
}