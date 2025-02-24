using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOUR_MANAGERMENT.DTO_Data_Transfer_Object;
using TOUR_MANAGERMENT.Service;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace TOUR_MANAGERMENT.DAL_Data_Access_Layer
{
    public class CustomerDAL
    {
        public CustomerDAL() { }
        public static DataTable findAllCustomer()
        {
            DataTable dt = new DataTable();
            using SqlConnection sqlConnection = Connenction.GetSqlConnection("TourManagerment");

            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }

            string query = "SELECT * FROM Customer";
            using SqlCommand cmd = new(query, sqlConnection);

            using SqlDataAdapter adapter = new(cmd);
            adapter.Fill(dt); 
            return dt;
        }

        public static DataTable findCustomer(string info)
            {
            DataTable dt = new DataTable();
            using SqlConnection sqlConnection = Connenction.GetSqlConnection("TourManagerment");

            if (sqlConnection.State == ConnectionState.Closed)
                {
                sqlConnection.Open();
                }

            string query = "SELECT * FROM Customer WHERE firstname LIKE @info OR phone LIKE @info";

            using SqlCommand cmd = new(query, sqlConnection);

           
            cmd.Parameters.AddWithValue("@info", "%" + info + "%");

            using SqlDataAdapter adapter = new(cmd);
            adapter.Fill(dt);

            return dt;
            }




        public static string getCustomerByEmail(string email)
            {
            using SqlConnection sqlConnection = Connenction.GetSqlConnection("TourManagerment");

            if (sqlConnection.State == ConnectionState.Closed)
                {
                sqlConnection.Open();

                }

            string query = "Select Customer.email From Customer where Customer.email = @email";
            SqlCommand cmd = new(query, sqlConnection);

            cmd.Parameters.AddWithValue("@email", email);
            return (string)cmd.ExecuteScalar();
            }
        public static string getCustomerByPhone(string phone)
            {
            using SqlConnection sqlConnection = Connenction.GetSqlConnection("TourManagerment");

            if (sqlConnection.State == ConnectionState.Closed)
                {
                sqlConnection.Open();

                }

            string query = "Select Customer.phone From Customer where Customer.phone = @phone";
            SqlCommand cmd = new(query, sqlConnection);

            cmd.Parameters.AddWithValue("@phone", phone);
            return (string)cmd.ExecuteScalar();
            }

        public static void insertCustomer(Customer_DTO customer)
            {
            using SqlConnection sqlConnection = Connenction.GetSqlConnection("TourManagerment");

            if (sqlConnection.State == ConnectionState.Closed)
                {
                sqlConnection.Open();
                }

            string query = "INSERT INTO Customer (Firstname, Lastname, Phone,Email, Address) VALUES " +
                           "(@Firstname, @Lastname, @Phone,@Email, @Address)";

            using SqlCommand cmd = new(query, sqlConnection);
            cmd.Parameters.AddWithValue("@Firstname", customer.Firstname);
            cmd.Parameters.AddWithValue("@Lastname", customer.Lastname);
            cmd.Parameters.AddWithValue("@Phone", customer.Phone);
            cmd.Parameters.AddWithValue("@Email", customer.Email);
            cmd.Parameters.AddWithValue("@Address", customer.Address);
            cmd.ExecuteNonQuery();
            }
        public static void updateCustomer(Customer_DTO customer, int customerId)
                {
                using SqlConnection sqlConnection = Connenction.GetSqlConnection("TourManagerment");

                if (sqlConnection.State == ConnectionState.Closed)
                    {
                    sqlConnection.Open();
                    }

                 string query = "UPDATE Customer SET Firstname = @Firstname, Lastname = @Lastname, Phone = @Phone, Email = @Email, Address = @Address " +
            "WHERE customerId = @CustomerId";


            using SqlCommand cmd = new(query, sqlConnection);
                cmd.Parameters.AddWithValue("@Firstname", customer.Firstname);
                cmd.Parameters.AddWithValue("@Lastname", customer.Lastname);
                cmd.Parameters.AddWithValue("@Phone", customer.Phone);
                cmd.Parameters.AddWithValue("@Email", customer.Email);
                cmd.Parameters.AddWithValue("@Address", customer.Address);
                cmd.Parameters.AddWithValue("@CustomerId", customerId);
                cmd.ExecuteNonQuery();
                }
        public static void deleteCustomer(int customerId)
            {
            using SqlConnection sqlConnection = Connenction.GetSqlConnection("TourManagerment");

            if (sqlConnection.State == ConnectionState.Closed)
                {
                sqlConnection.Open();
                }

            string query = "DELETE FROM Customer WHERE customerId = @CustomerId";

            using SqlCommand cmd = new(query, sqlConnection);
            cmd.Parameters.AddWithValue("@CustomerId", customerId);

            cmd.ExecuteNonQuery();
            sqlConnection.Close();
            }

        }


    }
