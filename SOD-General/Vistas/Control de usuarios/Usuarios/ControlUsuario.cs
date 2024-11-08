using DocumentFormat.OpenXml.Spreadsheet;
using Modelos.Control_de_usuarios;
using SOD_General.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOD_General.Vistas.Control_de_usuarios.Usuarios
{
    public partial class ControlUsuario : Form
    {
        Control_UsersController Control_UsersController = new Control_UsersController();
        List<Model_Role> Roles = new List<Model_Role>();
        private Model_User _user;
        public ControlUsuario()
        {
            InitializeComponent();
        }
        public ControlUsuario(int id)
        {
            InitializeComponent();
            _user = Control_UsersController.Get_UserDetailed(id);
            Edit_View();
        }

        private void Load_ComboBox()
        {
            Roles = Control_UsersController.Get_Roles_ForCombobox();
            if (Roles != null)
            {
                foreach (Model_Role role in Roles)
                {
                    cr_ComboBox1.Items.Add(role.Name);
                }
            }
        }

        private void Load_DataGried(List<Model_Operations> operations)
        {
            cR_DataGriedView1.Rows.Clear();
            if (operations != null)
            {
                foreach (Model_Operations operation in operations)
                {
                    cR_DataGriedView1.Rows.Add
                        (
                            operation._Operation,
                            operation._Module
                        );
                }
            }
        }
        private void Edit_View()
        {
            cR_Subtitulos1.Text = "Editar usuario";
            cr_Textbox1.Text = _user.User_Name;
            Load_ComboBox();
            Load_DataGried(_user._Role._Operations);
            cr_ComboBox1.SelectedItem = _user._Role.Name;
            cr_Textbox2.Enabled = false;
            cr_Textbox3.Text = _user.Name;
        }

        private void ControlUsuario_Load(object sender, EventArgs e)
        {

        }

        private void botones_Nuevos4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
