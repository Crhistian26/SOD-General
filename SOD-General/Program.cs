using SOD_General.Vistas.Taller.Clientes;
using System;
using System.Windows.Forms;

namespace SOD_General
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new VistaPrincipal());
        }
    }
}
