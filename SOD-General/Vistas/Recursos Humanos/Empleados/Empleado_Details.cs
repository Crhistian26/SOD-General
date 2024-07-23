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
        public Empleado_Details(Employee emp)
        {
            InitializeComponent();
            employee = emp;
        }


        private void Empleado_Details_Load(object sender, EventArgs e)
        {

            soD_ComboBox1.Items.Add("Recursos Humanos");
            soD_ComboBox1.Items.Add("Taller recepcion");
            soD_ComboBox1.Items.Add("Taller reparacion");
            soD_ComboBox1.Items.Add("Almacen");
            soD_ComboBox1.SelectedIndex = 0;

            cR_Subtitulos1.Text = $"{employee._Name} {employee._Lastname}\n(Recursos Humanos)";
            soD_TextBox1.Text = employee._Name;
            soD_TextBox2.Text = employee._Lastname;
            cR_Checkbox1.Checked = true;

            Size size = cR_Subtitulos1.Size;
            Point punto = cR_Subtitulos1.Location;
            cR_Subtitulos1.Location = _size.CentrarElementosX(punto, size, this.Size);

            size = panel1.Size;
            Size panel = new Size(cR_SplitContainer1.Width, (cR_SplitContainer1.Height - cR_SplitContainer1.SplitterDistance));
            panel1.Location = _size.CentrarElementosXY(size, panel);
            cR_DataGriedView1.Visible = false;

            size = botones_Nuevos1.Size;
            punto = botones_Nuevos1.Location;
            botones_Nuevos4.Location = _size.CentrarElementosX(punto, size, this.Size);


        }

        private void Empleado_Details_Resize(object sender, EventArgs e)
        {
            Size size = cR_Subtitulos1.Size;
            Point punto = cR_Subtitulos1.Location;
            cR_Subtitulos1.Location = _size.CentrarElementosX(punto, size, this.Size);

            size = botones_Nuevos1.Size;
            punto = botones_Nuevos1.Location;
            botones_Nuevos4.Location = _size.CentrarElementosX(punto,size, this.Size);


            size = panel1.Size;
            Size panel = new Size(cR_SplitContainer1.Width,(cR_SplitContainer1.Height - cR_SplitContainer1.SplitterDistance));
            panel1.Location = _size.CentrarElementosXY(size, panel);
        }

        private void botones_Nuevos2_Click(object sender, EventArgs e)
        {
            cR_DataGriedView1.Visible=false;
        }

        private void cR_DataGriedView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void botones_Nuevos1_Click(object sender, EventArgs e)
        {
            cR_DataGriedView1.Visible = true;
        }
    }
}
