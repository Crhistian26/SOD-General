using Modelos.AsistenciasYPermisos;
using Modelos.Control_de_usuarios;
using SOD_General.Controladores;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SOD_General.Vistas.Recursos_Humanos.Registros
{
    public partial class Registros_GeneralesAsistencias : Form
    {
        Model_User user = Application.OpenForms.OfType<AppVistaGeneral>().First().user;
        SizesGenerales _size = new SizesGenerales();
        Registros_Controller control = new Registros_Controller();
        List<Record_Attendance> Asistencias;
        public Registros_GeneralesAsistencias()
        {
            InitializeComponent();
            Asistencias = control.Obtener_Asistencias(cR_DateTimePicker1.Value, cR_DateTimePicker1.Value);
            CentrarElementos();
            if (!user.Confirm_Operation("Agregar asistencias"))
            {
                botones_Nuevos1.Visible = false;
            }
        }

        public void CentrarElementos()
        {
            Point punto = cR_DateTimePicker1.Location;
            cR_DateTimePicker1.Location = _size.CentrarElementosX(punto, cR_DateTimePicker1.Size, this.Size);

            punto = cR_Subtitulos1.Location;
            cR_Subtitulos1.Location = _size.CentrarElementosX(punto, cR_Subtitulos1.Size, this.Size);
        }

        public void OrganizarDataGriedFecha()
        {
            cR_DataGriedView2.Rows.Clear();
            var data = Asistencias.Select(a => a)
                .Where(
                    a => a.DateAttendance.Date.Day == cR_DateTimePicker1.Value.Date.Day
                    && a.DateAttendance.Date.Month == cR_DateTimePicker1.Value.Date.Month
                    && a.DateAttendance.Date.Year == cR_DateTimePicker1.Value.Date.Year
                    )
                .ToList();

            if (data.Count > 0)
            {
                foreach (Record_Attendance registro in data)
                {
                    string LS, LF;
                    if(registro.LunchS != null && registro.LunchF != null)
                    {
                        LS = _size.FiltarHoras(registro.LunchS.Value);
                        LF = _size.FiltarHoras(registro.LunchF.Value);
                    }
                    else
                    {
                        LS = "No almorzo";
                        LF = "No almorzo";
                    }
                    cR_DataGriedView2.Rows.Add(
                        registro.IdRecord,
                        registro._Name,
                        _size.FiltarHoras(registro.Entry),
                        LS,
                        LF,
                        _size.FiltarHoras(registro.Exit),
                        registro.Job_Hours.ToString().Substring(0, 5) + " Horas"
                        );
                }
            }
        }


        private void Registros_GeneralesAsistencias_Load(object sender, EventArgs e)
        {
            OrganizarDataGriedFecha();
        }

        private void Registros_GeneralesAsistencias_Resize(object sender, EventArgs e)
        {
            CentrarElementos();
        }

        private void botones_Nuevos1_Click(object sender, EventArgs e)
        {
            control.AgregarAsistencia();
        }

        private void cR_DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Asistencias = control.Obtener_Asistencias(cR_DateTimePicker1.Value, cR_DateTimePicker1.Value);
            OrganizarDataGriedFecha();
        }

        private void cR_DataGriedView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                var win = Application.OpenForms.OfType<Control_Asistencias>().FirstOrDefault();
                if (win != null)
                {
                    win.Close();
                }
                Record_Attendance record = Asistencias
                    .Where(a => a.IdRecord == Convert.ToInt32(cR_DataGriedView2.Rows[e.RowIndex].Cells[0].Value))
                    .Select(a => a).First();
                Control_Asistencias window = new Control_Asistencias(record);
                window.Show();
            }
        }

        public void Reset()
        {
            Asistencias = control.Obtener_Asistencias(cR_DateTimePicker1.Value, cR_DateTimePicker1.Value);
            OrganizarDataGriedFecha();
        }
    }
}
