using Modelos.Control_de_usuarios;
using SOD_General.Controladores;
using SOD_General.Vistas.Control_de_usuarios.Operaciones;
using SOD_General.Vistas.Control_de_usuarios.Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOD_General.Vistas.Control_de_usuarios.Roles
{
    public partial class ControlRoles : Form, IResetForm
    {
        SizesGenerales _size = new SizesGenerales();
        General_Controller General_Controller = new General_Controller();
        Control_UsersController Controller = new Control_UsersController();
        Model_Role _role = new Model_Role();
        int id;
        public ControlRoles()
        {
            InitializeComponent();
            AddRoleView();
        }

        public ControlRoles(int id)
        {
            InitializeComponent();
            this.id = id;   
            Reset();
            EditRoleView();
        }

        private void AddRoleView()
        {
            cR_Subtitulos1.Text = "Agregar rol";
            this.Text = "Agregar rol";
            botones_Nuevos3.Visible = false;
        }

        private void EditRoleView()
        {
            cR_Subtitulos1.Text = "Editar rol de "+ _role.Name;
            this.Text = "Editar rol de "+ _role.Name;
            cr_Textbox1.Text = _role.Name;
        }

        
        private void ControlRoles_Load(object sender, EventArgs e)
        {

        }

        public void Reset()
        {
            _role = Controller.Get_RoleDetailed(this.id);
            Load_DataGried();
        }

        private void ControlRoles_Shown(object sender, EventArgs e)
        {
            _size.CloseForm(this);
        }

        private void Load_DataGried()
        {
            cR_DataGriedViewNormal1.Rows.Clear();
            if (_role != null)
            {
                foreach (Model_Operations operation in _role._Operations)
                {
                    cR_DataGriedViewNormal1.Rows.Add
                        (
                            operation._Operation,
                            operation._Module
                        );
                }
            }
        }

        private void botones_Nuevos1_Click(object sender, EventArgs e)
        {
            EditOperationRole view = new EditOperationRole(_role._Operations);
            view.Show();
            General_Controller.CloseForm(view);
        }

        private void botones_Nuevos3_Click(object sender, EventArgs e)
        {
            var h = MessageBox.Show("Estas seguro de eliminar este rol?\nTe informamos que cada uno de los usuarios con este rol seran removidos del sistema hasta que alguien con tu mismo nivel de acceso los reinstrodusca con roles diferentes, aun con esta informacion estas seguro de eliminar el rol?", "Eliminar rol", MessageBoxButtons.YesNo);
            if(h == DialogResult.Yes)
            {
                MessageBox.Show("Usuario eliminado");
                General_Controller.ResetForm(new Visual_Roles());
                this.Close();
                
            }
        }
    }
}
