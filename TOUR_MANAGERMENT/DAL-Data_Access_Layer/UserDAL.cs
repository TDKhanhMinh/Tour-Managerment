using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOUR_MANAGERMENT.DTO_Data_Transfer_Object;
using TOUR_MANAGERMENT.Service;

namespace TOUR_MANAGERMENT.DAL_Data_Access_Layer
{
    public class UserDAL
    {
        public static bool Login(User_DTO account)
        {
            using SqlConnection sqlConnection = Connenction.GetSqlConnection("TourManagerment");

            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();

            }
            string query = "Select Users.password From Users where Users.password = @password";
            SqlCommand cmd = new(query, sqlConnection);

            cmd.Parameters.AddWithValue("@password", account.Password);

            string storedPassword = (string)cmd.ExecuteScalar();

            if (storedPassword != null && storedPassword.Equals(account.Password))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public static string getRole(string username)
        {
            using SqlConnection sqlConnection = Connenction.GetSqlConnection("TourManagerment");

            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();

            }

            string query = "Select Users.role From Users where Users.username = @username";
            SqlCommand cmd = new(query, sqlConnection);

            cmd.Parameters.AddWithValue("@username", username);
            return (string)cmd.ExecuteScalar();
        }
    }
}
