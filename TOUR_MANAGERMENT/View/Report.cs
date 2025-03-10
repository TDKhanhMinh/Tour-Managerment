using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using System.Windows.Forms;
using TOUR_MANAGERMENT.BLL_Business_Logic_Layer;

namespace TOUR_MANAGERMENT.View
{
    public partial class Report : Form
        {
        

      
        private void Report_Load(object sender, EventArgs e)
            {
            dataGridView1.DataSource = ReportBLL.getReport();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.Columns["TourType"].HeaderText = " Loại tour";
            dataGridView1.Columns["NumberOfBookings"].HeaderText = "Số lượng đặt tour";
            dataGridView1.Columns["TotalRevenue"].HeaderText = "Tổng thu";
            }
        }
    }
