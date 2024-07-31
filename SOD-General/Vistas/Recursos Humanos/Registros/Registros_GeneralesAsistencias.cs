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
    public partial class Registros_GeneralesAsistencias : Form
    {
        SizesGenerales _size = new SizesGenerales();
        Registros_Controller control = new Registros_Controller();
        ControlOperaciones operaciones;
        public Registros_GeneralesAsistencias(AppVistaGeneral app)
        {
            InitializeComponent();
            operaciones = new ControlOperaciones(app);
        }

        public void CentrarElementos()
        {
            Point punto = cR_Subtitulos1.Location;
            cR_Subtitulos1.Location = _size.CentrarElementosX(punto, cR_Subtitulos1.Size, this.Size);

            punto = cR_DateTimePicker1.Location;
            cR_DateTimePicker1.Location = _size.CentrarElementosX(punto, cR_DateTimePicker1.Size, this.Size);
        }
        private void Registros_GeneralesAsistencias_Load(object sender, EventArgs e)
        {
            CentrarElementos();
            cR_DataGriedView2.Rows.Add(1, "Eduardo Brito", "8:25 AM", "5:50 PM", "8 horas y 10 min.");

            if(operaciones.BuscarAutorizacion("Agregar asistencias"))
            {
                botones_Nuevos1.Visible = true;
            }
            else
            {
                botones_Nuevos1.Visible = false;
            }
        }

        private void Registros_GeneralesAsistencias_Resize(object sender, EventArgs e)
        {
            CentrarElementos();
        }

        private void botones_Nuevos1_Click(object sender, EventArgs e)
        {
            control.AgregarAsistencia();
        }
    }
}
