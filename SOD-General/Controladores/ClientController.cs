using Modelos.Taller;
using SOD_General.Vistas.Taller.Registro_peticiones;
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
    public class ClientController
    {
        static string cadena = ConfigurationManager.ConnectionStrings["Conex"].ConnectionString;
        SqlConnection conex = new SqlConnection(cadena);
        

        public void AgregarCliente(Client cli)
        {
            try
            {
                string Query = "Exec Add_Client @Name, @Address, @Identifier, @Phone1, @Phone2, @Contact,";
                SqlCommand cmd = new SqlCommand(Query, conex);
                cmd.Parameters.Add("@Name", cli._Name);
                cmd.Parameters.Add("@Address", cli._Address);
                cmd.Parameters.Add("@Identifier", cli._Identifier);
                cmd.Parameters.Add("@Phone1", cli.Phone_1);
                cmd.Parameters.Add("@Phone2", cli.Phone_2);
                cmd.Parameters.Add("@Contact", cli._Contact);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Datos ingresados");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Cliente no registrado: " + ex.ToString());
            }
        }
    }

    
}
