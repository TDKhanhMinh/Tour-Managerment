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

        public static User_DTO getUser(string username, string pwd)
            {
            using SqlConnection sqlConnection = Connenction.GetSqlConnection("TourManagerment");

            if (sqlConnection.State == ConnectionState.Closed)
                {
                sqlConnection.Open();
                }

            string query = "SELECT * FROM Users WHERE Users.username = @username AND Users.password = @pwd";
            using SqlCommand cmd = new(query, sqlConnection);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@pwd", pwd);

            using SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read()) 
                {               
                return new User_DTO(
                    reader.GetString(reader.GetOrdinal("Username")),
                    reader.GetString(reader.GetOrdinal("Password")),
                    reader.GetString(reader.GetOrdinal("Role")),
                    reader.GetString(reader.GetOrdinal("Fullname")),
                    reader.GetString(reader.GetOrdinal("Gender")),
                    reader.GetString(reader.GetOrdinal("Phone")),
                    reader.GetInt32(reader.GetOrdinal("Age")),
                    reader.GetString(reader.GetOrdinal("Address"))
                );
                }
            return null; 
            }

            
        
               
        public static DataTable findAllStaff()
            {
            DataTable dt = new DataTable();
            using SqlConnection sqlConnection = Connenction.GetSqlConnection("TourManagerment");

            if (sqlConnection.State == ConnectionState.Closed)
                {
                sqlConnection.Open();
                }

            string query = "SELECT * FROM Users";
            using SqlCommand cmd = new(query, sqlConnection);

            using SqlDataAdapter adapter = new(cmd);
            adapter.Fill(dt);
            return dt;
            }

        public static DataTable findStaff(string info)
            {
            DataTable dt = new DataTable();
            using SqlConnection sqlConnection = Connenction.GetSqlConnection("TourManagerment");

            if (sqlConnection.State == ConnectionState.Closed)
                {
                sqlConnection.Open();
                }

            string query = "SELECT * FROM Users  WHERE fullname LIKE @info OR phone LIKE @info";

            using SqlCommand cmd = new(query, sqlConnection);


            cmd.Parameters.AddWithValue("@info", "%" + info + "%");

            using SqlDataAdapter adapter = new(cmd);
            adapter.Fill(dt);

            return dt;
            }

        public static string getUserByPhone(string phone)
            {
            using SqlConnection sqlConnection = Connenction.GetSqlConnection("TourManagerment");

            if (sqlConnection.State == ConnectionState.Closed)
                {
                sqlConnection.Open();

                }

            string query = "Select Users.phone From Users  where Users.phone = @phone";
            SqlCommand cmd = new(query, sqlConnection);

            cmd.Parameters.AddWithValue("@phone", phone);
            return (string)cmd.ExecuteScalar();
            }

        public static void insertStaff(User_DTO user)
            {
            using SqlConnection sqlConnection = Connenction.GetSqlConnection("TourManagerment");

            if (sqlConnection.State == ConnectionState.Closed)
                {
                sqlConnection.Open();
                }

            string query = "INSERT INTO Users (Username, Password, Role, Fullname, Age, Gender, Phone, Address)" +
                           "VALUES (@Username, @Password, @Role, @Fullname, @Age, @Gender, @Phone, @Address)";

            using SqlCommand cmd = new(query, sqlConnection);
            cmd.Parameters.AddWithValue("@Username", user.Username);
            cmd.Parameters.AddWithValue("@Password", user.Password);
            cmd.Parameters.AddWithValue("@Role", user.Role);
            cmd.Parameters.AddWithValue("@Fullname",user.fullname);
            cmd.Parameters.AddWithValue("@Age", user.age);
            cmd.Parameters.AddWithValue("@Gender", user.gender);
            cmd.Parameters.AddWithValue("@Phone", user.phone);
            cmd.Parameters.AddWithValue("@Address", user.address);
            cmd.ExecuteNonQuery();
            }
        public static void updateStaff(User_DTO user, int userId)
            {
            using SqlConnection sqlConnection = Connenction.GetSqlConnection("TourManagerment");

            if (sqlConnection.State == ConnectionState.Closed)
                {
                sqlConnection.Open();
                }

            string query = "UPDATE Users SET Username = @Username, Password = @Password, Role = @Role, FullName = @Fullname, " +
                           "Age = @Age, Gender = @Gender, Phone = @Phone, Address = @Address WHERE userId = @UserId";

            using SqlCommand cmd = new(query, sqlConnection);
            cmd.Parameters.AddWithValue("@Username", user.Username);
            cmd.Parameters.AddWithValue("@Password", user.Password);
            cmd.Parameters.AddWithValue("@Role", user.Role);
            cmd.Parameters.AddWithValue("@Fullname", user.fullname);
            cmd.Parameters.AddWithValue("@Age", user.age);
            cmd.Parameters.AddWithValue("@Gender", user.gender);
            cmd.Parameters.AddWithValue("@Phone", user.phone);
            cmd.Parameters.AddWithValue("@Address", user.address);
            cmd.Parameters.AddWithValue("@UserId", userId); // Đúng tham số userId

            cmd.ExecuteNonQuery();
            }

        public static void deleteStaff(int customerId)
            {
            using SqlConnection sqlConnection = Connenction.GetSqlConnection("TourManagerment");

            if (sqlConnection.State == ConnectionState.Closed)
                {
                sqlConnection.Open();
                }

            string query = "DELETE FROM Users WHERE userId = @userId";

            using SqlCommand cmd = new(query, sqlConnection);
            cmd.Parameters.AddWithValue("@userId", customerId);

            cmd.ExecuteNonQuery();
            sqlConnection.Close();
            }
        }
}
