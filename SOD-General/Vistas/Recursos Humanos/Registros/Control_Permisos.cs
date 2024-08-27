using Modelos.AsistenciasYPermisos;
using Modelos.Usuarios_Empleados;
using SOD_General.Controladores;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SOD_General.Vistas.Recursos_Humanos.Registros
{
    public partial class Control_Permisos : Form
    {
        SizesGenerales _size = new SizesGenerales();
        Registros_Controller control = new Registros_Controller();
        List<Employee> empleados;
        List<Model_Reason> motivos;
        Record_Permission Permission_Record;
        public Control_Permisos()
        {
            InitializeComponent();
            empleados = control.Obtener_Empleados_Trabajando();
            motivos = control.Obtener_Razones();
        }
        public Control_Permisos(Record_Permission record)
        {
            InitializeComponent();
            empleados = control.Obtener_Empleados_Trabajando();
            motivos = control.Obtener_Razones();
            this.Permission_Record = record;
            this.botones_Nuevos1.Click += Add_Permission;
        }

        private void AddPermissionView()
        {

        }

        private void EditPermissionView()
        {

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
            cR_Checkbox1.Checked = true;
            cR_Checkbox2.Checked = true;
        }

        private void Agregar_Permiso_Resize(object sender, EventArgs e)
        {
            CentrarElementos();
        }

        private void soD_ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cR_Checkbox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cR_Checkbox1.Checked == true)
            {
                panel2.Visible = false;
            }
            else
            {
                panel2.Visible = true;
            }

        }

        private void cR_Checkbox2_CheckedChanged(object sender, EventArgs e)
        {
            if (cR_Checkbox2.Checked == true)
            {
                panel3.Visible = false;
            }
            else
            {
                panel3.Visible = true;
            }
        }

        private void Add_Permission(object sender, EventArgs e)
        {
            DateTime Begin = new DateTime();
            DateTime End = new DateTime();

            if(cR_Checkbox1.Checked)
            {
                var day = _size.Days[cR_DateTimePicker1.Value.DayOfWeek];
                var hello = new DateTime
                    (cR_DateTimePicker1.Value.Year,
                    cR_DateTimePicker1.Value.Month,
                    cR_DateTimePicker1.Value.Day)
                    + day.JobStart
                    ;
                Begin = hello;
            }
            else
            {
                var hello = new DateTime
                    (cR_DateTimePicker1.Value.Year,
                    cR_DateTimePicker1.Value.Month,
                    cR_DateTimePicker1.Value.Day)
                    + _size.ConvertComboForTimeSpan(
                        Convert.ToInt32(cR_TBhora1.Text),
                        Convert.ToInt32(cR_TBminutos1.Text),
                        cr_ComboBox3.SelectedItem.ToString()
                        );
                Begin = hello;
            }

            if (cR_Checkbox2.Checked)
            {
                var day = _size.Days[cR_DateTimePicker2.Value.DayOfWeek];
                var hello = new DateTime
                    (cR_DateTimePicker2.Value.Year,
                    cR_DateTimePicker2.Value.Month,
                    cR_DateTimePicker2.Value.Day)
                    + day.JobEnd
                    ;
                End = hello;
            }
            else
            {
                var hello = new DateTime
                    (cR_DateTimePicker2.Value.Year,
                    cR_DateTimePicker2.Value.Month,
                    cR_DateTimePicker2.Value.Day)
                    + _size.ConvertComboForTimeSpan(
                        Convert.ToInt32(cR_TBhora2.Text),
                        Convert.ToInt32(cR_TBminutos2.Text),
                        cr_ComboBox4.SelectedItem.ToString()
                        );
                End = hello;
            }

            Record_Permission record = new Record_Permission(
                    0,
                    empleados[cr_ComboBox1.SelectedIndex].IdEmployee,
                    motivos[cr_ComboBox2.SelectedIndex].IdReason,
                    soD_TextBox2.Text,
                    Begin,
                    End
                );
            if (control.Add_Permission(record))
            {
                control.Reset_VisualPermisos();
                this.Close();
            }

        }
    }
}
