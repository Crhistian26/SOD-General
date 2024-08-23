using DocumentFormat.OpenXml.Office2010.Excel;
using Modelos.Taller;
using SOD_General.Taller.Control_calidad;
using SOD_General.Vistas.Taller.Registro_peticiones;
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

                Application.OpenForms.OfType<AgregarControles>().First().Close();

            }
            catch (SqlException Ex)
            {
                if (conex.State != System.Data.ConnectionState.Closed)
                {
                    conex.Close();
                }

                MessageBox.Show("Error desde la base de datos: " + Ex.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());

                if (conex.State != System.Data.ConnectionState.Closed)
                {
                    conex.Close();
                }
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
                List<int> inter = new List<int>();
                int b;
                //foreach que recorre todos los checkbox en el FlowLayoutPanel y almacena el tag(id) de los que estan en checked
                foreach (CheckBox chkx in flp.Controls)
                {
                    if (chkx.Checked)
                    {
                        b = Convert.ToInt32(chkx.Tag);
                        inter.Add(b);
                    }
                }

                string query = "Exec Add_EquipmentControl @TypeEquipment_Id, @ControlQuality_Id";
                SqlCommand cmd = new SqlCommand(query, conex);

                string equipo = cmb.SelectedItem.ToString();

                int idEquip = ctrlList.Where(c => c._EquipType == equipo)
                                         .Select(c => c.IdEquipType)
                                         .First();

                MessageBox.Show(idEquip.ToString());

                conex.Open();
                
                foreach (var a in inter)
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@TypeEquipment_Id", idEquip);
                    cmd.Parameters.AddWithValue("@ControlQuality_Id", a);
                    cmd.ExecuteNonQuery();
                    
                }
                conex.Close();
                MessageBox.Show("Agregado correctamente");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error de sql: " + ex.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("error del sistema: " + ex.ToString());
            }
            
        }


        public List<Controles> visualizarControles()
        {
            List<Controles> ControlesQ = new List<Controles>();
            Controles ListControl;
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

                    ListControl = new Controles(Id, Equipo, v);
                    ControlesQ.Add(ListControl);
                }
                conex.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString());
            }
            return ControlesQ;

        }
        public List<Controles> FiltrarControles(int id)
        {
            List<Controles> ControlesQ = new List<Controles>();
            Controles ListControl;
            try
            {
                string query = "SELECT Ec.IdEquipmentControl, Cq._NameQuality, Cq._Enable" +
                    "\nFROM EquipmentControl Ec" +
                    "\nJOIN TypeEquipment Te" +
                    "\nON Te.IdTypeEquipment = Ec.TypeEquipment_Id" +
                    "\nJOIN ControlQuality Cq" +
                    "\nON Cq.IdControlQuality = Ec.ControlQuality_Id" +
                    $"\nWHERE Te.IdTypeEquipment = {id}";
                SqlCommand cmd = new SqlCommand(query, conex);

                conex.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int Id = reader.GetInt32(0);
                    string Equipo = reader.GetString(1);
                    bool v = reader.GetBoolean(2);

                    ListControl = new Controles(Id, Equipo, v);
                    ControlesQ.Add(ListControl);
                }
                conex.Close();

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error de la base de datos " + ex.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString());
            }
            return ControlesQ;

        }

    }
}
