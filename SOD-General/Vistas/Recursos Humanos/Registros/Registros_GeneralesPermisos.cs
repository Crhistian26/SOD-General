using Controladores;
using Modelos.AsistenciasYPermisos;
using Modelos.Control_de_usuarios;
using Modelos.Usuarios_Empleados;
using SOD_General.Controladores;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SOD_General.Vistas.Recursos_Humanos.Registros
{
    public partial class Registros_GeneralesPermisos : Form
    {
        Registros_Controller control = new Registros_Controller();
        SizesGenerales _sizes = new SizesGenerales();
        ControlOperaciones operaciones;
        List<Employee> empleados;
        List<Model_Reason> motivos;
        List<Record_Permission> permisos;
        Model_User user;

        public Registros_GeneralesPermisos(AppVistaGeneral app)
        {
            InitializeComponent();
            user = Application.OpenForms.OfType<AppVistaGeneral>().First().user;
            empleados = control.Obtener_Empleados_Trabajando();
            motivos = control.Obtener_Razones();
            permisos = control.Obtener_Permisos(cR_DateTimePicker1.Value, cR_DateTimePicker2.Value.AddDays(1));
            CentrarElementos();
            LlenarComboEmpleados();
            LlenarComboMotivos();
            OrganizarDataGriedFecha();
            if (!user.Confirm_Operation("Agregar permisos"))
            {
                botones_Nuevos5.Visible = false;
            }
        }

        public void CentrarElementos()
        {
            Point punto = cR_Subtitulos1.Location;
            cR_Subtitulos1.Location = _sizes.CentrarElementosX(punto, cR_Subtitulos1.Size, this.Size);
        }

        private void LlenarComboEmpleados()
        {
            cr_ComboBox1.Items.Add("Todos los empleados");
            foreach (Employee emp in empleados)
            {
                cr_ComboBox1.Items.Add(emp._Name + " " + emp._Lastname);
            }
            cr_ComboBox1.SelectedIndex = 0;
        }

        private void LlenarComboMotivos()
        {
            cr_ComboBox2.Items.Add("Todos los motivos");
            foreach (Model_Reason reas in motivos)
            {
                cr_ComboBox2.Items.Add(reas._Reason);
            }
            cr_ComboBox2.SelectedIndex = 0;
        }


        public void OrganizarDataGriedFecha()
        {
            cR_DataGriedView1.Rows.Clear();
            List<Record_Permission> data = null;

            if (cr_ComboBox1.Text == "Todos los empleados")
            {
                cR_DataGriedView1.Rows.Clear();
                data =
                    permisos.Select(a => a)
                    .OrderBy(a => a.Begin_Date)
                    .ToList();
            }
            else
            {
                cR_DataGriedView1.Rows.Clear();
                data =
                    permisos.Select(a => a)
                    .Where
                    ( a =>
                        a._Name == cr_ComboBox1.Text
                    )
                    .OrderBy(a => a.Begin_Date)
                    .ToList();
            }

            if(cr_ComboBox2.Text == "Todos los motivos")
            {
                cR_DataGriedView1.Rows.Clear();
                data =
                    data.Select(a => a)
                    .OrderBy(a => a.Begin_Date)
                    .ToList();
            }
            else
            {
                cR_DataGriedView1.Rows.Clear();
                data =
                    data.Select(a => a)
                    .Where
                    (
                        a =>
                        a._Reason == cr_ComboBox2.Text
                        )
                    .OrderBy(a => a.Begin_Date)
                    .ToList();
            }

            if (data.Count > 0)
            {
                foreach (Record_Permission Record in data)
                {
                    cR_DataGriedView1.Rows.Add(
                    Record.IdRecord,
                    Record._Name,
                    Record._Reason,
                    Record.Begin_Date.ToString("f"),
                    Record.End_Date.ToString("f"),
                    _sizes.ConvertTSWithDays(Record.Get_Hours_Ausent())
                    );
                }
            }
        }


        private void Registros_Generales_Load(object sender, EventArgs e)
        {

        }

        private void Registros_Generales_Resize(object sender, EventArgs e)
        {
            CentrarElementos();
        }

        private void cR_DataGriedView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (user.Confirm_Operation("Editar permisos"))
                {
                    var win = Application.OpenForms.OfType<Control_Permisos>().FirstOrDefault();
                    if (win != null)
                    {
                        win.Close();
                    }

                    int h = Convert.ToInt32(cR_DataGriedView1.Rows[e.RowIndex].Cells[0].Value);
                    Record_Permission permiso = permisos.Where(a => a.IdRecord == h).Select(a => a).First();
                    Control_Permisos ver = new Control_Permisos(permiso);
                    ver.Show();
                }
            }
        }

        private void botones_Nuevos5_Click(object sender, EventArgs e)
        {
            control.AgregarPermiso();
        }


        private void botones_Nuevos1_Click(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Now;

            switch (fecha.DayOfWeek.ToString())
            {
                case "Sunday":
                    cR_DateTimePicker2.Value = DateTime.Now;
                    cR_DateTimePicker1.Value = DateTime.Now.AddDays(-6);
                    break;
                case "Monday":
                    cR_DateTimePicker2.Value = DateTime.Now;
                    cR_DateTimePicker1.Value = DateTime.Now.AddMinutes(-1);
                    break;
                case "Tuesday":
                    cR_DateTimePicker2.Value = DateTime.Now;
                    cR_DateTimePicker1.Value = DateTime.Now.AddDays(-1);
                    break;
                case "Wednesday":
                    cR_DateTimePicker2.Value = DateTime.Now;
                    cR_DateTimePicker1.Value = DateTime.Now.AddDays(-2);
                    break;
                case "Thursday":
                    cR_DateTimePicker2.Value = DateTime.Now;
                    cR_DateTimePicker1.Value = DateTime.Now.AddDays(-3);
                    break;
                case "Friday":
                    cR_DateTimePicker2.Value = DateTime.Now;
                    cR_DateTimePicker1.Value = DateTime.Now.AddDays(-4);
                    break;
                case "Saturday":
                    cR_DateTimePicker2.Value = DateTime.Now;
                    cR_DateTimePicker1.Value = DateTime.Now.AddDays(-5);
                    break;

            }
        }

        private void botones_Nuevos2_Click(object sender, EventArgs e)
        {
            DateTime hoy = DateTime.Now;
            DateTime fecha = new DateTime(hoy.Year, hoy.Month, 1);
            cR_DateTimePicker1.Value = fecha;
            cR_DateTimePicker2.Value = DateTime.Now;
        }

        private void botones_Nuevos3_Click(object sender, EventArgs e)
        {
            DateTime hoy = DateTime.Now;
            DateTime fecha = new DateTime(hoy.Year, hoy.AddMonths(-2).Month, 1);
            cR_DateTimePicker1.Value = fecha;
            cR_DateTimePicker2.Value = DateTime.Now;
        }

        private void botones_Nuevos4_Click(object sender, EventArgs e)
        {
            DateTime hoy = DateTime.Now;
            DateTime fecha = new DateTime(hoy.Year, 1, 1);
            cR_DateTimePicker1.Value = fecha;
            cR_DateTimePicker2.Value = DateTime.Now;
        }

        private void cR_DateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if (cR_DateTimePicker1.Value > cR_DateTimePicker2.Value)
            {
                cR_DateTimePicker1.Refresh();
                cR_DateTimePicker2.Refresh();
                MessageBox.Show("La segunda fecha debe ser mayor a la primera.");
            }
            else
            {
                permisos = control.Obtener_Permisos(cR_DateTimePicker1.Value.Date, cR_DateTimePicker2.Value.Date.AddDays(1));
                OrganizarDataGriedFecha();
            }
        }

        private void cR_DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (cR_DateTimePicker1.Value > cR_DateTimePicker2.Value)
            {
                cR_DateTimePicker1.Refresh();
                cR_DateTimePicker2.Refresh();
                MessageBox.Show("La primera fecha debe ser menor a la segunda.");
            }
            else
            {
                permisos = control.Obtener_Permisos(cR_DateTimePicker1.Value.Date, cR_DateTimePicker2.Value.Date.AddDays(1));
                OrganizarDataGriedFecha();
            }
        }

        private void cr_ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            OrganizarDataGriedFecha();
        }

        private void cr_ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            OrganizarDataGriedFecha();
        }
    }
}
