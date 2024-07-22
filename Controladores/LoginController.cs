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
        public List<MAuthorization> Ingresar(string username, string password)
        {
            try
            {
                //Crea la lista que devolvera al final.
                List<MAuthorization> list = new List<MAuthorization>();

                //El query con su procedimiento y sus parametros.
                string Query = "Exec GetInto @User, @password";
                SqlCommand cmd = new SqlCommand(Query, conex);
                cmd.Parameters.AddWithValue("@User", username);
                cmd.Parameters.AddWithValue("@password", password);

                //Se abre la conexion.
                conex.Open();
                //El lector.
                SqlDataReader lector = cmd.ExecuteReader();

                //En caso que la cantidad de columnas devueltas sea menor a tres me causara un error.
                //Se supone que esto se hace solo en el procedimiento almacenado pero por algun motivo el error desde haya no se me ejecuta.
                if(lector.FieldCount < 3)
                {
                    throw new Exception("Ese usuario no existe o no tiene autorizaciones para el sistema.");
                }

                //Si no hay error y el lector lee.
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
                //Me retorna la lista.
                return list;
            }
            catch(Exception ex)
            {
                //Si la conexion no esta cerrada la cierra.
                if (conex.State != System.Data.ConnectionState.Closed)
                {
                    conex.Close();
                }
                //El mensaje de error.
                MessageBox.Show(ex.Message);
                //Debe retornar algo.
                return null;
            }
            
        }

        //Esto se borrara luego de la demostracion
        public string Ingresar(string username, string password, int? y = null)
        {
            string Query = "select _Department from Employees E inner join Users U on U.EmployeeId = E.IdEmployee inner join Departments D on D.IdDepartment = E.DepartmentId where _User = @user and _Password = @pass;";
            SqlCommand cmd = new SqlCommand(Query, conex);
            cmd.Parameters.AddWithValue("@user", username);
            cmd.Parameters.AddWithValue("@pass", password);
            string departamento = null;
            conex.Open();
            SqlDataReader lector = cmd.ExecuteReader();
            if (lector.Read())
            {
                departamento = lector.GetString(0);
            }
            conex.Close();
            return departamento;
        }
    }
}
