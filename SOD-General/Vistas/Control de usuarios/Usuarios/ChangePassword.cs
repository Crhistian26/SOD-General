using Modelos.Control_de_usuarios;
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
    public partial class ChangePassword : Form
    {
        private int id;
        public ChangePassword(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {

        }

        private void Change_Password(object sender, EventArgs e)
        {
            if (cr_Textbox2.Text.Trim().Length > 5)
            {

            }
            else
            {
                MessageBox.Show("La contraseña debe ser mayor a 5 caracteres.");
            }
        }
    }
}
