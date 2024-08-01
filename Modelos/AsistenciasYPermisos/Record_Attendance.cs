using System;

namespace Modelos.AsistenciasYPermisos
{
    public class Record_Attendance
    {
        public int IdRecord { get; set; }
        public int IdEmployee { get; set; }
        public string _Name { get; set; }
        public TimeSpan Entry { get; set; }
        public TimeSpan Exit { get; set; }
        public TimeSpan LunchS { get; set; }
        public TimeSpan LunchF { get; set; }
        public DateTime DateAttendance { get; set; }
        public TimeSpan Job_Hours { get; set; }

        public Record_Attendance(int idRecord, int idEmployee,string Name, TimeSpan entry, TimeSpan exit, TimeSpan lunchS, TimeSpan lunchF, DateTime dateAttendance)
        {
            IdRecord = idRecord;
            IdEmployee = idEmployee;
            _Name = Name;
            Entry = entry;
            Exit = exit;
            LunchS = lunchS;
            LunchF = lunchF;
            DateAttendance = dateAttendance;

            Job_Hours = (exit - entry) - (lunchF - lunchS);

        }

    }
}
