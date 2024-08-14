using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Office2010.ExcelAc;
using Modelos.Taller;
using SOD_General.Vistas.Taller.Equipos;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOD_General.Controladores
{
    public class EquipmentController
    {
        static string cadena = ConfigurationManager.ConnectionStrings["Conex"].ConnectionString;
        SqlConnection conex = new SqlConnection(cadena);
        EquipType equipType;

        public void agregarEquipo(string equipo, int enable)
        {
            try
            {
                string Query = "Exec Add_TypeEquipment @NameEquipment, @Enable";

                SqlCommand cmd = new SqlCommand(Query, conex);
                cmd.Parameters.AddWithValue("@NameEquipment", equipo);
                cmd.Parameters.AddWithValue("@Enable", enable);


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

        public List<EquipType> visualizarEquipo()
        {
            List<EquipType> tipoEquipo = new List<EquipType>();

            try
            {
                string query = "Select * from TypeEquipment";
                SqlCommand cmd = new SqlCommand(query, conex);

                conex.Open();
                SqlDataReader reader = cmd.ExecuteReader();
  
                while (reader.Read())
                {
                    int Id = reader.GetInt32(0);
                    string Equipo = reader.GetString(1);
                    bool v = reader.GetBoolean(2);

                    equipType = new EquipType(Id, Equipo, v);
                    tipoEquipo.Add(equipType);
                }
                conex.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString());
            }
            return tipoEquipo;
           
        }


        public void AgregarControles(string txt, bool bolean)
        {
            try
            {

                string Query = "Exec Add_QualityControl @NameQuality, @Enable";

                SqlCommand Cmd = new SqlCommand(Query, conex);

                Cmd.Parameters.AddWithValue("@NameQuality", txt);

                Cmd.Parameters.AddWithValue("@Enable", bolean);

                conex.Open();

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Agregado Exitosamente");

            }
            catch(SqlException Ex)

            {
                MessageBox.Show("Error desde la base de datos: " +Ex.ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }

        }

    }
}
