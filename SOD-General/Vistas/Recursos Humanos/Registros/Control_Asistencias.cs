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
        Record_Attendance record;
        public Control_Asistencias()
        {
            InitializeComponent();
            VistaAgregar();
        }

        public Control_Asistencias(Record_Attendance record)
        {
            InitializeComponent();
            this.record = record;
            VistaEditar();
        }
        private void VistaAgregar()
        {
            empleados = control.Obtener_Empleados_Trabajando();
            botones_Nuevos2.Visible = false;
            cr_Textbox1.Visible = false;
            LlenarComboEmpleados();
            botones_Nuevos1.Click += AddAttendance;
            txtsDefecto();
        }
        private void VistaEditar()
        {
            NulificarElementos();
            botones_Nuevos1.Visible = false;
            botones_Nuevos2.Visible = false;
            soD_ComboBox1.Visible = false;
            cR_Subtitulos1.Text = "Editar asistencia";
            cr_Textbox1.Enabled = false;
            botones_Nuevos1.Text = "Editar";
            cr_Textbox1.Visible = true;
            cR_DateTimePicker1.Value = record.DateAttendance;

            cr_Textbox1.Text = record._Name;
            string index = "";

            (cR_TBhora1.Text, cR_TBminutos1.Text, index) = _size.FiltrarHorasComb(record.Entry);
            soD_ComboBox2.SelectedIndex = soD_ComboBox4.FindString(index);

            (cR_TBhora2.Text, cR_TBminutos2.Text, index) = _size.FiltrarHorasComb(record.Exit);
            soD_ComboBox3.SelectedIndex = soD_ComboBox4.FindString(index);

            (cR_TBhora3.Text, cR_TBminutos3.Text, index) = _size.FiltrarHorasComb(record.LunchS);
            soD_ComboBox4.SelectedIndex = soD_ComboBox4.FindString(index);

            (cR_TBhora4.Text, cR_TBminutos4.Text, index) = _size.FiltrarHorasComb(record.LunchF);
            soD_ComboBox5.SelectedIndex = soD_ComboBox4.FindString(index);

            if (user.Confirm_Operation("Eliminar asistencias"))
            {
                botones_Nuevos2.Visible = true;
            }

            if (user.Confirm_Operation("Editar asistencias"))
            {
                botones_Nuevos1.Visible = true;
                HabilitarElementos();
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

        private void txtsDefecto()
        {
            cR_TBhora1.Text = "8";
            cR_TBminutos1.Text = "30";
            soD_ComboBox2.SelectedIndex = 0;

            cR_TBhora2.Text = "5";
            cR_TBminutos2.Text = "30";
            soD_ComboBox3.SelectedIndex = 1;

            cR_TBhora3.Text = "12";
            cR_TBminutos3.Text = "00";
            soD_ComboBox4.SelectedIndex = 1;

            cR_TBhora4.Text = "1";
            cR_TBminutos4.Text = "00";
            soD_ComboBox5.SelectedIndex = 1;
        }

        private void NulificarElementos()
        {
            cR_TBhora1.Enabled = false;
            cR_TBminutos1.Enabled = false;
            soD_ComboBox2.Enabled = false;

            cR_TBhora2.Enabled = false;
            cR_TBminutos2.Enabled = false;
            soD_ComboBox3.Enabled = false;

            cR_TBhora3.Enabled = false;
            cR_TBminutos3.Enabled = false;
            soD_ComboBox4.Enabled = false;

            cR_TBhora4.Enabled = false;
            cR_TBminutos4.Enabled = false;
            soD_ComboBox5.Enabled = false;
        }
        private void HabilitarElementos()
        {
            cR_TBhora1.Enabled = true;
            cR_TBminutos1.Enabled = true;
            soD_ComboBox2.Enabled = true;

            cR_TBhora2.Enabled = true;
            cR_TBminutos2.Enabled = true;
            soD_ComboBox3.Enabled = true;

            cR_TBhora3.Enabled = true;
            cR_TBminutos3.Enabled = true;
            soD_ComboBox4.Enabled = true;

            cR_TBhora4.Enabled = true;
            cR_TBminutos4.Enabled = true;
            soD_ComboBox5.Enabled = true;
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
            Record_Attendance record = new Record_Attendance
            (
                empleados[soD_ComboBox1.SelectedIndex].IdEmployee,
                _size.CreateTS(cR_TBhora1.Text, cR_TBminutos1.Text, soD_ComboBox2.SelectedItem.ToString()),
                _size.CreateTS(cR_TBhora2.Text, cR_TBminutos2.Text, soD_ComboBox3.SelectedItem.ToString()),
                _size.CreateTS(cR_TBhora3.Text, cR_TBminutos3.Text, soD_ComboBox4.SelectedItem.ToString()),
                _size.CreateTS(cR_TBhora4.Text, cR_TBminutos4.Text, soD_ComboBox5.SelectedItem.ToString()),
                cR_DateTimePicker1.Value
            );
            if(control.AddAttendance(record))
            {
                control.Reset_VisualRegistors();
                this.Close();
            }
        }

        private void EditAttendance(object sender, EventArgs e)
        {

            record.Entry = _size.CreateTS(cR_TBhora1.Text, cR_TBminutos1.Text, soD_ComboBox2.SelectedItem.ToString());
            record.Exit = _size.CreateTS(cR_TBhora2.Text, cR_TBminutos2.Text, soD_ComboBox3.SelectedItem.ToString());
            record.LunchS = _size.CreateTS(cR_TBhora3.Text, cR_TBminutos3.Text, soD_ComboBox4.SelectedItem.ToString());
            record.LunchF = _size.CreateTS(cR_TBhora4.Text, cR_TBminutos4.Text, soD_ComboBox5.SelectedItem.ToString());
            record.DateAttendance = cR_DateTimePicker1.Value;

            if (control.EditAttendance(record))
            {
                control.Reset_VisualRegistors();
                this.Close();
            }
        }

        private void DeleteAttendance(object sender, EventArgs e)
        {
            var ms = MessageBox.Show("Estas seguro de eliminar esta asistencia?", "Eliminar asistencia", MessageBoxButtons.OKCancel);
            if (ms == DialogResult.OK)
            {
                if (control.DeleteAttendance(record))
                {
                    control.Reset_VisualRegistors();
                    this.Close();
                }
            }
        }
    }
}
