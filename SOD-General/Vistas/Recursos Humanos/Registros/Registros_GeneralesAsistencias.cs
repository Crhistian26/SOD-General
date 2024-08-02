using Controladores;
using Modelos.AsistenciasYPermisos;
using SOD_General.Controladores;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOD_General.Vistas.Recursos_Humanos.Registros
{
    public partial class Registros_GeneralesAsistencias : Form
    {
        SizesGenerales _size = new SizesGenerales();
        Registros_Controller control = new Registros_Controller();
        ControlOperaciones operaciones;
        List<Record_Attendance> Asistencias;
        public Registros_GeneralesAsistencias(AppVistaGeneral app)
        {
            InitializeComponent();
            operaciones = new ControlOperaciones(app);
        }

        public void CentrarElementos()
        {
            Point punto = cR_Subtitulos1.Location;
            cR_Subtitulos1.Location = _size.CentrarElementosX(punto, cR_Subtitulos1.Size, this.Size);

            punto = cR_DateTimePicker1.Location;
            cR_DateTimePicker1.Location = _size.CentrarElementosX(punto, cR_DateTimePicker1.Size, this.Size);
        }

        public void OrganizarDataGriedFecha()
        {
            var data = Asistencias.Select(a => a)
                .Where(
                    a => a.DateAttendance.Date.Day == cR_DateTimePicker1.Value.Date.Day 
                    && a.DateAttendance.Date.Month == cR_DateTimePicker1.Value.Date.Month 
                    && a.DateAttendance.Date.Year == cR_DateTimePicker1.Value.Date.Year
                    )
                .ToList();

            if(data.Count > 0)
            {
                cR_DataGriedView2.Rows.Clear();
                foreach (Record_Attendance registro in data)
                {
                   
                    cR_DataGriedView2.Rows.Add(
                        registro.IdRecord,
                        registro._Name,
                        _size.FiltarHoras(registro.Entry),
                        _size.FiltarHoras(registro.LunchS),
                        _size.FiltarHoras(registro.LunchF),
                        _size.FiltarHoras(registro.Exit),
                        registro.Job_Hours.ToString().Substring(0, 5)
                        );
                    
                }
            }
            else
            {
                MessageBox.Show("No hay asistencias en este dia.");
            }
        }

        public void OrganizarDataGried()
        {
            var data = Asistencias.Select(a => a)
                .Where(
                    a => a.DateAttendance.Date.Day == cR_DateTimePicker1.Value.Date.Day
                    && a.DateAttendance.Date.Month == cR_DateTimePicker1.Value.Date.Month
                    && a.DateAttendance.Date.Year == cR_DateTimePicker1.Value.Date.Year
                    )
                .ToList();

            if (data.Count > 0)
            {
                cR_DataGriedView2.Rows.Clear();
                foreach (Record_Attendance registro in data)
                {

                    cR_DataGriedView2.Rows.Add(
                        registro.IdRecord,
                        registro._Name,
                        _size.FiltarHoras(registro.Entry),
                        _size.FiltarHoras(registro.LunchS),
                        _size.FiltarHoras(registro.LunchF),
                        _size.FiltarHoras(registro.Exit),
                        registro.Job_Hours.ToString().Substring(0, 5)
                        );

                }
            }
            else
            {
                MessageBox.Show("No hay asistencias en este dia.");
            }
        }

        private async void Registros_GeneralesAsistencias_Load(object sender, EventArgs e)
        {
            Task llenarlista = new Task(() => { Asistencias = control.Obtener_Asistencias(); });

            llenarlista.Start();
            CentrarElementos();
            if (operaciones.BuscarAutorizacion("Agregar asistencias"))
            {
                botones_Nuevos1.Visible = true;
            }
            else
            {
                botones_Nuevos1.Visible = false;
            }

            await llenarlista;
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
            OrganizarDataGried();
        }
    }
}
