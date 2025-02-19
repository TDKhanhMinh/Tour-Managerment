using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOUR_MANAGERMENT.DTO_Data_Transfer_Object
{
    public class Customer_DTO
    {


        public int CustomerId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int BookingId { get; set; }

        public Customer_DTO( string firstname,string lastname, string phone, string email, string address, int bookingId)
        {
            
            Firstname = firstname;
            Lastname = lastname;
            Phone = phone;
            Email = email;
            Address = address;
            BookingId = bookingId;
        }

    

    }
}
