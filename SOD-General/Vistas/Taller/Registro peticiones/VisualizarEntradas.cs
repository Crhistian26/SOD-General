using SOD_General.Controladores;
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

       
        private void cR_DataGriedView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
    }
}
