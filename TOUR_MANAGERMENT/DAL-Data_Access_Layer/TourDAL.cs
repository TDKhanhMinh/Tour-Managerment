using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using TOUR_MANAGERMENT.DTO_Data_Transfer_Object;
using TOUR_MANAGERMENT.Service;

namespace TOUR_MANAGERMENT.DAL_Data_Access_Layer
{
    public class TourDAL
    {
        public TourDAL() { }
        public static DataTable findAllTour()
        {
            DataTable dt = new DataTable();
            using SqlConnection sqlConnection = Connenction.GetSqlConnection("TourManagerment");
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
            string query = "SELECT * FROM Tour";
            using SqlCommand cmd = new(query, sqlConnection);

            using SqlDataAdapter adapter = new(cmd);
            adapter.Fill(dt);
            return dt;
        }

        public static void addTour(Tour_DTO tour)
        {
            using SqlConnection sqlConnection = Connenction.GetSqlConnection("TourManagerment");

            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }

            string query = "INSERT INTO Tour (Tourname, Type, Price, Transportation, Description) VALUES " +
                            "(@Tourname, @Type, @Price, @Transportation, @Description)";
            using SqlCommand cmd = new(query, sqlConnection);
            cmd.Parameters.AddWithValue("@Tourname", tour.TourName);
            cmd.Parameters.AddWithValue("@Type", tour.Type);
            cmd.Parameters.AddWithValue("@Price", tour.Price);
            cmd.Parameters.AddWithValue("@Transportation", tour.Transportation);
            cmd.Parameters.AddWithValue("@Description", tour.Description);
            cmd.ExecuteNonQuery();
        }

        public static void updateTour(Tour_DTO tour, int tourId)
        {
            using SqlConnection sqlConnection = Connenction.GetSqlConnection("TourManagerment");

            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
            string query = "UPDATE Tour SET Tourname = @Tourname, Type = @Type, Price = @Price, Transportation = @Transportation, Description = @Description " +
                            "WHERE tourId = @tourId";
            using SqlCommand cmd = new(query, sqlConnection);
            cmd.Parameters.AddWithValue("@Tourname", tour.TourName);
            cmd.Parameters.AddWithValue("@Type", tour.Type);
            cmd.Parameters.AddWithValue("@Price", tour.Price);
            cmd.Parameters.AddWithValue("@Transportation", tour.Transportation);
            cmd.Parameters.AddWithValue("@Description", tour.Description);
            cmd.Parameters.AddWithValue("@tourId", tourId);
            cmd.ExecuteNonQuery();
        }
        public static void deleteTour(int tourId)
        {
            using SqlConnection sqlConnection = Connenction.GetSqlConnection("TourManagerment");
            if (sqlConnection.State == ConnectionState.Closed) { sqlConnection.Open(); }
            string check = "SELECT COUNT(*) FROM Booking WHERE TourID = @TourID";
            using SqlCommand cmd = new(check, sqlConnection);
            cmd.Parameters.AddWithValue("@TourID", tourId);
            int count = (int)cmd.ExecuteScalar();

            if (count > 0)
            {
                MessageBox.Show("Không thể xóa tour vì có booking liên quan!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string query = "DELETE FROM Tour WHERE tourId = @tourID";
            using SqlCommand deleteQ = new(query, sqlConnection);
            deleteQ.Parameters.AddWithValue("@tourId", tourId);
            deleteQ.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public static DataTable findTour(string type, decimal min, decimal max, string transportation)
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
