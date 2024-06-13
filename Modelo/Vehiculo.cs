namespace POE_proyecto.Modelo
{
    public class Vehiculo
    {
        #region fields
        public string? Placa { get; set; }
        public string? Marca { get; set; }
        public string? Modelo { get; set; }
        public string? Anio { get; set; }
        public string? Kilometraje { get; set; }
        #endregion

        #region constructors
        public Vehiculo() { }
        public Vehiculo(string placa, string marca, string modelo, string anio, string kilometraje)
        {
            Placa = placa;
            Marca = marca;
            Modelo = modelo;
            Anio = anio;
            Kilometraje = kilometraje;
        }
        #endregion
    }
}
