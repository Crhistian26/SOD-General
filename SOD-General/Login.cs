using Controladores;
using Modelos.Control_de_usuarios;
using Modelos.Usuarios_Empleados.Control_de_usuario;
using SOD_General.Vistas.Recursos_Humanos.Exportar;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SOD_General
{

    public partial class Login : Form
    {

        VistaPrincipal principal { get; set; }

        LoginController controller = new LoginController();

        public Login(VistaPrincipal principal)
        {
            InitializeComponent();
            this.principal = principal;

        }

        private void btn_login_Click(object sender, EventArgs e)
        {

            Model_User user;
            user = controller.Log_in(cr_Textbox1.Text, cr_Textbox2.Text);

            if(user != null)
            {
                if(user._Role._Operations.Count > 0)
                {
                    principal.AbrirVistaGeneral(user);
                }
                else
                {
                    MessageBox.Show("Sus permisos en la aplicacion fueron revocados."); 
                }
            }
            
            cr_Textbox1.Clear();
            cr_Textbox2.Clear();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }

}
