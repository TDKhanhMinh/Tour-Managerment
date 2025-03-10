using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOUR_MANAGERMENT.Service;

namespace TOUR_MANAGERMENT.DAL_Data_Access_Layer
{
    public class ReportDAL
    {
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
        public static DataTable GetTourReport()
            {
            DataTable dt = new DataTable();
            using SqlConnection sqlConnection = Connenction.GetSqlConnection("TourManagerment");
            if (sqlConnection.State == ConnectionState.Closed)
                {
                sqlConnection.Open();
                }

            string query = @"SELECT t.type AS TourType,
            COUNT(b.bookingId) AS NumberOfBookings,
            SUM(t.price) AS TotalRevenue
            FROM Tour t
            LEFT JOIN Booking b ON t.tourId = b.tourId
            GROUP BY t.type
            ORDER BY TotalRevenue DESC;";
            using SqlCommand cmd = new(query, sqlConnection);

            using SqlDataAdapter adapter = new(cmd);
            adapter.Fill(dt);

            return dt;
            }

        }
}
