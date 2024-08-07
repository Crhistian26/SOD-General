using SOD_General.Vistas.Recursos_Humanos.Motivos;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using Modelos.AsistenciasYPermisos;
using System.Runtime.InteropServices.WindowsRuntime;

namespace SOD_General.Controladores
{
    internal class Motivos_Controller
    {
        static string cadena = ConfigurationManager.ConnectionStrings["Conex"].ConnectionString;
        SqlConnection conex = new SqlConnection(cadena);

         public List<Model_Reason> Obtener_Razones()
        {
            try
            {
                List<Model_Reason> reasons = new List<Model_Reason>();
                string Query = "Select IdReason,_Reason,Mesure_Time1,Mesure_Time2,MaximunCount_Time,MesureMaximune_Time from Reasons";
                //La consulta
                SqlCommand cmd = new SqlCommand(Query, conex);
                //Los parametros

                //El proceso
                conex.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    reasons.Add
                     (
                        new Model_Reason
                        (
                            reader.GetInt32(0),
                            reader.GetString(1),
                            reader.GetString(2),
                            reader.GetString(3),
                            reader.GetInt32(4),
                            reader.GetString(5)
                        )
                     );
                }
                conex.Close();
                return reasons;

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
        
        public void AbrirEditar(int? y)
        {
            if (y is null)
            {
                AgregarEditar_Motivos hola = new AgregarEditar_Motivos();
                hola.Show();
            }
            else
            {
                AgregarEditar_Motivos hola = new AgregarEditar_Motivos(y);
                hola.Show();
            }
        }
    }
}
