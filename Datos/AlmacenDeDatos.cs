using POE_proyecto.Modelo;
using System.Collections.Generic;

namespace POE_proyecto.Datos
{
    public static class AlmacenDeDatos
    {
        private static readonly List<Cliente> Clientes = new();
        private static readonly List<Mecanico> Mecanicos = new();
        private static readonly List<Mantenimiento> Mantenimientos = new();
        private static readonly List<Vehiculo> Vehiculos = new();
        public static IReadOnlyList<Cliente> ClientesList => Clientes.AsReadOnly();
        public static IReadOnlyList<Mecanico> MecanicosList => Mecanicos.AsReadOnly();
        public static IReadOnlyList<Mantenimiento> MantenimientosList => Mantenimientos.AsReadOnly();
        public static IReadOnlyList<Vehiculo> VehiculosList => Vehiculos.AsReadOnly();

        public static void AgregarCliente(Cliente cliente)
        {
            Clientes.Add(cliente);
        }

        public static void AgregarMecanico(Mecanico mecanico)
        {
            Mecanicos.Add(mecanico);
        }

        public static void AgregarMantenimiento(Mantenimiento mantenimiento)
        {
            Mantenimientos.Add(mantenimiento);
        }

        public static void AgregarVehiculo(Vehiculo vehiculo)
        {
            Vehiculos.Add(vehiculo);
        }
    }
}