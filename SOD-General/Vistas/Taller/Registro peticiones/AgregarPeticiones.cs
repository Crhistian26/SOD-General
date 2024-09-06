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
        List<ClientContact> ContactList = new List<ClientContact>();

        List<Locations> ListLoc = new List<Locations>();
        public AgregarPeticiones()
        {
            InitializeComponent();

            this.vista = vista;
        }
        private void CentrarElementos()
        {
            Point SubL = cR_Subtitulos4.Location;
            cR_Subtitulos4.Location = _size.CentrarElementosX(SubL, cR_Subtitulos4.Size, this.Size);

            Size panel = new Size(cR_SplitContainer1.Width, (cR_SplitContainer1.Height - cR_SplitContainer1.SplitterDistance));
            panel1.Location = _size.CentrarElementosXY(panel1.Size, panel);

        }

        private void AgregarPeticiones_Load(object sender, EventArgs e)
        {
            CentrarElementos();
            cbRncClient();
            cbRncLoc();
        }



        private void AgregarPeticiones_Resize(object sender, EventArgs e)
        {
            CentrarElementos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }


        public void cbRncClient()
        {
            cbClient.Items.Clear();
            ContactList = Ccontroller.ViewClient();
            
            cbClient.SelectedItem = null;

            foreach (var ListCont in ContactList)
            {
                cbClient.Items.Add(ListCont.locat.Identifier);
            }

            
        }
        public void cbRncLoc()
        {
            CbCont.Items.Clear();
            ContactList = Ccontroller.ViewClient();

            foreach (var b in ContactList)
            {
                cbClient.Items.Add(b.contc.identifier);

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
