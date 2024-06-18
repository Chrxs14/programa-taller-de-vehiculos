using POE_proyecto.Modelo;
using System.Collections.Generic;

namespace POE_proyecto.Datos
{
    public static class AlmacenDeDatos
    {
        private static readonly List<Cliente> Clientes = new();
        //private static readonly List<Mecanico> Mecanicos = new();
        private static readonly List<Mantenimiento> Mantenimientos = new();
        private static readonly List<Vehiculo> Vehiculos = new();
        private static readonly List<Empleado> Empleados = new();
        private static readonly List<Servicio> Servicios = new();
        public static IReadOnlyList<Cliente> ClientesList => Clientes.AsReadOnly();
        //public static IReadOnlyList<Mecanico> MecanicosList => Mecanicos.AsReadOnly();
        public static IReadOnlyList<Mantenimiento> MantenimientosList => Mantenimientos.AsReadOnly();
        public static IReadOnlyList<Vehiculo> VehiculosList => Vehiculos.AsReadOnly();
        public static IReadOnlyList<Empleado> EmpleadosList => Empleados.AsReadOnly();
        public static IReadOnlyList<Servicio> ServiciosList => Servicios.AsReadOnly();

        public static void AgregarCliente(Cliente cliente)
        {
            Clientes.Add(cliente);
        }
      
        //public static void AgregarMecanico(Mecanico mecanico)
        //{
        //    Mecanicos.Add(mecanico);
        //}

        public static void AgregarMantenimiento(Mantenimiento mantenimiento)
        {
            Mantenimientos.Add(mantenimiento);
        }

        public static void AgregarVehiculo(Vehiculo vehiculo)
        {
            Vehiculos.Add(vehiculo);
        }

        public static void AgregarEmpleado(Empleado empleado)
        {
            Empleados.Add(empleado);
        }

        public static void AgregarServicio(Servicio servicio)
        {
            Servicios.Add(servicio);
        }

        public static Cliente BuscarCliente(string cedula)
        {
            return Clientes.FirstOrDefault(c => c.Cedula == cedula);
        }

        //public static Mecanico BuscarMecanico(string cedula)
        //{
        //    return Mecanicos.FirstOrDefault(m => m.Cedula == cedula);
        //}

        public static Vehiculo BuscarVehiculo(string placa)
        {
            return Vehiculos.FirstOrDefault(v => v.Placa == placa);
        }

        public static Mantenimiento BuscarMantenimiento(string codigo)
        {
            return Mantenimientos.FirstOrDefault(m => m.Codigo == codigo);
        }

        public static Empleado BuscarEmpleado(string cedula)
        {
            return Empleados.FirstOrDefault(e => e.Cedula == cedula);
        }

        public static Servicio BuscarServicio(int codigo)
        {
            return Servicios.FirstOrDefault(s => s.Codigo == codigo);
        }

        public static void ModificarCliente(string cedula, Cliente cliente)
        {
            int index = Clientes.FindIndex(c => c.Cedula == cedula);
            if (index != -1)
            {
                Clientes[index] = cliente;
            }
            else
            {
                throw new KeyNotFoundException($"No se encontró un cliente con la cédula {cedula}");
            }
        }

        //public static void ModificarMecanico(string cedula, Mecanico mecanico)
        //{
        //    int index = Mecanicos.FindIndex(m => m.Cedula == cedula);
        //    if (index != -1)
        //    {
        //        Mecanicos[index] = mecanico;
        //    }
        //    else
        //    {
        //        throw new KeyNotFoundException($"No se encontró un mecánico con la cédula {cedula}");
        //    }
        //}

        public static void ModificarVehiculo(string placa, Vehiculo vehiculo)
        {
            int index = Vehiculos.FindIndex(v => v.Placa == placa);
            if (index != -1)
            {
                Vehiculos[index] = vehiculo;
            }
            else
            {
                throw new KeyNotFoundException($"No se encontró un vehículo con la placa {placa}");
            }
        }

        public static void ModificarMantenimiento(string codigo, Mantenimiento mantenimiento)
        {
            int index = Mantenimientos.FindIndex(m => m.Codigo == codigo);
            if (index != -1)
            {
                Mantenimientos[index] = mantenimiento;
            }
            else
            {
                throw new KeyNotFoundException($"No se encontró un mantenimiento con el código {codigo}");
            }
        }

        public static void ModificarEmpleado(string cedula, Empleado empleado)
        {
            int index = Empleados.FindIndex(e => e.Cedula == cedula);
            if (index != -1)
            {
                Empleados[index] = empleado;
            }
            else
            {
                throw new KeyNotFoundException($"No se encontró un empleado con la cédula {cedula}");
            }
        }

        public static void ModificarServicio(int codigo, Servicio servicio)
        {
            int index = Servicios.FindIndex(s => s.Codigo == codigo);
            if (index != -1)
            {
                Servicios[index] = servicio;
            }
            else
            {
                throw new KeyNotFoundException($"No se encontró un servicio con el código {codigo}");
            }
        }    
    }
}
