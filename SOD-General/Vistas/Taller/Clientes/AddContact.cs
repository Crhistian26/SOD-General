using Modelos.Taller;
using SOD_General.Controladores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SOD_General.Vistas.Taller.Pruebadiseño
{
    public partial class AddContact : Form
    {
        ClientController cliCont = new ClientController();
        List<Client> lista = new List<Client>();
        string rnc = "";

        public AddContact()
        {
            InitializeComponent();
        }

        public void LlenarRnc()
        {
            lista = cliCont.ViewIdentifier();    
            foreach (var ver in lista )
            {
                cbRnc.Items.Add(ver._Identifier);                                                                                                                                                                                                                                                                                                                                                                                                                                                         

            }
        }

        

        private void CbRnc_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            rnc = cbRnc.SelectedItem.ToString();
        }

        private void btnAgregContact_Click(object sender, System.EventArgs e)
        {
            cliCont.AgregarContacto(txtNombreCtc.Text.ToString(), cbRnc.SelectedItem.ToString(), txtPhone1Ctc.Text.ToString());
        }

        private void AddContact_Load(object sender, System.EventArgs e)
        {
            LlenarRnc();
        }
    }
}
