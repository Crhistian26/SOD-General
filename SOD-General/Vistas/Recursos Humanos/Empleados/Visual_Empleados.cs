using Modelos.Usuarios_Empleados;
using SOD_General.Controladores;
using SOD_General.Vistas.Recursos_Humanos.Empleados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace SOD_General.Recursos_Humanos.Empleados
{
    public partial class Visual_Empleados : Form
    {
        SizesGenerales _size = new SizesGenerales();

        Empleados_Controller control = new Empleados_Controller();

        Size tam;
        public Visual_Empleados()
        {
            InitializeComponent();
        }


        private void cR_DataGriedView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Junciona");
        }

        private void Visual_Empleados_Load(object sender, EventArgs e)
        {
            cR_DataGriedView1.Rows.Add(1,"Fernando","Gutierrez","Recursos Humanos",DateTime.Now.AddYears(-2).ToString("D"));
            cR_DataGriedView1.Rows.Add(1, "Maria", "Veltran", "Recursos Humanos", DateTime.Now.AddYears(-2).ToString("D"));
            cR_DataGriedView1.Rows.Add(1, "Rodrigo", "Carrasco", "Recursos Humanos", DateTime.Now.AddYears(-2).ToString("D"));
            tam = this.Size;
            Point localA = cR_Subtitulos1.Location;
            cR_Subtitulos1.Location = _size.CentrarElementosX(localA, cR_Subtitulos1.Size, this.Size);
        }

        private void cR_DataGriedView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow fila = cR_DataGriedView1.Rows[e.RowIndex];
                int id = Convert.ToInt32(fila.Cells[0].Value);
                string name = fila.Cells[1].Value.ToString();
                string lastname = fila.Cells[2].Value.ToString();
                DateTime fecha = Convert.ToDateTime(fila.Cells[4].Value);
                Employee emp = new Employee(id, 1, name, lastname, fecha, null, true);


                Empleado_Details empleado = new Empleado_Details(emp);
                empleado.Show();
            }
        }

        private void cR_SplitContainer1_Panel1_Resize(object sender, EventArgs e)
        {
            Point localA = cR_Subtitulos1.Location;
            cR_Subtitulos1.Location =_size.CentrarElementosX(localA, cR_Subtitulos1.Size, this.Size);


        }

        private void botones_Nuevos1_Click(object sender, EventArgs e)
        {
            control.AbrirEditar();
        }
    }
}
