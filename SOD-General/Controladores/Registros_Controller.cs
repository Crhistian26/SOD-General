using Modelos.AsistenciasYPermisos;
using Modelos.Usuarios_Empleados;
using SOD_General.Vistas.Recursos_Humanos.Registros;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace SOD_General.Controladores
{
    public class Registros_Controller
    {
        SizesGenerales _size = new SizesGenerales();
        //La cadena de conexion
        static string cadena = ConfigurationManager.ConnectionStrings["Conex"].ConnectionString;
        SqlConnection conex = new SqlConnection(cadena);

        #region Asistencias
        public void AgregarAsistencia(DateTime fecha)
        {
            var win = Application.OpenForms.OfType<Control_Asistencias>().FirstOrDefault();
            if (win != null)
            {
                win.Close();
            }
            Control_Asistencias vista = new Control_Asistencias(fecha);
            vista.Show();
        }

        public List<Record_Attendance> Obtener_Asistencias(DateTime date1, DateTime date2)
        {
            try
            {
                List<Record_Attendance> diccionario = new List<Record_Attendance>();
                Record_Attendance record;
                //El query.
                string Query = "exec Get_AttendanceForDate @date1, @date2";
                //La consulta
                SqlCommand cmd = new SqlCommand(Query, conex);
                cmd.Parameters.AddWithValue("@date1", date1);
                cmd.Parameters.AddWithValue("@date2", date2);
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
                    TimeSpan? lunchS, lunchF;
                    if(!reader.IsDBNull(6) && !reader.IsDBNull(7))
                    {
                        lunchS = reader.GetTimeSpan(6);
                        lunchF = reader.GetTimeSpan(7);
                    }
                    else
                    {
                        lunchS = null;
                        lunchF = null;
                    }
                    DateTime record_Date = reader.GetDateTime(8);

                    record = new Record_Attendance(IdRecord, IdEmployee, Name, entry, exit, lunchS, lunchF, record_Date);
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

        public bool AddAttendance(Record_Attendance record)
        {
            try
            {
                //El query.
                string Query = "Exec Add_Attendance @idEmp,@entry,@exit,@lunchS,@lunchF,@date";
                //La consulta
                SqlCommand cmd = new SqlCommand(Query, conex);
                //Los parametros
                cmd.Parameters.AddWithValue("@idEmp", record.IdEmployee);
                cmd.Parameters.AddWithValue("@entry", record.Entry);
                cmd.Parameters.AddWithValue("@exit", record.Exit);
                if (record.LunchS != null && record.LunchF != null)
                {
                    cmd.Parameters.AddWithValue("@lunchS", record.LunchS);
                    cmd.Parameters.AddWithValue("@lunchF", record.LunchF);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@lunchS", DBNull.Value);
                    cmd.Parameters.AddWithValue("@lunchF", DBNull.Value);
                }
                cmd.Parameters.AddWithValue("@date", record.DateAttendance);
                //El proceso
                conex.Open();
                cmd.ExecuteNonQuery();
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
        public int AddAttendanceMulti(Record_Attendance record)
        {
            try
            {
                //El query.
                string Query = "Exec Add_Attendance @idEmp,@entry,@exit,@lunchS,@lunchF,@date";
                //La consulta
                SqlCommand cmd = new SqlCommand(Query, conex);
                //Los parametros
                cmd.Parameters.AddWithValue("@idEmp", record.IdEmployee);
                cmd.Parameters.AddWithValue("@entry", record.Entry);
                cmd.Parameters.AddWithValue("@exit", record.Exit);
                if (record.LunchS != null && record.LunchF != null)
                {
                    cmd.Parameters.AddWithValue("@lunchS", record.LunchS);
                    cmd.Parameters.AddWithValue("@lunchF", record.LunchF);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@lunchS", DBNull.Value);
                    cmd.Parameters.AddWithValue("@lunchF", DBNull.Value);
                }
                cmd.Parameters.AddWithValue("@date", record.DateAttendance);
                //El proceso
                conex.Open();
                cmd.ExecuteNonQuery();
                conex.Close();
                return -1;
            }
            catch (SqlException ex)
            {
                if (conex.State != System.Data.ConnectionState.Closed)
                {
                    conex.Close();
                }
                return record.IdEmployee;
            }
            
        }
        public bool EditAttendance(Record_Attendance record)
        {
            try
            {
                //El query.
                string Query = "exec Edit_Attendance @recordId, @employeeId, @entry,@exit,@lunchS, @lunchF, @date";
                //La consulta
                SqlCommand cmd = new SqlCommand(Query, conex);
                //Los parametros
                cmd.Parameters.AddWithValue("@recordId", record.IdRecord);
                cmd.Parameters.AddWithValue("@employeeId", record.IdEmployee);
                cmd.Parameters.AddWithValue("@entry", record.Entry);
                cmd.Parameters.AddWithValue("@exit", record.Exit);
                if (record.LunchS != null && record.LunchF != null)
                {
                    cmd.Parameters.AddWithValue("@lunchS", record.LunchS);
                    cmd.Parameters.AddWithValue("@lunchF", record.LunchF);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@lunchS", DBNull.Value);
                    cmd.Parameters.AddWithValue("@lunchF", DBNull.Value);
                }
                cmd.Parameters.AddWithValue("@date", record.DateAttendance);

                conex.Open();
                cmd.ExecuteNonQuery();
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

        public bool DeleteAttendance(Record_Attendance record)
        {
            try
            {
                //El query.
                string Query = "exec Delete_Attendance @recordId";
                //La consulta
                SqlCommand cmd = new SqlCommand(Query, conex);
                //Los parametros
                cmd.Parameters.AddWithValue("@recordId", record.IdRecord);

                conex.Open();
                cmd.ExecuteNonQuery();
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

        public bool DeleteAttendance()
        {
            return false;
        }

        #endregion

        #region Permisos
        public void AgregarPermiso()
        {
            var win = Application.OpenForms.OfType<Control_Permisos>().FirstOrDefault();
            if (win != null)
            {
                win.Close();
            }
            Control_Permisos vista = new Control_Permisos();
            vista.Show();
        }

   

        public List<Record_Permission> Obtener_Permisos(DateTime date1, DateTime date2)
        {
            try
            {
                List<Record_Permission> permisos = new List<Record_Permission>();
                Record_Permission record;
                //El query.
                string Query = "exec Get_PermissionForDate @date1,@date2";
                //La consulta
                SqlCommand cmd = new SqlCommand(Query, conex);
                cmd.Parameters.AddWithValue("@date1", date1);
                cmd.Parameters.AddWithValue("@date2", date2);
                //El proceso
                conex.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int IdRecord = reader.GetInt32(0);
                    string Name = reader.GetString(1);
                    string Reason = reader.GetString(2);
                    string Det = reader.GetString(3);
                    DateTime Begin = reader.GetDateTime(4);
                    DateTime End = reader.GetDateTime(5);

                    record = new Record_Permission(IdRecord,  Name, Reason, Det, Begin, End);
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

        public bool Add_Permission(Record_Permission record)
        {
            try
            {
                //El query.
                string Query = "Exec Add_Permission @idEmp,@idReason,@Details,@DT1,@DT2";
                //La consulta
                SqlCommand cmd = new SqlCommand(Query, conex);
                //Los parametros
                cmd.Parameters.AddWithValue("@idEmp", record.IdEmployee);
                cmd.Parameters.AddWithValue("@idReason", record.IdReason);
                cmd.Parameters.AddWithValue("@Details", record._Description);
                cmd.Parameters.AddWithValue("@DT1", record.Begin_Date);
                cmd.Parameters.AddWithValue("@DT2", record.End_Date);
                //El proceso
                conex.Open();
                cmd.ExecuteNonQuery();
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

        public bool Edit_Permission(Record_Permission record)
        {
            try
            {
                //El query.
                string Query = "Exec Edit_Permission @idRecord,@idReason,@Details,@DT1,@DT2";
                //La consulta
                SqlCommand cmd = new SqlCommand(Query, conex);
                //Los parametros
                cmd.Parameters.AddWithValue("@idRecord", record.IdRecord);
                cmd.Parameters.AddWithValue("@idReason", record.IdReason);
                cmd.Parameters.AddWithValue("@Details", record._Description);
                cmd.Parameters.AddWithValue("@DT1", record.Begin_Date);
                cmd.Parameters.AddWithValue("@DT2", record.End_Date);
                //El proceso
                conex.Open();
                cmd.ExecuteNonQuery();
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

        public bool Delete_Permission(int id)
        {
            string query = "Delete from Permission_Record where IdRecordPermission = @id";
            SqlCommand cmd = new SqlCommand(query, conex);
            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                conex.Open();
                cmd.ExecuteNonQuery();
                conex.Close();

                return true;
            }
            catch(SqlException ex)
            {
                _size.ChechekConnection(conex);
                MessageBox.Show(ex.Message);
                return false;
            }
            catch(Exception ex)
            {
                _size.ChechekConnection(conex);
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        #endregion

        public List<Employee> Obtener_Empleados_Trabajando()
        {
            try
            {
                //La lista a retornar.
                List<Employee> empleados = new List<Employee>();
                //El query.
                string Query = "select IdEmployee,_Name,_Lastname from Employees where Job_State = 1 order by _Name ;";
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
                string Query = "select IdDeparment,_Department from Departments order by _Department;";
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
                string Query = "select IdReason,_Reason from Reasons order by IdReason;";
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

        public void Reset_VisualRegistors()
        {
            var h = Application.OpenForms.OfType<AppVistaGeneral>().First();
            h.OpenForm(new Registros_GeneralesAsistencias());
        }
        public void Reset_VisualRegistors(DateTime fecha)
        {
            var h = Application.OpenForms.OfType<AppVistaGeneral>().First();
            var f = new Registros_GeneralesAsistencias();
            f.cR_DateTimePicker1.Value = fecha;
            h.OpenForm(f);
        }
        public void Reset_VisualPermisos()
        {
            var h = Application.OpenForms.OfType<AppVistaGeneral>().First();
            h.OpenForm(new Registros_GeneralesPermisos(h));
        }
    }
}
