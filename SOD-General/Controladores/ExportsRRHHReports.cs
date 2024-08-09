using ClosedXML.Excel;
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

        public void ImprimirReporteAsistencias(Employee emp, DateTime date1, DateTime date2)
        {
            try
            {
                XLWorkbook LibroExcel = new XLWorkbook();
                int row = 1;
                var hoja1 = LibroExcel.Worksheets.Add("Asistencias");

                List<Record_Attendance> records = new List<Record_Attendance>();

                string Query = "exec Get_EmployeeAttendanceForDate @id, @date1, @date2";
                SqlCommand cmd = new SqlCommand(Query, conex);
                //Los parametros
                cmd.Parameters.AddWithValue("@id", emp.IdEmployee);
                cmd.Parameters.AddWithValue("@date1", date1);
                cmd.Parameters.AddWithValue("@date2", date2);
                //El proceso
                conex.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    records.Add
                    (
                        new Record_Attendance
                        (
                            reader.GetDateTime(0),
                            reader.GetTimeSpan(1),
                            reader.GetTimeSpan(2),
                            reader.GetTimeSpan(3),
                            reader.GetTimeSpan(4)
                        )
                    );
                }
                conex.Close();

                hoja1.Range("A1:F1").Merge().SetValue($"Registro de asistencias de: {emp._Name} {emp._Lastname}").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                row++;

                hoja1.Range("A2:C2").Merge().SetValue($"Desde el {date1.ToString("D")}").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center; ;
                hoja1.Range("D2:F2").Merge().SetValue($"Desde el {date2.ToString("D")}").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;;
                row++;


                hoja1.Cell(row, 1).Value = $"Fecha de registro:";
                hoja1.Cell(row, 2).Value = $"Hora de entrada:";
                hoja1.Cell(row, 3).Value = $"Inicio de almuerzo:";
                hoja1.Cell(row, 4).Value = $"Fin de almuerzo:";
                hoja1.Cell(row, 5).Value = $"Hora de salida:";
                hoja1.Cell(row, 6).Value = $"Horas laboradas:";
                row++;

                foreach (Record_Attendance record in records)
                {
                    hoja1.Cell(row, 1).Value = record.DateAttendance.ToString("dddd d MMM yyy");
                    hoja1.Cell(row, 2).Value = _size.FiltarHoras(record.Entry);
                    hoja1.Cell(row, 3).Value = _size.FiltarHoras(record.LunchS);
                    hoja1.Cell(row, 4).Value = _size.FiltarHoras(record.LunchF);
                    hoja1.Cell(row, 5).Value = _size.FiltarHoras(record.Exit);
                    hoja1.Cell(row, 6).Value = record.Job_Hours.ToString().Substring(0, 5) + " Horas";
                    //TimeSpan extra = (record.Job_Hours - (new TimeSpan(8, 0, 0)));
                    //if (extra.Hours >= 0 && extra.Minutes >= 0)
                    //{
                    //    hoja1.Cell(row, 6).Value = $"+ {extra.ToString().Substring(0, 5)}";
                    //}
                    //else
                    //{
                    //    hoja1.Cell(row, 6).Value = $"- {extra.ToString().Substring(0, 5)}";
                    //}
                    
                }
                hoja1.Columns().AdjustToContents();
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
            catch (SqlException ex)
            {
                if (conex.State != System.Data.ConnectionState.Closed)
                {
                    conex.Close();
                }
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                if (conex.State != System.Data.ConnectionState.Closed)
                {
                    conex.Close();
                }
                MessageBox.Show(ex.Message);
            }

        }
    }
}
