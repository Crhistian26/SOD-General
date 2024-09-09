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
            cbRnc.Items.Clear();
            ContactList = Ccontroller.ViewClient();
            
            cbRnc.SelectedItem = null;

            foreach (var ListCont in ContactList)
            {
                cbRnc.Items.Add(ListCont.locat.Identifier);
            }

            
        }
        public void cbRncLoc()
        {
            cbContact.Items.Clear();
            ContactList = Ccontroller.ViewClient();

            foreach (var b in ContactList)
            {
                cbRnc.Items.Add(b.contc.identifier);

            }

        }

        private void chbEmpresa_CheckedChanged(object sender, EventArgs e)
        {
            chbCliente.Checked = false;
            pnlCliente.Visible = false;
            pnlRnc.Visible = true;
        }

        private void chbCliente_CheckedChanged(object sender, EventArgs e)
        {
            chbEmpresa.Checked = false;
            pnlRnc.Visible = false;
            pnlCliente.Visible = true;
        }
    }
}
