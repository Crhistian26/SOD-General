using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladores
{
    internal class VistaGeneralController
    {
        //cadena de conexion y la propia conexion.
        static string cadena = ConfigurationManager.ConnectionStrings["Conex"].ConnectionString;
        SqlConnection conex = new SqlConnection(cadena);

        public void 
    }
}
