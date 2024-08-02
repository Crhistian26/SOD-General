using Controladores;
using Modelos.AsistenciasYPermisos;
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
        List<Record_Permission> permisos;

        public Registros_GeneralesPermisos(AppVistaGeneral app)
        {
            InitializeComponent();
            operaciones = new ControlOperaciones(app);
            empleados = control.Obtener_Empleados();
            permisos = control.Obtener_Permisos();
        }

        public void CentrarElementos()
        {
            Point punto = cR_Subtitulos1.Location;
            cR_Subtitulos1.Location = _sizes.CentrarElementosX(punto, cR_Subtitulos1.Size, this.Size);
        }

        private void LlenarComboEmpleados()
        {
            comboBox1.Items.Add("Todos los empleados");
            foreach (Employee emp in empleados)
            {
                comboBox1.Items.Add(emp._Name + " " + emp._Lastname);
            }
            comboBox1.SelectedIndex = 0;
        }

        public void OrganizarDataGriedFecha()
        {
            cR_DataGriedView1.Rows.Clear();
            if (comboBox1.Text != "Todos los departamentos")
            {
                cR_DataGriedView1.Rows.Clear();
                var data = permisos.Select(a => a).Where(a => a.Permission_Date <= cR_DateTimePicker2.Value && a.Permission_Date >= cR_DateTimePicker1.Value).ToList();

                if (data.Count > 0)
                {
                    foreach(Record_Permission Record in data)
                    {
                        cR_DataGriedView1.Rows.Add(
                        Record.IdRecord,
                        Record._Name,
                        Record._Reason,
                        Record.Count_Time +" "+ Record.Mesure_Time,
                        Record.Permission_Date.ToString("D")
                        );
                    }
                }
            }
            else
            {

            }
        }

        private void Registros_Generales_Load(object sender, EventArgs e)
        {
            CentrarElementos();
            cR_DataGriedView1.Rows.Add(1, "Fernando Acosta", "Enfermedad", "Lunes 27 de mayo", "Jueves 30 de mayo");
            cR_DataGriedView1.Rows.Add(1, "Maria Fernandez", "Diligencia", "Lunes 27 de mayo (10:30)", "Lunes 27 de mayo (2:15)");
            if (operaciones.BuscarAutorizacion("Agregar permisos"))
            {
                botones_Nuevos5.Visible = true;
            }
            else
            {
                botones_Nuevos5.Visible = false;
            }
            LlenarComboEmpleados();
            cR_DateTimePicker1.Value = DateTime.Now;
            cR_DateTimePicker2.Value = DateTime.Now.AddMinutes(1);
        }

        private void Registros_Generales_Resize(object sender, EventArgs e)
        {
            CentrarElementos();
        }

        private void cR_DataGriedView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (operaciones.BuscarAutorizacion("Editar permisos"))
                {
                    Permiso_Details ver = new Permiso_Details();
                    ver.Show();
                }
                else
                {
                    Permiso_Details ver = new Permiso_Details(0);
                    ver.Show();
                }

            }
        }

        private void botones_Nuevos5_Click(object sender, EventArgs e)
        {
            control.AgregarPermiso();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void botones_Nuevos1_Click(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Now;
            switch (fecha.DayOfWeek.ToString())
            {
                case "Sunday":
                    cR_DateTimePicker1.Value = DateTime.Now.AddDays(-6);
                    cR_DateTimePicker2.Value.AddMinutes(2);
                    break;
                case "Monday":
                    cR_DateTimePicker1.Value = DateTime.Now.AddDays(0);
                    cR_DateTimePicker2.Value = DateTime.Now.AddMinutes(2);
                    break;
                case "Tuesday":
                    cR_DateTimePicker1.Value = DateTime.Now.AddDays(-1);
                    cR_DateTimePicker2.Value = DateTime.Now.AddMinutes(2);
                    break;
                case "Wednesday":
                    cR_DateTimePicker1.Value = DateTime.Now.AddDays(-2);
                    cR_DateTimePicker2.Value = DateTime.Now.AddMinutes(2);
                    break;
                case "Thursday":
                    cR_DateTimePicker1.Value = DateTime.Now.AddDays(-3);
                    cR_DateTimePicker2.Value = DateTime.Now.AddMinutes(2);
                    break;
                case "Friday":
                    cR_DateTimePicker1.Value = DateTime.Now.AddDays(-4);
                    cR_DateTimePicker2.Value = DateTime.Now.AddMinutes(2);
                    break;
                case "Saturday":
                    cR_DateTimePicker1.Value = DateTime.Now.AddDays(-5);
                    cR_DateTimePicker2.Value = DateTime.Now.AddMinutes(2);
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
                cR_DateTimePicker2.Value = DateTime.Now.AddMinutes(1);
                cR_DateTimePicker1.Value = DateTime.Now.AddMinutes(-1);
                MessageBox.Show("La primera fecha introducida no puede ser mayor a la segunda.");
            }
            else
            {
                OrganizarDataGriedFecha();
            }
        }

        private void cR_DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (cR_DateTimePicker1.Value > cR_DateTimePicker2.Value)
            {
                cR_DateTimePicker2.Value = DateTime.Now.AddMinutes(1);
                cR_DateTimePicker1.Value = DateTime.Now.AddMinutes(-1);
                MessageBox.Show("La primera fecha introducida no puede ser mayor a la segunda.");
            }
            else
            {
                OrganizarDataGriedFecha();
            }
        }
    }
}
