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

namespace SOD_General.Vistas.Recursos_Humanos.Exportar
{
    public partial class ExportarReportesRRHH : Form
    {
        SizesGenerales _size = new SizesGenerales();

        public ExportarReportesRRHH()
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

        private void ExportarReportesRRHH_Resize(object sender, EventArgs e)
        {
            CentrarElementos();
        }

        private void ExportarReportesRRHH_Load(object sender, EventArgs e)
        {
            CentrarElementos();
        }
    }
}
