using Modelos.Usuarios_Empleados;
using Modelos.AsistenciasYPermisos;
using SOD_General.Vistas.Pruebas;
using SOD_General.Vistas.Recursos_Humanos.Empleados;
using SOD_General.Vistas.Recursos_Humanos.Motivos;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices.WindowsRuntime;

namespace SOD_General.Controladores
{
    internal class Empleados_Controller
    {
        static string cadena = ConfigurationManager.ConnectionStrings["Conex"].ConnectionString;
        SqlConnection conex = new SqlConnection(cadena);


        

        //Area de visual_empleados

        public List<Employee> ListaGeneralEmpleados()
        {
            try
            {
                List<Employee> empleados = new List<Employee>();
                string Query = "Exec Get_Employees";
                SqlCommand cmd = new SqlCommand(Query,conex);
                conex.Open();

                SqlDataReader lector = cmd.ExecuteReader();

                if (lector.FieldCount <= 1)
                {
                    throw new Exception("No hay campos en la base de datos de empleados.");
                }

                while (lector.Read())
                {
                    Employee empleado;
                    int id = lector.GetInt32(0);
                    string name = lector.GetString(1);
                    string lastname = lector.GetString(2);
                    string department = lector.GetString(3);
                    DateTime date = lector.GetDateTime(4);

                    empleado = new Employee(id,name,lastname,department,date);
                    empleados.Add(empleado);
                }
                
                conex.Close();
                return empleados;
            }
            catch (Exception ex)
            {
                if(conex.State != System.Data.ConnectionState.Closed)
                {
                    conex.Close();
                }

                MessageBox.Show(ex.ToString());
                return null;
            }
        }

        public Dictionary<DateTime,Record_Attendance> ListaAsistenciasEmpleado(int id)
        {
            Dictionary<DateTime,Record_Attendance> diccionario = new Dictionary<DateTime, Record_Attendance>();
            Record_Attendance record;
            string Query = "Exec Get_EmployeeAttendance @IdEmpleado";
            SqlCommand  cmd = new SqlCommand(Query,conex);
            cmd.Parameters.AddWithValue("@IdEmpleado", id);

            conex.Open();

            SqlDataReader lector = cmd.ExecuteReader();
            while (lector.Read())
            {
                int IdRecord = lector.GetInt32(0);
                int IdEmployee = lector.GetInt32(1);
                TimeSpan entry = lector.GetTimeSpan(2);
                TimeSpan exit = lector.GetTimeSpan(3);
                TimeSpan lunchS = lector.GetTimeSpan(4);
                TimeSpan lunchF = lector.GetTimeSpan(5);
                DateTime record_Date = lector.GetDateTime(6);

                record = new Record_Attendance(IdRecord, IdEmployee, entry, exit, lunchS, lunchF, record_Date);
                diccionario.Add(record_Date, record);
            }
            conex.Close();
            return diccionario;
        }
        #region Sql server
        public Employee ObtenerEmpleado(int id)
        {
            try
            {
                Employee empleado = null;
                string Query = "exec Get_OneEmployee @Id";

                SqlCommand cmd = new SqlCommand(Query,conex);
                cmd.Parameters.AddWithValue("@Id", id);
                conex.Open();
                SqlDataReader lector = cmd.ExecuteReader();
                if(lector.Read())
                {
                    int IdEmployee = lector.GetInt32(0);
                    string Depart = lector.GetString(2);
                    string Name = lector.GetString(3);
                    string Lastname = lector.GetString(4);
                    DateTime Addmision = lector.GetDateTime(5);

                    empleado = new Employee(IdEmployee, Name, Lastname,Depart, Addmision);
                    conex.Close();
                    
                }

                return empleado;

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
                if(conex.State != System.Data.ConnectionState.Closed)
                {
                    conex.Close();
                }
                MessageBox.Show(ex.Message);
                return null;
            }
            
        }
        #endregion
        public void AbrirEditar()
        {
            AgregarEditar_Empleados hola = new AgregarEditar_Empleados();
            hola.Show();
        }
        public void AbrirEditar(int y)
        {
            AgregarEditar_Empleados hola = new AgregarEditar_Empleados(y);
            hola.Show();
        }
        public void AbrirEditar(string y)
        {
            AgregarEditar_Empleados hola = new AgregarEditar_Empleados(y);
            hola.Show();
        }
    }
}
