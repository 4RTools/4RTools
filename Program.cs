using System;
namespace _4RTools
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            // Application app = new Application();
            // app.IsMdiContainer = true;

            Forms.Container app = new Forms.Container();
            System.Windows.Forms.Application.Run(app);
        }
    }
}
