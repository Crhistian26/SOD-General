using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Modelos.AsistenciasYPermisos.Count_hours
{
    public class Schedule
    {
        public DateTime StartDate { get; set; }
        public List<DailySchedule> DailySchedules { get; set; }

        public Schedule(DateTime date, string JSON_Data)
        {
            StartDate = date;
            var options = new JsonSerializerOptions
            {
                IncludeFields = true
            };
            DailySchedules = JsonSerializer.Deserialize<List<DailySchedule>>(JSON_Data,options);
        }

        public Schedule(DateTime date, List<DailySchedule> dailySchedules) 
        {
            StartDate = date;
            DailySchedules = dailySchedules;
        }

        public DateTime Get_StartDate()    
        { 
            return StartDate; 
        }

        public List<DailySchedule> Get_DailySchedules()
        {
            return DailySchedules;
        }

        public DailySchedule GetDailySchedule(DayOfWeek day)
        {
            return DailySchedules.Where(a=>a._dayOfWeek == day).FirstOrDefault();
        }

        public string Get_JSON_DailySchedules()
        {
            return JsonSerializer.Serialize<List<DailySchedule>>(DailySchedules);
        }

    }
}
