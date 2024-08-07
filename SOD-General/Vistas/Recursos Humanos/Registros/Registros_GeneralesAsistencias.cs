using Controladores;
using Modelos.AsistenciasYPermisos;
using Modelos.Control_de_usuarios;
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
        Model_User user;
        SizesGenerales _size = new SizesGenerales();
        Registros_Controller control = new Registros_Controller();
        List<Record_Attendance> Asistencias;
        public Registros_GeneralesAsistencias(Model_User user)
        {
            InitializeComponent();
            this.user = user;
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

            if(data.Count > 0)
            {
                
                foreach (Record_Attendance registro in data)
                {
                    cR_DataGriedView2.Rows.Add(
                        registro.IdRecord,
                        registro._Name,
                        _size.FiltarHoras(registro.Entry),
                        _size.FiltarHoras(registro.LunchS),
                        _size.FiltarHoras(registro.LunchF),
                        _size.FiltarHoras(registro.Exit),
                        registro.Job_Hours.ToString().Substring(0, 5)+ " Horas"
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
            Task centrar = new Task(() => { CentrarElementos(); });
            Task.Delay(400);
            llenarlista.Start();
            centrar.Start();

            await llenarlista;
            await centrar;

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
            OrganizarDataGriedFecha();
        }
    }
}
