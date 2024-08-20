using DocumentFormat.OpenXml.EMMA;
using Modelos.AsistenciasYPermisos;
using Modelos.Usuarios_Empleados;
using SOD_General.Controladores;
using SOD_General.Vistas.Pruebas;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SOD_General.Vistas.Recursos_Humanos.Registros
{
    public partial class Control_Permisos : Form
    {
        SizesGenerales _size = new SizesGenerales();
        Registros_Controller control = new Registros_Controller();
        List<Employee> empleados;
        List<Model_Reason> motivos;
        public Control_Permisos()
        {
            InitializeComponent();
            empleados = control.Obtener_Empleados_Trabajando();
            motivos = control.Obtener_Razones();
        }

        private void CentrarElementos()
        {
            Point SubL = cR_Subtitulos1.Location;
            cR_Subtitulos1.Location = _size.CentrarElementosX(SubL, cR_Subtitulos1.Size, this.Size);

            Size panel = new Size(cR_SplitContainer1.Width, (cR_SplitContainer1.Height - cR_SplitContainer1.SplitterDistance));
            panel1.Location = _size.CentrarElementosXY(panel1.Size, panel);
        }

        private void LlenarCombobox()
        {
            foreach (Employee emp in empleados)
            {
                cr_ComboBox1.Items.Add(emp._Name + " " + emp._Lastname);
            }
            foreach (Model_Reason rea in motivos)
            {
                cr_ComboBox2.Items.Add(rea._Reason);
            }
        }
        private void Agregar_Permiso_Load(object sender, EventArgs e)
        {
            CentrarElementos();
            LlenarCombobox();
            cR_Checkbox1.Visible = false;
        }

        private void soD_ComboBox4_Resize(object sender, EventArgs e)
        {

        }

        private void Agregar_Permiso_Resize(object sender, EventArgs e)
        {
            CentrarElementos();
        }

        private void soD_ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int a = empleados[cr_ComboBox1.SelectedIndex].IdEmployee;
        }

        private void cr_ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cr_ComboBox3.SelectedIndex == 2)
            {
                cR_Checkbox1.Visible = true;
            }
            else
            {
                cR_Checkbox1.Visible = false;
            }
        }
    }
}
