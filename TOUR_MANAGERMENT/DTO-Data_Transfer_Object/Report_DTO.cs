using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOUR_MANAGERMENT.DTO_Data_Transfer_Object
{
    public class Report_DTO
    {
        public int ReportId { get; set; }
        public int Revenue { get; set; }
        public DateTime ReportDate { get; set; }
        public string Description { get; set; }

        public Report_DTO() { }

        public Report_DTO( int revenue, DateTime reportDate, string description)
        {
          
            Revenue = revenue;
            ReportDate = reportDate;
            Description = description;
        }
    }
}
