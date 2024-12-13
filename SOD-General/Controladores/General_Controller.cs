using SOD_General.Vistas.Recursos_Humanos.Motivos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using SOD_General.Vistas.Recursos_Humanos.Empleados;
namespace SOD_General.Controladores
{
    public class General_Controller
    {

        private SqlConnection Connection;

        /// <summary>
        /// Esto iniciriara <see cref="General_Controller"/> con la conexion y con las funciones generales a utilizar.
        /// </summary>
        public General_Controller()
        {
            Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Conex"].ConnectionString);
        }

        /// <summary>
        /// Se encarga de retornar la conexion del sistema.
        /// </summary>
        /// <returns></returns>
        public SqlConnection GetConnection()
        {
            return Connection;
        }
        
        /// <summary>
        /// Este metodo se encarga de cerrar un <see cref="Form"/> secundario del programa.
        /// </summary>
        /// <param name="formulario">Este es el formulario a cerrar.</param>
        public void CloseForm(Form formulario)
        {
            var windows = Application.OpenForms.OfType<Form>().Where(f => f.GetType() == formulario.GetType()).ToList();

            if (windows.Count > 1)
            {
                var window = windows.First();
                window.Close();
            }
        }

        /// <summary>
        /// Este metodo se encarga de verificar la conexion y cerrarla en caso de haber un error.
        /// </summary>
        /// <param name="conex"></param>
        public void ChechekConnection(SqlConnection conex)
        {
            if (conex.State != System.Data.ConnectionState.Closed)
            {
                conex.Close();
            }
        }

        public void ResetForm(Form formulario)
        {
            var windows = Application.OpenForms.OfType<Form>().Where(f => f.GetType() == formulario.GetType()).First();

            if (windows is IResetForm window)
            {
                window.Reset();
            }
        }

        public Form GetForm(Form formulario)
        {
            var windows = Application.OpenForms.OfType<Form>().Where(f => f.GetType() == formulario.GetType()).First();
            return windows;
        }

    }
}
