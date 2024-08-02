using Modelos.Taller;
using SOD_General.Controladores;
using System;
using System.Windows.Forms;


namespace SOD_General.Vistas.Taller.Registro_peticiones
{
    public partial class AgregarClientes : Form
    {
        //instancia del modelo de clientes
        Client cliente;

        //instancia de la clase que se encargara de agregar, editar y eliminar los clientes
        ClientController clientContr = new ClientController();

        public AgregarClientes()
        {
            InitializeComponent();
        }



        private void fR_TextBox7__TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_AgregarClientes_Click(object sender, EventArgs e)
        {

            if (txtCliente.Text.Trim().Length == 0)
            {
                string Sucursal = "No especificado";
                cliente = new Client(null, Sucursal, txtSucursal.Text, txtDireccion.Text, txtCedula.Text, txtNumero1.Text, txtNumero2.Text, txtContacto.Text);
                clientContr.AgregarCliente(cliente);
            }
            else
            {

                cliente = new Client(null, txtSucursal.Text, txtCliente.Text, txtDireccion.Text, txtCedula.Text, txtNumero1.Text, txtNumero2.Text, txtContacto.Text);

                cliente = new Client(null, txtCliente.Text, txtSucursal.Text, txtDireccion.Text, txtCedula.Text, txtNumero1.Text, txtNumero2.Text, txtContacto.Text);

                clientContr.AgregarCliente(cliente);
            }

        }

        private void txtContacto_TextChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void botones_Nuevos1_Click(object sender, EventArgs e)
        {
            //debera abrir formulario para crear una marca
        }
    }
}
