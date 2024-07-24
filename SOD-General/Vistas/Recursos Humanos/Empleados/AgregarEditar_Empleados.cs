using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOD_General.Vistas.Recursos_Humanos.Empleados
{
    public partial class AgregarEditar_Empleados : Form
    {
        public AgregarEditar_Empleados()
        {
            InitializeComponent();
            cR_Subtitulos1.Text = "Agregar empleado";
            botones_Nuevos1.Text = "Agregar";
        }

        public AgregarEditar_Empleados(int? y)
        {
            InitializeComponent();
            cR_Subtitulos1.Text = "Editar empleado";
            botones_Nuevos1.Text = "Editar";
            panel2.Visible = true;
        }

        public AgregarEditar_Empleados(string y)
        {
            InitializeComponent();
            cR_Subtitulos1.Text = "Editar empleado";
            botones_Nuevos1.Text = "Editar";
            panel2.Visible = true;
            panel3.Visible = true;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AgregarEditar_Empleados_Load(object sender, EventArgs e)
        {

        }
    }
}
