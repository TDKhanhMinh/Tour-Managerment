using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TOUR_MANAGERMENT.DAL_Data_Access_Layer;
using TOUR_MANAGERMENT.Service;
namespace TOUR_MANAGERMENT.View
{
    public partial class Schedule : Form
    {
        public Schedule()
        {
            InitializeComponent();
        }

        private void Schedule_Load(object sender, EventArgs e)
        {
            DataTable DTable = ScheduleDAL.findAllTours();
            BindingSource Sbind = new BindingSource();
            Sbind.DataSource = DTable;
            dataGridViewSchedule.AutoGenerateColumns = true;
            dataGridViewSchedule.DataSource = DTable;
            dataGridViewSchedule.DataSource = Sbind;
            dataGridViewSchedule.Refresh();

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lstStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridViewSchedule.DataSource;
            bs.Filter = dataGridViewSchedule.Columns[9].HeaderText + " LIKE '%" + cbxStatus.Text + "%'";
            dataGridViewSchedule.DataSource = bs;


            //ScheduleDAL.findToursByID(dataGridViewSchedule,"scheduleId", txtScheduleId.Text);
            dataGridViewSchedule.Refresh();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBoxSchedule_Enter(object sender, EventArgs e)
        {

        }

        private void txtScheduleId_TextChanged(object sender, EventArgs e)
        {

            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridViewSchedule.DataSource;
            bs.Filter = dataGridViewSchedule.Columns[0].HeaderText + " = " + txtScheduleId.Text;
            dataGridViewSchedule.DataSource = bs;


            //ScheduleDAL.findToursByID(dataGridViewSchedule,"scheduleId", txtScheduleId.Text);
            dataGridViewSchedule.Refresh();
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridViewSchedule.DataSource;
            bs.Filter = dataGridViewSchedule.Columns[10].HeaderText + " LIKE '%" + comboBox1.Text + "%'";
            dataGridViewSchedule.DataSource = bs;


            //ScheduleDAL.findToursByID(dataGridViewSchedule,"scheduleId", txtScheduleId.Text);
            dataGridViewSchedule.Refresh();
        }
    }
}
