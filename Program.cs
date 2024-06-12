using POE_proyecto.Vista;

namespace POE_proyecto
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            // TOCARA INVESTIGAR MEJOR ESTO, POR QUE NI IDEA POR QUE SE NECESITAN SETEAR ESTOS METODOS PRIMERO (Se saca y se rompe todo jaja)
            // ESTOS COMENTARIOS HAY QUE BORRARLOS JAJA, SABES QUE ME DA COSA HACER TODO ESTO PARA QUE LUEGO VAYAMOS A HACER DIFERENTE, TIPO USAR ASP.NET AUNQUE NOSEEE
            // LIT ES ALGO QUE RECOMENDARIA ANGELITO, PERO TOCARIA INVESTICAR BIEN QUE CHCH ES PRIMERO
            Application.SetCompatibleTextRenderingDefault(false);
            Application.EnableVisualStyles();
            ApplicationConfiguration.Initialize();

            // En .NETCore 8 se pueden inicializar objetos de esta manera
            FrmPrincipal frmPrincipal = new();
            Application.Run(frmPrincipal);
        }
    }
}