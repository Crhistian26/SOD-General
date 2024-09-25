using SOD_General.Controladores;
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

        public void cargarDgv()
        {

        }
    }
}
