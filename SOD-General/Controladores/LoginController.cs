using Modelos.Control_de_usuarios;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Controladores
{
    public class LoginController
    {
        //cadena de conexion y la propia conexion.
        static string cadena = ConfigurationManager.ConnectionStrings["Conex"].ConnectionString;
        SqlConnection conex = new SqlConnection(cadena);

        /// <summary>
        /// La funcion de ingresar que utiliza un procedimiento almacenado para recuperar las autorizaciones
        /// </summary>
        /// <param name="username">Su nombre de usuario</param>
        /// <param name="password">Su contraseña</param>
        /// <returns>Devuelve una lista de las autorizaciones hecha a base de la clase <seealso cref="MAuthorization"/></returns>
        public Model_User Log_in(string username, string password)
        {
            try
            {
                Model_User user = null;
                Model_Role role;
                List<Model_Operations> operations = new List<Model_Operations>();

                string Query = "Exec Get_Operations @user, @password";
                SqlCommand cmd = new SqlCommand(Query, conex);
                cmd.Parameters.AddWithValue("@user", username);
                cmd.Parameters.AddWithValue("@password", password);

                //Se abre la conexion.
                conex.Open();
                //El lector.
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string module = reader.GetString(0);
                    int id = reader.GetInt32(1);
                    string operation_name = reader.GetString(2);

                    Model_Operations operation = new Model_Operations(id, module, operation_name);

                    operations.Add(operation);
                }

                conex.Close();

                Query = "exec Get_User_Data @user,@password";
                cmd = new SqlCommand(Query, conex);
                cmd.Parameters.AddWithValue("@user", username);
                cmd.Parameters.AddWithValue("@password", password);

                conex.Open();
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    role = new Model_Role(reader.GetInt32(2), reader.GetString(3), operations);
                    user = new Model_User(reader.GetInt32(0), reader.GetInt32(1), role, reader.GetString(4), reader.GetString(5));
                }
                conex.Close();

                return user;

            }
            catch (SqlException ex)
            {
                if (conex.State != System.Data.ConnectionState.Closed)
                {
                    conex.Close();
                }
                MessageBox.Show(ex.Message);
                return null;
            }
            catch (Exception ex)
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
