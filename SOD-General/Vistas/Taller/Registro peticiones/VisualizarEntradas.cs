using Modelos.Taller;
using SOD_General.Controladores;
using System;
using System.Collections.Generic;
using System.Security.RightsManagement;
using System.Windows.Forms;

namespace SOD_General.Vistas.Taller.Registrar_entrada
{
    public partial class VisualizarEntradas : Form
    {
        public int IdPetition { get; }
        EntryOrderController entryOrderController = new EntryOrderController(); 

        public VisualizarEntradas(int peticion)
        {
            InitializeComponent();
            this.IdPetition = peticion;
        }

       
        

        public void cargarDgv(int a)
        {
          List<EntryOrderController.EntradaSt> listEntr = entryOrderController.llenarDgvEntrada(a);

            foreach (var list in listEntr)
            {
                dgvEntrys.Rows.Add(list.ids, list.tipo, list.marca, list.modelo, list.serial, list.falla, list._date);
            }
        }

        private void VisualizarEntradas_Load(object sender, System.EventArgs e)
        {
            cargarDgv(IdPetition);
        }

        private void dgvEntrys_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow dgvRows = dgvEntrys.Rows[e.RowIndex];
                int idEntr = Convert.ToInt32(dgvRows.Cells[0].Value);

                List<Accesories> listAcc = entryOrderController.ObtenerAccesorios(idEntr);

                dgvVerAccesorios.Rows.Clear();
                foreach (var list in listAcc)
                {
                    dgvVerAccesorios.Rows.Add(list.idAccesories, list.nameAccesories, list._Enable);
                }
            }
        }
    }
}
