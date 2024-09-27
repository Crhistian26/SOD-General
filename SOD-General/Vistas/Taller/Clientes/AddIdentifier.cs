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
    public partial class AddIdentifier : Form
    {
        ClientController cliCon = new ClientController();
        public AddIdentifier()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            cliCon.AgregarCliente(txtIdentifier.Text.ToString());
            
            AddLocations addloc = new AddLocations();

            addloc.CbRnc.SelectedItem = txtIdentifier.Text.ToString();

            this.Close();
            RncSearch rncSearch = new RncSearch();
            rncSearch.Close();
            

        }
    }
}
