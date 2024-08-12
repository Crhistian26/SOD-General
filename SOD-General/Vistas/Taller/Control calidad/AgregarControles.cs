using SOD_General.Controladores;
using System.Windows.Forms;

namespace SOD_General.Taller.Control_calidad
{
    public partial class AgregarControles : Form
    {
        EquipmentController equipController = new EquipmentController();
        public AgregarControles()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, System.EventArgs e)
        {
            equipController.AgregarControles(txtControlName.Text, true);
        }
    }
}
