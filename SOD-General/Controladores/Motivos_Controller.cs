using Modelos.AsistenciasYPermisos;
using SOD_General.Vistas.Recursos_Humanos.Motivos;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SOD_General.Controladores
{
    internal class Motivos_Controller
    {
        static string cadena = ConfigurationManager.ConnectionStrings["Conex"].ConnectionString;
        SqlConnection conex = new SqlConnection(cadena);
        static SizesGenerales _size = new SizesGenerales();
        public List<Model_Reason> Obtener_Razones()
        {
            try
            {
                List<Model_Reason> reasons = new List<Model_Reason>();
                string Query = "Select IdReason,_Reason,Descripcion,MaximunCount_Time,MesureMaximune_Time,For_Mesure from Reasons";
                //La consulta
                SqlCommand cmd = new SqlCommand(Query, conex);
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
                            reader.GetInt32(3),
                            reader.GetString(4),
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

        public bool AddReason(Model_Reason reason)
        {
            try
            {
                //El query.
                string Query = "Exec Add_Reason @reason,@count,@mesureMax,@mesureFor,@descrip";
                //La consulta
                SqlCommand cmd = new SqlCommand(Query, conex);
                //Los parametros
                cmd.Parameters.AddWithValue("@reason", reason._Reason);
                cmd.Parameters.AddWithValue("@count", reason.MaximuneCount_Time);
                cmd.Parameters.AddWithValue("@mesureMax", reason.MesureMaximune_Time);
                cmd.Parameters.AddWithValue("@mesureFor", reason.For_mesure);
                cmd.Parameters.AddWithValue("@descrip", reason._Descripcion);

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
        public bool EditReason(Model_Reason reason)
        {
            try
            {
                //El query.
                string Query = "Exec Edit_Reason @reasonId,@reason,@count,@mesureMax,@mesureFor,@descrip";
                //La consulta
                SqlCommand cmd = new SqlCommand(Query, conex);
                //Los parametros
                cmd.Parameters.AddWithValue("@reasonId", reason.IdReason);
                cmd.Parameters.AddWithValue("@reason", reason._Reason);
                cmd.Parameters.AddWithValue("@count", reason.MaximuneCount_Time);
                cmd.Parameters.AddWithValue("@mesureMax", reason.MesureMaximune_Time);
                cmd.Parameters.AddWithValue("@mesureFor", reason.For_mesure);
                cmd.Parameters.AddWithValue("@descrip", reason._Descripcion);

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
        public void OpenControlReasons()
        {
            AgregarEditar_Motivos window = new AgregarEditar_Motivos();
            window.Show();
        }
        public void OpenControlReasons(Model_Reason reason)
        {
            AgregarEditar_Motivos window = new AgregarEditar_Motivos(reason);
            _size.CloseForm(window);
            window.Show();
        }

        public void ResetVisualReasons()
        {
            var h = Application.OpenForms.OfType<AppVistaGeneral>().First();
            _size.CloseForm(h);
            h.OpenForm(new Visual_Motivos());
        }

    }
}
