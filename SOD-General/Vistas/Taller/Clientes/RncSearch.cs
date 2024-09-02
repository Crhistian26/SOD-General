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
    public partial class RncSearch : Form
    {
        ClientController clieControl = new ClientController();
        private bool cambioSelectIndex = false;

        public RncSearch()
        {
            InitializeComponent();
            verRnc();
            llenarCbRnc();
        }

     

       private void llenarCbRnc()
        {
            List<Locations> locList = clieControl.Rellenado();
            foreach (Locations loc in locList) 
            {
                cmbNmb.Items.Add(loc._Location);
                cmbNmb.Tag = loc.IdLocation;

                cmbRnc.Items.Add(loc.Identifier);
                cmbNmb.Tag = loc.IdClient;
            }

        }

        public void verRnc()
        {
            List<Locations> cliente = clieControl.LlenarDataGridRNC();
            dgvRncSearch.Rows.Clear();

            foreach (Locations client in cliente)
            {
                dgvRncSearch.Rows.Add(client.IdClient, client._Location, client.Identifier, client.Addrees, client.Phone1, client.Phone2);
            }
        }

        private void cmbNmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!cambioSelectIndex)
            {
                cambioSelectIndex = true;
                cmbRnc.SelectedItem = null;
                cambioSelectIndex = false;
            }
        }

        private void cmbRnc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!cambioSelectIndex)
            {
                cambioSelectIndex = true;
                cmbNmb.SelectedItem = null;
                cambioSelectIndex = false;
            }
        }
    }
}
