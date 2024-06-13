namespace POE_proyecto.Modelo
{
    public class Servicio
    {
        // Tengo la IDEA de agregar el encargado de realizar el servicio y asi le damos uso a la clase Empleado
        #region fields
        public int Codigo { get; set; }
        public string? Nombre { get; set; }
        public int Precio { get; set; }
        public string? Descripcion { get; set; }
        // public Empleado Encargado { get; set; }

        #endregion

        #region constructors
        public Servicio() { }
        public Servicio(int codigo, string nombre, int precio, string descripcion)
        {
            Codigo = codigo;
            Nombre = nombre;
            Precio = precio;
            Descripcion = descripcion;
        }
        #endregion
    }
}
