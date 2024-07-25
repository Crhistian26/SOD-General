using Controladores;
using Modelos.Usuarios_Empleados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOD_General
{
    
    public partial class Login : Form
    {
        /// <summary>
        /// Este es el atributo de tipo VistaPrincipal para ejecutar sus 
        /// metodos desde aca, .
        /// </summary>
        VistaPrincipal principal { get; set; }

        /// <summary>
        /// Este es el controlador para usar las funciones de 
        /// la clase LoginController
        /// </summary>
        LoginController controller = new LoginController();


        //Su constructor donde recibe la vistaprincipal.
        public Login(VistaPrincipal principal)
        {
            InitializeComponent();
            this.principal = principal;
        }

        //El boton de login.
        private void botones_Nuevos1_Click(object sender, EventArgs e)
        {
            List<MAuthorization> authorizations;
            authorizations = controller.Ingresar(cr_Textbox1.Text,cr_Textbox2.Text);
            if(authorizations != null)
            {
                principal.AbrirVistaGeneral(authorizations);
            }
            cr_Textbox1.Clear();
            cr_Textbox2.Clear();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }

}
