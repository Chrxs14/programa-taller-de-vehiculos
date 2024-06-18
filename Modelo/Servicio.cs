namespace POE_proyecto.Modelo
{
    public class Servicio
    {
        #region fields
        public int Codigo { get; set; }
        public string? Nombre { get; set; }
        public float Precio { get; set; }
        public string? Descripcion { get; set; }
        public bool Estado { get; set; }
        #endregion

        #region constructors
        public Servicio() { }
        public Servicio(int codigo, string nombre, float precio, string descripcion)
        {
            Codigo = codigo;
            Nombre = nombre;
            Precio = precio;
            Descripcion = descripcion;
            Estado = true;
        }
        #endregion
    }
}
