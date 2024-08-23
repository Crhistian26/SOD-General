using SOD_General.Controladores;
using System.Windows.Forms;

namespace SOD_General.Vistas.Taller.Equipos
{
    public partial class AgregarMarcas : Form
    {
        BrandController MarcaControl = new BrandController();
        public AgregarMarcas()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, System.EventArgs e)
        {
            if (txtMarcas.Text.Trim().Length == 0)
            {
                MessageBox.Show("Rellena todos los campos");
            }
            else
            {
                MarcaControl.agregarMarca(txtMarcas.Text, 1);
                VisualizarMarcas visuaMarcas = new VisualizarMarcas();
                visuaMarcas.llenargrid();
            }
        }
    }
}
