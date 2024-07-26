using Modelos.Taller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOD_General.Vistas.Recursos_Humanos.Motivos
{
    public partial class AgregarEditar_Motivos : Form
    {

        public AgregarEditar_Motivos()
        {
            InitializeComponent();
            cR_Subtitulos1.Text = "Agregar motivo";
            botones_Nuevos1.Text = "Agregar";
            botones_Nuevos1.Click += AgregarBoton;
        }
        public AgregarEditar_Motivos(int? y)
        {
            InitializeComponent();
            cR_Subtitulos1.Text = "Editar motivo";
            botones_Nuevos1.Text = "Editar";
            botones_Nuevos1.Click += EditarBoton;
        }
        private void AgregarBoton(object sender, EventArgs e)
        {
            MessageBox.Show("Yo agrego y eso es todo");
        }

        private void EditarBoton(object sender, EventArgs e)
        {
            MessageBox.Show("Edito papa");
        }

        private void AgregarEditar_Motivos_Load(object sender, EventArgs e)
        {

        }
    }
}
