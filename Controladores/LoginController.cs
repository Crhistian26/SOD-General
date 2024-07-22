using Modelos.Usuarios_Empleados;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Controladores
{
    public class LoginController
    {
        static string cadena = ConfigurationManager.ConnectionStrings["Conex"].ConnectionString;
        SqlConnection conex = new SqlConnection(cadena);
        public void conectar()
        {
            
            MessageBox.Show(conex.State.ToString());
            conex.Open();
            MessageBox.Show(conex.State.ToString());
            conex.Close();
            MessageBox.Show(conex.State.ToString());
        }

        public List<MAuthorization> Ingresar(string username, string password)
        {
            try
            {
                List<MAuthorization> list = new List<MAuthorization>();
                string Query = "Exec GetInto @User, @password";
                SqlCommand cmd = new SqlCommand(Query, conex);
                cmd.Parameters.AddWithValue("@User", username);
                cmd.Parameters.AddWithValue("@password", password);
                conex.Open();
                SqlDataReader lector = cmd.ExecuteReader();
                if(lector.FieldCount > 2)
                {
                    while (lector.Read())
                    {
                        int id = lector.GetInt32(0);
                        string Autorizacion = lector.GetString(1);
                        string TipoAutorizacion = lector.GetString(2);

                        MAuthorization autorizacion = new MAuthorization(id, Autorizacion, TipoAutorizacion);
                        list.Add(autorizacion);
                    }
                }
                else
                {
                    throw new Exception("Ese usuario no existe o no tiene autorizaciones para el sistema.");
                }
                conex.Close();
                return list;
            }
            catch(Exception ex)
            {
                if (conex.State != System.Data.ConnectionState.Closed)
                {
                    conex.Close();
                }
                MessageBox.Show(ex.Message);
                return null;
            }
            
        }
    }

    
}
