using Controladores;
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
    public partial class Registros_GeneralesPermisos : Form
    {
        Registros_Controller control = new Registros_Controller();
        SizesGenerales _sizes = new SizesGenerales();
        ControlOperaciones operaciones;
        public Registros_GeneralesPermisos(AppVistaGeneral app)
        {
            InitializeComponent();
            operaciones = new ControlOperaciones(app);
        }

        public void CentrarElementos()
        {
            Point punto = cR_Subtitulos1.Location;
            cR_Subtitulos1.Location = _sizes.CentrarElementosX(punto, cR_Subtitulos1.Size, this.Size);
        }
        private void Registros_Generales_Load(object sender, EventArgs e)
        {
            CentrarElementos();
            cR_DataGriedView1.Rows.Add(1, "Fernando Acosta", "Enfermedad", "Lunes 27 de mayo", "Jueves 30 de mayo");
            cR_DataGriedView1.Rows.Add(1, "Maria Fernandez", "Diligencia", "Lunes 27 de mayo (10:30)", "Lunes 27 de mayo (2:15)");

            if (operaciones.BuscarAutorizacion(19))
            {
                botones_Nuevos5.Visible = true;
            }
            else
            {
                botones_Nuevos5.Visible = false;
            }
        }

        private void Registros_Generales_Resize(object sender, EventArgs e)
        {
            CentrarElementos();
        }

        private void cR_DataGriedView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                if (operaciones.BuscarAutorizacion(20))
                {
                    Permiso_Details ver = new Permiso_Details();
                    ver.Show();
                }
                else
                {
                    Permiso_Details ver = new Permiso_Details(0);
                    ver.Show();
                }
                
            }
        }

        private void botones_Nuevos5_Click(object sender, EventArgs e)
        {
            control.AgregarPermiso();
        }
    }
}
