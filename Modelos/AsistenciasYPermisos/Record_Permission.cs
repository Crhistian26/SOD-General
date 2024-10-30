using Modelos.AsistenciasYPermisos.Count_hours;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Modelos.AsistenciasYPermisos
{
    public class Record_Permission
    {
        public int IdRecord { get; set; }
        public int IdEmployee { get; set; }
        public string _Name { get; set; }
        public int IdReason { get; set; }
        public string _Reason { get; set; }
        public string _Description { get; set; }
        public DateTime Begin_Date { get; set; }
        public DateTime End_Date { get; set; }
        public List<Schedule> schedules { get; set; }

        public Record_Permission(int IdRecord, string Reason, string descip, DateTime fecha1, DateTime fecha2)
        {
            this.IdRecord = IdRecord;
            this._Reason = Reason;
            this._Description = descip;
            this.Begin_Date = fecha1;
            this.End_Date = fecha2;
        }

        public Record_Permission(int IdRecord, int idEmployee, int idReason, string descip, DateTime fecha1, DateTime fecha2)
        {
            this.IdRecord = IdRecord;
            this.IdEmployee = idEmployee;
            this.IdReason = idReason;
            this._Description = descip;
            this.Begin_Date = fecha1;
            this.End_Date = fecha2;
        }

        public Record_Permission(int IdRecord, string Name, string Reason, string descip, DateTime fecha1, DateTime fecha2)
            : this(IdRecord, Reason, descip, fecha1, fecha2)
        {
            this._Name = Name;
        }
        public Record_Permission(int IdRecord, int idEmployee, string Name, DateTime fecha1, DateTime fecha2, string Reason)
        {
            this.IdRecord = IdRecord;
            this._Name = Name;
            this._Reason = Reason;
            this.Begin_Date = fecha1;
            this.End_Date = fecha2;
        }

        private DailySchedule GetDailySchedule(DateTime date)
        {
            //Selecciono el horario correspondiente de la lista de horarios.
            Schedule schedule =
                schedules.Where(a => a.StartDate <= date.Date).ToList()
                .OrderBy(a => a.StartDate).FirstOrDefault();

            //selecciono el dia en especifico de los horarios que tengo.
            DailySchedule day_schedule = schedule.DailySchedules.Where(a => a._dayOfWeek == date.DayOfWeek).First();

            return day_schedule;
        }

        public TimeSpan Get_Hours_Ausent()
        {
            TimeSpan totalFaltado = TimeSpan.Zero;
            TimeSpan _start, _end;


            for (DateTime date = Begin_Date; date.Date <= End_Date.Date; date = date.AddDays(1))
            {
                TimeSpan hours = TimeSpan.Zero;

                DailySchedule day_schedule = GetDailySchedule(date);

                TimeSpan start = new TimeSpan(date.Hour, date.Minute, 0);

                _start = start > day_schedule._StartHour && date.Date == Begin_Date.Date? start : day_schedule._StartHour;

                TimeSpan end = new TimeSpan(End_Date.Hour, End_Date.Minute, 0);

                _end = end < day_schedule._EndHour && date.Date == End_Date.Date? end : day_schedule._EndHour;

                hours = _end - _start;

                if (_start.Hours <= 12 && _end.Hours >= 3 && Begin_Date.Date == End_Date.Date)
                {
                    hours -= day_schedule._LunchHours;
                }
                else if (_start.Hours <= 12 && End_Date.Date != Begin_Date.Date)
                {
                    hours -= day_schedule._LunchHours;
                }

                if (date.DayOfWeek != DayOfWeek.Sunday)
                {
                    totalFaltado += hours;
                }
            }

            return totalFaltado;
        }

        public TimeSpan Get_Hours_Ausent(DateTime _date, DateTime _date2)
        {
            //_date2.Hours = 0; _date2.Minutes = 0;
            TimeSpan totalFaltado = TimeSpan.Zero;
            TimeSpan _start, _end;
            var iterador = _date.Date <= Begin_Date.Date ? Begin_Date : _date;
            var desicion = _date2.Date >= End_Date.Date ? End_Date : _date2;

            for (
                    DateTime date = iterador;
                    date.Date <= desicion;
                    date = date.AddDays(1)
                )
            {
                TimeSpan hours = TimeSpan.Zero;

                DailySchedule day_schedule = GetDailySchedule(date);

                TimeSpan start = new TimeSpan(date.Hour, date.Minute, 0);

                _start = start > day_schedule._StartHour && date.Date == Begin_Date.Date ? start : day_schedule._StartHour;

                TimeSpan end = new TimeSpan(End_Date.Hour, End_Date.Minute, 0);

                _end = end < day_schedule._EndHour && date.Date == End_Date.Date ? end : day_schedule._EndHour;

                hours = _end - _start;

                if (_start.Hours <= 12 && _end.Hours >= 3 && Begin_Date.Date == End_Date.Date)
                {
                    hours -= day_schedule._LunchHours;
                }
                else if (_start.Hours <= 12 && End_Date.Date != Begin_Date.Date)
                {
                    hours -= day_schedule._LunchHours;
                }

                if (date.DayOfWeek != DayOfWeek.Sunday)
                {
                    totalFaltado += hours;
                }
            }

            return totalFaltado;
        }
        public bool ConfirmEndDate()
        {
            TimeSpan End = new TimeSpan(End_Date.Hour, End_Date.Minute, 0);
            DailySchedule day_schedule = GetDailySchedule(End_Date);
            if (End == day_schedule._EndHour)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ConfirmBeginDate()
        {
            TimeSpan Begin = new TimeSpan(Begin_Date.Hour, Begin_Date.Minute, 0);
            DailySchedule day_schedule = GetDailySchedule(Begin_Date);
            if (Begin == day_schedule._EndHour)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
