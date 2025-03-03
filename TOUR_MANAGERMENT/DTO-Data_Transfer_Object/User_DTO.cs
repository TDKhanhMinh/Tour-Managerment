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
        public string fullname { get; set; }
        public string gender { get; set; }
        public string phone { get; set; }
        public int age { get; set; }
        public string address { get; set; }
        public User_DTO()
        {
        }

        public User_DTO(string username, string password, string role, string fullname, string gender, string phone, int age, string address)
            {
            this.Username = username;
            this.Password = password;
            this.Role = role;
            this.fullname = fullname;
            this.gender = gender;
            this.phone = phone;
            this.age = age;
            this.address = address;
            }
        public User_DTO(int userId, string username, string password, string role, string fullname, string gender, string phone, int age, string address)
            {
            this.UserId = userId;
            this.Username = username;
            this.Password = password;
            this.Role = role;
            this.fullname = fullname;
            this.gender = gender;
            this.phone = phone;
            this.age = age;
            this.address = address;
            }

        public User_DTO(string username, string password, string role)
            {
            this.Username = username;
            this.Password = password;
            this.Role = role;
            
            }
        }
}
