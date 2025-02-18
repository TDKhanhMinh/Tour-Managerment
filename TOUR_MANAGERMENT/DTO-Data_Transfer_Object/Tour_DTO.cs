using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOUR_MANAGERMENT.DTO_Data_Transfer_Object
{
    public class Tour_DTO
    {
        public int TourId { get; set; }
        public string TourName { get; set; }
        public string Type { get; set; }
        public decimal Price { get; set; }
        public string Transportation { get; set; }
        public string Description { get; set; }

        public Tour_DTO() {
           
        }

        public Tour_DTO( string tourName, string type, decimal price, string transportation, string description)
        {
           
            TourName = tourName;
            Type = type;
            Price = price;
            Transportation = transportation;
            Description = description;
        }
    }
}
