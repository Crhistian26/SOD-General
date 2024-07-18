using Modelos.Usuarios_Empleados;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controladores
{
    public class VistaGeneralController
    {
        static string cadena = ConfigurationManager.ConnectionStrings["Conex"].ConnectionString;
        SqlConnection conex = new SqlConnection(cadena);
        public AppVistaGeneral vista { get; set; }

        public void Permisos(List<MAuthorization> list, MenuStrip menu)
        {
            var items = list.GroupBy(a => a.IdAuthorization)
                .Select(a => a.First())
                .ToList();
        }

        private void PermisoRegistroPeticiones(MAuthorization autorizacion, MenuStrip menu)
        {
            if(autorizacion._Authorization == "Registro Peticiones")
            {
                ToolStripMenuItem principal = new ToolStripMenuItem("Registro Peticiones");

                ToolStripMenuItem item1 = new ToolStripMenuItem("Visualizar Registros");

                item1 += new EventHandler();
            }
        }

    }
}
