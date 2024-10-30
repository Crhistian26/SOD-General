using DocumentFormat.OpenXml.Bibliography;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.AsistenciasYPermisos.Count_hours
{
    public class DailySchedule
    {
        public DayOfWeek _dayOfWeek { get; set; }
        public TimeSpan _StartHour {get; set;}
        public TimeSpan _EndHour {get; set;}
        public TimeSpan _LunchHours {get; set;}

        public DailySchedule() { }
        public DailySchedule(DayOfWeek dayOfWeek,TimeSpan startHour, TimeSpan endHour, TimeSpan lunchHours)
        {
            _dayOfWeek = dayOfWeek;
            _StartHour = startHour;
            _EndHour = endHour;
            _LunchHours = lunchHours;
        }
    }
}
