using Modelos.Usuarios_Empleados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private void CentrarLabel()
        {
            int posicion = 0;
            int panel = cR_SplitContainer1.Width;
            int label = cR_Subtitulos1.Width;
            posicion = (panel - label) / 2;
            cR_Subtitulos1.Location = new Point(posicion, 9);
        }

        private void Empleado_Details_Load(object sender, EventArgs e)
        {
            
            CentrarLabel();
        }

        private void Empleado_Details_Resize(object sender, EventArgs e)
        {
            CentrarLabel();
        }
    }
}
