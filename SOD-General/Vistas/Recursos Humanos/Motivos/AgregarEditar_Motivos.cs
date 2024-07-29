using Modelos.Taller;
using SOD_General.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOD_General.Vistas.Recursos_Humanos.Motivos
{
    public partial class AgregarEditar_Motivos : Form
    {
        SizesGenerales _size = new SizesGenerales();
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

        private void CentrarElementos()
        {
            Point SubL = cR_Subtitulos1.Location;
            cR_Subtitulos1.Location = _size.CentrarElementosX(SubL, cR_Subtitulos1.Size, this.Size);

            Size panel = new Size(cR_SplitContainer1.Width, (cR_SplitContainer1.Height - cR_SplitContainer1.SplitterDistance));
            panel1.Location = _size.CentrarElementosXY(panel1.Size, panel);
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
            CentrarElementos();
        }

        private void AgregarEditar_Motivos_Resize(object sender, EventArgs e)
        {
            CentrarElementos();
        }
    }
}
