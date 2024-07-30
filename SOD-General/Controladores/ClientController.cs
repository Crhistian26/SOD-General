using SOD_General.Vistas.Taller.Registro_peticiones;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOD_General.Controladores
{
    public class ClientController
    {
        static string cadena = ConfigurationManager.ConnectionStrings["Conex"].ConnectionString;
        SqlConnection conex = new SqlConnection(cadena);
        AgregarClientes cli = new AgregarClientes();

        public void AgregarCliente()
        {
            string Query = "Exec Add_Client @Name, @Address, @Identifier, @Phone1, @Phone2, @Contact,";
            SqlCommand cmd = new SqlCommand(Query, conex);
            cmd.Parameters.Add("@Name",cli.name);
            cmd.Parameters.Add("@Address", cli.address);
            cmd.Parameters.Add("@Identifier", cli.identifier);
            cmd.Parameters.Add("@Phone1", cli.phone1);
            cmd.Parameters.Add("@Phone2", cli.phone2);
            cmd.Parameters.Add("@Contact", cli.contact);


        }
    }

    
}
