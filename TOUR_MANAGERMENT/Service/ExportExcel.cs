using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ClosedXML.Excel;

namespace TOUR_MANAGERMENT.Service
    {
    public class ExportExcel
        {
        public static void ExportToExcel(DataTable dt)
            {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
                {
                if (sfd.ShowDialog() == DialogResult.OK)
                    {
                    using (XLWorkbook wb = new XLWorkbook())
                        {
                        wb.Worksheets.Add(dt, "Sheet1");
                        wb.SaveAs(sfd.FileName);
                        MessageBox.Show("Xuất file Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }
    }
