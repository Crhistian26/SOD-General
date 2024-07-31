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
            SqlCommand  cmd = new SqlCommand(Query);
            cmd.Parameters.AddWithValue("@IdEmpleado", id);
            conex.Open();
            SqlDataReader lector = cmd.ExecuteReader();
            while(lector.Read())
            {
                int IdRecord = lector.GetInt32(0);
                int IdEmployee = lector.GetInt32(1);
                DateTime entry = lector.GetDateTime(2);
                DateTime exit = lector.GetDateTime(3);
                DateTime lunchS = lector.GetDateTime(4);
                DateTime lunchF = lector.GetDateTime(5);
                DateTime record_Date = lector.GetDateTime(6);

                record = new Record_Attendance(IdRecord,IdEmployee,entry,exit,lunchS,lunchF,record_Date);
                diccionario.Add(record_Date, record);
            }
            return diccionario;
        }

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
