using Modelos.Taller;
using SOD_General.Controladores;
using SOD_General.Recursos_Humanos.Empleados;
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
        List<Client> RncList = new List<Client>();
        List<Locations> RncListLoc = new List<Locations>();
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
            RncList = Ccontroller.RellenarComboBox();
            cbRNC.Items.Clear();
            cbRNC.SelectedItem = null;

            foreach (var a in RncList)
            {
                cbRNC.Items.Add(a._Identifier);
                cbRNC.Tag = a.IdClient;
            }

            
        }

        public void cbRellenarCl()
        {
            RncList = Ccontroller.RellenarComboBox();
            CbCliente.Items.Clear();
            CbCliente.SelectedItem = null;

            foreach (var a in RncList)
            {
                CbCliente.Items.Add(a._NameBranch);
                CbCliente.Tag = a.IdClient;
            }
        }
        public void cbRellenarLoc(int a)
        {           
            RncListLoc = Ccontroller.ViewLocation(a);
            CbSucursal.Items.Clear();   

            foreach (var b in RncListLoc)
            {
                CbSucursal.Items.Add(b);
            }
        }



        private void cbRNC_SelectedIndexChanged(object sender, EventArgs e)
        {

            string selec = cbRNC.Text;
            string mostrar = RncList.Where(m => m._Identifier == selec)
                                    .Select(m => m._NameBranch)
                                    .First();

            CbCliente.Items.Clear();
            CbCliente.Items.Add(mostrar);
            CbCliente.SelectedIndex = 0;

            if (chkSucursal.Checked && cbRNC.SelectedIndex != null)
            {
                int a = Convert.ToInt32(CbCliente.Tag);
                cbRellenarLoc(a);
            }
            else
            {


            }
        }
            private void CbSucursal_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            

        }

        private void chkSucursal_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSucursal.Checked)
            {
                pnlSucursal.Visible = true;
                pnlCliente.Visible = false;
            }
            else
            {
                pnlSucursal.Visible = false;
                pnlCliente.Visible = true;
            }
        }

        private void CbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbRNC.SelectedIndex != null)
            {
                string selec = cbRNC.Text;
                string mostrar = RncList.Where(m => m._Identifier == selec)
                                        .Select(m => m._NameBranch)
                                        .First();


                CbCliente.SelectedItem = mostrar;
            }
            else
            {

            }
        }
    }
}
