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

namespace SOD_General.Vistas.Control_de_usuarios.Roles
{
    public partial class ControlRoles : Form
    {
        SizesGenerales _size = new SizesGenerales();
        General_Controller General_Controller = new General_Controller();
        public ControlRoles()
        {
            InitializeComponent();
        }

        public ControlRoles(int id)
        {
            InitializeComponent();
        }
        private void ControlRoles_Load(object sender, EventArgs e)
        {

        }

        private void ControlRoles_Shown(object sender, EventArgs e)
        {
            _size.CloseForm(this);
        }

        private void botones_Nuevos1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
