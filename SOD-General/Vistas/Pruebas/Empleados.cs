using Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOD_General.Vistas.Pruebas
{
    public partial class Empleados : Form
    {
        AppVistaGeneral app;

        ControlOperaciones controller;
        public Empleados(AppVistaGeneral app)
        {
            InitializeComponent();
            this.app = app;
            this.controller = new ControlOperaciones(app);
        }
        private void Empleados_Load(object sender, EventArgs e)
        {
            cR_DataGriedView1.Rows.Add("Pedrito");
            cR_DataGriedView1.Rows.Add("Pancho");

            if (controller.BuscarAutorizacion("Agregar empleados"))
            {
                button1.Visible = true;
            }
            else
            {
                button1.Visible = false;
            }
        }

        private void cR_DataGriedView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (controller.BuscarAutorizacion("Editar empleados"))
            {
                Agregar_empleado vista = new Agregar_empleado(1);
                vista.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Agregar_empleado vista = new Agregar_empleado();
            vista.Show();
        }
    }
}
