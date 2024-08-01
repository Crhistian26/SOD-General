using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.AsistenciasYPermisos
{
    public class Record_Attendance
    {
        public int IdRecord { get; set; }
        public int IdEmployee { get; set; }
        public TimeSpan Entry { get; set; }
        public TimeSpan Exit { get; set; }
        public TimeSpan LunchS { get; set; }
        public TimeSpan LunchF { get; set; }
        public DateTime DateAttendance { get; set; }
        public TimeSpan Job_Hours { get; set; }

        public Record_Attendance(int idRecord, int idEmployee, TimeSpan entry, TimeSpan exit, TimeSpan lunchS, TimeSpan lunchF, DateTime dateAttendance)
        {
            IdRecord = idRecord;
            IdEmployee = idEmployee;
            Entry = entry;
            Exit = exit;
            LunchS = lunchS;
            LunchF = lunchF;
            DateAttendance = dateAttendance;

            Job_Hours = (exit - entry) - (lunchF - lunchS);

        }

    }
}
