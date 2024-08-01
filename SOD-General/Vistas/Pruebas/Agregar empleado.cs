using System;
using System.Windows.Forms;

namespace SOD_General.Vistas.Pruebas
{
    public partial class Agregar_empleado : Form
    {
        public Agregar_empleado()
        {
            InitializeComponent();
            cR_Subtitulos1.Text = "Agregar empleado";
        }

        public Agregar_empleado(int a)
        {
            InitializeComponent();
            cR_Subtitulos1.Text = "Editar empleado";
        }

        private void Agregar_empleado_Load(object sender, EventArgs e)
        {

        }
    }
}
