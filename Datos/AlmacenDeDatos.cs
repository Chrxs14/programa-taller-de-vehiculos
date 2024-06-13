using POE_proyecto.Modelo;
using System.Collections.Generic;

namespace POE_proyecto.Datos
{
    public static class AlmacenDeDatos
    {
        private static readonly Dictionary<int, Cliente> clientes = new Dictionary<int, Cliente>();
        private static readonly Dictionary<int, Mecanico> mecanicos = new Dictionary<int, Mecanico>();
        private static readonly Dictionary<int, Mantenimiento> mantenimientos = new Dictionary<int, Mantenimiento>();

        public static IReadOnlyDictionary<int, Cliente> Clientes => clientes;
        public static IReadOnlyDictionary<int, Mecanico> Mecanicos => mecanicos;
        public static IReadOnlyDictionary<int, Mantenimiento> Mantenimientos => mantenimientos;

        public static void AgregarCliente(int codigoCliente, Cliente cliente)
        {
            clientes[codigoCliente] = cliente;
        }

        public static void AgregarMecanico(int codigoMecanico, Mecanico mecanico)
        {
            mecanicos[codigoMecanico] = mecanico;
        }

        public static void AgregarMantenimiento(int codigoMantenimiento, Mantenimiento mantenimiento)
        {
            mantenimientos[codigoMantenimiento] = mantenimiento;
        }
    }
}