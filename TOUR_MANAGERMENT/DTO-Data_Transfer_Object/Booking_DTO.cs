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
        public string Status { get; set; }

        public int TourId { get; set; }

        public int CustomerId { get; set; }

        public Booking_DTO() { }

        public Booking_DTO(DateTime date, string status, int tourId, int customerId)
        {
            Date = date;
            Status = status;
            TourId = tourId;
            CustomerId = customerId;
        }
        public Booking_DTO(DateTime date, string status, int tourId, int customerId, int bookingId)
        {
            Date = date;
            Status = status;
            TourId = tourId;
            CustomerId = customerId;
            BookingId = bookingId;
        }
    }
}
