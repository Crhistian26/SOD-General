using Modelos.AsistenciasYPermisos;
using Modelos.Usuarios_Empleados;
using SOD_General.Vistas.Recursos_Humanos.Registros;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SOD_General.Controladores
{
    public class Registros_Controller
    {
        //La cadena de conexion
        static string cadena = ConfigurationManager.ConnectionStrings["Conex"].ConnectionString;
        SqlConnection conex = new SqlConnection(cadena);

        #region Asistencias
        public void AgregarAsistencia()
        {
            Control_Asistencias vista = new Control_Asistencias();
            vista.Show();
        }

        public List<Record_Attendance> Obtener_Asistencias()
        {
            try
            {
                List<Record_Attendance> diccionario = new List<Record_Attendance>();
                Record_Attendance record;
                //El query.
                string Query = "exec Get_All_Attendances";
                //La consulta
                SqlCommand cmd = new SqlCommand(Query, conex);

                //El proceso
                conex.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int IdRecord = reader.GetInt32(0);
                    int IdEmployee = reader.GetInt32(1);
                    string Name = reader.GetString(2) + " " + reader.GetString(3);
                    TimeSpan entry = reader.GetTimeSpan(4);
                    TimeSpan exit = reader.GetTimeSpan(5);
                    TimeSpan lunchS = reader.GetTimeSpan(6);
                    TimeSpan lunchF = reader.GetTimeSpan(7);
                    DateTime record_Date = reader.GetDateTime(8);

                    record = new Record_Attendance(IdRecord, IdEmployee,Name, entry, exit, lunchS, lunchF, record_Date);
                    diccionario.Add(record);
                }
                conex.Close();
                return diccionario;
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
        #endregion

        #region Permisos
        public void AgregarPermiso()
        {
            Control_Permisos vista = new Control_Permisos();
            vista.Show();
        }

        public List<Record_Permission> Obtener_Permisos()
        {
            try
            {
                List<Record_Permission> permisos = new List<Record_Permission>();
                Record_Permission record;
                //El query.
                string Query = "exec Get_All_Permission";
                //La consulta
                SqlCommand cmd = new SqlCommand(Query, conex);

                //El proceso
                conex.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int IdRecord = reader.GetInt32(0);
                    string Name = reader.GetString(1);
                    string Reason = reader.GetString(2);
                    int Count = reader.GetInt32(3);
                    string Mesure = reader.GetString(4);
                    DateTime record_Date = reader.GetDateTime(5);

                    record = new Record_Permission(IdRecord,Name,Reason,Count,Mesure, record_Date);
                    permisos.Add(record);
                }
                conex.Close();

                
                return permisos;
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

        #endregion

        public List<Employee> Obtener_Empleados()
        {
            try
            {
                //La lista a retornar.
                List<Employee> empleados = new List<Employee>();
                //El query.
                string Query = "select IdEmployee,_Name,_Lastname from Employees order by _Name;";
                //La consulta
                SqlCommand cmd = new SqlCommand(Query, conex);

                //El proceso
                conex.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string name = reader.GetString(1);
                    string lastname = reader.GetString(2);

                    Employee emp = new Employee(id, name, lastname);
                    empleados.Add(emp);
                }
                conex.Close();
                return empleados;
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

        public List<Department> Obtener_Departamentos()
        {
            try
            {
                //La lista a retornar.
                List<Department> departamentos = new List<Department>();
                //El query.
                string Query = "select IdDeparment,_Department from Departments order by IdDeparment;";
                //La consulta
                SqlCommand cmd = new SqlCommand(Query, conex);

                //El proceso
                conex.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string depart = reader.GetString(1);

                    Department depa = new Department(id, depart);
                    departamentos.Add(depa);
                }
                conex.Close();
                return departamentos;
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

        public List<Model_Reason> Obtener_Razones()
        {
            try
            {
                //La lista a retornar.
                List<Model_Reason> razones = new List<Model_Reason>();
                //El query.
                string Query = "select IdReason,_Reason from Departments order by IdReason;";
                //La consulta
                SqlCommand cmd = new SqlCommand(Query, conex);

                //El proceso
                conex.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string reason = reader.GetString(1);

                    Model_Reason rea = new Model_Reason(id, reason);
                    razones.Add(rea);
                }
                conex.Close();
                return razones;
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
