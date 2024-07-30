using Controladores;
using Modelos.Usuarios_Empleados;
using SOD_General.Controladores;
using SOD_General.Vistas.Pruebas;
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

        ControlOperaciones operaciones;

        List<Employee> Empleados;



        public Visual_Empleados(AppVistaGeneral app)
        {
            InitializeComponent();
            operaciones = new ControlOperaciones(app);
        }

        private void Visual_Empleados_Load(object sender, EventArgs e)
        {
            Empleados = control.ListaGeneralEmpleados();
            CentrarElementos();
            LlenarDataGried();

        }


        public void CentrarElementos()
        {
            Point localA = cR_Subtitulos1.Location;
            cR_Subtitulos1.Location = _size.CentrarElementosX(localA, cR_Subtitulos1.Size, this.Size);
        }

        public void LlenarDataGried()
        {
            foreach (Employee empleado in Empleados)
            {
                int id = empleado.IdEmployee;
                string name = empleado._Name;
                string lastname = empleado._Lastname;
                string department = empleado.Department;
                DateTime date = empleado.Admission_date;

                cR_DataGriedView1.Rows.Add(id, name, lastname,department, date.ToString("D"));
            }
        }


        private void cR_DataGriedView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Junciona");
        }

        private void cR_DataGriedView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow fila = cR_DataGriedView1.Rows[e.RowIndex];
                int id = Convert.ToInt32(fila.Cells[0].Value);

                Empleado_Details vista = new Empleado_Details(id);
                vista.Show();
            }
        }

        private void cR_SplitContainer1_Panel1_Resize(object sender, EventArgs e)
        {
            CentrarElementos();
        }

        private void botones_Nuevos1_Click(object sender, EventArgs e)
        {
            control.AbrirEditar();
        }
    }
}
