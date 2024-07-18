using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controladores
{
    public class LoginController
    {
       public void conectar()
        {
            string cadena = ConfigurationManager.ConnectionStrings["Conex"].ConnectionString;
            SqlConnection conex = new SqlConnection(cadena);
            MessageBox.Show(conex.State.ToString());
            conex.Open();
            MessageBox.Show(conex.State.ToString());
            conex.Close();
            MessageBox.Show(conex.State.ToString());
        }
    }
}
