using SOD_General.Controladores;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SOD_General.Vistas.Recursos_Humanos.Motivos
{
    public partial class Visual_Motivos : Form
    {
        SizesGenerales _size = new SizesGenerales();
        Motivos_Controller control = new Motivos_Controller();
        public Visual_Motivos()
        {
            InitializeComponent();
        }

        private void Visual_Motivos_Load(object sender, EventArgs e)
        {
            Point punto = cR_Subtitulos1.Location;
            cR_Subtitulos1.Location = _size.CentrarElementosX(punto, cR_Subtitulos1.Size, this.Size);

            punto = botones_Nuevos1.Location;
            botones_Nuevos1.Location = _size.CentrarElementosX(punto, botones_Nuevos1.Size, this.Size);
            cR_DataGriedView1.Rows.Add(1, "Enfermedad", "Dias", "Meses", "5 meses", "Al año");
        }

        private void Visual_Motivos_Resize(object sender, EventArgs e)
        {
            Point punto = cR_Subtitulos1.Location;
            cR_Subtitulos1.Location = _size.CentrarElementosX(punto, cR_Subtitulos1.Size, this.Size);

            punto = botones_Nuevos1.Location;
            botones_Nuevos1.Location = _size.CentrarElementosX(punto, botones_Nuevos1.Size, this.Size);
        }

        private void botones_Nuevos1_Click(object sender, EventArgs e)
        {
            control.AbrirEditar(null);
        }

        private void cR_DataGriedView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                control.AbrirEditar(1);
            }
        }
    }
}
