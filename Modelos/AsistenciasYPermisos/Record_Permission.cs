using System;
using System.Collections.Generic;

namespace Modelos.AsistenciasYPermisos
{
    public class Record_Permission
    {
        public Dictionary<DayOfWeek, (TimeSpan JobStart, TimeSpan JobEnd)> Days = new Dictionary<DayOfWeek, (TimeSpan JobStart, TimeSpan JobEnd)>
        {
            {DayOfWeek.Monday,(new TimeSpan(8,30,0),new TimeSpan(17,45,0))},
            {DayOfWeek.Tuesday,(new TimeSpan(8,30,0),new TimeSpan(17,45,0))},
            {DayOfWeek.Wednesday,(new TimeSpan(9,0,0),new TimeSpan(17,45,0))},
            {DayOfWeek.Thursday,(new TimeSpan(8,30,0),new TimeSpan(17,45,0))},
            {DayOfWeek.Friday,(new TimeSpan(8,30,0),new TimeSpan(17,45,0))},
            {DayOfWeek.Saturday,(new TimeSpan(8,30,0),new TimeSpan(13,0,0))},
            {DayOfWeek.Sunday,(new TimeSpan(0,0,0),new TimeSpan(0,0,0))},
        };

        public int IdRecord { get; set; }
        public int IdEmployee { get; set; }
        public string _Name { get; set; }
        public int IdReason { get; set; }
        public string _Reason { get; set; }
        public string _Description { get; set; }
        public DateTime Begin_Date { get; set; }
        public DateTime End_Date { get; set; }
        public TimeSpan LunchS { get; set; }
        public TimeSpan LunchF { get; set; }

        public Record_Permission(int IdRecord, string Reason, string descip, DateTime fecha1, DateTime fecha2)
        {
            this.IdRecord = IdRecord;
            this._Reason = Reason;
            this._Description = descip;
            this.Begin_Date = fecha1;
            this.End_Date = fecha2;

        }

        public Record_Permission(int IdRecord, string Reason, string Name, string descip, DateTime fecha1, DateTime fecha2)
            : this(IdRecord, Reason, descip, fecha1, fecha2)
        {
            this._Name = Name;
        }

        public Record_Permission(int IdRecord, string Reason, string Name, string descip, DateTime fecha1, DateTime fecha2, TimeSpan time1, TimeSpan time2)
            : this(IdRecord, Reason, Name, descip, fecha1, fecha2)
        {
            this.LunchS = time1;
            this.LunchF = time2;
        }
        public Record_Permission(int IdRecord, string Name, DateTime fecha1, DateTime fecha2, string Reason)
        {
            this.IdRecord = IdRecord;
            this._Name = Name;
            this._Reason = Reason;
            this.Begin_Date = fecha1;
            this.End_Date = fecha2;
        }

        public TimeSpan Get_Hours_Ausent()
        {

            TimeSpan totalFaltado = TimeSpan.Zero;

            for (DateTime dia = Begin_Date.Date; dia <= End_Date.Date; dia = dia.AddDays(1))
            {
                if (Days.TryGetValue(dia.DayOfWeek, out var horario))
                {
                    DateTime inicioJornada = dia.Date + horario.JobStart;
                    DateTime finJornada = dia.Date + horario.JobEnd;

                    if (Begin_Date < finJornada && End_Date > inicioJornada)
                    {

                        DateTime start = Begin_Date > inicioJornada ? Begin_Date : inicioJornada;
                        DateTime end = End_Date < finJornada ? End_Date : finJornada;

                        if (end > start)
                        {
                            totalFaltado += end - start;
                            if (LunchS.Minutes > 0 || LunchS.Hours > 0)
                            {
                                totalFaltado -= (LunchF - LunchS);
                            }
                            else
                            {
                                totalFaltado -= new TimeSpan(1, 0, 0);
                            }
                        }
                    }
                }
            }
            return totalFaltado;
        }


    }
}
