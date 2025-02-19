using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOUR_MANAGERMENT.DTO_Data_Transfer_Object
{
    public class User_DTO
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        public User_DTO()
        {
        }

        public User_DTO(string username, string password, string role)
        {
            Username = username;
            Password = password;
            Role = role;
        }
    }
}
