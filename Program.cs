using POE_proyecto.Controlador;
using POE_proyecto.Modelo;
using POE_proyecto.Vista;

namespace POE_proyecto
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // Renderizado de texto con GDI o GDI+ (Graphics Device Interface) al estar en falso usa GDI+
            // para renderizar el texto en windows forms

            Application.SetCompatibleTextRenderingDefault(false);

            // Habilita los estilos visuales en la app
            Application.EnableVisualStyles();

            //Metodo para inicializar la configuración de la app
            ApplicationConfiguration.Initialize();

            CtlPrincipal ctlPrincipal = new();

            // En .NETCore 8 se pueden inicializar objetos de esta manera
            FrmPrincipal frmPrincipal = new(ctlPrincipal);

            // Se muestra el frmPrincipal. Es un bucle de mensajes que funciona como nucleo de la app
            Application.Run(frmPrincipal);
        }
    }
}