using Modelos.Usuarios_Empleados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOD_General.Vistas.Recursos_Humanos.Empleados
{
    public partial class Empleado_Details : Form
    {
        private Employee employee;
        public Empleado_Details(/*Employee emp*/)
        {
            InitializeComponent();
            //employee = emp;
        }

        private Point DejarEnPosicionEquivalenteX(Point ElementoP, Size ElementoS, Size Panel)
        {
            Point punto = new Point();

            return punto;
        }
        private Point CentrarElementosXY(Size Elemento, Size Panel)
        {
            int posicionX = 0, posicionY = 0;
            int panel = Panel.Width;
            int element = Elemento.Width;
            posicionX = (panel - element) / 2;
            panel = Panel.Height;
            element = Elemento.Height;
            posicionY = (panel - element) / 2;

            Point punto = new Point();
            punto = new Point(posicionX, posicionY);
            return punto;
        }

        private Point CentrarElementosX(Point ElementoP,Size ElementoS, Size PanelSize)
        {
            int posicion = 0;
            int panel = PanelSize.Width;
            int element = ElementoS.Width;
            posicion = (panel - element) / 2;
            Point punto = new Point();
            punto = new Point(posicion, ElementoP.Y);
            return punto;
        }

        
        private void Empleado_Details_Load(object sender, EventArgs e)
        {
            Size size = cR_Subtitulos1.Size;
            Point punto = cR_Subtitulos1.Location;
            cR_Subtitulos1.Location = CentrarElementosX(punto,size, this.Size);
            size = panel1.Size;
            Size panel = new Size(cR_SplitContainer1.Width, (cR_SplitContainer1.Height - cR_SplitContainer1.SplitterDistance));
            panel1.Location = CentrarElementosXY(size, panel);
        }

        private void Empleado_Details_Resize(object sender, EventArgs e)
        {
            Size size = cR_Subtitulos1.Size;
            Point punto = cR_Subtitulos1.Location;
            cR_Subtitulos1.Location = CentrarElementosX(punto, size, this.Size);
            size = panel1.Size;
            Size panel = new Size(cR_SplitContainer1.Width,(cR_SplitContainer1.Height - cR_SplitContainer1.SplitterDistance));
            panel1.Location = CentrarElementosXY(size, panel);
        }

        private void botones_Nuevos2_Click(object sender, EventArgs e)
        {

        }
    }
}
