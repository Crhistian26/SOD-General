using Modelos.AsistenciasYPermisos;
using SOD_General.Vistas.Recursos_Humanos.Registros;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SOD_General.Controladores
{
    internal class Registros_Controller
    {
        static string cadena = ConfigurationManager.ConnectionStrings["Conex"].ConnectionString;
        SqlConnection conex = new SqlConnection(cadena);

        #region Asistencias
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
                    string Name = reader.GetString(2);
                    TimeSpan entry = reader.GetTimeSpan(3);
                    TimeSpan exit = reader.GetTimeSpan(4);
                    TimeSpan lunchS = reader.GetTimeSpan(5);
                    TimeSpan lunchF = reader.GetTimeSpan(6);
                    DateTime record_Date = reader.GetDateTime(7);

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
        #endregion

        public void AgregarPermiso()
        {
            Agregar_Permiso vista = new Agregar_Permiso();
            vista.Show();
        }

        public void AgregarAsistencia()
        {
            Agregar_Asistencias vista = new Agregar_Asistencias();
            vista.Show();
        }

    }
}
