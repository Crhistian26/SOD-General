using Modelos.Taller;
using SOD_General.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOD_General.Vistas.Taller.Clientes
{
    public partial class ContactoSearch : Form
    {
        ClientController clieControl = new ClientController();
        private bool cambioSelectIndex = false;
        AddLocations addLoc  = Application.OpenForms.OfType<AddLocations>().FirstOrDefault();

        bool cambioSeleccion = false;
        List<Contact> listLot = new List<Contact>();

        public ContactoSearch()
        {
            InitializeComponent();
            llenarCbRncName();
        }

        private void cR_SplitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void llenarCbRncName()
        {
            List<Contact> contList = clieControl.ContactData();
            foreach (Contact ctc in contList)
            {
                cmbName.Items.Add(ctc.ContactName);
                cmbCed.Items.Add(ctc.identifier);
            }
        }

        public void verRnc()
        {
            List<Contact> contactClient = clieControl.ContactData();
            dgvContact.Rows.Clear();

            foreach (Contact ctc in contactClient)
            {
                dgvContact.Rows.Add(ctc.IdContact, ctc.ContactName, ctc.identifier, ctc.numero1, ctc.numero2);
            }
        }

        private void cmbName_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvContact.Rows.Clear();

            if (!cambioSeleccion)
            {
                cambioSeleccion = true;
                cmbCed.SelectedItem = null;
                cambioSeleccion = false;
            }
            List<Contact> listLot = clieControl.ContactData();

            var filtro = listLot.Select(a => a).Where(a => a.ContactName == cmbName.Text).ToList();

            if (filtro.Count > 0)
            {
                foreach (Contact loc in filtro)
                {
                    dgvContact.Rows.Add(
                        loc.IdContact,
                        loc.ContactName,
                        loc.identifier,
                        loc.numero1,
                        loc.numero2
                        );
                }
            }
            else
            {
                verRnc();
            }

        }

        private void cmbCed_SelectedIndexChanged(object sender, EventArgs e)
        {
           

            if (!cambioSeleccion)
            {
                cambioSeleccion = true;
                cmbName.SelectedItem = null;
                cambioSeleccion = false;
            }

            List<Contact> contactClient = clieControl.ContactData();
            dgvContact.Rows.Clear();

            listLot = clieControl.ContactData();

            var filtro = listLot.Select(a => a).Where(a => a.identifier == cmbCed.Text).ToList();

            if (filtro.Count > 0)
            {
                foreach (Contact loc in filtro)
                {
                    dgvContact.Rows.Add(
                        loc.IdContact,
                        loc.ContactName,
                        loc.identifier,
                        loc.numero1,
                        loc.numero2
                        );
                }
            }
            else
            {
                verRnc();
            }
        }

        private void dgvContact_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (addLoc != null)
                {
                    DataGridViewRow dgvRows = dgvContact.Rows[e.RowIndex];

                    string iden = dgvRows.Cells[2].Value.ToString();
                    addLoc.CbContact.SelectedItem = iden;
                    this.Close();
                }

            }
        }

        
    }
}
