using Modelos.Usuarios_Empleados;
using SOD_General.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOD_General.Vistas.Recursos_Humanos.Empleados
{
    public partial class Empleado_Details : Form
    {
        private SizesGenerales _size = new SizesGenerales();
        private Employee employee;
        Empleados_Controller control = new Empleados_Controller();
        public Empleado_Details(Employee emp)
        {
            InitializeComponent();
            employee = emp;
        }


        private void Empleado_Details_Load(object sender, EventArgs e)
        {

            Size size = cR_Subtitulos1.Size;
            Point punto = cR_Subtitulos1.Location;
            cR_Subtitulos1.Location = _size.CentrarElementosX(punto, size, this.Size);

        }

        private void Empleado_Details_Resize(object sender, EventArgs e)
        {
            Size size = cR_Subtitulos1.Size;
            Point punto = cR_Subtitulos1.Location;
            cR_Subtitulos1.Location = _size.CentrarElementosX(punto, size, this.Size);

        }

        private void botones_Nuevos2_Click(object sender, EventArgs e)
        {
            control.AbrirEditar(1);
            this.Close();
        }

        private void cR_DataGriedView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void botones_Nuevos1_Click(object sender, EventArgs e)
        {
            cR_DataGriedView1.Visible = true;
            cR_DataGriedView2.Visible=false;
        }

        private void botones_Nuevos5_Click(object sender, EventArgs e)
        {
            cR_DataGriedView2.Visible = true;
            cR_DataGriedView1.Visible = false;
        }
    }
}
