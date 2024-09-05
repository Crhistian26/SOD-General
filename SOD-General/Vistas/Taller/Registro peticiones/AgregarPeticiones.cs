using Modelos.Taller;
using SOD_General.Controladores;
using SOD_General.Vistas.Taller.Registro_peticiones;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SOD_General.Taller.Registro_peticiones
{
    public partial class AgregarPeticiones : Form
    {
        SizesGenerales _size = new SizesGenerales();
        AppVistaGeneral vista;
        ClientController Ccontroller = new ClientController();
        int elegido = 0;
        List<Client> ClientList = new List<Client>();
        List<Locations> ListLoc = new List<Locations>();
        public AgregarPeticiones()
        {
            InitializeComponent();

            this.vista = vista;
        }
        private void CentrarElementos()
        {
            Point SubL = panelTitulo.Location;
            panelTitulo.Location = _size.CentrarElementosX(SubL, panelTitulo.Size, this.Size);

            Size panel = new Size(cR_SplitContainer1.Width, (cR_SplitContainer1.Height - cR_SplitContainer1.SplitterDistance));
            panel1.Location = _size.CentrarElementosXY(panel1.Size, panel);

        }

        private void AgregarPeticiones_Load(object sender, EventArgs e)
        {
            CentrarElementos();
            cbRellenarRNC();
            cbRellenarCl();
        }



        private void AgregarPeticiones_Resize(object sender, EventArgs e)
        {
            CentrarElementos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }


        public void cbRellenarRNC()
        {
            ClientList = Ccontroller.RellenarComboBox();
            cbClient.Items.Clear();
            cbClient.SelectedItem = null;

            foreach (var a in ClientList)
            {
                cbClient.Items.Add(a._Identifier);
                //  cbRNC.Tag = a.IdClient;
            }

            
        }

        public void cbRellenarCl()
        {
            ClientList = Ccontroller.RellenarComboBox();
            CbCliente.Items.Clear();
            CbCliente.SelectedItem = null;

            foreach (var a in ClientList)
            {
             //   CbCliente.Items.Add(a);
                //     CbCliente.Tag = a.IdClient;

            }
        }
        public void cbRellenarLoc(int a)
        {
            ListLoc = Ccontroller.ViewLocation(a);
            if (ListLoc != null)
            {
                foreach (var b in ListLoc)
                {
                }
            }
            else
            {

            }

        }






        private void chkSucursal_CheckedChanged(object sender, EventArgs e)
        {
        
        }

        private void CbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cbRNC_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }



        private void RncCliente_CheckedChanged(object sender, EventArgs e)
        {
        
        }

        private void pnlRnc_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
