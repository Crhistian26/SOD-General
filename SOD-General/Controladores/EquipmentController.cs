using Modelos.Taller;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SOD_General.Controladores
{
    public class EquipmentController
    {
        static string cadena = ConfigurationManager.ConnectionStrings["Conex"].ConnectionString;
        SqlConnection conex = new SqlConnection(cadena);
        EquipType equipType;
        Controles controlesQ;
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

        public List<Controles> visualizarControles()
        {
            List<Controles> tipoControles = new List<Controles>();

            try
            {
                string query = "Select * from ControlQuality";
                SqlCommand cmd = new SqlCommand(query, conex);

                conex.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int Id = reader.GetInt32(0);
                    string Equipo = reader.GetString(1);
                    bool v = reader.GetBoolean(2);

                    controlesQ = new Controles(Id, Equipo, v);
                    tipoControles.Add(controlesQ);
                }
                conex.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString());
            }
            return tipoControles;

        }

        public List<Accesories> ObtenerAccesorios()
        {
            try
            {
                List<Accesories> listaAccesorios = new List<Accesories>();
                //El query
                string Query = "select IdAccesoriesEquipment, Accesories, _Enable from AccesoriesEquipment";
                //La consulta
                SqlCommand cmd = new SqlCommand(Query, conex);
                //El proceso
                conex.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Accesories accesorios;
                    int id = reader.GetInt32(0);
                    string name = reader.GetString(1);
                    bool enable = reader.GetBoolean(2);
                    accesorios = new Accesories(id, name, enable);
                    listaAccesorios.Add(accesorios);
                }

                conex.Close();
                return listaAccesorios;
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
