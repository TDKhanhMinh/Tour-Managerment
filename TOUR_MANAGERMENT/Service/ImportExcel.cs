using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClosedXML.Excel;
using TOUR_MANAGERMENT.View;
using TOUR_MANAGERMENT.BLL_Business_Logic_Layer;
using Microsoft.IdentityModel.Tokens;

namespace TOUR_MANAGERMENT.Service
{
    public class ImportExcel
    {
        public static DataTable ReadExcel(string filePath)
        {
            DataTable dt = new DataTable();

            using (var workbook = new XLWorkbook(filePath))
            {
                var worksheet = workbook.Worksheet(1);
                bool firstRow = true;

                foreach (var row in worksheet.RowsUsed())
                {
                    if (firstRow)
                    {
                        foreach (var cell in row.Cells())
                        {
                            dt.Columns.Add(cell.Value.ToString());
                        }
                        firstRow = false;
                    }
                    else
                    {
                        dt.Rows.Add(row.Cells().Select(c => c.Value.ToString()).ToArray());
                    }
                }
            }

            return dt;
        }

        public static void importTour(DataTable dt)
        {
            using SqlConnection sqlConnection = Connenction.GetSqlConnection("TourManagerment");
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }

            foreach (DataRow row in dt.Rows)
            {
                if (String.IsNullOrEmpty(row[0].ToString()) || String.IsNullOrEmpty(row[1].ToString()) || String.IsNullOrEmpty(row[2].ToString()) || String.IsNullOrEmpty(row[3].ToString()) || String.IsNullOrEmpty(row[4].ToString()))
                {
                    MessageBox.Show("File chứa hàng không đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (row[1].ToString() != "Cao cấp" && row[1].ToString() != "Tiêu chuẩn" && row[1].ToString() != "Tiết kiệm")
                {
                    MessageBox.Show("File chứa PHÂN LOẠI Tour không hợp lệ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (row[3].ToString() != "Xe" && row[3].ToString() != "Máy bay")
                {
                    MessageBox.Show("File chứa PHÂN LOẠI Tour không hợp lệ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                decimal price;
                if (!decimal.TryParse(row[2].ToString(), out price))
                {
                    MessageBox.Show("Định dạng giá không hợp lệ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                TourBLL.addTour(new DTO_Data_Transfer_Object.Tour_DTO(row[0].ToString(), row[1].ToString(), price, row[3].ToString(), row[4].ToString()));
            }
                
            MessageBox.Show("Dữ liệu đã nhập thành công!");
            
        }
    }
}
    
