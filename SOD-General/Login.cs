using Controladores;
using Modelos.Control_de_usuarios;
using Modelos.Usuarios_Empleados.Control_de_usuario;
using SOD_General.Controladores;
using SOD_General.Vistas.Recursos_Humanos.Exportar;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SOD_General
{

    public partial class Login : Form
    {

        VistaPrincipal principal { get; set; }
        SizesGenerales _size = new SizesGenerales();

        public Login(VistaPrincipal principal)
        {
            InitializeComponent();
            this.principal = principal;

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            LoginController controller = new LoginController();

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
           panel1.Location = _size.CentrarElementosXY(panel1.Size, this.Size);
        }

        private void Login_Resize(object sender, EventArgs e)
        {
            panel1.Location = _size.CentrarElementosXY(panel1.Size, this.Size);
        }
    }

}
