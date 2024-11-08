using DocumentFormat.OpenXml.Spreadsheet;
using Modelos.Control_de_usuarios;
using SOD_General.Controladores;
using SOD_General.Vistas.Control_de_usuarios.Usuarios;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SOD_General.Vistas.Control_de_usuarios.Roles
{
    public partial class Visual_Roles : Form
    {
        General_Controller General_Controller = new General_Controller();
        Control_UsersController Control_UsersController = new Control_UsersController();
        List<(Model_Role, int)> Roles = new List<(Model_Role, int)>();
        public Visual_Roles()
        {
            InitializeComponent();
        }

        private void Load_DataGried()
        {
            Roles = Control_UsersController.Get_RolesBasicWithCount();
            cR_DataGriedView1.Rows.Clear();
            if (Roles != null)
            {
                foreach ((Model_Role,int) role in Roles)
                {
                    cR_DataGriedView1.Rows.Add
                        (
                            role.Item1.Id_Role,
                            role.Item1.Name,
                            role.Item2.ToString()
                        );
                }
            }
        }

        private void cR_DataGriedView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow fila = cR_DataGriedView1.Rows[e.RowIndex];
                int id = Convert.ToInt32(fila.Cells[0].Value);

                ControlRoles visual = new ControlRoles(id);
                visual.Show();
                General_Controller.CloseForm(visual);
            }
        }

        private void Visual_Roles_Load(object sender, EventArgs e)
        {
            Load_DataGried();
        }
    }
}
