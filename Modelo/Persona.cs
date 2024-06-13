namespace POE_proyecto.Modelo
{
    public class Persona
    {
        // Aqui me indicaba usar required o ? para poder decir si el campo sera requerido o puede ser nulo, pero se resolvio colocando un constructor por defecto con
        // campos en nulo (estara bien?, estara mal?, sabe dios)
        // Update: Al final lo cambie por que me parece mejor jaja
        // Update: Esto solo lo solicita cuando el campo es string?, con los int no me pide hacerlo
        #region fields
        public string? Cedula { get; set; }
        public string? Nombres { get; set; }
        public string? Apellidos { get; set; }
        public string? Direccion { get; set; }
        public string? Correo { get; set; }
        public string? NumeroTelefono { get; set; }
        public DateTime FechaNacimiento { get; set; }
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
        }
        #endregion
    }
}