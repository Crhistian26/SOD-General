using Modelos.AsistenciasYPermisos;
using Modelos.Usuarios_Empleados;
using SOD_General.Recursos_Humanos.Empleados;
using SOD_General.Vistas.Recursos_Humanos.Empleados;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
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
                SqlCommand cmd = new SqlCommand(Query, conex);
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
                    bool job = lector.GetBoolean(5);

                    empleado = new Employee(id, name, lastname, department, date,job);
                    empleados.Add(empleado);
                }

                conex.Close();
                return empleados;
            }
            catch (Exception ex)
            {
                if (conex.State != System.Data.ConnectionState.Closed)
                {
                    conex.Close();
                }

                MessageBox.Show(ex.ToString());
                return null;
            }
        }
        public List<Record_Attendance> ListaAsistenciasEmpleado(int id)
        {
            List<Record_Attendance> diccionario = new List<Record_Attendance>();
            Record_Attendance record;
            string Query = "Exec Get_EmployeeAttendance @IdEmpleado";
            SqlCommand cmd = new SqlCommand(Query, conex);
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
                diccionario.Add(record);
            }
            conex.Close();
            return diccionario;
        }

        public List<Record_Permission> ListaPermisosEmpleado(int id)
        {
            List<Record_Permission> diccionario = new List<Record_Permission>();
            Record_Permission record;
            string Query = "Exec Get_EmployeePermission @IdEmpleado";
            SqlCommand cmd = new SqlCommand(Query, conex);
            cmd.Parameters.AddWithValue("@IdEmpleado", id);

            conex.Open();

            SqlDataReader lector = cmd.ExecuteReader();
            while (lector.Read())
            {
                int IdRecord = lector.GetInt32(0);
                string Reason = lector.GetString(1);
                string Details = lector.GetString(2);
                int count = lector.GetInt32(3);
                string Mesure = lector.GetString(4);
                DateTime date = lector.GetDateTime(5);

                record = new Record_Permission(IdRecord, Reason,Details,count,Mesure,date);
                diccionario.Add(record);
            }
            conex.Close();
            return diccionario;
        }

        public bool AddEmployee(Employee emp)
        {
            try
            {
                //El query.
                string Query = "Exec Add_Employee @DepartId, @name, @lastname, @Admission_date";
                //La consulta
                SqlCommand cmd = new SqlCommand(Query, conex);
                //Los parametros
                cmd.Parameters.AddWithValue("@DepartId", emp.DepartmentId);
                cmd.Parameters.AddWithValue("@name", emp._Name);
                cmd.Parameters.AddWithValue("@lastname", emp._Lastname);
                cmd.Parameters.AddWithValue("@Admission_date", emp.Admission_date);
                //El proceso
                conex.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                conex.Close();
                return true;

            }
            catch (SqlException ex)
            {
                if (conex.State != System.Data.ConnectionState.Closed)
                {
                    conex.Close();
                }
                MessageBox.Show(ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                if (conex.State != System.Data.ConnectionState.Closed)
                {
                    conex.Close();
                }
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool EditEmployee(Employee emp)
        {
            try
            {
                //El query.
                string Query = "Exec Edit_Employee @Idemployee, @DepartId, @name, @lastname, @Admission_date, @jobstate";
                //La consulta
                SqlCommand cmd = new SqlCommand(Query, conex);
                //Los parametros
                cmd.Parameters.AddWithValue("@Idemployee",emp.IdEmployee);
                cmd.Parameters.AddWithValue("@DepartId", emp.DepartmentId);
                cmd.Parameters.AddWithValue("@name", emp._Name);
                cmd.Parameters.AddWithValue("@lastname", emp._Lastname);
                cmd.Parameters.AddWithValue("@Admission_date", emp.Admission_date);
                cmd.Parameters.AddWithValue("@jobstate", emp.Job_State);
                //El proceso
                conex.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                conex.Close();
                return true;

            }
            catch (SqlException ex)
            {
                if (conex.State != System.Data.ConnectionState.Closed)
                {
                    conex.Close();
                }
                MessageBox.Show(ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                if (conex.State != System.Data.ConnectionState.Closed)
                {
                    conex.Close();
                }
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool DeleteEmployee(int id)
        {
            try
            {
                //El query.
                string Query = "Exec Delete_Employee @Idemployee";
                //La consulta
                SqlCommand cmd = new SqlCommand(Query, conex);
                //Los parametros
                cmd.Parameters.AddWithValue("@Idemployee",id);
                //El proceso
                conex.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                conex.Close();
                return true;

            }
            catch (SqlException ex)
            {
                if (conex.State != System.Data.ConnectionState.Closed)
                {
                    conex.Close();
                }
                MessageBox.Show(ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                if (conex.State != System.Data.ConnectionState.Closed)
                {
                    conex.Close();
                }
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        #region Sql server
        public Employee ObtenerEmpleado(int id)
        {
            try
            {
                Employee empleado = null;
                string Query = "exec Get_OneEmployee @Id";

                SqlCommand cmd = new SqlCommand(Query, conex);
                cmd.Parameters.AddWithValue("@Id", id);
                conex.Open();
                SqlDataReader lector = cmd.ExecuteReader();
                if (lector.Read())
                {
                    int IdEmployee = lector.GetInt32(0);
                    int DepartmentId = lector.GetInt32(1);
                    string Depart = lector.GetString(2);
                    string Name = lector.GetString(3);
                    string Lastname = lector.GetString(4);
                    DateTime Addmision = lector.GetDateTime(5);
                    bool enabled = lector.GetBoolean(6);
                    DateTime? dismal = null;
                    if(!lector.IsDBNull(7))
                    {
                        dismal = lector.GetDateTime(7);
                    }
                    bool ejob = lector.GetBoolean(8);

                    empleado = new Employee(IdEmployee,DepartmentId,Depart, Name, Lastname, Addmision,dismal,enabled,ejob);
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
                if (conex.State != System.Data.ConnectionState.Closed)
                {
                    conex.Close();
                }
                MessageBox.Show(ex.Message);
                return null;
            }

        }
        #endregion
        public void Abrir_Control_Empleados()
        {
            Control_Empleados hola = new Control_Empleados();
            hola.Show();
        }
        public void Abrir_Control_Empleados(Employee emp)
        {
            Control_Empleados hola = new Control_Empleados(emp);
            hola.Show();
        }

        public void Reset_VisualEmpleados()
        {
            var h = Application.OpenForms.OfType<AppVistaGeneral>().First();
            Visual_Empleados view = new Visual_Empleados();
            h.OpenForm(view);
        }
    }
}
