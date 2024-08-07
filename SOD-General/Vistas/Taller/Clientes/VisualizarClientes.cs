using Modelos.Taller;
using SOD_General.Controladores;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SOD_General.Vistas.Taller.Clientes
{
    public partial class VisualizarClientes : Form
    {
        ClientController controller = new ClientController();
        
        public VisualizarClientes()
        {
            InitializeComponent();
            
        }

        

        private void cR_SplitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void VisualizarClientes_Load(object sender, System.EventArgs e)
        {
            llenarGrid();
        }

        private void llenarGrid()
        {
            List<Client> clientes = new List<Client>();
            clientes = controller.ViewClient();

            foreach (Client client in clientes) 
            {
                cR_DataGriedView1.Rows.Add(client.IdClient, client._Identifier, client._NameBranch, client._Address, client.Phone_1, client.Phone_2, client._Contact);
            
            }
        }
    }
}
