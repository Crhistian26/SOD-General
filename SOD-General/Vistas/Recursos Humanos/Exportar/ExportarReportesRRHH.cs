using Modelos.AsistenciasYPermisos;
using SOD_General.Controladores;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SOD_General.Vistas.Recursos_Humanos.Exportar
{
    public partial class ExportarReportesRRHH : Form
    {
        SizesGenerales _size = new SizesGenerales();
        Registros_Controller controlRegistro = new Registros_Controller();
        ExportsRRHHReports reports = new ExportsRRHHReports();
        public ExportarReportesRRHH()
        {
            InitializeComponent();
        }

        private void CentrarElementos()
        {
            Point SubL = cR_Subtitulos1.Location;
            cR_Subtitulos1.Location = _size.CentrarElementosX(SubL, cR_Subtitulos1.Size, this.Size);

            Size panel = new Size(cR_SplitContainer1.Width, (cR_SplitContainer1.Height - cR_SplitContainer1.SplitterDistance));
            panel1.Location = _size.CentrarElementosXY(panel1.Size, panel);
        }

        private void ExportarReportesRRHH_Resize(object sender, EventArgs e)
        {
            CentrarElementos();
        }

        private void ExportarReportesRRHH_Load(object sender, EventArgs e)
        {
            CentrarElementos();
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

        private void cR_DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (cR_DateTimePicker1.Value > cR_DateTimePicker2.Value)
            {
                cR_DateTimePicker1.Refresh();
                cR_DateTimePicker2.Refresh();
                MessageBox.Show("La primera fecha debe ser menor a la segunda.");
            }
        }

        private void cR_DateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if (cR_DateTimePicker1.Value > cR_DateTimePicker2.Value)
            {
                cR_DateTimePicker1.Refresh();
                cR_DateTimePicker2.Refresh();
                MessageBox.Show("La segunda fecha debe ser mayor a la primera.");
            }
        }

        private void botones_Nuevos5_Click(object sender, EventArgs e)
        {
            ExportAttendance();
        }
        private void ExportAttendance()
        {

            List<Record_Attendance> records = controlRegistro.Obtener_Asistencias(cR_DateTimePicker1.Value, cR_DateTimePicker2.Value);
            List<Record_Permission> permissions = controlRegistro.Obtener_Permisos(cR_DateTimePicker1.Value, cR_DateTimePicker2.Value.AddDays(1));
            if (records != null)

                if (records.Count > 0)
                {
                    reports.ImprimirReporte(records, permissions, cR_DateTimePicker1.Value, cR_DateTimePicker2.Value);
                }
                else
                {
                    MessageBox.Show("No hay registro de asistencias entre estas fechas.");
                }

        }
    }
}
