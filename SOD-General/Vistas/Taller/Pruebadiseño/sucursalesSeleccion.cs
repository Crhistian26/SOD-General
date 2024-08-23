using Modelos.Taller;
using SOD_General.Controladores;
using SOD_General.Vistas.Taller.Clientes;
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
        List<Client> cliente = new List<Client>();
        VisualizarSucursales Sucursal;

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

        private void sucursalesSeleccion_Load(object sender, EventArgs e)
        {
            cbRnc();
            CbClienteLlenar();
        }

        private void CbClienteLlenar()
        {
            cliente = clientContr.RellenarComboBox();

            cbCliente.Items.Clear();
            cbCliente.SelectedItem = null;

            foreach (var client in cliente)
            {
                cbCliente.Items.Add(client._NameBranch);
            }

        }

        private bool isUpdating = false;
        private void cbRnc2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isUpdating) return;

            try
            {
                isUpdating = true;
                cbCliente.SelectedItem = null;
            }
            finally
            {
                isUpdating = false;
            }

            string cb = cbRnc2.SelectedItem.ToString();

            Client especifi = cliente.Where(c => c._Identifier == cb).FirstOrDefault();
            dgvClientes.Rows.Clear();
            dgvClientes.Rows.Add(especifi.IdClient, especifi._Identifier, especifi._NameBranch, especifi._Address, especifi.Phone_1, especifi.Phone_2, especifi._Contact);
        }

        private void cbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isUpdating) return;

            try
            {
                isUpdating = true;
                cbRnc2.SelectedItem = null;
            }
            finally
            {
                isUpdating = false;
            }


           string cb = cbCliente.SelectedItem.ToString();

                Client especifi = cliente.Where(c => c._NameBranch == cb).FirstOrDefault();
                dgvClientes.Rows.Clear();
                dgvClientes.Rows.Add(especifi.IdClient, especifi._Identifier, especifi._NameBranch, especifi._Address, especifi.Phone_1, especifi.Phone_2, especifi._Contact);

            
        }

        private void llenarGridClientes()
        {
            cliente = clientContr.ViewClient();
            dgvClientes.Rows.Clear();

            foreach (Client client in cliente)
            {
                dgvClientes.Rows.Add(client.IdClient, client._Identifier, client._NameBranch, client._Address, client.Phone_1, client.Phone_2, client._Contact);
            }
        }

        private void cR_DataGriedView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvClientes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgvClientes.Rows[e.RowIndex];
            int id = Convert.ToInt32(fila.Cells[0].Value);
            Sucursal = new VisualizarSucursales(id);

            var formu = Application.OpenForms.OfType<VisualizarSucursales>().FirstOrDefault();
            if(formu != null)
            {
                formu.Close();
            }
            Sucursal.Show();
        }
    }
}
