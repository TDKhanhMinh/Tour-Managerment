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

    }
}
