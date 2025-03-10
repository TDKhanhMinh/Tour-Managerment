using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TOUR_MANAGERMENT.DTO_Data_Transfer_Object;
using TOUR_MANAGERMENT.Service;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace TOUR_MANAGERMENT.DAL_Data_Access_Layer
{
    public class ScheduleDAL
    {
        public static DataTable findAllTours()
        {
            DataTable dt = new DataTable();
            using SqlConnection sqlConnection = Connenction.GetSqlConnection("TourManagerment");

            if(sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }

            string query = "SELECT * FROM Schedule";
            using SqlCommand cmd = new(query, sqlConnection);
            using SqlDataAdapter adapter = new(cmd);
            adapter.Fill(dt);

            return dt;
        }

        public static void findToursByID(DataGridView DGV, String ID, String columnName)
        {
            DataView dv = new DataView();
            string rowFilter = string.Format("[{0}] = '{1}'", columnName, ID);
            try
            {
                (DGV.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
            }
            catch (Exception e) {
                MessageBox.Show(e.ToString());
                    }
        }
        
       
        
    }
}
