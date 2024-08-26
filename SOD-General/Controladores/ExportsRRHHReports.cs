using ClosedXML.Excel;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle;
using Modelos.AsistenciasYPermisos;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace SOD_General.Controladores
{
    internal class ExportsRRHHReports
    {
        static string cadena = ConfigurationManager.ConnectionStrings["Conex"].ConnectionString;
        SqlConnection conex = new SqlConnection(cadena);
        static SizesGenerales _size2 = new SizesGenerales();
        SizesGenerales _size = new SizesGenerales();
        Registros_Controller Registros_Controller = new Registros_Controller();

        static Dictionary<DayOfWeek, (TimeSpan JobStart, TimeSpan JobEnd)> Days = _size2.Days;

        public TimeSpan CountHoursPendent(DateTime Begin, DateTime End)
        {
            DateTime Begin_Date = new DateTime(Begin.Year, Begin.Month, Begin.Day);
            DateTime End_Date = new DateTime(End.Year, End.Month, End.Day);

            TimeSpan totalFaltado = TimeSpan.Zero;

            for (DateTime dia = Begin_Date.Date; dia <= End_Date.Date; dia = dia.AddDays(1))
            {
                if (Days.TryGetValue(dia.DayOfWeek, out var horario))
                {
                    if (dia.DayOfWeek == DayOfWeek.Sunday)
                    {
                        continue;
                    }
                    totalFaltado += horario.JobEnd - horario.JobStart;

                    if (dia.DayOfWeek == DayOfWeek.Saturday)
                    {
                        continue;
                    }
                    totalFaltado -= new TimeSpan(1, 15, 0);


                }
            }

            return totalFaltado;
        }

        public (string,XLColor) ConvertTimeSpan(TimeSpan timespan)
        {
            string Diferent = "";
            XLColor color = XLColor.Black;

            if (Convert.ToInt32(timespan.TotalHours) > 0 && timespan.Minutes > 0)
            {
                Diferent = $"{Convert.ToInt32(timespan.TotalHours)} horas y {timespan.Minutes} minutos";
                color = XLColor.Green;
            }
            else if (Convert.ToInt32(timespan.TotalHours) > 0 && timespan.Minutes == 0)
            {
                Diferent = $"{Convert.ToInt32(timespan.TotalHours)} horas";
                color = XLColor.Green;
            }
            else if (Convert.ToInt32(timespan.TotalHours) == 0 && timespan.Minutes > 0)
            {
                Diferent = $"{Convert.ToInt32(timespan.Minutes)} minutos";
                color = XLColor.Green;
            }
            else if (Convert.ToInt32(timespan.TotalHours) <= 0 && timespan.Minutes == 0)
            {
                Diferent = $"{System.Math.Abs(Convert.ToInt32(timespan.TotalHours))} horas";
                color = XLColor.Red;
            }
            else if (Convert.ToInt32(timespan.TotalHours) == 0 && timespan.Minutes <= 0)
            {
                Diferent = $"{System.Math.Abs(timespan.Minutes)} minutos";
                color = XLColor.Red;
            }
            else if (Convert.ToInt32(timespan.TotalHours) == 0 && timespan.Minutes == 0)
            {
                Diferent = "Justo.";
                color = XLColor.Black;
            }
            else
            {
                Diferent = $"{System.Math.Abs(Convert.ToInt32(timespan.TotalHours))} horas y {System.Math.Abs(timespan.Minutes)} minutos";
                color = XLColor.Red;
            }
            return (Diferent, color);

        }

        public void ImprimirReporte(List<Record_Attendance> records, List<Record_Permission> permissions, DateTime date1, DateTime date2)
        {
            try
            {
 
                XLWorkbook LibroExcel = new XLWorkbook();
                #region Asistencias detalladas
                int row = 1;
                var hoja1 = LibroExcel.Worksheets.Add("Asistencias");

                var title1 = hoja1.Range("A1:G1").Merge();
                title1.Style.Fill.BackgroundColor = XLColor.FromArgb(0, 153, 168);
                title1.Style.Font.FontName = "Century";
                title1.Style.Font.FontSize = 16;
                title1.Style.Font.FontColor = XLColor.White;
                title1.SetValue($"Registro de asistencias general").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                row++;

                var title2 = hoja1.Range("A2:G2");
                title2.Style.Fill.BackgroundColor = XLColor.FromArgb(0, 153, 168);
                title2.Style.Font.FontName = "Lucida Bright";
                title2.Style.Font.FontSize = 12;
                title2.Style.Font.FontColor = XLColor.White;
                hoja1.Range("A2:C2").Merge().SetValue($"Desde el {date1.ToString("D")}").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center; ;
                hoja1.Range("E2:G2").Merge().SetValue($"Hasta el {date2.ToString("D")}").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center; ;
                row++;

                var title3 = hoja1.Range("A3:G3");
                title3.Style.Fill.BackgroundColor = XLColor.FromArgb(0, 153, 168);
                title3.Style.Font.FontName = "Lucida Bright";
                title3.Style.Font.FontSize = 12;
                title3.Style.Font.FontColor = XLColor.White;

                hoja1.Cell(row, 1).Value = $"Nombre del empleado:";
                hoja1.Cell(row, 2).Value = $"Fecha de registro:";
                hoja1.Cell(row, 3).Value = $"Hora de entrada:";
                hoja1.Cell(row, 4).Value = $"Inicio de almuerzo:";
                hoja1.Cell(row, 5).Value = $"Fin de almuerzo:";
                hoja1.Cell(row, 6).Value = $"Hora de salida:";
                hoja1.Cell(row, 7).Value = $"Horas asistidas:";
                row++;

                foreach (Record_Attendance record in records)
                {
                    hoja1.Cell(row, 1).Value = record._Name;
                    hoja1.Cell(row, 2).Value = record.DateAttendance.ToString("dddd d MMM yyy");
                    hoja1.Cell(row, 3).Value = _size.FiltarHoras(record.Entry);
                    hoja1.Cell(row, 4).Value = _size.FiltarHoras(record.LunchS);
                    hoja1.Cell(row, 5).Value = _size.FiltarHoras(record.LunchF);
                    hoja1.Cell(row, 6).Value = _size.FiltarHoras(record.Exit);
                    hoja1.Cell(row, 7).Value = record.Job_Hours.ToString().Substring(0, 5) + " Horas";
                    row++;
                }
                hoja1.Columns().AdjustToContents();

                var range = hoja1.Range($"A1:G{row - 1}");

                range.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                range.Style.Border.InsideBorder = XLBorderStyleValues.Thin;
                range = hoja1.Range($"A3:G{row - 1}").CreateTable();
                #endregion

                #region Calculo de horas asistidas
                //Calculo de horas asistidas

                row = 1;
                var Hours_hoja1 = LibroExcel.Worksheets.Add("Horas asistidas");

                var Hours_title1 = Hours_hoja1.Range("A1:D1").Merge();
                Hours_title1.Style.Fill.BackgroundColor = XLColor.FromArgb(0, 153, 168);
                Hours_title1.Style.Font.FontName = "Century";
                Hours_title1.Style.Font.FontSize = 16;
                Hours_title1.Style.Font.FontColor = XLColor.White;
                Hours_title1.SetValue("Resumen de horas asistidas").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                row++;

                var Hours_title2 = Hours_hoja1.Range("A2:D2");
                Hours_title2.Style.Fill.BackgroundColor = XLColor.FromArgb(0, 153, 168);
                Hours_title2.Style.Font.FontName = "Lucida Bright";
                Hours_title2.Style.Font.FontSize = 12;
                Hours_title2.Style.Font.FontColor = XLColor.White;
                Hours_hoja1.Range("A2:B2").Merge().SetValue($"Desde el {date1.ToString("D")}").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center; 
                Hours_hoja1.Range("C2:D2").Merge().SetValue($"Hasta el {date2.ToString("D")}").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center; 
                

                row++;


                Hours_hoja1.Cell(row, 1).Value = "Nombre del empleado:";
                Hours_hoja1.Cell(row, 1).Style.Font.FontColor = XLColor.FromArgb(0, 153, 168);

                Hours_hoja1.Cell(row, 2).Value = "Horas trabajadas:";
                Hours_hoja1.Cell(row, 2).Style.Font.FontColor = XLColor.FromArgb(0, 153, 168);

                Hours_hoja1.Cell(row, 3).Value = "Horas estimadas:";
                Hours_hoja1.Cell(row, 3).Style.Font.FontColor = XLColor.FromArgb(0, 153, 168);

                Hours_hoja1.Cell(row, 4).Value = "Diferencia:";
                Hours_hoja1.Cell(row, 4).Style.Font.FontColor = XLColor.FromArgb(0, 153, 168);

                row++;


                var registrosAgrupados = records.GroupBy(r => r._Name);

                foreach (var grupo in registrosAgrupados)
                {
                    string nombreEmpleado = grupo.Key;
                    TimeSpan horasTrabajadas = TimeSpan.Zero;
                    int diasLaborales = 0;

                    foreach (var record in grupo)
                    {
                        horasTrabajadas += record.Job_Hours;
                        if (record.DateAttendance.DayOfWeek != DayOfWeek.Sunday) // Contar sólo días laborales
                        {
                            diasLaborales++;
                        }
                    }


                    TimeSpan horasEsperadas = CountHoursPendent(date1, date2);
                    TimeSpan diferencia = horasTrabajadas - horasEsperadas;

                    string HoursJob = $"{Convert.ToInt32(horasTrabajadas.TotalHours)} horas y {horasTrabajadas.Minutes}  minutos";
                    string StimateHours = $"{Convert.ToInt32(horasEsperadas.TotalHours)} horas y {horasEsperadas.Minutes} minutos";
                    string Diferent; XLColor color;

                    (Diferent, color) = ConvertTimeSpan(diferencia);

                    Hours_hoja1.Cell(row, 1).Value = nombreEmpleado;
                    Hours_hoja1.Cell(row, 2).Value = HoursJob;
                    Hours_hoja1.Cell(row, 3).Value = StimateHours;
                    Hours_hoja1.Cell(row, 4).Value = Diferent;
                    Hours_hoja1.Cell(row, 4).Style.Font.FontColor = color; 
                    row++;
                }
                
                var Hours_range2 = Hours_hoja1.Range($"A1:D{row - 1}");
                Hours_range2.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                Hours_range2.Style.Border.InsideBorder = XLBorderStyleValues.Thin;
                Hours_hoja1.Columns().AdjustToContents();
                #endregion

                //Area encargada de cada uno de los permisos.
                #region Permisos detallados
                if (permissions.Count <= 0)
                {
                    goto SaveFile;
                }

                row = 1;
                var DetailedPermission = LibroExcel.Worksheets.Add("Permisos detallados");

                var DetPer_title = DetailedPermission.Range("A1:H1").Merge();
                DetPer_title.Style.Fill.BackgroundColor = XLColor.FromArgb(0, 153, 168);
                DetPer_title.Style.Font.FontName = "Century";
                DetPer_title.Style.Font.FontSize = 16;
                DetPer_title.Style.Font.FontColor = XLColor.White;
                DetPer_title.SetValue($"Registro de asistencias general").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                row++;

                var DetPer_title2 = DetailedPermission.Range("A2:G2");
                DetPer_title2.Style.Fill.BackgroundColor = XLColor.FromArgb(0, 153, 168);
                DetPer_title2.Style.Font.FontName = "Lucida Bright";
                DetPer_title2.Style.Font.FontSize = 12;
                DetPer_title2.Style.Font.FontColor = XLColor.White;
                DetailedPermission.Range("A2:D2").Merge().SetValue($"Desde el {date1.ToString("D")}").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center; ;
                DetailedPermission.Range("E2:H2").Merge().SetValue($"Hasta el {date2.ToString("D")}").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center; ;
                row++;

                var DetPer_title3 = DetailedPermission.Range("A3:H3");
                DetPer_title3.Style.Fill.BackgroundColor = XLColor.FromArgb(0, 153, 168);
                DetPer_title3.Style.Font.FontName = "Lucida Bright";
                DetPer_title3.Style.Font.FontSize = 12;
                DetPer_title3.Style.Font.FontColor = XLColor.White;

                DetailedPermission.Cell(row, 1).Value = $"Nombre del empleado:";
                DetailedPermission.Cell(row, 2).Value = $"Motivo:";
                DetailedPermission.Cell(row, 3).Value = $"Detalles:";
                DetailedPermission.Cell(row, 4).Value = $"Inicio de almuerzo:";
                DetailedPermission.Cell(row, 5).Value = $"Fin de almuerzo:";
                DetailedPermission.Cell(row, 6).Value = $"Desde el:";
                DetailedPermission.Cell(row, 7).Value = $"Hasta el:";
                DetailedPermission.Cell(row, 8).Value = $"Total en horas:";
                row++;

                foreach (Record_Permission permission in permissions)
                {
                    DetailedPermission.Cell(row, 1).Value = permission._Name;
                    DetailedPermission.Cell(row, 2).Value = permission._Reason;
                    DetailedPermission.Cell(row, 3).Value = permission._Description;
                    if(permission.LunchS.Value.TotalMinutes > 0 && permission.LunchF.Value.TotalMinutes > 0)
                    {
                        DetailedPermission.Cell(row, 4).Value = _size.FiltarHoras(permission.LunchS.Value);
                        DetailedPermission.Cell(row, 5).Value = _size.FiltarHoras(permission.LunchF.Value);
                    }
                    else
                    {
                        DetailedPermission.Cell(row, 4).Value = "No almorzo este dia.";
                        DetailedPermission.Cell(row, 5).Value = "No almorzo este dia.";
                    }
                    DetailedPermission.Cell(row, 6).Value = permission.Begin_Date.ToString("f");
                    DetailedPermission.Cell(row, 7).Value = permission.End_Date.ToString("f");
                    DetailedPermission.Cell(row, 8).Value = ConvertTimeSpan(permission.Get_Hours_Ausent()).Item1;
                    row++;
                }
                DetailedPermission.Columns().AdjustToContents();

                var DetPer_range = DetailedPermission.Range($"A1:H{row - 1}");

                DetPer_range.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                DetPer_range.Style.Border.InsideBorder = XLBorderStyleValues.Thin;
                DetPer_range = DetailedPermission.Range($"A3:H{row - 1}").CreateTable();
                #endregion

                #region Calculo de horas de permisos
                row = 1;
                var HoursPermission_hoja1 = LibroExcel.Worksheets.Add("Horas ausentes");

                var HoursPermission_title1 = HoursPermission_hoja1.Range("A1:B1").Merge();
                HoursPermission_title1.Style.Fill.BackgroundColor = XLColor.FromArgb(0, 153, 168);
                HoursPermission_title1.Style.Font.FontName = "Century";
                HoursPermission_title1.Style.Font.FontSize = 16;
                HoursPermission_title1.Style.Font.FontColor = XLColor.White;
                HoursPermission_title1.SetValue("Resumen de horas ausentes").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                row++;

                var HoursPermission_title2 = HoursPermission_hoja1.Range("A2:B2");
                HoursPermission_title2.Style.Fill.BackgroundColor = XLColor.FromArgb(0, 153, 168);
                HoursPermission_title2.Style.Font.FontName = "Lucida Bright";
                HoursPermission_title2.Style.Font.FontSize = 12;
                HoursPermission_title2.Style.Font.FontColor = XLColor.White;
                HoursPermission_hoja1.Cell("A2").SetValue($"Desde el {date1.ToString("D")}").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                HoursPermission_hoja1.Cell("B2").SetValue($"Hasta el {date2.ToString("D")}").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;


                row++;


                HoursPermission_hoja1.Cell(row, 1).Value = "Nombre del empleado:";
                HoursPermission_hoja1.Cell(row, 1).Style.Font.FontColor = XLColor.FromArgb(0, 153, 168);

                HoursPermission_hoja1.Cell(row, 2).Value = "Total de horas:";
                HoursPermission_hoja1.Cell(row, 2).Style.Font.FontColor = XLColor.FromArgb(0, 153, 168);


                row++;


                var PermisosAgrupados = permissions.GroupBy(r => r._Name);

                foreach (var grupo in PermisosAgrupados)
                {
                    string nombreEmpleado = grupo.Key;
                    TimeSpan HoursAusent = TimeSpan.Zero;
                    string TotalHours;
                    foreach (var record in grupo)
                    {
                        HoursAusent += record.Get_Hours_Ausent();
                    }
                    

                    XLColor h;
                    (TotalHours, h) = ConvertTimeSpan(HoursAusent);

                    HoursPermission_hoja1.Cell(row, 1).Value = nombreEmpleado;
                    HoursPermission_hoja1.Cell(row, 2).Value = TotalHours;
                    row++;
                }

                var HoursPermission_range2 = HoursPermission_hoja1.Range($"A1:B{row - 1}");
                HoursPermission_range2.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                HoursPermission_range2.Style.Border.InsideBorder = XLBorderStyleValues.Thin;
                HoursPermission_hoja1.Columns().AdjustToContents();
            #endregion


            SaveFile:
                //Esta es la parte encargada de guardar el archivo
                SaveFileDialog saveFileDialog = new SaveFileDialog();

                string NameFile = $"Registro asistencias ({date1.ToString("D")} - {date2.ToString("D")})";
                saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx|All Files (*.*)|*.*";
                saveFileDialog.Title = "Guardar archivo Excel";
                saveFileDialog.FileName = NameFile;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    LibroExcel.SaveAs(saveFileDialog.FileName);
                    Process.Start(saveFileDialog.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

    }
}
