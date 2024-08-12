using DocumentFormat.OpenXml.Office2010.ExcelAc;
using Modelos.Taller;
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

    public class BrandController
    {
        static string cadena = ConfigurationManager.ConnectionStrings["Conex"].ConnectionString;
        SqlConnection conex = new SqlConnection(cadena);


        public void agregarMarca(string marca, int enable)
        {
            try
            {
                string query = "exec Add_Brand @NameBrand, @Enable";
                SqlCommand cmd = new SqlCommand(query, conex);
                cmd.Parameters.Add("NameBrand", marca);
                cmd.Parameters.Add("Enable", enable);
                conex.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Ingresado correctamente");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error desde la base de datos: " + ex.Message.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message.ToString());
            }
          
        }

        public List<Brand> ViewBrand()
        {
            string query = "Select * from Brand";
            SqlCommand cmd = new SqlCommand(query, conex);
            List<Brand> brandList = new List<Brand>();

            try
            {
                conex.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.FieldCount <= 0)
                {
                    MessageBox.Show("No hay marcas registradas");
                }
                else
                {
                    while (reader.Read())
                    {
                        Brand lista;
                        int id = reader.GetInt32(0);
                        string marca = reader.GetString(1);
                        int enable = Convert.ToInt32(reader.GetBoolean(2));

                        lista = new Brand(id, marca, enable);
                        brandList.Add(lista);
                    }
                    conex.Close();                    
                }
            }
         
            catch (SqlException ex)
            {
                MessageBox.Show("Error desde la base de datos: " + ex.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha habido un error: " + ex.ToString());
            }
            return brandList;

        }
    }

}
