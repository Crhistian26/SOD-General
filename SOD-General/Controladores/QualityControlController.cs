using DocumentFormat.OpenXml.Office2010.Excel;
using Modelos.Taller;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOD_General.Controladores
{
    public class QualityControlController
    {
        static string cadena = ConfigurationManager.ConnectionStrings["Conex"].ConnectionString;
        SqlConnection conex = new SqlConnection(cadena);

        List<EquipType> ctrlList = new List<EquipType>();

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

                conex.Close();

                MessageBox.Show("Agregado Exitosamente");

            }
            catch (SqlException Ex)

            {
                MessageBox.Show("Error desde la base de datos: " + Ex.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }

        }

        public void ControlesCheckBx(FlowLayoutPanel flp)
        {
            string query = "Select * from ControlQuality"; 
            SqlCommand cmd = new SqlCommand(query, conex);

            conex.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
              //  Control controles = new Control();   
                CR_Checkbox chb = new CR_Checkbox();
                int id = reader.GetInt32(0);
                string name = reader.GetString(1);
                bool bolea = reader.GetBoolean(2);
                chb.Text = name;
                chb.Tag = id;
                flp.Controls.Add(chb);
            }
            conex.Close();
        }

        public List<EquipType> RellenarCmbBox()
        {
            try
            {
                string query = "select * from TypeEquipment";
                SqlCommand cmd = new SqlCommand(query, conex);

                conex.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    EquipType ctrl;
                    int id = reader.GetInt32(0);
                    string name = reader.GetString(1);
                    bool bolea = reader.GetBoolean(2);
                    ctrl = new EquipType(id, name, bolea);
                    ctrlList.Add(ctrl);

                }
                conex.Close();
            }
            catch (SqlException ex)
            {
                if (conex.State != System.Data.ConnectionState.Closed)
                {
                    conex.Close();
                }
                MessageBox.Show("Error desde la base de datos: " + ex.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error desde el sistema: " + ex.ToString());
                if (conex.State != System.Data.ConnectionState.Closed)
                {
                    conex.Close();
                }
            }

            return ctrlList;
        }

        public void agregarCheckbox(FlowLayoutPanel flp, ComboBox cmb)
        {
            

            try
            {
                

                string query = "Exec Add_EquipmentControl @TypeEquipment_Id, @ControlQuality_Id";
                SqlCommand cmd = new SqlCommand(query, conex);

                string equipo = cmb.SelectedItem.ToString();

                int idEquip = ctrlList.Where(c => c._EquipType == equipo)
                                         .Select(c => c.IdEquipType)
                                         .First();

                MessageBox.Show(idEquip.ToString());

                

                //foreach (var a in inter)
                //{
                    
                //}
                




                
                //List<int> inter = new List<int>();

                //foreach que recorre todos los checkbox en el FlowLayoutPanel y almacena el tag(id) de los que estan en checked
                foreach (CheckBox chkx in flp.Controls)
                {
                    if (chkx.Checked)
                    {
                        conex.Open();
                        int b;
                        b = Convert.ToInt32(chkx.Tag);
                        cmd.Parameters.AddWithValue("@TypeEquipment_Id", idEquip);
                        cmd.Parameters.AddWithValue("@ControlQuality_Id", b);
                        cmd.ExecuteNonQuery();
                        conex.Close();
                    }
                }
                
                MessageBox.Show("Agregado correctamente");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error del sistema: " + ex.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("error de sql: " + ex.ToString());
            }
            
        }

        
    }
}
