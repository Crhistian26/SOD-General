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

        public Record_Attendance(int idEmployee, TimeSpan entry, TimeSpan exit, TimeSpan lunchS, TimeSpan lunchF, DateTime dateAttendance)
        {
            this.IdEmployee = idEmployee;
            this.Entry = entry;
            this.Exit = exit;
            this.LunchS = lunchS;
            this.LunchF = lunchF;
            this.DateAttendance = dateAttendance;

        }

        public Record_Attendance(DateTime dateAttendance, TimeSpan entry, TimeSpan exit, TimeSpan lunchS, TimeSpan lunchF)
        {
            this.Entry = entry;
            this.Exit = exit;
            this.LunchS = lunchS;
            this.LunchF = lunchF;
            this.DateAttendance = dateAttendance;
            Job_Hours = (exit - entry) - (lunchF - lunchS);
        }
        public Record_Attendance(string Name, DateTime dateAttendance, TimeSpan entry, TimeSpan exit, TimeSpan lunchS, TimeSpan lunchF)
            : this(dateAttendance, entry, exit, lunchS, lunchF)
        {
            this._Name = Name;
        }

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

        public Record_Attendance(int idRecord, int idEmployee, string Name, TimeSpan entry, TimeSpan exit, TimeSpan lunchS, TimeSpan lunchF, DateTime dateAttendance)
           : this(idRecord, idEmployee, entry, exit, lunchS, lunchF, dateAttendance)
        {

            _Name = Name;


        }
    }
}
