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

namespace SOD_General.Vistas.Recursos_Humanos.Registros
{
    public partial class Permiso_Details : Form
    {
        SizesGenerales _size = new SizesGenerales();
        Registros_Controller control = new Registros_Controller();
        private void CentrarElementos()
        {
            Point SubL = cR_Subtitulos1.Location;
            cR_Subtitulos1.Location = _size.CentrarElementosX(SubL, cR_Subtitulos1.Size, this.Size);

            Point LabL = cR_LabelUp1.Location;
            cR_LabelUp1.Location = _size.CentrarElementosX(LabL, cR_LabelUp1.Size, this.Size);

            Size panel = new Size(cR_SplitContainer1.Width, (cR_SplitContainer1.Height - cR_SplitContainer1.SplitterDistance));
            panel1.Location = _size.CentrarElementosXY(panel1.Size, panel);
        }
        public Permiso_Details()
        {
            InitializeComponent();
        }

        public Permiso_Details(int y)
        {
            InitializeComponent();
            botones_Nuevos1.Visible = false;
            botones_Nuevos2.Visible = false;


        }

        private void Registro_Details_Load(object sender, EventArgs e)
        {
            CentrarElementos();
        }

        private void Registro_Details_Resize(object sender, EventArgs e)
        {
            CentrarElementos();
        }

        private void botones_Nuevos1_Click(object sender, EventArgs e)
        {
            control.AgregarPermiso();
            this.Close();
        }
    }
}
