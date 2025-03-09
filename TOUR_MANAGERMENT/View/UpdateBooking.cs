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
using TOUR_MANAGERMENT.DTO_Data_Transfer_Object;

namespace TOUR_MANAGERMENT.View
{
    public partial class UpdateBooking : Form
    {
        private Booking_DTO booking_;
        public event Action? OnBookingUpdated;
        public UpdateBooking(Booking_DTO booking)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            booking_ = booking;


        }

        private void UpdateBooking_Load(object sender, EventArgs e)
        {

            DataTable dt = BookingBLL.findAllBookingData();
            comboBox1.DataSource = TourBLL.findAllTourData();
            comboBox1.DisplayMember = "tourName";
            comboBox1.ValueMember = "tourId";
            comboBox1.SelectedIndex = booking_.TourId;

            comboBox2.DataSource = CustomerBLL.fullName();
            comboBox2.DisplayMember = "fullName";
            comboBox2.ValueMember = "customerId";
            comboBox2.SelectedIndex = booking_.CustomerId;

            comboBox3.Items.Add("Đã cọc");
            comboBox3.Items.Add("Đã thanh toán");
            comboBox3.Items.Add("Hoàn thành");
            comboBox3.SelectedIndex = comboBox3.Items.IndexOf(booking_.Status);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BookingBLL.updateBooking(new Booking_DTO(dateTimePicker1.Value, comboBox3.SelectedItem?.ToString() ?? "Đã cọc", booking_.TourId, booking_.CustomerId), booking_.BookingId);
            MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK);
            OnBookingUpdated?.Invoke();
            this.Close();
        }
    }
}
