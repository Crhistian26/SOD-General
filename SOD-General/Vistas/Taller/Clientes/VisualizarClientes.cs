using Modelos.Taller;
using SOD_General.Controladores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SOD_General.Vistas.Taller.Clientes
{
    public partial class VisualizarClientes : Form
    {
        ClientController controller = new ClientController();
        VisualizarSucursales sucursal;
        List<Client> clientes = new List<Client>();
        Client especifi;

        string cb = "";

        public VisualizarClientes()
        {
            InitializeComponent();

        }

        private void cR_SplitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void VisualizarClientes_Load(object sender, System.EventArgs e)
        {
            llenarGridClientes();
            cbFiltro.Items.Add("Nombre");
            cbFiltro.Items.Add("Rnc o Cedula");


        }
        private void cbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb = cbCliente.SelectedItem.ToString();

            if (cbFiltro.SelectedIndex == 0)
            {
                Client especifi = clientes.Where(c => c._NameBranch == cb).FirstOrDefault();
                dgvClientes.Rows.Clear();
                dgvClientes.Rows.Add(especifi.IdClient, especifi._Identifier, especifi._NameBranch, especifi._Address, especifi.Phone_1, especifi.Phone_2, especifi._Contact);

            }
            else if (cbFiltro.SelectedIndex == 1)
            {
                Client especifi = clientes.Where(c => c._Identifier == cb.ToString()).FirstOrDefault();
                dgvClientes.Rows.Clear();
                dgvClientes.Rows.Add(especifi.IdClient, especifi._Identifier, especifi._NameBranch, especifi._Address, especifi.Phone_1, especifi.Phone_2, especifi._Contact);


            }
            else
            {
                llenarGridClientes();

            }

        }

        //   int a = empleados[soD_ComboBox1.SelectedIndex].IdEmployee

        private void llenarGridClientes()
        {
            clientes = controller.ViewClient();
            dgvClientes.Rows.Clear();

            foreach (Client client in clientes)
            {
                dgvClientes.Rows.Add(client.IdClient, client._Identifier, client._NameBranch, client._Address, client.Phone_1, client.Phone_2, client._Contact);
            }
        }


        private void dgvClientes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgvClientes.Rows[e.RowIndex];
            int id = Convert.ToInt32(fila.Cells[0].Value);
            sucursal = new VisualizarSucursales(id);

            sucursal.Show();

        }

        public void cbLlenar(int a)
        {
            List<Client> lisCli = new List<Client>();
            lisCli = controller.RellenarComboBox();

            if (a == 0)
            {
                cbCliente.Items.Clear();
                cbCliente.SelectedItem = null;
                foreach (var client in lisCli)
                {
                    cbCliente.Items.Add(client._NameBranch);
                }
            }
            else
            {
                cbCliente.Items.Clear();
                cbCliente.SelectedItem = null;

                foreach (var client in lisCli)
                {
                    cbCliente.Items.Add(client._Identifier);
                }
            }
        }

        private void cbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            int b = cbFiltro.SelectedIndex;
            cbLlenar(b);
        }


    }
}
