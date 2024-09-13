using SOD_General.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOD_General.Vistas.Control_de_usuarios.Operaciones
{
    public partial class VisualOperaciones : Form
    {
        SizesGenerales _size = new SizesGenerales();
        public VisualOperaciones()
        {
            InitializeComponent();
            CentrarElementos();
        }

        private void botones_Nuevos1_Click(object sender, EventArgs e)
        {

        }

        private void cR_SplitContainer1_Panel1_Resize(object sender, EventArgs e)
        {
            CentrarElementos();
        }

        public void CentrarElementos()
        {
            Point localA = cR_Subtitulos1.Location;
            cR_Subtitulos1.Location = _size.CentrarElementosX(localA, cR_Subtitulos1.Size, this.Size);
        }
    }
}
