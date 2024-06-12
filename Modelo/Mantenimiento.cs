namespace POE_proyecto.Modelo
{
    internal class Mantenimiento
    {
        #region fields
        public int Codigo { get; set; }
        public Cliente Cliente { get; set; }
        public Mecanico Mecanico { get; set; }
        public DateTime FechaMantenimiento { get; set; }
        public Vehiculo Vehiculo { get; set; }
        public string Diagnostico { get; set; }
        public string TrabajosRealizados { get; set; }
        public bool EsCorrectivo { get; set; }
        public List<Servicio> ListaServiciosRealizados { get; set; }
        #endregion

        #region constructors
        public Mantenimiento()
        {
            ListaServiciosRealizados = new List<Servicio>();
        }
        public Mantenimiento(int codigo, Cliente cliente, Mecanico mecanico, DateTime fechaMantenimiento, Vehiculo vehiculo, string diagnostico, string trabajosRealizados, bool esCorrectivo, List<Servicio> listaServiciosRealizados)
        {
            Codigo = codigo;
            Cliente = cliente;
            Mecanico = mecanico;
            FechaMantenimiento = fechaMantenimiento;
            Vehiculo = vehiculo;
            Diagnostico = diagnostico;
            TrabajosRealizados = trabajosRealizados;
            EsCorrectivo = esCorrectivo;
            ListaServiciosRealizados = listaServiciosRealizados ?? new List<Servicio>();
        }
        #endregion
    }
}