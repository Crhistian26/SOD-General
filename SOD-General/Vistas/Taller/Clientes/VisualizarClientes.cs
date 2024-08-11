using Modelos.Taller;
using SOD_General.Controladores;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SOD_General.Vistas.Taller.Clientes
{
    public partial class VisualizarClientes : Form
    {
        ClientController controller = new ClientController();
        VisualizarSucursales sucursal;

        
        
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
            string que = "Select _Client from Client";
            cbCliente.Items.Add(controller.RellenarComboBox(cbCliente,que));
        }

        private void llenarGridClientes()
        {
            List<Client> clientes = new List<Client>();
            clientes = controller.ViewClient();

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

            MessageBox.Show(id.ToString());
        }
    }
}
