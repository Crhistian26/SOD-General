using DocumentFormat.OpenXml.Office2010.ExcelAc;
using Modelos.Control_de_usuarios;
using Modelos.Taller;
using SOD_General.Vistas.Taller.Clientes;
using SOD_General.Vistas.Taller.Pruebadiseño;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
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

        //sirve
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

        //sirve
        public List<ClientContact> ViewClient()
        {
            try
            {
                string Query = "Exec Get_LocationsContact";
                List<ClientContact> CliCont = new List<ClientContact>();    

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

                        CliCont.Add(
                            new ClientContact(
                                Reader.GetInt32(0),
                                new Locations(
                                    Reader.GetInt32(0),
                                    Reader.GetString(1),
                                    Reader.GetString(2),
                                    Reader.GetString(3),
                                    Reader.GetString(4),
                                    Reader.GetString(5),
                                    Reader.GetString(6)
                                    
                                ),
                                new Contact(
                                     Reader.GetString(6),
                                      Reader.GetString(7),
                                      Reader.GetString(8),
                                      Reader.GetString(9)
                                    )
                           ));

                        
                    }

                    conex.Close();
                    return CliCont;
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


        //sirve?
        public List<Locations> ViewContact(int id)
        {
            try
            {
                string Query = "Exec Get_Locations";
                List<Locations> locations = new List<Locations>();

                SqlCommand cmd = new SqlCommand(Query, conex);
                conex.Open();
                SqlDataReader reader = cmd.ExecuteReader();


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

        //sirve
        public void AgregarSucursal(string name, string address, string phone1, string phone2, string identifier, string contactIdent, string tipoCliente)
        {
            try
            {
                string Query = "Exec Add_Locations @Name, @Address, @Phone1, @Phone2, @Identifier, @ContactIdentifier, @tipoCliente";
                SqlCommand cmd = new SqlCommand(Query, conex);

                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Address", address);
                cmd.Parameters.AddWithValue("@Phone1", phone1);
                cmd.Parameters.AddWithValue("@Phone2", phone2);
                cmd.Parameters.AddWithValue("@Identifier", identifier);
                cmd.Parameters.AddWithValue("@ContactIdentifier", contactIdent);
                cmd.Parameters.AddWithValue("@tipoCliente", tipoCliente);


                conex.Open();
                cmd.ExecuteNonQuery();
                conex.Close();
                MessageBox.Show("Agregado exitorsamente");
            }
            catch (SqlException ex)
            {
                if (conex.State != System.Data.ConnectionState.Closed)
                {
                    conex.Close();
                }
                MessageBox.Show("Error desde la base de datos: \n" + ex.ToString());
            }

            catch (Exception ex)
            {
                if (conex.State != System.Data.ConnectionState.Closed)
                {
                    conex.Close();
                }
                MessageBox.Show("Error desde el sistema: \n" + ex.ToString());
            }
        }

       
       
        //nidea
        public List<Locations> VerEmpresa(string identifier)
        {
            List<Locations> clientLista = new List<Locations>();

            try
            {
                string Query = "exec Get_RncName @RNC";
                conex.Open();

                SqlCommand cmd = new SqlCommand(Query, conex);

                cmd.Parameters.AddWithValue("@RNC", identifier);

                SqlDataReader Reader = cmd.ExecuteReader();

                while (Reader.Read())
                {
                    Locations RncLoc;
                    int IdClient = Reader.GetInt32(0);
                    string Client = Reader.GetString(1);
                    string Address = Reader.GetString(2);
                    string Phone1 = Reader.GetString(3);
                    string Phone2 = Reader.GetString(4);
                    int IdIdentifier = Reader.GetInt32(5);
                    string TipoCliente = Reader.GetString(6);

                    RncLoc = new Locations(IdClient, Client, Address, Phone1, Phone2, IdIdentifier, TipoCliente);
                    clientLista.Add(RncLoc);

                }
            }

            catch (SqlException ex)
            {
                MessageBox.Show("Error de la base de datos: " + ex.Message.ToString());

                if (conex.State != System.Data.ConnectionState.Closed)
                {
                    conex.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error del sistema: " + ex.Message.ToString());

                if (conex.State != System.Data.ConnectionState.Closed)
                {
                    conex.Close();
                }
            }
            conex.Close();
            return clientLista;

        }

        //repetido? sirve sin id
        public List<Locations> Rellenado()
        {
            List<Locations> ListLoc = new List<Locations>();
            try
            {
                string query = "Exec Get_Locations";
                SqlCommand cmd = new SqlCommand(query, conex);

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

        //sirve
        public List<Contact> ContactData()
        {
            List<Contact> ListLoc = new List<Contact>();
            try
            {
                string query = "Exec Get_Contact";
                SqlCommand cmd = new SqlCommand(query, conex);

                conex.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Contact loc;
                    int IdClient = reader.GetInt32(0);
                    string name = reader.GetString(1);
                    string identifier = reader.GetString(2);
                    string phone1 = reader.GetString(3);
                    string phone2 = reader.GetString(4);

                    loc = new Contact(name, identifier, phone1, phone2, IdClient);
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

        public List<Contact> ContactoCliente(int Rnc)
        {
            List<Contact> ListLoc = new List<Contact>();
            try
            {
                string query = "Exec Get_ContactClient @Identifier";
                SqlCommand cmd = new SqlCommand(query, conex);
                cmd.Parameters.AddWithValue("@Identifier", Rnc);

                conex.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Contact loc;
                    int IdClient = reader.GetInt32(0);
                    string name = reader.GetString(1);
                    string identifier = reader.GetString(2);
                    string phone1 = reader.GetString(3);
                    string phone2 = reader.GetString(4);

                    loc = new Contact(name, identifier, phone1, phone2, IdClient);
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

        public void ordenDeEntrada(string details, int idClient, int idContact)
        {

        }
    }
}
