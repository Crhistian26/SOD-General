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
        //cadena de conexion y la propia conexion.
        static string cadena = ConfigurationManager.ConnectionStrings["Conex"].ConnectionString;
        SqlConnection conex = new SqlConnection(cadena);

        /// <summary>
        /// La funcion de ingresar que utiliza un procedimiento almacenado para recuperar las autorizaciones
        /// </summary>
        /// <param name="username">Su nombre de usuario</param>
        /// <param name="password">Su contraseña</param>
        /// <returns>Devuelve una lista de las autorizaciones hecha a base de la clase <seealso cref="MAuthorization"/></returns>
        public (List<MAuthorization>,string) Ingresar(string username, string password)
        {
            try
            {
                //Crea la lista que devolvera al final.
                List<MAuthorization> list = new List<MAuthorization>();
                string department ="";
                //El query con su procedimiento y sus parametros.
                string Query = "Exec GetAuthorizations @User, @password";
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
                    int id = lector.GetInt32(0);
                    string Autorizacion = lector.GetString(1);
                    string TipoAutorizacion = lector.GetString(2);

                    //Creacion de objeto autorizacion.
                    MAuthorization autorizacion = new MAuthorization(id, Autorizacion, TipoAutorizacion);

                    //Lo agrega a la lista.
                    list.Add(autorizacion);
                }
                //La conexion se cierra.
                conex.Close();


                Query = "select _Department from Users U\r\ninner join Employees E on E.IdEmployee = U.EmployeeId\r\ninner join Departments D on D.IdDepartment = E.DepartmentId\r\nwhere _User =@user and _Password=@pass;";
                cmd = new SqlCommand(Query, conex);
                cmd.Parameters.AddWithValue("@user", username);
                cmd.Parameters.AddWithValue("@pass", password);

                conex.Open();
                lector = cmd.ExecuteReader();
                if(lector.Read())
                {
                    department = lector.GetString(0);
                }
                conex.Close();
                //Me retorna la lista y el departamento.
                return (list,department);
            }
            catch(SqlException ex)
            {
                //Si la conexion no esta cerrada la cierra.
                if (conex.State != System.Data.ConnectionState.Closed)
                {
                    conex.Close();
                }
                //El mensaje de error de Sql en caso de no existir el usuario.
                MessageBox.Show(ex.Message);
                //Debe retornar algo.
                return (null,null);
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
                return (null, null);
            }
            
        } 
    }
}
