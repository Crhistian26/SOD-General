using Modelos.Control_de_usuarios;
using SOD_General.Controladores;
using SOD_General.Recursos_Humanos.Empleados;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace SOD_General.Vistas.Control_de_usuarios.Usuarios
{
    public partial class Visual_Usuarios : Form
    {
        Control_UsersController Control_UsersController = new Control_UsersController();
        General_Controller General_Controller = new General_Controller();
        static List<Model_User> Users = new List<Model_User>();
        static List<Model_Role> Roles = new List<Model_Role>();
        public Visual_Usuarios()
        {
            InitializeComponent();
        }

        private void Load_DataGried()
        {
            Users = Control_UsersController.Get_Users();
            cR_DataGriedView1.Rows.Clear();
            if (Users != null)
            {
                foreach (Model_User user in Users)
                {
                    cR_DataGriedView1.Rows.Add
                        (
                            user.Id_User.ToString(),
                            user.Name,
                            user.User_Name,
                            user._Role.Name
                        );
                }
            }
        }

        private void Load_DataGried(List<Model_User> users)
        {
            cR_DataGriedView1.Rows.Clear();
            if (users != null)
            {
                foreach (Model_User user in users)
                {
                    cR_DataGriedView1.Rows.Add
                        (
                            user.Id_User.ToString(),
                            user.Name,
                            user.User_Name,
                            user._Role.Name
                        );
                }
            }
        }

        private void Load_Combobox()
        {
            Roles = Control_UsersController.Get_Roles_ForCombobox();
            if (Roles != null)
            {
                cr_ComboBox2.Items.Add("Todos los roles");
                foreach (Model_Role role in Roles)
                {
                    cr_ComboBox2.Items.Add(role.Name);
                }
            }
        }


        private void Visual_Usuarios_Load(object sender, System.EventArgs e)
        {
            Load_DataGried();
            Load_Combobox();
        }

        private void ChangeRoleComboBox()
        {
            var list = Users;
            string namerole = cr_ComboBox2.SelectedItem.ToString();
            if (namerole != "Todos los roles")
            {
                list = Users.Where(a => a._Role.Name == namerole).ToList();
            }
            Load_DataGried(list);
        }

        private void cR_DataGriedView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow fila = cR_DataGriedView1.Rows[e.RowIndex];
                int id = Convert.ToInt32(fila.Cells[0].Value);

                ControlUsuario visual = new ControlUsuario(id);
                visual.Show();
                General_Controller.CloseForm(visual);
            }
        }

        private void cr_ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeRoleComboBox();
        }

        private void botones_Nuevos1_Click(object sender, EventArgs e)
        {
            ControlUsuario view = new ControlUsuario();
            view.Show();
            General_Controller.CloseForm(view);
        }
    }
}
