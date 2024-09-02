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

        public RncSearch()
        {
            InitializeComponent();
            verRnc();
        }

        private void cR_SplitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

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
    }
}
