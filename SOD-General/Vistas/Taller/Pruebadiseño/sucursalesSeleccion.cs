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

namespace SOD_General.Vistas.Taller.Pruebadiseño
{
    public partial class sucursalesSeleccion : Form
    {
        ClientController clientContr = new ClientController();
        public sucursalesSeleccion()
        {
            InitializeComponent();
        }

        private void cR_SplitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

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
    }
}
