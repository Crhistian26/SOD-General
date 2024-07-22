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

        //Este es el controlador para usar sus funciones .
        LoginController control = new LoginController();


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
            List<MAuthorization> Autorizaciones = control.Ingresar(textBox1.Text, textBox2.Text);
            
            //Me limpia los textboxs
            textBox1.texts = null;
            textBox2.texts = null;

            //En caso que sea nulo me ejecuta la funcion desde la VistaPrincipal
            if(Autorizaciones != null)
            {
                principal.AbrirVistaGeneral(Autorizaciones);
            }
            
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void texc2__holaPAPA(object sender, EventArgs e)
        {
            MessageBox.Show("Hola bro soy el primero");
        }

        private void texc1__holaPAPA(object sender, EventArgs e)
        {
            MessageBox.Show("Hola bro soy el segundo");
        }

        private void textBox1__TextChanged(object sender, EventArgs e)
        {

        }
    }

}
