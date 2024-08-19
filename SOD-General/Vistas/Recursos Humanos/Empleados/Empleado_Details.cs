using Microsoft.Win32;
using Modelos.AsistenciasYPermisos;
using Modelos.Control_de_usuarios;
using Modelos.Usuarios_Empleados;
using SOD_General.Controladores;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Windows.Forms;

namespace SOD_General.Vistas.Recursos_Humanos.Empleados
{
    public partial class Empleado_Details : Form
    {
        private SizesGenerales _size = new SizesGenerales();
        private Employee employee;
        Empleados_Controller controlEmpleados = new Empleados_Controller();
        List<Record_Attendance> Asistencias = new List<Record_Attendance>();
        List<Record_Permission> Permisos;
        Model_User user = Application.OpenForms.OfType<AppVistaGeneral>().First().user;
        public Empleado_Details(int id)
        {
            InitializeComponent();
            Asistencias = controlEmpleados.ListaAsistenciasEmpleado(id);
            employee = controlEmpleados.ObtenerEmpleado(id);
            Permisos = controlEmpleados.ListaPermisosEmpleado(id);
        }

        public void CentrarElementos()
        {
            Size size = cR_Subtitulos1.Size;
            Point punto = cR_Subtitulos1.Location;
            cR_Subtitulos1.Location = _size.CentrarElementosX(punto, size, this.Size);
            punto = cR_Subtitulos2.Location;
            size = cR_Subtitulos2.Size;
            cR_Subtitulos2.Location = _size.CentrarElementosX(punto, size, this.Size);
        }

        public void LlenarAsistencias()
        {
            if (Asistencias.Count > 0)
            {
                foreach (Record_Attendance registro in Asistencias)
                {
                    cR_DataGriedView2.Rows.Add(
                        _size.FiltarHoras(registro.Entry),
                        _size.FiltarHoras(registro.LunchS),
                        _size.FiltarHoras(registro.LunchF),
                        _size.FiltarHoras(registro.Exit),
                        registro.Job_Hours.ToString().Substring(0, 5)+" Horas",
                        registro.DateAttendance.ToString("D")
                        );
                }
            }
        }

        public void LlenarPermisos()
        {
            if (Asistencias.Count > 0)
            {
                foreach (Record_Permission registro in Permisos)
                {
                    cR_DataGriedView1.Rows.Add(
                        registro.IdRecord,
                        registro._Reason,
                        registro._Description
                        );
                }
            }
        }
        private void Empleado_Details_Load(object sender, EventArgs e)
        {
            if(!user.Confirm_Operation("Editar empleados"))
            {
                botones_Nuevos2.Visible = false;
            }
            cR_Subtitulos1.Text = employee._Name + "\n" + employee._Lastname;
            this.Text = $"Registros de: {employee._Name} {employee._Lastname}";
            cR_Subtitulos2.Text = "Asistencias";
            cR_DataGriedView2.Visible = true;
            LlenarAsistencias();
            LlenarPermisos();
            CentrarElementos();
        }

        private void Empleado_Details_Resize(object sender, EventArgs e)
        {
            CentrarElementos();
        }

        private void botones_Nuevos2_Click(object sender, EventArgs e)
        {
            if (user.Employye_Id != employee.IdEmployee && (user._Role.Name != "Administrador" || user._Role.Name != "Programador"))
            {
                controlEmpleados.Abrir_Control_Empleados(employee);
                this.Close();
            }
            else
            {
                MessageBox.Show("No puedes alterar tus propios datos.");
            }
            
        }

        private void cR_DataGriedView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void botones_Nuevos1_Click(object sender, EventArgs e)
        {
            cR_Subtitulos2.Text = "Permisos";
            cR_DataGriedView1.Visible = true;
            cR_DataGriedView2.Visible = false;
        }

        private void botones_Nuevos5_Click(object sender, EventArgs e)
        {
            cR_Subtitulos2.Text = "Asistencias";
            cR_DataGriedView2.Visible = true;
            cR_DataGriedView1.Visible = false;
        }
    }
}
