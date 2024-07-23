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
    public partial class Registros_GeneralesAsistencias : Form
    {
        SizesGenerales _size = new SizesGenerales();
        public Registros_GeneralesAsistencias()
        {
            InitializeComponent();
        }

        private void Registros_GeneralesAsistencias_Load(object sender, EventArgs e)
        {
            Point punto = cR_Subtitulos1.Location;
            cR_Subtitulos1.Location = _size.CentrarElementosX(punto, cR_Subtitulos1.Size, this.Size);

            punto = cR_DateTimePicker1.Location;
            cR_DateTimePicker1.Location = _size.CentrarElementosX(punto,cR_DateTimePicker1.Size,this.Size);

            cR_DataGriedView2.Rows.Add(1, "Eduardo Brito");
        }

        private void Registros_GeneralesAsistencias_Resize(object sender, EventArgs e)
        {
            Point punto = cR_Subtitulos1.Location;
            cR_Subtitulos1.Location = _size.CentrarElementosX(punto, cR_Subtitulos1.Size, this.Size);

            punto = cR_DateTimePicker1.Location;
            cR_DateTimePicker1.Location = _size.CentrarElementosX(punto, cR_DateTimePicker1.Size, this.Size);
        }
    }
}
