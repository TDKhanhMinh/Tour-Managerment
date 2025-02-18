using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOUR_MANAGERMENT.DTO_Data_Transfer_Object
{
    public class Booking_DTO
    {
        public int BookingId { get; set; }
        public DateTime Date { get; set; }
        public int Status { get; set; }

        public Booking_DTO() { }

        public Booking_DTO( DateTime date, int status)
        {
            Date = date;
            Status = status;
        }
    }
}
