using SOD_General.Controladores;
using System;
using System.Windows.Forms;

namespace SOD_General.Vistas.Taller.Pruebadiseño
{
    public partial class AddEnterprise : Form
    {
        ClientController CliControl = new ClientController();
        public AddEnterprise()
        {
            InitializeComponent();
        }

        private void btn_AgregarRNC_Click(object sender, System.EventArgs e)
        {
            int a = Convert.ToInt32(txtRNC.Text);
            CliControl.AgregarCliente(a);
        }
    }
}
