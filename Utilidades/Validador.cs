using System;
using System.Numerics;
using System.Reflection;
using System.Text.RegularExpressions;

namespace POE_proyecto.Utilidades
{
    /// <summary>
    /// Proporciona métodos para validar varios campos de entrada.
    /// </summary>
    public static class Validador
    {
        #region Métodos publicos
        /// <summary>
        /// Valida los campos proporcionados del cliente.
        /// </summary>
        /// <returns>
        /// <c>true</c> si todos los campos son válidos; de lo contrario, <c>false</c>.
        /// </returns>
        public static bool ValidarCamposCliente(string cedula, string correo, string numeroTelefono, string nombres, string apellidos, string direccion, DateTime fechaNacimiento)
        {
            return ValidarCedula(cedula) && ValidarCorreo(correo) && ValidarTelefono(numeroTelefono) &&
                   ValidarNombres(nombres) && ValidarNombres(apellidos) && ValidarCadena(direccion) && ValidarFechaNacimiento(fechaNacimiento);
        }

        /// <summary>
        /// Valida los campos proporcionados del vehículo.
        /// </summary>
        /// <returns>
        /// <c>true</c> si todos los campos son válidos; de lo contrario, <c>false</c>.
        /// </returns>
        public static bool ValidarCamposVehiculo(string placa, string marca, string modelo, string anio, string kilometraje)
        {
            return ValidarPlaca(placa) && ValidarCadena(marca) && ValidarCadena(modelo) && ValidarAnio(anio) && ValidarKilometraje(kilometraje);
        }

        /// <summary>
        /// Valida los campos proporcionados del mecánico.
        /// </summary>
        /// <returns>
        /// <c>true</c> si todos los campos son válidos; de lo contrario, <c>false</c>.
        /// </returns>
        public static bool ValidarCamposMecanico(string cedula, string nombres, string apellidos, string direccion, string correo, string numeroTelefono
                , DateTime fechaNacimiento, string especialidad, string nivelDeExperiencia)
        {
            return ValidarCedula(cedula) && ValidarNombres(nombres) && ValidarNombres(apellidos) && ValidarCadena(direccion) && ValidarCorreo(correo) && 
                   ValidarTelefono(numeroTelefono) && ValidarFechaNacimiento(fechaNacimiento) && ValidarCadena(especialidad) && ValidarNivelDeExperiencia(nivelDeExperiencia);
        }

        /// <summary>
        /// Valida los campos proporcionados del mantenimiento.
        /// </summary>
        /// <returns>
        /// <c></c> si todos los campos son válidos; de lo contrario, <c>false</c>.
        /// </returns>
        public static bool ValidarCamposMantenimiento(DateTime fechaMantenimiento, string diagnostico, string trabajosRealizados)
        {
            return ValidarFechaNacimiento(fechaMantenimiento) && ValidarCadena(diagnostico) && ValidarCadena(trabajosRealizados);
        }

        /// <summary>
        /// Valida el formato de una cédula (número de identificación).
        /// </summary>
        /// <returns>
        /// <c>true</c> si el número de identificación es válido; de lo contrario, <c>false</c>.
        /// </returns>
        public static bool ValidarCedula(string cedula)
        {
            var regex = new Regex(@"^\d{10}$");
            return regex.IsMatch(cedula);
        }

        /// <summary>
        /// Valida el formato de un código de mantenimiento.
        /// </summary>
        /// <returns>
        /// <c>true</c> si el código de mantenimiento es válido; de lo contrario, <c>false</c>.
        /// </returns>
        public static bool ValidarCodigoMantenimiento(string codigoMantenimiento)
        {
            var regex = new Regex(@"^M\d+$");
            return regex.IsMatch(codigoMantenimiento);
        }

        /// <summary>
        /// Validar el formato de un id de servicio.
        /// </summary>
        /// <returns>
        /// <c>true</c> si el id de servicio es válido; de lo contrario, <c>false</c>.
        /// </returns>
        public static bool ValidarIdServicio(int id)
        {
            return id > 0 && id < 100;
        }

        /// <summary>
        /// Validar los campos proporcionados del servicio.
        /// </summary>
        /// <returns>   
        /// <c>true</c> si todos los campos son válidos; de lo contrario, <c>false</c>.
        /// </returns>
        public static bool ValidarCamposServicio(string nombre, float precio, string descripcion)
        {
            return ValidarCadena(nombre) && precio > 0.00 && ValidarCadena(descripcion);
        }

        /// <summary>
        /// Validar los campos proporcionados del cliente.
        /// </summary>
        /// <returns>
        /// <c>true</c> si todos los campos son válidos; de lo contrario, <c>false</c>.
        /// </returns>
        public static bool ValidarCamposEmpleado(string cedula, string correo, string numeroTelefono, string nombres, string apellidos, string direccion, DateTime fechaNacimiento)
        {
            return ValidarCedula(cedula) && ValidarCorreo(correo) && ValidarTelefono(numeroTelefono) &&
                   ValidarNombres(nombres) && ValidarNombres(apellidos) && ValidarCadena(direccion) && ValidarFechaNacimiento(fechaNacimiento);
        }
        #endregion

        #region Métodos privados
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
        /// Valida si la cadena ingresada no está vacía.
        /// </summary>
        /// <returns>
        /// <c>true</c> si la cadena no está vacía; de lo contrario, <c>false</c>.
        /// </returns>
        public static bool ValidarCadena(string cadena)
        {
            return !string.IsNullOrEmpty(cadena);
        }

        /// <summary>
        /// Valida la fecha de nacimiento, asegurándose de que no sea una fecha futura.
        /// <c>true</c> si la fecha de nacimiento es válida; de lo contrario, <c>false</c>.
        /// </returns>
        public static bool ValidarFechaNacimiento(DateTime fechaNacimiento)
        {
            return fechaNacimiento <= DateTime.Now;
        }

        /// <summary>
        /// Valida el formato de una placa de vehículo.
        /// </summary>
        /// <returns>
        /// <c>true</c> si la placa es válida; de lo contrario, <c>false</c>.
        /// </returns>
        public static bool ValidarPlaca(string placa)
        {
            var regex = new Regex(@"^[A-Z]{3}-\d{4}$");
            return regex.IsMatch(placa);
        }

        /// <summary>
        /// Valida el formato de un año de vehículo.
        /// </summary>
        /// <returns>
        /// <c>true</c> si el año es válido; de lo contrario, <c>false</c>.
        /// </returns>
        public static bool ValidarAnio(string anio)
        {
            var regex = new Regex(@"^\d{4}$");
            return regex.IsMatch(anio);
        }

        /// <summary>
        /// Valida el formato de un kilometraje de vehículo.
        /// </summary> 
        /// <returns>
        /// <c>true</c> si el kilometraje es válido; de lo contrario, <c>false</c>.
        /// </returns>
        public static bool ValidarKilometraje(string kilometraje)
        {
            return BigInteger.TryParse(kilometraje, out _);
        }

        /// <summary>
        /// Valida que el nivel de experiencia sea uno de los valores permitidos.
        /// </summary>
        /// <returns>
        /// <c>true</c> si el nivel de experiencia es válido; de lo contrario, <c>false</c>.
        /// </returns>
        public static bool ValidarNivelDeExperiencia(string nivelDeExperiencia)
        {
            nivelDeExperiencia = nivelDeExperiencia.ToLower();
            return nivelDeExperiencia == "principiante" || nivelDeExperiencia == "intermedio" || nivelDeExperiencia == "avanzado";
        }
        #endregion
    }
}
