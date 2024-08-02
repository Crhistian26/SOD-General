using SOD_General.Vistas_Taller.Taller_Recepcion;
using System.Windows.Forms;

namespace SOD_General.Vistas.Taller.Registro_peticiones
{
    public partial class RegistrarSolicitudEquipo : Form
    {
        AppVistaGeneral vista;
        public RegistrarSolicitudEquipo(AppVistaGeneral vista)
        {
            InitializeComponent();
            this.vista = vista;
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cR_DataGriedView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void botones_Nuevos2_Click(object sender, System.EventArgs e)
        {
            VisualizarPeticiones visuaPeti= new VisualizarPeticiones();
            
        }
    }
}
