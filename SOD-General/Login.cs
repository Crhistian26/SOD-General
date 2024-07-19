using Controladores;
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
        VistaPrincipal principal { get; set; }

        LoginController control = new LoginController();

        public Login(VistaPrincipal principal)
        {
            InitializeComponent();
            this.principal = principal;
        }

        private void botones_Nuevos1_Click(object sender, EventArgs e)
        {
            principal.AbrirVistaGeneral(new AppVistaGeneral(control.Ingresar(textBox1.Text, textBox2.Text)));
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //texc1.AddCombo("Hola men");
            //texc1.AddCombo("Hola funciono");
            //texc2.AddCombo("Hola men");
            //texc2.AddCombo("Hola funciono");
        }

        private void texc2__holaPAPA(object sender, EventArgs e)
        {
            MessageBox.Show("Hola bro soy el primero");
        }

        private void texc1__holaPAPA(object sender, EventArgs e)
        {
            MessageBox.Show("Hola bro soy el segundo");
        }
    }

}
