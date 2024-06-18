using POE_proyecto.Datos;
using POE_proyecto.Modelo;

namespace POE_proyecto.Controlador
{
    public class CtlPrincipal
    {
        #region fields
        private readonly CtlCliente ctlCliente;
        private readonly CtlMecanico ctlMecanico;
        private readonly CtlMantenimiento ctlMantenimiento;
        private readonly CtlVehiculo ctlVehiculo;
        private readonly CtlServicio ctlServicio;
        private readonly CtlEmpleado ctlEmpleado;
        #endregion

        #region constructors
        public CtlPrincipal()
        {
            agregarDatosQuemados();
            ctlCliente = new();
            ctlMecanico = new();
            ctlMantenimiento = new();
            ctlVehiculo = new();
            ctlServicio = new();
            ctlEmpleado = new();
        }
        #endregion

        #region Properties
        public CtlCliente CtlCliente { get { return ctlCliente; } }
        public CtlMecanico CtlMecanico { get { return ctlMecanico; } }
        public CtlMantenimiento CtlMantenimiento { get { return ctlMantenimiento; } }
        public CtlVehiculo CtlVehiculo { get { return ctlVehiculo; } }
        public CtlServicio CtlServicio { get { return ctlServicio; } }
        public CtlEmpleado CtlEmpleado { get { return ctlEmpleado; } }
        #endregion

        public void agregarDatosQuemados()
        {
            // Servicios
            ctlServicio.AgregarServicio("Lavado exterior", 30.0f, "Lavado exterior del vehículo");
            ctlServicio.AgregarServicio("Lavado interior", 40.0f, "Limpieza interior del vehículo");
            ctlServicio.AgregarServicio("Encerado", 50.0f, "Encerado para protección de la pintura");
            ctlServicio.AgregarServicio("Aspirado de interiores", 25.0f, "Aspirado y limpieza de alfombras y asientos");
            ctlServicio.AgregarServicio("Pulido de faros", 20.0f, "Pulido y restauración de faros delanteros");

            // Clientes
            ctlCliente.AgregarCliente("1010101010", "Juan", "Perez", "Av. Principal 123", "juan@example.com", "555-1234", new DateTime(1985, 3, 12), "Referencia Cliente 1");
            ctlCliente.AgregarCliente("2020202020", "María", "Gómez", "Calle Secundaria 456", "maria@example.com", "555-5678", new DateTime(1990, 7, 21), "Referencia Cliente 2");
            ctlCliente.AgregarCliente("3030303030", "Pedro", "Ramírez", "Calle Central 789", "pedro@example.com", "555-4567", new DateTime(1983, 9, 15), "Referencia Cliente 3");
            ctlCliente.AgregarCliente("4040404040", "Ana", "Sánchez", "Av. Libertad 567", "ana@example.com", "555-7890", new DateTime(1987, 5, 8), "Referencia Cliente 4");
            ctlCliente.AgregarCliente("5050505050", "Luisa", "Martínez", "Av. Norte 890", "luisa@example.com", "555-2345", new DateTime(1984, 11, 20), "Referencia Cliente 5");

            // Vehiculos
            ctlVehiculo.AgregarVehiculo("ABC123", "Toyota", "Corolla", "2020", "55000 km");
            ctlVehiculo.AgregarVehiculo("XYZ789", "Honda", "Civic", "2018", "72000 km");
            ctlVehiculo.AgregarVehiculo("DEF456", "Ford", "Fiesta", "2019", "40000 km");
            ctlVehiculo.AgregarVehiculo("GHI789", "Chevrolet", "Spark", "2021", "25000 km");
            ctlVehiculo.AgregarVehiculo("JKL012", "Nissan", "Sentra", "2017", "80000 km");

            // Empleados
            ctlEmpleado.AgregarEmpleado("6060606060", "Roberto", "López", "Calle Sur 789", "roberto@example.com", "555-6789", new DateTime(1982, 7, 18));
            ctlEmpleado.AgregarEmpleado("7070707070", "Carlos", "Martínez", "Av. Principal 456", "carlos@example.com", "555-7890", new DateTime(1980, 4, 12));
            ctlEmpleado.AgregarEmpleado("8080808080", "Sofía", "González", "Calle Este 234", "sofia@example.com", "555-3456", new DateTime(1986, 8, 25));
            ctlMecanico.AgregarMecanico("9090909090", "Javier", "Hernández", "Av. Oeste 678", "javier@example.com", "555-9012", new DateTime(1981, 12, 8), "Electricidad automotriz", "Experto");
            ctlMecanico.AgregarMecanico("1010101010", "Laura", "Sánchez", "Av. Central 789", "laura@example.com", "555-5678", new DateTime(1984, 10, 10), "Transmisión automática", "Especialista");

            // Mantenimientos
            ctlMantenimiento.AgregarMantenimiento(ctlCliente.ObtenerClienteByCedula("4040404040"), ctlMecanico.ObtenerMecanicoByCedula("9090909090"), new DateTime(2024, 6, 10), ctlVehiculo.ObtenerVehiculoByPlaca("GHI789"),
                "El vehículo presenta problemas de arranque intermitente. Se diagnosticó un fallo en el sistema de ignición.",
                "Se procedió a revisar y limpiar los conectores de la batería, así como a ajustar los cables de la bujía. Se realizó prueba de arranque y se verificó el correcto funcionamiento.",
                true,
                new List<Servicio> { ctlServicio.ObtenerServicioById(6) });

            ctlMantenimiento.AgregarMantenimiento(ctlCliente.ObtenerClienteByCedula("5050505050"), ctlMecanico.ObtenerMecanicoByCedula("9090909090"), new DateTime(2024, 6, 12), ctlVehiculo.ObtenerVehiculoByPlaca("JKL012"),
                "El vehículo presenta vibraciones al frenar a alta velocidad. Se sospecha desbalanceo de los discos de freno.",
                "Se desmontaron los discos de freno delanteros y traseros para su inspección. Se procedió al balanceo de los discos y a la reinstalación. Prueba de frenado realizada con éxito.",
                true,
                new List<Servicio> { ctlServicio.ObtenerServicioById(7), ctlServicio.ObtenerServicioById(8) });

            ctlMantenimiento.AgregarMantenimiento(ctlCliente.ObtenerClienteByCedula("1010101010"), ctlMecanico.ObtenerMecanicoByCedula("1010101010"), new DateTime(2024, 6, 15), ctlVehiculo.ObtenerVehiculoByPlaca("ABC122"),
                "El vehículo presenta pérdida de potencia al acelerar. Se diagnosticó un problema en el sistema de inyección de combustible.",
                "Se procedió a limpiar los inyectores y a realizar una prueba de presión en el sistema de combustible. Se verificó el correcto funcionamiento y se restableció la potencia del motor.",
                true,
                new List<Servicio> { ctlServicio.ObtenerServicioById(9), ctlServicio.ObtenerServicioById(10) });
        }
    }
}
