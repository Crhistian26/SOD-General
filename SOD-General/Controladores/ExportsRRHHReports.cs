using ClosedXML.Excel;
using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.Win32;
using Modelos.AsistenciasYPermisos;
using Modelos.Usuarios_Empleados;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOD_General.Controladores
{
    internal class ExportsRRHHReports
    {
        static string cadena = ConfigurationManager.ConnectionStrings["Conex"].ConnectionString;
        SqlConnection conex = new SqlConnection(cadena);
        SizesGenerales _size = new SizesGenerales();

        static Dictionary<DayOfWeek, (TimeSpan JobStart, TimeSpan JobEnd)> Days = new Dictionary<DayOfWeek, (TimeSpan JobStart, TimeSpan JobEnd)>
        {
            {DayOfWeek.Monday,(new TimeSpan(8,30,0),new TimeSpan(17,45,0))},
            {DayOfWeek.Tuesday,(new TimeSpan(8,30,0),new TimeSpan(17,45,0))},
            {DayOfWeek.Wednesday,(new TimeSpan(9,0,0),new TimeSpan(17,45,0))},
            {DayOfWeek.Thursday,(new TimeSpan(8,30,0),new TimeSpan(17,45,0))},
            {DayOfWeek.Friday,(new TimeSpan(8,30,0),new TimeSpan(17,45,0))},
            {DayOfWeek.Saturday,(new TimeSpan(8,30,0),new TimeSpan(13,0,0))},
            {DayOfWeek.Sunday,(new TimeSpan(0,0,0),new TimeSpan(0,0,0))},
        };

        public TimeSpan CountHoursPendent(DateTime Begin, DateTime End)
        {
            DateTime Begin_Date = new DateTime(Begin.Year, Begin.Month, Begin.Day);
            DateTime End_Date = new DateTime(End.Year,End.Month,End.Day);

            TimeSpan totalFaltado = TimeSpan.Zero;

            for (DateTime dia = Begin_Date.Date; dia <= End_Date.Date; dia = dia.AddDays(1))
            {
                if (Days.TryGetValue(dia.DayOfWeek, out var horario))
                {
                    if (dia.DayOfWeek == DayOfWeek.Sunday)
                    {
                        continue;
                    }
                    totalFaltado +=  horario.JobEnd - horario.JobStart;

                    if(dia.DayOfWeek == DayOfWeek.Saturday)
                    {
                        continue;
                    }
                    totalFaltado -= new TimeSpan(1, 15, 0);
                    
                    
                }
            }

            return totalFaltado;
        }
        //public List<Record_Attendance> Get_AttendanceEmployee(Employee emp, DateTime date1, DateTime date2)
        //{
        //    List<Record_Attendance> records = new List<Record_Attendance>();
        //    string Query = "exec Get_EmployeeAttendanceForDate @id, @date1, @date2";
        //    SqlCommand cmd = new SqlCommand(Query, conex);
        //    //Los parametros
        //    cmd.Parameters.AddWithValue("@id", emp.IdEmployee);
        //    cmd.Parameters.AddWithValue("@date1", date1);
        //    cmd.Parameters.AddWithValue("@date2", date2);
        //    //El proceso
        //    try
        //    {
        //        conex.Open();
        //        SqlDataReader reader = cmd.ExecuteReader();
        //        while (reader.Read())
        //        {
        //            records.Add
        //            (
        //                new Record_Attendance
        //                (
        //                    reader.GetDateTime(0),
        //                    reader.GetTimeSpan(1),
        //                    reader.GetTimeSpan(2),
        //                    reader.GetTimeSpan(3),
        //                    reader.GetTimeSpan(4)
        //                )
        //            );
        //        }
        //        conex.Close();
        //        return records;
        //    }
        //    catch(SqlException ex)
        //    {
        //        if(conex.State != System.Data.ConnectionState.Closed)
        //        {
        //            conex.Close();
        //        }
        //        MessageBox.Show(ex.Message);
        //        return null;
        //    }
        //    catch(Exception ex)
        //    {
        //        if (conex.State != System.Data.ConnectionState.Closed)
        //        {
        //            conex.Close();
        //        }
        //        MessageBox.Show(ex.Message);
        //        return null;
        //    }
            
        //}

        public List<Record_Attendance> Get_AttendanceAllEmployee(DateTime date1, DateTime date2)
        {
            List<Record_Attendance> records = new List<Record_Attendance>();
            string Query = "exec Get_AttendanceForDate @date1, @date2";
            SqlCommand cmd = new SqlCommand(Query, conex);
            //Los parametros
            cmd.Parameters.AddWithValue("@date1", date1);
            cmd.Parameters.AddWithValue("@date2", date2);
            //El proceso
            try
            {
                conex.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    records.Add
                    (
                        new Record_Attendance
                        (
                            reader.GetString(2) + " "+ reader.GetString(3),
                            reader.GetDateTime(8),
                            reader.GetTimeSpan(4),
                            reader.GetTimeSpan(5),
                            reader.GetTimeSpan(6),
                            reader.GetTimeSpan(7)
                        )
                    );
                }
                conex.Close();
                return records;
            }
            catch (SqlException ex)
            {
                if (conex.State != System.Data.ConnectionState.Closed)
                {
                    conex.Close();
                }
                MessageBox.Show(ex.Message);
                return null;
            }
            catch (Exception ex)
            {
                if (conex.State != System.Data.ConnectionState.Closed)
                {
                    conex.Close();
                }
                MessageBox.Show(ex.Message);
                return null;
            }

        }

        //public void ImprimirReporteAsistencias(List<Record_Attendance> records, Employee emp, DateTime date1, DateTime date2)
        //{
        //    try
        //    {
        //        if (records != null)
        //        {
        //            XLWorkbook LibroExcel = new XLWorkbook();
        //            int row = 1;
        //            var hoja1 = LibroExcel.Worksheets.Add("Asistencias");

        //            var title1 = hoja1.Range("A1:F1").Merge();
        //            title1.Style.Fill.BackgroundColor = XLColor.FromArgb(0, 153, 168);
        //            title1.Style.Font.FontName = "Century";
        //            title1.Style.Font.FontSize = 16;
        //            title1.Style.Font.FontColor = XLColor.White;
        //            title1.SetValue($"Registro de asistencias de: {emp._Name} {emp._Lastname}").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
        //            row++;


        //            var title2 = hoja1.Range("A2:F2");
        //            title2.Style.Fill.BackgroundColor = XLColor.FromArgb(0, 153, 168);
        //            title2.Style.Font.FontName = "Lucida Bright";
        //            title2.Style.Font.FontSize = 12;
        //            title2.Style.Font.FontColor = XLColor.White;
        //            hoja1.Range("A2:C2").Merge().SetValue($"Desde el {date1.ToString("D")}").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center; ;
        //            hoja1.Range("D2:F2").Merge().SetValue($"Hastal el {date2.ToString("D")}").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center; ;
        //            row++;

        //            var title3 = hoja1.Range("A3:F3");
        //            title3.Style.Fill.BackgroundColor = XLColor.FromArgb(0, 153, 168);
        //            title3.Style.Font.FontName = "Lucida Bright";
        //            title3.Style.Font.FontSize = 12;
        //            title3.Style.Font.FontColor = XLColor.White;
        //            hoja1.Cell(row, 1).Value = $"Fecha de registro:";
        //            hoja1.Cell(row, 2).Value = $"Hora de entrada:";
        //            hoja1.Cell(row, 3).Value = $"Inicio de almuerzo:";
        //            hoja1.Cell(row, 4).Value = $"Fin de almuerzo:";
        //            hoja1.Cell(row, 5).Value = $"Hora de salida:";
        //            hoja1.Cell(row, 6).Value = $"Horas laboradas:";
        //            row++;

        //            foreach (Record_Attendance record in records)
        //            {
        //                hoja1.Cell(row, 1).Value = record.DateAttendance.ToString("dddd d MMM yyy");
        //                hoja1.Cell(row, 2).Value = _size.FiltarHoras(record.Entry);
        //                hoja1.Cell(row, 3).Value = _size.FiltarHoras(record.LunchS);
        //                hoja1.Cell(row, 4).Value = _size.FiltarHoras(record.LunchF);
        //                hoja1.Cell(row, 5).Value = _size.FiltarHoras(record.Exit);
        //                hoja1.Cell(row, 6).Value = record.Job_Hours.ToString().Substring(0, 5) + " Horas";
        //                row++;
        //            }
        //            hoja1.Columns().AdjustToContents();

        //            var range = hoja1.Range($"A1:F{row-1}");
        //            range.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
        //            range.Style.Border.InsideBorder = XLBorderStyleValues.Thin;

        //            row = 1;
        //            //Area de calculo de horas
        //            var Hours_hoja1 = LibroExcel.Worksheets.Add("Resumen Horas");

        //            // Encabezado
        //            var Hours_title1 = Hours_hoja1.Range("A1:D1").Merge();
        //            Hours_title1.Style.Fill.BackgroundColor = XLColor.FromArgb(0, 153, 168);
        //            Hours_title1.Style.Font.FontName = "Century";
        //            Hours_title1.Style.Font.FontSize = 16;
        //            Hours_title1.Style.Font.FontColor = XLColor.White;
        //            Hours_title1.SetValue("Resumen de Horas Trabajadas").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
        //            row++;

        //            var Hours_title2 = Hours_hoja1.Range("A2:D2");
        //            Hours_title2.Style.Fill.BackgroundColor = XLColor.FromArgb(0, 153, 168);
        //            Hours_title2.Style.Font.FontName = "Lucida Bright";
        //            Hours_title2.Style.Font.FontSize = 12;
        //            Hours_title2.Style.Font.FontColor = XLColor.White;
        //            Hours_hoja1.Range("A2:B2").Merge().SetValue($"Desde el {date1.ToString("D")}").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center; ;
        //            Hours_hoja1.Range("C2:D2").Merge().SetValue($"Hasta el {date2.ToString("D")}").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center; ;
        //            row++;

        //            // Cabecera de la tabla
        //            Hours_hoja1.Cell(row, 1).Value = "Nombre del empleado:";
        //            Hours_hoja1.Cell(row, 2).Value = "Horas trabajadas:";
        //            Hours_hoja1.Cell(row, 3).Value = "Horas que deberían haberse trabajado:";
        //            Hours_hoja1.Cell(row, 4).Value = "Diferencia:";
        //            row++;

        //            // Agrupar registros por empleado
        //            var registrosAgrupados = records.GroupBy(r => r._Name);

        //            foreach (var grupo in registrosAgrupados)
        //            {
        //                string nombreEmpleado = grupo.Key;
        //                TimeSpan horasTrabajadas = TimeSpan.Zero;
        //                int diasLaborales = 0;

        //                foreach (var record in grupo)
        //                {
        //                    horasTrabajadas += record.Job_Hours;
        //                    if (record.DateAttendance.DayOfWeek != DayOfWeek.Sunday) // Contar sólo días laborales
        //                    {
        //                        diasLaborales++;
        //                    }
        //                }

        //                // Calcular las horas que deberían haberse trabajado (8h lunes-viernes, 4h sábado)
        //                TimeSpan horasEsperadas = TimeSpan.FromHours(diasLaborales * 8);
        //                TimeSpan diferencia = horasTrabajadas - horasEsperadas;

        //                // Añadir datos a la hoja
        //                Hours_hoja1.Cell(row, 1).Value = nombreEmpleado;
        //                Hours_hoja1.Cell(row, 2).Value = horasTrabajadas.ToString();
        //                Hours_hoja1.Cell(row, 3).Value = horasEsperadas.ToString();
        //                Hours_hoja1.Cell(row, 4).Value = diferencia.ToString();
        //                row++;
        //            }

        //            // Ajustar columnas y bordes
        //            Hours_hoja1.Columns().AdjustToContents();
        //            var Hours_range2 = Hours_hoja1.Range($"A1:D{row - 1}");
        //            Hours_range2.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
        //            Hours_range2.Style.Border.InsideBorder = XLBorderStyleValues.Thin;


                    
        //            SaveFileDialog saveFileDialog = new SaveFileDialog();

                    
        //            saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx|All Files (*.*)|*.*";
        //            saveFileDialog.Title = "Guardar archivo Excel";
        //            saveFileDialog.FileName = "default.xlsx";

        //            if (saveFileDialog.ShowDialog() == DialogResult.OK)
        //            {
        //                LibroExcel.SaveAs(saveFileDialog.FileName);
        //                Process.Start(saveFileDialog.FileName);
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }

        //}

        public void ImprimirReporteAsistencias(List<Record_Attendance> records, DateTime date1, DateTime date2)
        {
            try
            {
                XLWorkbook LibroExcel = new XLWorkbook();
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
                hoja1.Cell(row, 7).Value = $"Horas laboradas:";
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

                row = 1;
                //Area de calculo de horas
                var Hours_hoja1 = LibroExcel.Worksheets.Add("Resumen Horas");

                // Encabezado
                var Hours_title1 = Hours_hoja1.Range("A1:D1").Merge();
                Hours_title1.Style.Fill.BackgroundColor = XLColor.FromArgb(0, 153, 168);
                Hours_title1.Style.Font.FontName = "Century";
                Hours_title1.Style.Font.FontSize = 16;
                Hours_title1.Style.Font.FontColor = XLColor.White;
                Hours_title1.SetValue("Resumen de Horas Trabajadas").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                row++;

                var Hours_title2 = Hours_hoja1.Range("A2:D2");
                Hours_title2.Style.Fill.BackgroundColor = XLColor.FromArgb(0, 153, 168);
                Hours_title2.Style.Font.FontName = "Lucida Bright";
                Hours_title2.Style.Font.FontSize = 12;
                Hours_title2.Style.Font.FontColor = XLColor.White;
                Hours_hoja1.Range("A2:B2").Merge().SetValue($"Desde el {date1.ToString("D")}").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center; ;
                Hours_hoja1.Range("C2:D2").Merge().SetValue($"Hasta el {date2.ToString("D")}").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center; ;
                row++;

                // Cabecera de la tabla
                Hours_hoja1.Cell(row, 1).Value = "Nombre del empleado:";
                Hours_hoja1.Cell(row, 2).Value = "Horas trabajadas:";
                Hours_hoja1.Cell(row, 3).Value = "Horas que deberían haberse trabajado:";
                Hours_hoja1.Cell(row, 4).Value = "Diferencia:";
                row++;

                // Agrupar registros por empleado
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

                    // Calcular las horas que deberían haberse trabajado (8h lunes-viernes, 4h sábado)
                    TimeSpan horasEsperadas = CountHoursPendent(date1,date2);
                    TimeSpan diferencia = horasTrabajadas - horasEsperadas;

                    // Añadir datos a la hoja
                    Hours_hoja1.Cell(row, 1).Value = nombreEmpleado;
                    Hours_hoja1.Cell(row, 2).Value = horasTrabajadas.ToString();
                    Hours_hoja1.Cell(row, 3).Value = horasEsperadas.ToString();
                    Hours_hoja1.Cell(row, 4).Value = diferencia.ToString();
                    row++;
                }

                // Ajustar columnas y bordes
                Hours_hoja1.Columns().AdjustToContents();
                var Hours_range2 = Hours_hoja1.Range($"A1:D{row - 1}");
                Hours_range2.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                Hours_range2.Style.Border.InsideBorder = XLBorderStyleValues.Thin;

                // Crear una instancia del SaveFileDialog
                SaveFileDialog saveFileDialog = new SaveFileDialog();

                // Configurar las propiedades del SaveFileDialog
                saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx|All Files (*.*)|*.*";
                saveFileDialog.Title = "Guardar archivo Excel";
                saveFileDialog.FileName = "default.xlsx";

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
