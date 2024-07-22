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
        //Esta es la VistaPrincipal para ejecutar sus metodos desde aca.
        VistaPrincipal principal { get; set; }

        //Este es el controlador para usar sus funciones.
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
            //Aca me captura las autorizaciones del usuario con el metodo Ingresar.
            //List<MAuthorization> Autorizaciones = control.Ingresar(textBox1.texts, textBox2.texts);
            
            //Me limpia los textboxs.
            

            //En caso que sea nulo me ejecuta la funcion desde la VistaPrincipal.
            //if(Autorizaciones != null)
            //{
            //    principal.AbrirVistaGeneral(Autorizaciones);
            //}
            string depart;
            depart = controller.Ingresar(textBox1.texts,textBox2.texts,1);

            if(depart != null)
            {
                principal.AbrirVistaGeneral(depart);
            }
            textBox1.texts = null;
            textBox2.texts = null;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }

}
