using SOD_General.Controladores;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SOD_General.Vistas.Recursos_Humanos.Registros
{
    public partial class Agregar_Permiso : Form
    {
        SizesGenerales _size = new SizesGenerales();
        public Agregar_Permiso()
        {
            InitializeComponent();
        }

        private void CentrarElementos()
        {
            Point SubL = cR_Subtitulos1.Location;
            cR_Subtitulos1.Location = _size.CentrarElementosX(SubL, cR_Subtitulos1.Size, this.Size);

            Size panel = new Size(cR_SplitContainer1.Width, (cR_SplitContainer1.Height - cR_SplitContainer1.SplitterDistance));
            panel1.Location = _size.CentrarElementosXY(panel1.Size, panel);
        }


        private void Agregar_Permiso_Load(object sender, EventArgs e)
        {
            CentrarElementos();
        }

        private void soD_ComboBox4_Resize(object sender, EventArgs e)
        {

        }

        private void Agregar_Permiso_Resize(object sender, EventArgs e)
        {
            CentrarElementos();
        }
    }
}
