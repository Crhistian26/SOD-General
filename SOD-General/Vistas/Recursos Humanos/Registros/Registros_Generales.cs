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
    public partial class Registros_Generales : Form
    {
        SizesGenerales _sizes = new SizesGenerales();
        public Registros_Generales()
        {
            InitializeComponent();
        }

        private void Registros_Generales_Load(object sender, EventArgs e)
        {
            Point punto = cR_Subtitulos1.Location;
            cR_Subtitulos1.Location = _sizes.CentrarElementosX(punto, cR_Subtitulos1.Size, this.Size);
            cR_DataGriedView1.Rows.Add(1, "Fernando Acosta", "Enfermedad", "Lunes 27 de mayo", "Jueves 30 de mayo");
            cR_DataGriedView1.Rows.Add(1, "Maria Fernandez", "Diligencia", "Lunes 27 de mayo (10:30)", "Lunes 27 de mayo (2:15)");
        }

        private void Registros_Generales_Resize(object sender, EventArgs e)
        {
            Point punto = cR_Subtitulos1.Location;
            cR_Subtitulos1.Location = _sizes.CentrarElementosX(punto, cR_Subtitulos1.Size, this.Size);
        }

        private void cR_DataGriedView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                Registro_Details ver = new Registro_Details();
                ver.Show();
            }
        }
    }
}
