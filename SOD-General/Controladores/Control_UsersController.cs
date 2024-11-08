using Modelos.Control_de_usuarios;
using SOD_General.Vistas.Recursos_Humanos.Empleados;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOD_General.Controladores
{
    internal class Control_UsersController
    {
        static private General_Controller _general = new General_Controller();

        static private SqlConnection conex = _general.GetConnection();

        public void CloseForms(Form form)
        {
            var win = Application.OpenForms.OfType<Control_Empleados>().FirstOrDefault();
            if (win != null)
            {
                win.Close();
            }
            Control_Empleados hola = new Control_Empleados();
            hola.Show();
        }

        public List<Model_User> Get_Users()
        {
            try
            {
                List<Model_User> list = new List<Model_User>();
                //El query.
                string Query = "select IdUser,_Name,_Lastname,_User,_Role from Users_Details";
                //La consulta
                SqlCommand cmd = new SqlCommand(Query, conex);
                //El proceso
                conex.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string Name = reader.GetString(1)+" "+reader.GetString(2);
                    string User = reader.GetString(3);
                    Model_Role role = new Model_Role(reader.GetString(4));

                    Model_User user = new Model_User(id, Name, User, role);
                    list.Add(user);
                }
                conex.Close();
                return list;

            }
            catch (SqlException ex)
            {
                _general.ChechekConnection(conex);
                MessageBox.Show(ex.Message);
                return null;
            }
            catch (Exception ex)
            {
                _general.ChechekConnection(conex);
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public List<Model_Role> Get_Roles_ForCombobox()
        {
            try
            {
                List<Model_Role> list = new List<Model_Role>();
                //El query.
                string Query = "select IdRole,_Role from Roles";
                //La consulta
                SqlCommand cmd = new SqlCommand(Query, conex);
                //El proceso
                conex.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string Role = reader.GetString(1);

                    Model_Role role = new Model_Role(id, Role);
                    list.Add(role);
                }
                conex.Close();
                return list;

            }
            catch (SqlException ex)
            {
                _general.ChechekConnection(conex);
                MessageBox.Show(ex.Message);
                return null;
            }
            catch (Exception ex)
            {
                _general.ChechekConnection(conex);
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public List<Model_Operations> Get_Operations()
        {
            try
            {
                List<Model_Operations> list = new List<Model_Operations>();
                //El query.
                string Query = "select IdOperation,_Operation,_Module from Operations_Details;";
                //La consulta
                SqlCommand cmd = new SqlCommand(Query, conex);
                //El proceso
                conex.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string NameOpe = reader.GetString(1);
                    string Module = reader.GetString(2);
                    

                    Model_Operations operation = new Model_Operations(id,Module,NameOpe);
                    list.Add(operation);
                }
                conex.Close();
                return list;

            }
            catch (SqlException ex)
            {
                _general.ChechekConnection(conex);
                MessageBox.Show(ex.Message);
                return null;
            }
            catch (Exception ex)
            {
                _general.ChechekConnection(conex);
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public List<(Model_Role,int)> Get_RolesBasicWithCount()
        {
            try
            {
                List<(Model_Role,int)> list = new List<(Model_Role,int)>();

                //El query.
                string Query = "select * from Rol_With_NumberUsers";
                //La consulta
                SqlCommand cmd = new SqlCommand(Query, conex);
                //El proceso
                conex.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int Oid = reader.GetInt32(0);
                    string Operation = reader.GetString(1);
                    int count = reader.GetInt32(2);
                    list.Add((new Model_Role(Oid, Operation),count));

                }
                conex.Close();

                return list;
            }
            catch (SqlException ex)
            {
                _general.ChechekConnection(conex);
                MessageBox.Show(ex.Message);
                return null;
            }
            catch (Exception ex)
            {
                _general.ChechekConnection(conex);
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public List<Model_Operations> Get_OperationsForRoleId(int id)
        {
            try
            {
                List<Model_Operations> list = new List<Model_Operations>();

                //El query.
                string Query = "exec Get_OperationsForRoleId @id";
                //La consulta
                SqlCommand cmd = new SqlCommand(Query, conex);
                cmd.Parameters.AddWithValue("@id", id);
                //El proceso
                conex.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int Oid = reader.GetInt32(0);
                    string Operation = reader.GetString(1);
                    string Module = reader.GetString(2);
                    list.Add(new Model_Operations(Oid, Operation, Module));
                }
                conex.Close();

                return list;
            }
            catch (SqlException ex)
            {
                _general.ChechekConnection(conex);
                MessageBox.Show(ex.Message);
                return null;
            }
            catch (Exception ex)
            {
                _general.ChechekConnection(conex);
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public List<Model_Module> Get_Modules()
        {
            try
            {
                List<Model_Module> list = new List<Model_Module>();
                //El query.
                string Query = "select IdModule,_Module from Module;";
                //La consulta
                SqlCommand cmd = new SqlCommand(Query, conex);
                //El proceso
                conex.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string Module = reader.GetString(1);

                    Model_Module module = new Model_Module(id, Module);
                    list.Add(module);
                }
                conex.Close();
                return list;

            }
            catch (SqlException ex)
            {
                _general.ChechekConnection(conex);
                MessageBox.Show(ex.Message);
                return null;
            }
            catch (Exception ex)
            {
                _general.ChechekConnection(conex);
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        
        public Model_User Get_UserDetailed(int id)
        {
            try
            {
                List<Model_Operations> list = new List<Model_Operations>();
                Model_Role role = new Model_Role(1,"");
                Model_User user = new Model_User();
                //El query.
                string Query = "exec Get_OperationsForUserId @id";
                //La consulta
                SqlCommand cmd = new SqlCommand(Query, conex);
                cmd.Parameters.AddWithValue("@id", id);
                //El proceso
                conex.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int Oid = reader.GetInt32(0);
                    string Operation = reader.GetString(1);
                    string Module = reader.GetString(2);
                    list.Add(new Model_Operations(Oid,Module, Operation));
                }
                conex.Close();

                conex.Open();
                Query = "exec Get_RoleForUserId @id";
                cmd = new SqlCommand(Query, conex);
                cmd.Parameters.AddWithValue("@id", id);
                SqlDataReader reader2 = cmd.ExecuteReader();
                if (reader2.Read())
                {
                    role = new Model_Role
                        (
                        reader2.GetInt32(0),
                        reader2.GetString(1),
                        list
                        );
                }
                conex.Close();

                conex.Open();
                Query = "exec Get_UserDetailedForId @id";
                cmd = new SqlCommand(Query, conex);
                cmd.Parameters.AddWithValue("@id", id);
                SqlDataReader reader3 = cmd.ExecuteReader();
                if (reader3.Read())
                {
                    user = new Model_User(
                        reader3.GetInt32(0),
                        reader3.GetInt32(1),
                        role,
                        reader3.GetString(2)+" "+reader3.GetString(3),
                        reader3.GetString(4),
                        reader3.GetString(5),
                        reader3.GetBoolean(6)
                        );
                }
                conex.Close();
                return user;
            }
            catch (SqlException ex)
            {
                _general.ChechekConnection(conex);
                MessageBox.Show(ex.Message);
                return null;
            }
            catch (Exception ex)
            {
                _general.ChechekConnection(conex);
                MessageBox.Show(ex.Message);
                return null;
            }
        }

    }
}
