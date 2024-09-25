using Modelos.Taller;
using SOD_General.Controladores;
using SOD_General.Vistas.Taller.Clientes;
using SOD_General.Vistas.Taller.Registrar_entrada;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SOD_General.Vistas_Taller.Taller_Recepcion
{
    public partial class VisualizarPeticiones : Form
    {
        EntryOrderController entOrController = new EntryOrderController();
       // AddLocations addLoc = Application.OpenForms.OfType<AddLocations>().FirstOrDefault();

        public VisualizarPeticiones()
        {
            InitializeComponent();
        }

        private void VisualizarPeticiones_Load(object sender, EventArgs e)
        {
            verPeticiones();
        }

        public void verPeticiones()
        {
            List<EntryOrderData> listaEntry = new List<EntryOrderData>();
            listaEntry = entOrController.GetEntryOrderData();

            foreach (var lista in listaEntry)
            {
                dgvOrderEntry.Rows.Add(lista.peticion.IdPetition, lista.clienteContacto.locat._Location, lista.clienteContacto.contc.ContactName, lista.peticion.Date, lista.peticion.Details);
            }
        }

        private void dgvOrderEntry_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow dgvRows = dgvOrderEntry.Rows[e.RowIndex];

                int iden = Convert.ToInt32(dgvRows.Cells[0].Value);
                verEntradas(iden);
            }
        }

        public void verEntradas(int id)
        {
            VisualizarEntradas verEntrys = new VisualizarEntradas(id);    
        }
    }
}
