using Modelos.Control_de_usuarios;
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
    public class Administrator_Controller
    {
        static SizesGenerales _size = new SizesGenerales();
        static string connectionstring = ConfigurationManager.ConnectionStrings["Conex"].ConnectionString;
        static SqlConnection conex = new SqlConnection(connectionstring);
        #region Usuarios
        public List<Model_User> GetAllUsers()
        {
            try
            {

                return null;
            }
            catch (SqlException ex)
            {
                _size.ChechekConnection(conex);
                MessageBox.Show(ex.Message);
                return null;
            }
            catch (Exception ex)
            {
                _size.ChechekConnection(conex);
                MessageBox.Show(ex.Message);
                return null;
            }

        }

        public Model_User GetOneUsers(int id)
        {
            try
            {

                return null;
            }
            catch (SqlException ex)
            {
                _size.ChechekConnection(conex);
                MessageBox.Show(ex.Message);
                return null;
            }
            catch (Exception ex)
            {
                _size.ChechekConnection(conex);
                MessageBox.Show(ex.Message);
                return null;
            }

        }
        #endregion

        #region Modulos
        public List<Model_User> GetAllModules()
        {
            try
            {

                return null;
            }
            catch (SqlException ex)
            {
                _size.ChechekConnection(conex);
                MessageBox.Show(ex.Message);
                return null;
            }
            catch (Exception ex)
            {
                _size.ChechekConnection(conex);
                MessageBox.Show(ex.Message);
                return null;
            }

        }
        #endregion
    }
}
