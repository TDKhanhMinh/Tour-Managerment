using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using TOUR_MANAGERMENT.DTO_Data_Transfer_Object;
using TOUR_MANAGERMENT.Service;

namespace TOUR_MANAGERMENT.DAL_Data_Access_Layer
{
    public class BookingDAL
    {
        public static DataTable findAllBooking()
        {
            DataTable dt = new DataTable();
            using SqlConnection sqlConnection = Connenction.GetSqlConnection("TourManagerment");
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
            string query = @"SELECT " +
                                "b.BookingId AS bookingId, " +
                                "b.Date AS date, " +
                                "b.Status AS status, " +
                                "(c.lastname + ' ' + c.firstname) AS CustomerName," +
                                "t.tourname AS TourName " +
                            "FROM Booking b " +
                            "JOIN Customer c ON b.CustomerId = c.CustomerId " +
                            "JOIN Tour t ON b.TourId = t.TourId;";
            using SqlCommand cmd = new(query, sqlConnection);

            using SqlDataAdapter adapter = new(cmd);
            adapter.Fill(dt);
            return dt;
        }

        public static void createBooking(Booking_DTO booking)
        {
            using SqlConnection sqlConnection = Connenction.GetSqlConnection("TourManagerment");

            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }

            string query = "INSERT INTO Booking (Date, Status, TourId, CustomerId) VALUES " +
                            "(@Date, @Status, @TourId, @CustomerId)";
            using SqlCommand cmd = new(query, sqlConnection);
            cmd.Parameters.AddWithValue("@Date", booking.Date);
            cmd.Parameters.AddWithValue("@TourId", booking.TourId);
            cmd.Parameters.AddWithValue("@Status", booking.Status);
            cmd.Parameters.AddWithValue("@CustomerId", booking.CustomerId);

            cmd.ExecuteNonQuery();
        }

        public static void updateBooking(Booking_DTO booking, int bookingId)
        {
            using SqlConnection sqlConnection = Connenction.GetSqlConnection("TourManagerment");

            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
            string query = "UPDATE Booking SET Status = @Status, " +
                            "Date = @Date " +
                            "WHERE BookingId = @BookingId";
            using SqlCommand cmd = new(query, sqlConnection);
            cmd.Parameters.AddWithValue("@Status", booking.Status);
            cmd.Parameters.AddWithValue("@Date", booking.Date);
            cmd.Parameters.AddWithValue("@BookingId", bookingId);

            cmd.ExecuteNonQuery();
        }
        public static void deleteBooking(int bookingId)
        {
            using SqlConnection sqlConnection = Connenction.GetSqlConnection("TourManagerment");
            if (sqlConnection.State == ConnectionState.Closed) { sqlConnection.Open(); }
            string query = "DELETE FROM Booking WHERE bookingId = @bookingID";
            using SqlCommand deleteQ = new(query, sqlConnection);
            deleteQ.Parameters.AddWithValue("@bookingId", bookingId);
            deleteQ.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public static DataTable findBooking(string type, decimal min, decimal max, string transportation)
        {
            DataTable dt = new DataTable();
            using SqlConnection sqlConnection = Connenction.GetSqlConnection("TourManagerment");
            if (sqlConnection.State == ConnectionState.Closed) { sqlConnection.Open(); }

            string query = @"SELECT * FROM Tour " +
            "WHERE (type = @type OR @type = '') " +
            "AND (transportation = @transportation OR @transportation = '') " +
            "AND (price BETWEEN @min AND @max)";

            using SqlCommand cmd = new(query, sqlConnection);
            cmd.Parameters.AddWithValue("@type", type);
            cmd.Parameters.AddWithValue("@min", min);
            cmd.Parameters.AddWithValue("@max", max);
            cmd.Parameters.AddWithValue("@transportation", transportation);
            using SqlDataAdapter adapter = new(cmd);
            adapter.Fill(dt);
            return dt;
        }
    }
}
