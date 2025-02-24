using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace TOUR_MANAGERMENT.Service
    {
    public class ExportExcel
        {
        public static void ExportToExcel(DataTable dt)
            {
            if (dt == null || dt.Rows.Count == 0)
                {
                MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
                }


            Excel.Application excelApp = new Excel.Application();
            excelApp.Visible = false;


            Excel.Workbook workbook = excelApp.Workbooks.Add();
            Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Sheets[1];


            for (int i = 0; i < dt.Columns.Count; i++)
                {
                worksheet.Cells[1, i + 1] = dt.Columns[i].ColumnName;
                }

            for (int row = 0; row < dt.Rows.Count; row++)
                {
                for (int col = 0; col < dt.Columns.Count; col++)
                    {
                    worksheet.Cells[row + 2, col + 1] = dt.Rows[row][col];
                    }
                }


            SaveFileDialog sfd = new SaveFileDialog
                {
                Filter = "Excel Files|*.xlsx",
                FileName = "CustomersData.xlsx"
                };

            if (sfd.ShowDialog() == DialogResult.OK)
                {
                workbook.SaveAs(sfd.FileName);
                MessageBox.Show("Xuất file Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

       
            workbook.Close();
            excelApp.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
            }
        }
    }
