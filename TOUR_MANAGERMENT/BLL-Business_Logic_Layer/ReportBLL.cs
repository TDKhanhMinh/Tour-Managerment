using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOUR_MANAGERMENT.DAL_Data_Access_Layer;

namespace TOUR_MANAGERMENT.BLL_Business_Logic_Layer
{
   public class ReportBLL
    {
        public static DataTable getReport()
            {
            DataTable dt = new DataTable();
            try { dt = ReportDAL.GetTourReport(); }
            catch (Exception ex) { MessageBox.Show("Lỗi " + ex.Message); }
            return dt;
            }

        }
    }
