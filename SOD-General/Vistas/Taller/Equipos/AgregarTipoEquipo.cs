using SOD_General.Controladores;
using System.Windows.Forms;

namespace SOD_General.Vistas.Taller.Equipos
{
    public partial class AgregarTipoEquipo : Form
    {
        EquipmentController equipControl = new EquipmentController();
        public AgregarTipoEquipo()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, System.EventArgs e)
        {
            if (txtTipoEquipo.Text.Trim().Length == 0)
            {
                MessageBox.Show("Por favor, rellene el campo");
            }
            else
            {
                equipControl.agregarEquipo(txtTipoEquipo.Text, 1);
            }
        }
    }
}
