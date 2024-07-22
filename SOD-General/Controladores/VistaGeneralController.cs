using Modelos.Usuarios_Empleados;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controladores
{
    public class VistaGeneralController
    {
        
        //cadena de conexion y la propia conexion.
        static string cadena = ConfigurationManager.ConnectionStrings["Conex"].ConnectionString;
        SqlConnection conex = new SqlConnection(cadena);

        public ToolStripMenuItem Comprobar_Autorizaciones(MenuStrip menu, string departamento)
        {
            ToolStripMenuItem item = new ToolStripMenuItem();
            item.Text = departamento;
            item.Click += new EventHandler(Hola);
            return item;
        }

        //Esta parte de aca se borrara luego de la demostracion
        public void Hola(object sender, EventArgs e)
        {
            MessageBox.Show("Hola");
        }
    }
}
