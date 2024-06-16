using System;
using System.Text.RegularExpressions;

namespace POE_proyecto.Utilidades
{
    /// <summary>
    /// Proporciona métodos para validar varios campos de entrada.
    /// </summary>
    public static class Validador
    {
        /// <summary>
        /// Valida los campos proporcionados del cliente.
        /// </summary>
        /// <returns>
        /// <c>true</c> si todos los campos son válidos; de lo contrario, <c>false</c>.
        /// </returns>
        public static bool CamposCliente(string cedula, string correo, string numeroTelefono, string nombres, string apellidos, string direccion, DateTime fechaNacimiento)
        {
            return ValidarCedula(cedula) && ValidarCorreo(correo) && ValidarTelefono(numeroTelefono) &&
                   ValidarNombres(nombres) && ValidarNombres(apellidos) && ValidarDireccion(direccion) && ValidarFechaNacimiento(fechaNacimiento);
        }


        /// <summary>
        /// Valida el formato de una dirección de correo electrónico.
        /// </summary>
        /// <returns>
        /// <c>true</c> si la dirección de correo electrónico es válida; de lo contrario, <c>false</c>.
        /// </returns>
        private static bool ValidarCorreo(string correo)
        {
            var regex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
            return regex.IsMatch(correo);
        }

        /// <summary>
        /// Valida el formato de una cédula (número de identificación).
        /// </summary>
        /// <returns>
        /// <c>true</c> si el número de identificación es válido; de lo contrario, <c>false</c>.
        /// </returns>
        private static bool ValidarCedula(string cedula)
        {
            var regex = new Regex(@"^\d{10}$");
            return regex.IsMatch(cedula);
        }

        /// <summary>
        /// Valida el formato de un número de teléfono.
        /// </summary>
        /// <returns>
        /// <c>true</c> si el número de teléfono es válido; de lo contrario, <c>false</c>.
        /// </returns>
        private static bool ValidarTelefono(string telefono)
        {
            var regex = new Regex(@"^09\d{8}$");
            return regex.IsMatch(telefono);
        }

        /// <summary>
        /// Valida los nombres, asegurándose de que no estén vacíos y contengan solo letras y espacios.
        /// </summary>
        /// <returns>
        /// <c>true</c> si los nombres son válidos; de lo contrario, <c>false</c>.
        /// </returns>
        public static bool ValidarNombres(string nombres)
        {
            var regex = new Regex(@"^[a-zA-Z\s]+$");
            return !string.IsNullOrEmpty(nombres) && regex.IsMatch(nombres);
        }

        /// <summary>
        /// Valida la dirección, asegurándose de que no esté vacía.
        /// </summary>
        /// <returns>
        /// <c>true</c> si la dirección es válida; de lo contrario, <c>false</c>.
        /// </returns>
        public static bool ValidarDireccion(string direccion)
        {
            return !string.IsNullOrEmpty(direccion);
        }

        /// <summary>
        /// Valida la fecha de nacimiento, asegurándose de que no sea una fecha futura.
        /// <c>true</c> si la fecha de nacimiento es válida; de lo contrario, <c>false</c>.
        /// </returns>
        public static bool ValidarFechaNacimiento(DateTime fechaNacimiento)
        {
            return fechaNacimiento <= DateTime.Now;
        }
    }
}
