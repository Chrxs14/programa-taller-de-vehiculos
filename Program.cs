using POE_proyecto.Vista;

namespace POE_proyecto
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            //var host = IHost.CreateDefaultBuilder().

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            // TOCARA INVESTIGAR MEJOR ESTO, POR QUE NI IDEA POR QUE SE NECESITAN SETEAR ESTOS METODOS PRIMERO (Se saca y se rompe todo jaja)
            // ESTOS COMENTARIOS HAY QUE BORRARLOS JAJA, SABES QUE ME DA COSA HACER TODO ESTO PARA QUE LUEGO VAYAMOS A HACER DIFERENTE, TIPO USAR ASP.NET AUNQUE NOSEEE
            // LIT ES ALGO QUE RECOMENDARIA ANGELITO, PERO TOCARIA INVESTICAR BIEN QUE CHCH ES PRIMERO


            // Renderizado de texto con GDI o GDI+ (Graphics Device Interface) al estar en falso usa GDI+
            // para renderizar el texto en windows forms

            Application.SetCompatibleTextRenderingDefault(false);

            // Habilita los estilos visuales en la app
            Application.EnableVisualStyles();

            //Metodo para inicializar la configuración de la app
            ApplicationConfiguration.Initialize();

            // En .NETCore 8 se pueden inicializar objetos de esta manera
            FrmPrincipal frmPrincipal = new();

            // Se muestra el frmPrincipal. Es un bucle de mensajes que funciona como nucleo de la app
            Application.Run(frmPrincipal);
        }
    }
}