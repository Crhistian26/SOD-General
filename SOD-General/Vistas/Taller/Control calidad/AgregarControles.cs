using Modelos.Taller;
using SOD_General.Controladores;
using System.Windows.Forms;

namespace SOD_General.Taller.Control_calidad
{
    public partial class AgregarControles : Form
    {
        QualityControlController cQController = new QualityControlController();
        public AgregarControles()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, System.EventArgs e)
        {
            cQController.AgregarControles(txtControlName.Text, true);
        }
    }
}
