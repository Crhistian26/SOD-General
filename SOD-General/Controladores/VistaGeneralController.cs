using Modelos.Usuarios_Empleados;
using SOD_General;
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

        AppVistaGeneral vista;

        public VistaGeneralController(AppVistaGeneral vista)
        {
            this.vista = vista;
        }

        public void Comprobar_Autorizaciones()
        {
            ToolStripMenuItem item = new ToolStripMenuItem();
            item.Text = vista.Departamento;
            item.Click += new EventHandler(Hola);
            
        }

        //Esta parte de aca se borrara luego de la demostracion
        public void Hola(object sender, EventArgs e)
        {
            MessageBox.Show("Hola");
        }
    }
}
