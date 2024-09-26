using Modelos.Control_de_usuarios;
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
    public class EntryOrderController
    {
        static string cadena = ConfigurationManager.ConnectionStrings["Conex"].ConnectionString;
        SqlConnection conex = new SqlConnection(cadena);

        public struct EntradaSt
        {
            public long ids;
            public string tipo;
            public string marca;
            public string modelo;
            public string serial;
            public string falla;
            public DateTime _date;
            public EntradaSt(long idst, string tip, string mar, string mod, string ser, string fal, DateTime dat)
            {
                ids = idst;
                tipo = tip;
                marca = mar;
                modelo = mod;  
                serial = ser;
                falla = fal;
                _date = dat;
            }
        }

        AppVistaGeneral view;

        public void ordenDeEntrada(string details, int idClient, int idContact)
        {
            try
            {
                string query = "Exec Add_EntryOrder @Fecha, @idClient, @idContact, @Detalles";
                DateTime date = DateTime.Now;

                SqlCommand cmd = new SqlCommand(query, conex);

                cmd.Parameters.AddWithValue("@idClient", idClient);
                cmd.Parameters.AddWithValue("@idContact", idContact);
                cmd.Parameters.AddWithValue("@Detalles", details);
                cmd.Parameters.AddWithValue("@Fecha", date);

                conex.Open();
                cmd.ExecuteNonQuery();
                conex.Close();
                MessageBox.Show("Agregado Correctamente");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error de la base de datos: " + ex.ToString());

                if (conex.State != System.Data.ConnectionState.Closed)
                {
                    conex.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error del sistema: " + ex.ToString());

                if (conex.State != System.Data.ConnectionState.Closed)
                {
                    conex.Close();
                }
            }

        }

        public void Entradas(int IdEntryOrder, int IdEquipo, int IdTecnico, string serial, string falla, int counter, int code)
        {
            try
            {
                string query = "Exec Add_Entrada @petitionId, @EquipmentId, @TecnicalRepairId, @Serial, @Fault, @Count_Printer, @Code";

                SqlCommand cmd = new SqlCommand(query, conex);

                cmd.Parameters.AddWithValue("@petitionId", IdEntryOrder);
                cmd.Parameters.AddWithValue("@EquipmentId", IdEquipo);
                cmd.Parameters.AddWithValue("@TecnicalRepairId", IdTecnico);
                cmd.Parameters.AddWithValue("@serial", serial);
                cmd.Parameters.AddWithValue("@fault", falla);
                cmd.Parameters.AddWithValue("@Counter_Printer", counter);
                cmd.Parameters.AddWithValue("@Code", code);

                conex.Open();
                cmd.ExecuteNonQuery();
                conex.Close();
                MessageBox.Show("Agregado Correctamente");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error de la base de datos: " + ex.ToString());

                if (conex.State != System.Data.ConnectionState.Closed)
                {
                    conex.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error del sistema: " + ex.ToString());

                if (conex.State != System.Data.ConnectionState.Closed)
                {
                    conex.Close();
                }
            }
        }

        public int UltimoId()
        {
            int IdUltimo = 0;
            try
            {
                string query = "Exec Get_LastEntrance";

                SqlCommand cmd = new SqlCommand(query, conex);

                conex.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    IdUltimo = reader.GetInt32(0);
                }

                conex.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error de la base de datos: " + ex.ToString());

                if (conex.State != System.Data.ConnectionState.Closed)
                {
                    conex.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error del sistema: " + ex.ToString());
            }

            return IdUltimo;
        }


        public void AgregarEntradas(int peticionId, int EquipmentId, int equipStatusId, string serial, string fault, bool counterPrinter)
        {
            try
            {
                //El query.
                string Query = "exec Add_Entrada @petitionId, @EquipmentId, @EquipStatusId, @serial, @fault, @Count_Printer";
                //La consulta
                SqlCommand cmd = new SqlCommand(Query, conex);
                //Los parametros
                cmd.Parameters.AddWithValue("@petitionId", peticionId);
                cmd.Parameters.AddWithValue("@EquipmentId", EquipmentId);
                cmd.Parameters.AddWithValue("@EquipStatusId", equipStatusId);
                cmd.Parameters.AddWithValue("@serial", serial);
                cmd.Parameters.AddWithValue("@fault", fault);
                cmd.Parameters.AddWithValue("@Count_Printer", counterPrinter);

                //El proceso
                conex.Open();
                cmd.ExecuteNonQuery();
                conex.Close();
               // tomarEntradas();

                MessageBox.Show("Datos ingresados correctamente");
              
            }
            catch (SqlException ex)
            {
                if (conex.State != System.Data.ConnectionState.Closed)
                {
                    conex.Close();
                }
                MessageBox.Show(ex.Message);
                //return null;
            }
            catch (Exception ex)
            {
                if (conex.State != System.Data.ConnectionState.Closed)
                {
                    conex.Close();
                }
                MessageBox.Show(ex.Message);
                // return null;
            }

            
        }

        public List<EntryOrderData> GetEntryOrderData()
        {
            try
            {
                List<EntryOrderData> listaEntry = new List<EntryOrderData>();
                //El query.
                string Query = "exec Get_EntryOrder";
                //La consulta
                SqlCommand cmd = new SqlCommand(Query, conex);

                //El proceso
                conex.Open();
                SqlDataReader Reader = cmd.ExecuteReader();
                while (Reader.Read())
                {
                    listaEntry.Add(
                        new EntryOrderData(
                            new Petition
                            (
                                Reader.GetInt32(0),
                                Reader.GetInt32(3),
                                Reader.GetDateTime(1),
                                Reader.GetString(2)
                            ),
                            new ClientContact(
                                    Reader.GetInt32(4),
                                    new Locations(
                                        Reader.GetInt32(7),
                                        Reader.GetString(8),
                                        Reader.GetString(9),
                                        Reader.GetString(10),
                                        Reader.GetString(11),
                                        Reader.GetInt32(12),
                                        Reader.GetString(13)
                                    ),
                                    new Contact(
                                          Reader.GetString(15),
                                          Reader.GetString(16),
                                          Reader.GetInt32(14)
                                    )))
                    );
                }
                conex.Close();
                return listaEntry;

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

        public void tomarEntradas(int idAccesories)
        {
            try
            {
                //El query.
                string Query = "exec Add_AccesoriesEntrance @idAccesories";
                //La consulta
                SqlCommand cmd = new SqlCommand(Query, conex);
                //Los parametros
                cmd.Parameters.AddWithValue("@idAccesories", idAccesories);

                //El proceso
                conex.Open();
                cmd.ExecuteNonQuery();
                
                conex.Close();
                MessageBox.Show("Datos ingresados correctamente");
            }
            catch (SqlException ex)
            {
                if (conex.State != System.Data.ConnectionState.Closed)
                {
                    conex.Close();
                }
                MessageBox.Show(ex.Message);

            }
            catch (Exception ex)
            {
                if (conex.State != System.Data.ConnectionState.Closed)
                {
                    conex.Close();
                }
                MessageBox.Show(ex.Message);

            }
        }


        public List<EntradaSt> llenarDgvEntrada(int id)
        {
            try
            {
                List<EntradaSt> listEntrada = new List<EntradaSt>();
                //El query.
                string Query = "exec Get_Entrance @idEquipment";

                //La consulta
                SqlCommand cmd = new SqlCommand(Query, conex);

                //Los parametros
                cmd.Parameters.AddWithValue("@idEquipment", id);

                //El proceso
                conex.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    EntradaSt entry;
                    long idEntr = reader.GetInt64(0);
                    string tipo = reader.GetString(1);
                    string marca = reader.GetString(2);
                    string modelo = reader.GetString(3);
                    string serial = reader.GetString(4);
                    string falla = reader.GetString(5);
                    DateTime dat = reader.GetDateTime(6);
                    entry = new EntradaSt(idEntr, tipo, marca, modelo, serial, falla, dat);
                    listEntrada.Add(entry);
                }

                conex.Close();
                return listEntrada;
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
