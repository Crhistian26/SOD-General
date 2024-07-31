using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.AsistenciasYPermisos
{
    internal class Record_Attendance
    {
        public int IdRecord { get; set; }
        public int IdEmployee { get; set; }
        public DateTime Entry { get; set; }
        public DateTime Exit { get; set; }
        public DateTime LunchS { get; set; }
        public DateTime LunchF { get; set; }
        public DateTime DateAttendance { get; set; }

        public Record_Attendance(int idRecord, int idEmployee, DateTime entry, DateTime exit, DateTime lunchS, DateTime lunchF, DateTime dateAttendance)
        {
            IdRecord = idRecord;
            IdEmployee = idEmployee;
            Entry = entry;
            Exit = exit;
            LunchS = lunchS;
            LunchF = lunchF;
            DateAttendance = dateAttendance;
        }

    }
}
