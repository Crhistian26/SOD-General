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
            CbSucursal.Items.Clear();
        }



        private void AgregarPeticiones_Resize(object sender, EventArgs e)
        {
            CentrarElementos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            RegistrarSolicitudEquipo regi = new RegistrarSolicitudEquipo(vista);
            vista.OpenForm(regi);
        }


        public void cbRellenarRNC()
        {
            ClientList = Ccontroller.RellenarComboBox();
            cbRNC.Items.Clear();
            cbRNC.SelectedItem = null;

            foreach (var a in ClientList)
            {
                cbRNC.Items.Add(a._Identifier);
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
                CbCliente.Items.Add(a._NameBranch);
                //     CbCliente.Tag = a.IdClient;

            }
        }
        public void cbRellenarLoc(int a)
        {
            ListLoc = Ccontroller.ViewLocation(a);
            CbSucursal.Items.Clear();
            if (ListLoc != null)
            {
                foreach (var b in ListLoc)
                {
                    CbSucursal.Items.Add(b._Location);
                }
            }
            else
            {

            }

        }






        private void chkSucursal_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSucursal.Checked)
            {
                CbSucursal.Enabled = true;

            }
            else
            {
                CbSucursal.Enabled = false;

            }
        }

        private void CbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbCliente.SelectedIndex != null)
            {
                string selection = CbCliente.Text;
                string view = ClientList.Where(m => m._NameBranch == selection)
                                        .Select(m => m._Identifier)
                                        .First();

                txtCliente.Text = view.ToString();
            }
            else
            {
                txtCliente.Text = null;
            }

            if (chkSucursal.Checked && CbCliente.SelectedIndex != null)
            {
                string select = CbCliente.Text;
                int? buscar = ClientList.Where(Z => Z._NameBranch == select)
                                        .Select(m => m.IdClient)
                                        .First();

                int busc = Convert.ToInt32(buscar);
                cbRellenarLoc(busc);
            }
            else
            {


            }
        }

        private void cbRNC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbRNC.SelectedIndex != null)
            {
                string selection = cbRNC.Text;
                string view = ClientList.Where(m => m._Identifier == selection)
                                        .Select(m => m._NameBranch)
                                        .First();

                txtRnc.Text = view.ToString();
            }
            else
            {
                txtCliente.Text = null;
            }

            if (chkSucursal.Checked && cbRNC.SelectedIndex != null)
            {
                string select = cbRNC.Text;
                int? buscar = ClientList.Where(Z => Z._Identifier == select)
                                        .Select(m => m.IdClient)
                                        .First();

                int busc = Convert.ToInt32(buscar);
                cbRellenarLoc(busc);
            }
            else
            {


            }
        }



        private void RncCliente_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkRncCliente.Checked)
            {
                pnlRnc.Visible = true;
                pnlCliente.Visible = false;

            }
            else
            {
                pnlRnc.Visible = false;
                pnlCliente.Visible = true;

            }
        }
    }
}
