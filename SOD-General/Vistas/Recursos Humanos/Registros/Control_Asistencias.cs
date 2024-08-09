using DocumentFormat.OpenXml.Packaging;
using Modelos.AsistenciasYPermisos;
using Modelos.Control_de_usuarios;
using Modelos.Usuarios_Empleados;
using SOD_General.Controladores;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SOD_General.Vistas.Recursos_Humanos.Registros
{
    public partial class Control_Asistencias : Form
    {
        SizesGenerales _size = new SizesGenerales();
        Registros_Controller control = new Registros_Controller();
        List<Employee> empleados;
        Model_User user = Application.OpenForms.OfType<AppVistaGeneral>().First().user;
        public Control_Asistencias()
        {
            InitializeComponent();
            empleados = control.Obtener_Empleados();
            botones_Nuevos2.Visible = false;
            cr_Textbox1.Visible = false;
            LlenarComboEmpleados();
            botones_Nuevos1.Click += AddAttendance;
        }

        public Control_Asistencias(Record_Attendance record)
        {
            InitializeComponent();
            botones_Nuevos1.Visible = false;
            botones_Nuevos2.Visible = false;
            soD_ComboBox1.Visible = false;
            cr_Textbox1.Visible = true;
            cr_Textbox1.Enabled = false;
            cr_Textbox1.Text = record._Name;
            if (user.Confirm_Operation("Eliminar asistencias"))
            {
                botones_Nuevos2.Visible = true;
            }
            if (user.Confirm_Operation("Editar asistencias"))
            {
                botones_Nuevos1.Visible = true;
                botones_Nuevos1.Text = "Editar";
            }
            botones_Nuevos1.Click += EditAttendance;
            botones_Nuevos2.Click += DeleteAttendance;
        }
        private void CentrarElementos()
        {
            Point SubL = cR_Subtitulos1.Location;
            cR_Subtitulos1.Location = _size.CentrarElementosX(SubL, cR_Subtitulos1.Size, this.Size);

            Size panel = new Size(cR_SplitContainer1.Width, (cR_SplitContainer1.Height - cR_SplitContainer1.SplitterDistance));
            panel1.Location = _size.CentrarElementosXY(panel1.Size, panel);
        }
        private void LlenarComboEmpleados()
        {
            foreach (Employee emp in empleados)
            {
                soD_ComboBox1.Items.Add(emp._Name + " " + emp._Lastname);
            }
        }
        private void Agregar_Asistencias_Load(object sender, EventArgs e)
        {
            CentrarElementos();
        }

        private void Agregar_Asistencias_Resize(object sender, EventArgs e)
        {
            CentrarElementos();
        }

        private void AddAttendance(object sender, EventArgs e)
        {
            MessageBox.Show("Yo agrego");
        }

        private void EditAttendance(object sender, EventArgs e)
        {
            MessageBox.Show("Yo edito");
        }

        private void DeleteAttendance(object sender, EventArgs e)
        {
            MessageBox.Show("Yo elimino");
        }
    }
}
