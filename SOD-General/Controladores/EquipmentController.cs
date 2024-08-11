using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOD_General.Controladores
{
    public class EquipmentController
    {
        static string cadena = ConfigurationManager.ConnectionStrings["Conex"].ConnectionString;
        SqlConnection conex = new SqlConnection(cadena);

        public void agregarEquipo(string equipo, int enable)
        {
            try
            {
                string Query = "Exec Add_TypeEquipment @NameEquipment, @Enable";

                SqlCommand cmd = new SqlCommand(Query, conex);
                cmd.Parameters.Add("@NameEquipment", equipo);
                cmd.Parameters.Add("@Enable", enable);


                conex.Open();
                cmd.ExecuteNonQuery();
                conex.Close();

            }

            catch (SqlException ex)
            {
                MessageBox.Show("Error desde la base de datos" + ex.ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error, no se cargado el equipo");
            }
        }
    }
}
