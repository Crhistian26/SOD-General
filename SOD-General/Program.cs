using SOD_General.Recursos_Humanos.Empleados;
using SOD_General.Vistas.Recursos_Humanos.Empleados;
using SOD_General.Vistas.Recursos_Humanos.Registros;
using SOD_General.Vistas_Taller.Taller_Recepcion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
