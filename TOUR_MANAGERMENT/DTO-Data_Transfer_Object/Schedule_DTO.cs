using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOUR_MANAGERMENT.DTO_Data_Transfer_Object
{
    public class Schedule_DTO
    {
        public int ScheduleId { get; set; }
        public DateTime BeginDay { get; set; }
        public string Activity { get; set; }
        public DateTime EndDay { get; set; }

        public Schedule_DTO() { }

        public Schedule_DTO( DateTime beginDay, string activity, DateTime endDay)
        {
            BeginDay = beginDay;
            Activity = activity;
            EndDay = endDay;
        }
    }
}
