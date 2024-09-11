using DocumentFormat.OpenXml.EMMA;
using Modelos.Control_de_usuarios;
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
        List<Contact> ctcClient = new List<Contact>();
        Model_User user = Application.OpenForms.OfType<AppVistaGeneral>().First().user;
        string RNC = "";

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
            RncCedulaCtc();
            RncEmpresaLlenado();
        }



        private void AgregarPeticiones_Resize(object sender, EventArgs e)
        {
            CentrarElementos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }


        public void RncEmpresaLlenado()
        {
            cbRncEmpresa.Items.Clear();
            ContactList = Ccontroller.ViewClient();
            
            cbRncEmpresa.SelectedItem = null;

            foreach (var ListCont in ContactList)
            {
                cbRncEmpresa.Items.Add(ListCont.locat.Identifier);
            }

            
        }
        public void RncCedulaCtc()
        {
            cbContactEmpresa.Items.Clear();
            ctcClient = Ccontroller.ContactoCliente(RNC);

            foreach (var b in ctcClient)
            {
                cbContactEmpresa.Items.Add(b.identifier);
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

        public void validarClienteNuevo()
        {
            if (user.Confirm_Operation("Añadir Clientes"))
            {
                btnClienteNuevo.Visible = true;
            }
            else
            {
                btnClienteNuevo.Visible = false;
            }
        }

        private void cbContactEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cedula = cbContactEmpresa.SelectedItem.ToString();

            List<Contact> registroContacto = Ccontroller.ContactoCliente(cedula);

           
        }

        private void cbRncEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            RNC = cbRncEmpresa.SelectedItem.ToString();

            var registroEmpresa = ContactList.Where(c => c.locat.Identifier == RNC).First();

            txtNombreEmpresa.Text = registroEmpresa.locat._Location.ToString();
            txtTlfnoEmpre.Text = registroEmpresa.locat.Phone1.ToString();
            txtTlfnoSecundario.Text = registroEmpresa.locat.Phone2.ToString();
            txtDireccionEmpre.Text = registroEmpresa.locat.Addrees.ToString();
        }
    }
}
