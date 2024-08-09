using Modelos.Taller;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace SOD_General.Controladores
{
    public class ClientController
    {
        static string cadena = ConfigurationManager.ConnectionStrings["Conex"].ConnectionString;
        SqlConnection conex = new SqlConnection(cadena);

        List<Client> Registro;
        
        /// <summary>
        /// usando el Procedimiento Add_Client y el modelo de Client, se suben los datos y se llenan los parametros
        /// </summary>
        /// <param name="cli"></param>
        /// 
        public void AgregarCliente(Client cli)
        {
            try
            {
               
                string Query = "Exec Add_Client @Identifier, @Client, @Address, @Phone1, @Phone2, @Contact";
                
                SqlCommand cmd = new SqlCommand(Query, conex);
                cmd.Parameters.Add("@Identifier", cli._Identifier);
                cmd.Parameters.Add("@Client", cli._NameBranch);
                cmd.Parameters.Add("@Address", cli._Address);
                
                cmd.Parameters.Add("@Phone1", cli.Phone_1);
                cmd.Parameters.Add("@Phone2", cli.Phone_2);
                cmd.Parameters.Add("@Contact", cli._Contact);

                conex.Open();
                cmd.ExecuteNonQuery();
                conex.Close();

                MessageBox.Show(cli._NameBranch + "\n" + cli._Address);
            }
            catch(SqlException ex)
            {
            
            }

            catch (Exception ex)
            {
                MessageBox.Show("Cliente no registrado: " + ex.ToString());
            }
        }

      

        public List<Client> ViewClient()
        {
            try
            {
                string Query = "Exec Get_Client";
                List<Client> ClientsRecordTaller = new List<Client>();
                SqlCommand cmd = new SqlCommand(Query, conex);

                conex.Open();
                SqlDataReader Reader = cmd.ExecuteReader();


                if (Reader.FieldCount <= 1)
                {
                    throw new Exception("No hay Clientes registrados");
                }
                else
                {
                    while (Reader.Read())
                    {
                        Client Clientes;
                        int Id = Reader.GetInt32(0);
                        string Identifier = Reader.GetString(1);
                        string Client = Reader.GetString(2);
                        string Address = Reader.GetString(3);
                        string Phone1 = Reader.GetString(4);
                        string Phone2 = Reader.GetString(5);
                        string Contact = Reader.GetString(6);

                        Clientes = new Client(Id, Identifier, Client, Address, Phone1, Phone2, Contact);
                        ClientsRecordTaller.Add(Clientes);
                    }

                    conex.Close();
                    return ClientsRecordTaller;
                }
            }
          
            catch (Exception ex)
            {
                if (conex.State != System.Data.ConnectionState.Closed)
                {
                    conex.Close();
                }

                MessageBox.Show(ex.ToString());
                return null;
            }
        }

        public List<Locations> ViewLocation(int id)
        {

            try
            {
                string Query = "Exec Get_Locations @id";
                List<Locations> locations = new List<Locations>();

                SqlCommand cmd = new SqlCommand(Query, conex);
                cmd.Parameters.Add("@id", id);
                conex.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.FieldCount <= 1)
                {
                    throw new Exception("Este cliente no tiene sucursales registradas");
                }
                else
                {
                    while (reader.Read())
                    {
                        Locations loca;
                        int IdLocation = reader.GetInt32(0);
                        int IdClient = reader.GetInt32(1);
                        string identifier = reader.GetString(2);
                        string location = reader.GetString(3);
                        string address = reader.GetString(4);
                        string phone1 = reader.GetString(5);
                        string phone2 = reader.GetString(6);
                        string contact = reader.GetString(7);

                        loca = new Locations(IdLocation, IdClient, identifier, location, address, phone1, phone2, contact);
                        locations.Add(loca);
                    }

                    conex.Close();
                    return locations;
                }

            }
            catch (Exception ex)
            {
                if (conex.State != System.Data.ConnectionState.Closed)
                {
                    conex.Close();
                }
                MessageBox.Show("Fallo: " + ex.ToString());
                return null;
            }
        }


        public bool AgregarSucursal(Locations loc)
        {
            bool insercion;
            try
            {
                string Query = "Exec Add_Locations @Identifier, @Location, @Address, @Phone1, @Phone2, @Contact";
                SqlCommand cmd = new SqlCommand(Query, conex);

                cmd.Parameters.Add("@Identifier", loc.Identifier);
                cmd.Parameters.Add("@Location", loc._Location);
                cmd.Parameters.Add("@Address", loc.Addrees);
                cmd.Parameters.Add("@Phone1", loc.Phone1);
                cmd.Parameters.Add("@Phone2", loc.Phone2);
                cmd.Parameters.Add("@Contact", loc.Contact);

                conex.Open();
                cmd.ExecuteNonQuery();                
                conex.Close();
                insercion = true;
                
            }
            catch (SqlException ex)
            {
                if (conex.State != System.Data.ConnectionState.Closed)
                {
                    conex.Close();
                }
                MessageBox.Show("Error desde la base de datos: \n" + ex.ToString());

                insercion = false;
            }

            catch (Exception ex)
            {
                if (conex.State != System.Data.ConnectionState.Closed)
                {
                    conex.Close();
                }
                MessageBox.Show("Error desde el sistema: \n" + ex.ToString());

                insercion = false;
            }

            if (insercion == true) 
            {
                MessageBox.Show("Agregado con exito");
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error");
            }
            return insercion;


        }


    }


}
