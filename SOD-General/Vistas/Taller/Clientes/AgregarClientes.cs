using Modelos.Taller;
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


namespace SOD_General.Vistas.Taller.Registro_peticiones
{
    public partial class AgregarClientes : Form
    {
        Client cliente;
        ClientController clientContr = new ClientController();
        public AgregarClientes()
        {
            InitializeComponent();

            cliente = new Client(null, txtNombre.Text, txtDireccion.Text, txtCedula.Text, txtNumero1.Text, txtNumero2.Text, txtContacto.Text);
            clientContr.AgregarCliente(cliente);
        }

        

        private void fR_TextBox7__TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_AgregarClientes_Click(object sender, EventArgs e)
        {
           
            
        }

        private void txtContacto_TextChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
