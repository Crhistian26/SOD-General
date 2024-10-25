using Modelos.AsistenciasYPermisos;
using Modelos.Usuarios_Empleados;
using SOD_General.Controladores;
using SOD_General.Vistas.Taller.Controles_de_Equipo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
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
            AddPermissionView();
        }
        public Control_Permisos(Record_Permission record)
        {
            InitializeComponent();
            empleados = control.Obtener_Empleados_Trabajando();
            motivos = control.Obtener_Razones();
            this.Permission_Record = record;
            EditPermissionView();
            cR_Subtitulos1.Text = "Editar permiso";
            botones_Nuevos1.Text = "Editar";
        }
        //Esta funcion es la que se encarga de verificar los datos antes de guardarlos
        private bool ConfirmData()
        {
            //Cada uno de estos if llevan la opcion contraria, osea el empleado no esta seleccionado, descripcion vacia etc
           //esto para que sea mas sencillo el seguimiento
            if(cR_DateTimePicker1.Value.Date > cR_DateTimePicker2.Value.Date)
            {
                return false;
            }

            if(Permission_Record != null)
            {
                if(cr_Textbox1.Text == null)
                {
                    return false;
                }
            }
            else
            {
                if(cr_ComboBox1.SelectedIndex == -1)
                {
                    return false;
                }
            }

            if(cR_Checkbox1.Checked == false)
            {
                if(cR_TBhora1.Text.Trim().Length == 0)
                {
                    return false;
                }
                if (cR_TBminutos1.Text.Trim().Length == 0)
                {
                    return false;
                }
                if(cr_ComboBox3.SelectedIndex == -1)
                {
                    return false;
                }
            }

            if (cR_Checkbox2.Checked == false)
            {
                if (cR_TBhora2.Text.Trim().Length == 0)
                {
                    return false;
                }
                if (cR_TBminutos2.Text.Trim().Length == 0)
                {
                    return false;
                }
                if (cr_ComboBox4.SelectedIndex == -1)
                {
                    return false;
                }
            }

            if (cr_ComboBox2.SelectedIndex == -1)
            {
                return false;
            }
            DateTime Begin, End;

            (Begin, End) = GetTimes();

            if(Begin.Date > End.Date)
            {
                return false;
            }

            return true;

        }

        private (DateTime,DateTime) GetTimes()
        {
            DateTime Begin = new DateTime();
            DateTime End = new DateTime();

            if (cR_Checkbox1.Checked)
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

            return(Begin,End);
        }

        //Esta funcion es la que se encarga de obtener el reporte en la ventana.
        private Record_Permission GetPermissionData()
        {
            DateTime Begin, End;

            (Begin, End) = GetTimes();

            int id = Permission_Record == null ? 0 : Permission_Record.IdRecord; 

            int idempleado;

            if(Permission_Record != null)
            {
                idempleado = empleados.Where(a => (a._Name + " " + a._Lastname) == Permission_Record._Name).Select(a => a.IdEmployee).First();
            }
            else
            {
                idempleado = empleados[cr_ComboBox1.SelectedIndex].IdEmployee;
            }

            Record_Permission record = new Record_Permission(
                    id,
                    idempleado,
                    motivos[cr_ComboBox2.SelectedIndex].IdReason,
                    soD_TextBox2.Text,
                    Begin,
                    End
                );

            return record;
        }

        private void AddPermissionView()
        {
            cr_ComboBox1.Visible = true;
            cr_Textbox1.Visible = false;
            botones_Nuevos1.Visible = true;
            botones_Nuevos1.Click += Add_Permission;
            botones_Nuevos2.Visible = false;
            botones_Nuevos3.Visible = false;
            panel2.Visible = true;
            panel3.Visible = true;
            LlenarCombobox();
        }

        private void EditPermissionView()
        {
            cR_DateTimePicker1.Value = Permission_Record.Begin_Date.Date;
            cR_DateTimePicker2.Value = Permission_Record.End_Date.Date;
            cr_ComboBox1.Visible = false;
            cr_Textbox1.Visible = true;
            cr_Textbox1.Text = Permission_Record._Name;
            cr_Textbox1.Enabled = false;
            soD_TextBox2.Text = Permission_Record._Description;
            LlenarCombobox();
            cr_ComboBox2.SelectedItem = motivos.Where(a => a._Reason == Permission_Record._Reason)
                    .Select(a => a._Reason).First();

            botones_Nuevos1.Visible = false;
            botones_Nuevos2.Visible = true;
            botones_Nuevos2.Click += Edit_Permission;
            botones_Nuevos3.Visible = true;
            botones_Nuevos3.Click += Delete_Permission;

            panel2.Visible = true;
            panel3.Visible = true;

            if(Permission_Record.ConfirmBeginDate())
            {
                cR_Checkbox1.Checked = true;
            }

            if (Permission_Record.ConfirmEndDate())
            {
                cR_Checkbox2.Checked = true;
            }

            

            SelectHours();
        }

        private void SelectHours()
        {
            TimeSpan start = _size.Days[Permission_Record.Begin_Date.DayOfWeek].JobStart;
            TimeSpan end = _size.Days[Permission_Record.End_Date.DayOfWeek].JobEnd;

            TimeSpan startPermission = new TimeSpan(
                Permission_Record.Begin_Date.Hour,
                Permission_Record.Begin_Date.Minute,
                0
                );

            TimeSpan endPermission = new TimeSpan(
                Permission_Record.End_Date.Hour,
                Permission_Record.End_Date.Minute,
                0
                );

            (cR_TBhora1.Text,cR_TBminutos1.Text,cr_ComboBox3.SelectedItem) = _size.FiltrarHorasComb(startPermission);
            (cR_TBhora2.Text, cR_TBminutos2.Text, cr_ComboBox4.SelectedItem) = _size.FiltrarHorasComb(endPermission);

            if ( startPermission == start)
            {
                cR_Checkbox1.Checked = true;
            }
            else
            {
                cR_Checkbox1.Checked = false;
            }

            if (endPermission == end)
            {
                cR_Checkbox2.Checked = true;
            }
            else
            {
                cR_Checkbox2.Checked = false;
            }
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
            if (ConfirmData())
            {
                if (control.Add_Permission(GetPermissionData()))
                {
                    control.Reset_VisualPermisos();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Hay campos que se deben completar.");
            }

        }

        private void Edit_Permission(object sender, EventArgs e)
        {
            if (ConfirmData())
            {
                if (control.Edit_Permission(GetPermissionData()))
                {
                    control.Reset_VisualPermisos();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Hay campos que se deben completar.");
            }
        }

        private void Delete_Permission(object sender, EventArgs e)
        {
            var msg = MessageBox.Show("Estas seguro de eliminar este registro?", "Confirmacion", MessageBoxButtons.OKCancel);
            if (msg == DialogResult.OK)
            {
                if (control.Delete_Permission(Permission_Record.IdRecord))
                {
                    control.Reset_VisualPermisos();
                    this.Close();
                }
            }

        }

        private void cr_Textbox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
