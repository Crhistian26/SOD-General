using DocumentFormat.OpenXml.Spreadsheet;
using Modelos.Control_de_usuarios;
using Modelos.Usuarios_Empleados;
using OfficeOpenXml.ExternalReferences;
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
        List<Employee> Employees = new List<Employee>();
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

        private void Load_ComboBoxEmployee()
        {

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
            cR_LabelDown2.Visible = false;
            cr_Textbox2.Visible = false;
            Load_ComboBox();
            Load_DataGried(_user._Role._Operations);
            cr_ComboBox1.SelectedItem = _user._Role.Name;
            cr_Textbox2.Enabled = false;
            cr_Textbox3.Text = _user.Name;
        }

        public void Add_View()
        {
            Load_ComboBox();
            botones_Nuevos1.Visible = false;
            cr_ComboBox2.Visible = true;
        }
        private void ControlUsuario_Load(object sender, EventArgs e)
        {

        }

        private void botones_Nuevos4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cr_ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cr_ComboBox1.SelectedIndex != -1)
            {
                int id = Roles.Where(r => r.Name == cr_ComboBox1.SelectedItem.ToString()).Select(r=> r.Id_Role).FirstOrDefault();
                if(id != 0)
                {
                    var list = Control_UsersController.Get_OperationsForRoleId(id);
                    Load_DataGried(list);
                }
                
            }
        }
    }
}
