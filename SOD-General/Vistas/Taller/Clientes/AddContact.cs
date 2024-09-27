using Modelos.Taller;
using SOD_General.Controladores;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SOD_General.Vistas.Taller.Pruebadiseño
{
    public partial class AddContact : Form
    {
        ClientController cliCont = new ClientController();
        public AddContact()
        {
            InitializeComponent();
        }

        public void LlenarRnc()
        {
            List<Client> lista = new List<Client>();
            lista = cliCont.ViewIdentifier();    
            foreach (var ver in lista )
            {
                CbRnc.Items.Add(ver._Identifier);                                                                                                                                                                                                                                                                                                                                                                                                                                                         

            }
        }

        private void CbRnc_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }


    }
}
