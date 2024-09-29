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

namespace SOD_General.Vistas.Taller.Clientes
{
    public partial class AddLocations : Form
    {
        ClientController clieControl =  new ClientController();
        public AddLocations()
        {
            InitializeComponent();
        }

        private void btn_AgregarClientes_Click(object sender, EventArgs e)
        {
           clieControl.AgregarSucursal(txtCliente.Text, txtDireccion.Text, txtNumero1.Text, txtNumero2.Text, CbRnc.SelectedItem.ToString(), CbContact.SelectedItem.ToString(), cbTipoCliente.SelectedItem.ToString());
            txtCliente.Text = null;
            txtDireccion.Text = null;
            txtNumero1.Text = null;
            txtNumero2.Text = null;
            CbContact.SelectedItem = null;
            CbRnc.SelectedItem = null;
        }

        private void btnBuscarRnc_Click(object sender, EventArgs e)
        {
            RncSearch rncSearch = new RncSearch();
            rncSearch.Show();   
        }

        private void btnBuscarCtc_Click(object sender, EventArgs e)
        {
            //if (CbRnc.SelectedItem != null)
            //{
                string rnc = CbRnc.SelectedItem.ToString();
                ContactoSearch contactoSearch = new ContactoSearch(rnc);
                contactoSearch.Show();
            //}
            //else
            //{
            //    MessageBox.Show("Primero seleccione el numero de identificacion de la entidad");
            //}
        }



        public void cbRncRelleno()
        {
           List<Client> cliente = clieControl.ViewIdentifier();

            CbRnc.Items.Clear();
            CbRnc.SelectedItem = null;

            foreach (var client in cliente)
            {
                CbRnc.Items.Add(client._Identifier);
            }
        }

        public void cbCtcRelleno(string a)
        {
            if (CbRnc.SelectedItem != null)
            {
                string rnc = a;
                List<Contact> contact = clieControl.ContactDataSearch(rnc);

                CbContact.Items.Clear();
                CbContact.SelectedItem = null;

                foreach (var cont in contact)
                {
                    CbContact.Items.Add(cont.ContactName);
                }
            }
        }

        private void CbContact_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CbRnc_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbCtcRelleno(CbRnc.SelectedItem.ToString());
        }

        private void AddLocations_Load(object sender, EventArgs e)
        {
            cbRncRelleno();
        }
    }
}
