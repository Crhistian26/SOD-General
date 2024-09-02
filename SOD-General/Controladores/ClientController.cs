using Modelos.Control_de_usuarios;
using Modelos.Taller;
using SOD_General.Vistas.Taller.Clientes;
using SOD_General.Vistas.Taller.Pruebadiseño;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace SOD_General.Controladores
{
    public class ClientController
    {
        static string cadena = ConfigurationManager.ConnectionStrings["Conex"].ConnectionString;
        SqlConnection conex = new SqlConnection(cadena);

        Model_User user = Application.OpenForms.OfType<AppVistaGeneral>().FirstOrDefault().user;

        AppVistaGeneral view;

        List<Client> Registro;

        /// <summary>
        /// usando el Procedimiento Add_Client y el modelo de Client, se suben los datos y se llenan los parametros
        /// </summary>
        /// <param name="cli"></param>
        /// 
        public void AgregarCliente(int _Name, string _Address, string Phone1, string Phone2, string ident )
        {

            try
            {
                string Query = "Exec Add_Client @Name, @Address, @Phone1, @Phone2, @Identifier";

                SqlCommand cmd = new SqlCommand(Query, conex);
                cmd.Parameters.AddWithValue("@Name", _Name);
                cmd.Parameters.AddWithValue("@Address", _Address);
                cmd.Parameters.AddWithValue("@Phone1", Phone1);
                cmd.Parameters.AddWithValue("@Phone2", Phone2);
                cmd.Parameters.AddWithValue("@Identifier", ident);

                conex.Open();
                cmd.ExecuteNonQuery();
                conex.Close();

                MessageBox.Show("RNC/Cedula cargado");
            }


            catch (SqlException ex)
            {
                MessageBox.Show("Cliente no registrado: " + ex.ToString());

                if (conex.State != System.Data.ConnectionState.Closed)
                {
                    conex.Close();
                }
            }

            catch (Exception ex)
            {
                if (conex.State != System.Data.ConnectionState.Closed)
                {
                    conex.Close();
                }
                MessageBox.Show("Cliente no registrado: " + ex.ToString());
            }
        }


        public List<Client> ViewIdentifier()
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

                        Clientes = new Client(Id, Identifier);
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


                        Clientes = new Client(Id, Identifier);
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
                cmd.Parameters.AddWithValue("@id", id);
                conex.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.FieldCount <= 1)
                {
                    MessageBox.Show("Este cliente no tiene sucursales registradas");
                    conex.Close();
                    return null;
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
                        int a = 2; 

                        loca = new Locations(IdLocation, IdClient, a, address, phone1, phone2, contact, identifier);
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

              //  cmd.Parameters.AddWithValue("@Identifier", loc.Identifier);
                cmd.Parameters.AddWithValue("@Location", loc._Location);
                cmd.Parameters.AddWithValue("@Address", loc.Addrees);
                cmd.Parameters.AddWithValue("@Phone1", loc.Phone1);
                cmd.Parameters.AddWithValue("@Phone2", loc.Phone2);

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

        public List<Locations> Rellenado()
        {
            List<Locations> ListLoc = new List<Locations>();
            try
            {
                string query = "Exec Get_Locations";
                SqlCommand cmd = new SqlCommand(query,conex);

                conex.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Locations loc;
                    int IdClient = reader.GetInt32(0);
                    string name = reader.GetString(1);
                    string address = reader.GetString(2);
                    string phone1 = reader.GetString(3);
                    string phone2 = reader.GetString(4);
                    int IdIdent = reader.GetInt32(5);
                    string Identifier = reader.GetString(6);

                    loc = new Locations(IdClient, IdIdent, null, name, address, phone1, phone2, Identifier);
                    ListLoc.Add(loc);
                }
                conex.Close();
                reader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error de la base de datos: " + ex.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error del sistema" + ex.ToString());
            }
            return ListLoc;
        }

        public List<Client> RellenarComboBox()
        {
            string Query = "Select * from Client";

            List<Client> clientLista = new List<Client>();
            SqlCommand cmd = new SqlCommand(Query, conex);
            conex.Open();
            SqlDataReader Reader = cmd.ExecuteReader();


            while (Reader.Read())
            {
                Client Clientes;
                int Id = Reader.GetInt32(0);
                string Identifier = Reader.GetString(1);
                string Client = Reader.GetString(2);

                Clientes = new Client(Id, Identifier);
                clientLista.Add(Clientes);
            }

            conex.Close();

            return clientLista;
        }

        public List<Locations> LlenarDataGridRNC()
        {
            string Query = "select CD._Name, CD._Address, CD.Phone1, CD.Phone2, CD.ClientIdentId, CI.identifier from ClienteData CD join ClientIdentifier CI on ClientIdentId = IdClientIdent";

            List<Locations> clientLista = new List<Locations>();
            SqlCommand cmd = new SqlCommand(Query, conex);
            conex.Open();
            SqlDataReader Reader = cmd.ExecuteReader();


            while (Reader.Read())
            {
                Locations RncLoc;
                string Client = Reader.GetString(0);
                string Address = Reader.GetString(1);
                string Phone1 = Reader.GetString(2);
                string Phone2 = Reader.GetString(3);
                int IdIdentifier = Reader.GetInt32(4);
                string Identifier = Reader.GetString(5);

                RncLoc = new Locations(null, IdIdentifier, null, Client,  Address, Phone1, Phone2,  Identifier);
                clientLista.Add(RncLoc);
            }

            conex.Close();

            return clientLista;
        }

    }
}
