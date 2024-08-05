using Modelos.Taller;
using SOD_General.Controladores;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace SOD_General.Vistas.Taller.Registro_peticiones
{
    public partial class AgregarClientes : Form
    {
        //instancia del modelo de clientes
        Client cliente;
        Locations locations;
        List<Client> listaCliente = new List<Client>();
       
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
           
            

        }

       

        private void botones_Nuevos1_Click(object sender, EventArgs e)
        {
            
        }

        private void AgregarClientes_Load(object sender, EventArgs e)
        {
            Cb_ClienteSucursal.Items.Add("Cliente");
            Cb_ClienteSucursal.Items.Add("Sucursal");

            
        }

        private void Cb_ClienteSucursal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cb_ClienteSucursal.SelectedIndex == 0)
            {
                panelCliente.Visible = true;
                panelSucursal.Visible = false;
            }
            else if (Cb_ClienteSucursal.SelectedIndex == 1)
            {
                panelSucursal.Visible = true;
                panelCliente.Visible = false;
            }
        }

        private void btn_AgregarClientes_Click_1(object sender, EventArgs e)
        {
            if (txtDireccion.Text.Trim().Length == 0 || txtCedula.Text.Trim().Length == 0 || txtContacto.Text.Trim().Length == 0 || txtNumero1.Text.Trim().Length == 0 || txtNumero2.Text.Trim().Length == 0)
            {
                MessageBox.Show("Por favor, rellene todos los campos");
            }
            else
            {
                 cliente = new Client(null, txtCliente.Text.ToString(), txtDireccion.Text.ToString(), txtCedula.Text.ToString(), txtNumero1.Text.ToString(), txtNumero2.Text.ToString(), txtContacto.Text.ToString());

                 clientContr.AgregarCliente(cliente);
                
            }
        }
    }
}
