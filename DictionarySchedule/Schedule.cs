using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionarySchedule
{
    public class Schedule
    {
       static Dictionary<DateTime, List<(TimeSpan StartTime, TimeSpan Duration, string EventName)>> schedule = new Dictionary<DateTime, List<(TimeSpan, TimeSpan, string)>>();
        /// <summary>
        /// добавление события
        /// </summary>
        /// <param name="date"></param>
        /// <param name="StartTime"></param>
        /// <param name="Duration"></param>
        /// <param name="EventName"></param>
        /// <returns></returns>
        public static bool AddSchedule(DateTime date, TimeSpan startTime, TimeSpan duration, string eventName)
        {
          int lengthDictionary= schedule.Count();
            schedule[date] = new List<(TimeSpan, TimeSpan, string)>
                {                    ( startTime, duration, eventName)
                };


            if (schedule.Count()== lengthDictionary+1)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// редактирование(обновление) события
        /// </summary>
        /// <param name="date"></param>
        /// <param name="startTime"></param>
        /// <param name="duration"></param>
        /// <param name="eventName"></param>
        /// <returns></returns>
        public static (TimeSpan StartTime, TimeSpan Duration, string EventName) EditSchedule(DateTime date, TimeSpan startTime, TimeSpan duration, string eventName)
        {
            var searchElement = schedule.FirstOrDefault(x => x.Key == date);
         var result = searchElement.Value.FirstOrDefault(x => x.StartTime == startTime);
            result.StartTime = startTime;
            result.Duration = duration;
            result.EventName = eventName;

            return result;
        }
        /// <summary>
        /// поиск события 
        /// </summary>
        /// <param name="date"></param>
        /// <param name="startTime"></param>
        /// <param name="duration"></param>
        /// <param name="eventName"></param>
        /// <returns></returns>
        public static bool SearchSchedule(DateTime date)
        {
            
        for (int i = 0; i<schedule.Count; i++)
                {
                if (date == 0)
                {
                    return false;
                }
                else

                    return true;
            }
        }
    }
}
