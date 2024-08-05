using Modelos.Taller;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SOD_General.Controladores
{
    public class ClientController
    {
        static string cadena = ConfigurationManager.ConnectionStrings["Conex"].ConnectionString;
        SqlConnection conex = new SqlConnection(cadena);
        
        /// <summary>
        /// usando el Procedimiento Add_Client y el modelo de Client, se suben los datos y se llenan los parametros
        /// </summary>
        /// <param name="cli"></param>
        /// 
        public void AgregarCliente(Client cli)
        {
            try
            {
                MessageBox.Show(cli._NameBranch + "\n" + cli._Address);
                string Query = "Exec Add_Client @Identifier, @Client, @Address, @Phone1, @Phone2, @Contact";
                conex.Open();
                SqlCommand cmd = new SqlCommand(Query, conex);
                cmd.Parameters.Add("@Identifier", cli._Identifier);
                cmd.Parameters.Add("@Client", cli._NameBranch);
                cmd.Parameters.Add("@Address", cli._Address);
                
                cmd.Parameters.Add("@Phone1", cli.Phone_1);
                cmd.Parameters.Add("@Phone2", cli.Phone_2);
                cmd.Parameters.Add("@Contact", cli._Contact);
                
                cmd.ExecuteNonQuery();
                conex.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show("Cliente no registrado: " + ex.ToString());
            }
        }

        /*
         if (selec == "Empleados")

              {
                  //En caso que el id de la operacion sea el 5 (visualizar empleados) se creara el evento de abrir ese formulario.
                  if (ope.Id == 23)
                  {
                      //El evento.
                      EventHandler evento = delegate (object sender, EventArgs e)
                      {
                          //El metodo que tiene el evento.
                          Empleados ventana = new Empleados(vista);
                          vista.AbrirFormulario(ventana);
                      };

                      //Se retorna el evento.
                      return evento;
                  }

                  if (ope._Operation == "Ver empleados")
                  {
                      EventHandler evento = delegate (object sender, EventArgs e)
                      {
                          
                      };

                      return evento;
                  }

              }

  if (selec == "Asistencias")
              {
                  if (ope._Operation == "Ver asistencias")
                  {
                      EventHandler evento = delegate (object sender, EventArgs e)
                      {
                          Registros_GeneralesAsistencias ventana = new Registros_GeneralesAsistencias(vista);
                          vista.AbrirFormulario(ventana);
                      };

                      return evento;
                  }

              }

              if (selec == "Permisos")
              {
                  if (ope._Operation == "Ver permisos")
                  {
                      EventHandler evento = delegate (object sender, EventArgs e)
                      {
                          Registros_GeneralesPermisos ventana = new Registros_GeneralesPermisos(vista);
                          vista.AbrirFormulario(ventana);
                      };

                      return evento;
                  }
              }

              if (selec == "Reportes de RRHH")
              {
                  if (ope._Operation == "Exportar reporte" && ope.Module_Name == "Reportes de RRHH")
                  {
                      EventHandler evento = delegate (object sender, EventArgs e)
                      {
                          ExportarReportesRRHH ventana = new ExportarReportesRRHH();
                          vista.AbrirFormulario(ventana);
                      };

                      return evento;
                  }
              }



         */

    }


}
