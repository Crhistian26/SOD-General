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
        EntryOrderController EnOrController = new EntryOrderController();
        int elegido = 0;
        List<ClientContact> ContactList = new List<ClientContact>();
        List<Contact> ctcClient = new List<Contact>();
        List<Client> ClienteIdentifier = new List<Client>();
        Model_User user = Application.OpenForms.OfType<AppVistaGeneral>().First().user;
        string RNC = "";
        List<Locations> EmpresaName;
        int idClienteCtc = 0;
        int IdContact = 0;
        int IdIdentififer = 0;
        int IdCliente = 0;

        List<Locations> ListLoc = new List<Locations>();
        public AgregarPeticiones()
        {
            InitializeComponent();

            this.vista = Application.OpenForms.OfType<AppVistaGeneral>().First();
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
            validarClienteNuevo();
            RncEmpresaLlenado();
            IdUltimo();
        }



        private void AgregarPeticiones_Resize(object sender, EventArgs e)
        {
            CentrarElementos();
        }

       


        public void RncEmpresaLlenado()
        {
            cbRncEmpresa.Items.Clear();
            ClienteIdentifier = Ccontroller.ViewIdentifier();
            
            cbRncEmpresa.SelectedItem = null;

            foreach (var ListCont in ClienteIdentifier)
            {
                cbRncEmpresa.Items.Add(ListCont._Identifier);
            } 
        }
        public void RncCedulaCtc()
        {
            cbContactEmpresa.Items.Clear();
            ctcClient = Ccontroller.ContactoCliente(idClienteCtc);

            foreach (var b in ctcClient)
            {
                cbContactEmpresa.Items.Add(b.ContactName);
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
            if (cbContactEmpresa.SelectedItem != null)
            {
                string nombre = cbContactEmpresa.SelectedItem.ToString();

                IdContact = Convert.ToInt32(ctcClient.Where(a => a.ContactName == nombre).Select(b => b.IdContact).First());
                txttlfnoContact.Text = ctcClient.Where(a => a.ContactName == nombre).Select(b => b.numero1).First().ToString();

            }

        }

        private void cbRncEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbRncEmpresa.SelectedItem != null)
            {
                RNC = cbRncEmpresa.SelectedItem.ToString();

                IdIdentififer = Convert.ToInt32(ClienteIdentifier.Where(a => a._Identifier == RNC).Select(b => b.IdClient).First());
                cbNombreEmpresa.Items.Clear();

                EmpresaName = Ccontroller.VerEmpresa(RNC);

                foreach (var EN in EmpresaName)
                {
                    cbNombreEmpresa.Items.Add(EN._Location);
                }
            }

        }

        private void cbNombreEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbNombreEmpresa.SelectedItem != null)
            {
                string nameEmpresa = cbNombreEmpresa.SelectedItem.ToString();

                IdCliente = Convert.ToInt32(EmpresaName.Where(a => a._Location == nameEmpresa).Select(b => b.IdLocation).First());
                //CAMBIO DE ID IDENTIFIER A ID CLIENTE
                idClienteCtc = Convert.ToInt32(EmpresaName.Where(b => b._Location == nameEmpresa).Select(a => a.IdLocation).First());
                txtDireccionEmpre.Text = EmpresaName.Where(b => b._Location == nameEmpresa).Select(a => a.Addrees).First().ToString();
                txtTlfnoEmpre.Text = EmpresaName.Where(b => b._Location == nameEmpresa).Select(a => a.Phone1).First().ToString();
                txtTlfnoSecundario.Text = EmpresaName.Where(b => b._Location == nameEmpresa).Select(a => a.Phone2).First().ToString();

                RncCedulaCtc();
            }
            else
            {

            }
        }

        private void btnGuardarEmpre_Click(object sender, EventArgs e)
        {
            EnOrController.ordenDeEntrada(txtDetallesContact.Text, IdCliente, IdContact);

            cbRncEmpresa.SelectedItem = null;
            txtDetallesContact.Text = null;
            cbNombreEmpresa.SelectedItem = null;
            txtTlfnoEmpre.Text= null;
            txtDireccionEmpre.Text = null;
            txtTlfnoEmpre.Text = null;
            txtTlfnoSecundario.Text = null; 
            cbContactEmpresa.SelectedItem = null;   
            txttlfnoContact.Text = null;
           
                RegistrarSolicitudEquipo regiEntrada = new RegistrarSolicitudEquipo(Convert.ToInt32(txtUltimoId.Text));
                vista.OpenForm(regiEntrada);
        }

        public void IdUltimo()
        {
            txtUltimoId.Text = EnOrController.UltimoId().ToString();
        }

        
    }
    
}
