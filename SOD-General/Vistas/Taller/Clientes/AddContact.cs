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

        public void llenarCliente(string c)
        {

        //    int idRnc = Convert.ToInt32(lista.Where(b => b._Identifier == c).Select(a => a.IdClient).First());
                             
            List<Locations> locations = new List<Locations>();
            locations = cliCont.VerEmpresa(rnc);

            cbClient.Items.Clear();
            cbClient.SelectedItem = null;

            foreach (var loc in locations)
            {
                cbClient.Items.Add(loc._Location);
            }
              
        }

        private void CbRnc_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            rnc = cbRnc.SelectedItem.ToString();
            llenarCliente(rnc);
        }

        private void btnAgregContact_Click(object sender, System.EventArgs e)
        {
            cliCont.AgregarContacto(txtNombreCtc.Text.ToString(), cbRnc.SelectedItem.ToString(),cbClient.SelectedItem.ToString(), txtPhone1Ctc.Text.ToString());
        }

        private void AddContact_Load(object sender, System.EventArgs e)
        {
            LlenarRnc();
        }
    }
}
