
using Modelos.Usuarios_Empleados;
using Modelos.Usuarios_Empleados.Control_de_usuario;
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
        //cadena de conexion y la propia conexion.
        static string cadena = ConfigurationManager.ConnectionStrings["Conex"].ConnectionString;
        SqlConnection conex = new SqlConnection(cadena);

        /// <summary>
        /// La funcion de ingresar que utiliza un procedimiento almacenado para recuperar las autorizaciones
        /// </summary>
        /// <param name="username">Su nombre de usuario</param>
        /// <param name="password">Su contraseña</param>
        /// <returns>Devuelve una lista de las autorizaciones hecha a base de la clase <seealso cref="MAuthorization"/></returns>
        public List<C_Operation> Ingresar(string username, string password)
        {
            try
            {
                //Crea la lista que devolvera al final.
                List<C_Operation> list = new List<C_Operation>();
                //El query con su procedimiento y sus parametros.
                string Query = "Exec Get_Operations @User, @password";
                SqlCommand cmd = new SqlCommand(Query, conex);
                cmd.Parameters.AddWithValue("@User", username);
                cmd.Parameters.AddWithValue("@password", password);

                //Se abre la conexion.
                conex.Open();
                //El lector.
                SqlDataReader lector = cmd.ExecuteReader();

                while (lector.Read())
                {
                    //Capturar datos.
                    string Modulo = lector.GetString(0);
                    int id = lector.GetInt32(1);
                    string Operacion = lector.GetString(2);
                    
                    //Creacion de objeto autorizacion.
                    C_Operation operacion = new C_Operation(id,Operacion,Modulo);

                    //Lo agrega a la lista.
                    list.Add(operacion);
                }
                //La conexion se cierra.
                conex.Close();

                //Me retorna la lista y el departamento.
                return list;
            }
            catch(SqlException ex)
            {
                //Si la conexion no esta cerrada la cierra.
                if (conex.State != System.Data.ConnectionState.Closed)
                {
                    conex.Close();
                }
                //El mensaje de error de Sql en caso de no existir el usuario.
                Clipboard.SetText(ex.ToString());
                MessageBox.Show(ex.ToString());
                //Debe retornar algo.
                return null;
            }
            catch(Exception ex)
            {
                //Si la conexion no esta cerrada la cierra.
                if (conex.State != System.Data.ConnectionState.Closed)
                {
                    conex.Close();
                }
                //El mensaje de error de C# por si ocurre algo.
                MessageBox.Show(ex.Message);
                //Debe retornar algo.
                return null;
            }
            
        } 
    }
}
