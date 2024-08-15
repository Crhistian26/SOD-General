using Modelos.Taller;
using SOD_General.Controladores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace SOD_General.Vistas.Taller.Registro_peticiones
{
    public partial class AgregarClientes : Form
    {
        //instancia del modelo de clientes
        
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
            cbRnc();  
        }

        private void Cb_ClienteSucursal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cb_ClienteSucursal.SelectedIndex == 0)
            {
                panelCliente.Visible = true;
                PanelRncCliente.Visible = true;

                panelRncSucursal.Visible = false;
                panelSucursal.Visible = false;
            }
            else if (Cb_ClienteSucursal.SelectedIndex == 1)
            {
                panelSucursal.Visible = true;
                panelRncSucursal.Visible = true;

                PanelRncCliente.Visible = false;
                panelCliente.Visible = false;
            }
        }

        private void btn_AgregarClientes_Click_1(object sender, EventArgs e)
        {
            if (txtDireccion.Text.Trim().Length == 0 || txtCedula.Text.Trim().Length == 0 || txtContacto.Text.Trim().Length == 0 || txtNumero1.Text.Trim().Length == 0 || txtNumero2.Text.Trim().Length == 0)
            {
                MessageBox.Show("Por favor, rellene todos los campos del cliente");
            }
            else
            {
                Client cliente = new Client(null, txtCedula.Text.ToString(), txtCliente.Text.ToString(), txtDireccion.Text.ToString(), txtNumero1.Text.ToString(), txtNumero2.Text.ToString(), txtContacto.Text.ToString());

                 clientContr.AgregarCliente(cliente);
                
            }
        }

        private void btn_Sucursal_Click(object sender, EventArgs e)
        {
            if (cbRnc2.SelectedIndex == null || txtSucursal.Text.Trim().Length == 0 || txtContactoSucur.Text.Trim().Length == 0 ||
                txtDireccionSucur.Text.Trim().Length == 0 || txtNumero1Sucur.Text.Trim().Length == 0 || txtNumero2Sucur.Text.Trim().Length == 0)
            {
                MessageBox.Show("Por favor, rellene todos los campos de la sucursal");
            }
            else 
            {
                Locations locat = new Locations(null, null, cbRnc2.SelectedItem.ToString(),txtSucursal.Text, txtDireccionSucur.Text, 
                    txtNumero1Sucur.Text, txtNumero2Sucur.Text, txtContactoSucur.Text);


                clientContr.AgregarSucursal(locat);
            }

        }
        public void cbRnc()
        {
            List<Client> lisCli = new List<Client>();
            lisCli = clientContr.RellenarComboBox();

            cbRnc2.Items.Clear();
            cbRnc2.SelectedItem = null;

            foreach (var client in lisCli)
            {
                cbRnc2.Items.Add(client._Identifier);
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
           // clientContr.ViewLocation();
        }
    }
}
