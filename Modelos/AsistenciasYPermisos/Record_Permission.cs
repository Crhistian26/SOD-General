using System;
using System.Collections.Generic;

namespace Modelos.AsistenciasYPermisos
{
    public class Record_Permission
    {
        public Dictionary<DayOfWeek, (TimeSpan JobStart, TimeSpan JobEnd)> Days = new Dictionary<DayOfWeek, (TimeSpan JobStart, TimeSpan JobEnd)>
        {
            {DayOfWeek.Monday,(new TimeSpan(8,30,0),new TimeSpan(17,30,0))},
            {DayOfWeek.Tuesday,(new TimeSpan(8,30,0),new TimeSpan(17,30,0))},
            {DayOfWeek.Wednesday,(new TimeSpan(9,0,0),new TimeSpan(17,30,0))},
            {DayOfWeek.Thursday,(new TimeSpan(8,30,0),new TimeSpan(17,30,0))},
            {DayOfWeek.Friday,(new TimeSpan(8,30,0),new TimeSpan(17,30,0))},
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

      

        public Record_Permission(int IdRecord, string Reason, string descip, DateTime fecha1, DateTime fecha2)
        {
            this.IdRecord = IdRecord;
            this._Reason = Reason;
            this._Description = descip;
            this.Begin_Date = fecha1;
            this.End_Date = fecha2;
        }

        public Record_Permission(int IdRecord, int idEmployee , int idReason, string descip, DateTime fecha1, DateTime fecha2)
        {
            this.IdRecord = IdRecord;
            this.IdEmployee = idEmployee;
            this.IdReason = idReason;
            this._Description = descip;
            this.Begin_Date = fecha1;
            this.End_Date = fecha2;
        }

        public Record_Permission(int IdRecord, string Name, string Reason,  string descip, DateTime fecha1, DateTime fecha2)
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

        public TimeSpan Get_Hours_Ausent()
        {
            TimeSpan totalFaltado = TimeSpan.Zero;
            DateTime InicioReal, FinReal;
            DateTime InicioHorario, FinHorario;

            if (Begin_Date.Date == End_Date.Date)
            {
                Days.TryGetValue(Begin_Date.DayOfWeek, out var horario);

                InicioHorario = Begin_Date.Date + horario.JobStart;
                FinHorario = End_Date.Date + horario.JobEnd;

                InicioReal = Begin_Date > InicioHorario ? Begin_Date : InicioHorario;
                FinHorario = End_Date > FinHorario ? End_Date : FinHorario;

                var h = End_Date - Begin_Date;

                totalFaltado = new TimeSpan(h.Hours, h.Minutes, 0);

                return totalFaltado;
            }
            else
            {
                DateTime h = Begin_Date.Date;
                
                do
                {
                    Days.TryGetValue(h.DayOfWeek, out var horario);

                    InicioHorario = h.Date + horario.JobStart;
                    FinHorario = h.Date + horario.JobEnd;

                    if(InicioHorario.Date == Begin_Date.Date)
                    {
                        InicioReal = Begin_Date > InicioHorario ? Begin_Date : InicioHorario;
                    }
                    else
                    {
                        InicioReal = InicioHorario;
                    }

                    if (FinHorario.Date == End_Date.Date)
                    {
                        FinReal = End_Date > FinHorario ? End_Date : FinHorario;
                    }
                    else
                    {
                        FinReal = FinHorario;
                    }
                    
                    var v = FinReal - InicioReal;

                    if(v.Hours > 8)
                    {
                        totalFaltado += new TimeSpan(v.Hours - 1, v.Minutes, 0);
                    }
                    else
                    {
                        totalFaltado += new TimeSpan(v.Hours, v.Minutes, 0);
                    }
                    


                    h = h.AddDays(1);
                } while (h.Date < End_Date.Date);
            }

            return totalFaltado;
        }

    

        public TimeSpan Get_Hours_Ausent(DateTime FinalDate)
        {

            TimeSpan totalFaltado = TimeSpan.Zero;
            for (DateTime dia = Begin_Date.Date; dia <= FinalDate; dia = dia.AddDays(1))
            {
                if (Days.TryGetValue(dia.DayOfWeek, out var horario))
                {
                    DateTime inicioJornada = dia.Date + horario.JobStart;
                    DateTime finJornada = dia.Date + horario.JobEnd;

                    if (Begin_Date < finJornada && End_Date > inicioJornada)
                    {

                        DateTime start = Begin_Date > inicioJornada ? Begin_Date : inicioJornada;
                        DateTime end = End_Date < finJornada ? End_Date : finJornada;

                        totalFaltado += end - start;

                        if (end > start)
                        {
                            totalFaltado -= new TimeSpan(1, 15, 0);
                        }
                    }
                }
            }

            return totalFaltado;
        }

        public bool ConfirmBeginDate()
        {
            TimeSpan begin = new TimeSpan(Begin_Date.Hour, Begin_Date.Minute, 0);
            if(begin > new TimeSpan(8, 30, 0))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool ConfirmEndDate()
        {
            TimeSpan End = new TimeSpan(End_Date.Hour, End_Date.Minute, 0);
            if (End > new TimeSpan(5, 30, 0) && End_Date.DayOfWeek != DayOfWeek.Sunday && End_Date.DayOfWeek != DayOfWeek.Saturday)
            {
                return true;
            }
            else if (End > new TimeSpan(5, 30, 0) && End_Date.DayOfWeek == DayOfWeek.Saturday)
            {
                return true;
            }
            else
            {
                return true;
            }
        }
    }
}
