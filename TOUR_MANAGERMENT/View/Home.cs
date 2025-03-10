using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TOUR_MANAGERMENT.View
{
    public partial class Home : Form


        {
        public Home()
            {
            InitializeComponent();
            }
        private Form currForm;
        public void OpenChidForm(Form child)
            {
            if (currForm != null) { currForm.Close(); }
            currForm = child;
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;
            panel_body.Controls.Add(child);
            panel_body.Tag = child;
            child.BringToFront();
            child.Show();

            }

        private void panel2_Paint(object sender, PaintEventArgs e)
            {

            }

        private void button1_Click(object sender, EventArgs e)
            {
            OpenChidForm(new CustomerManagerment());
            label_top.Text = button_manager_customer.Text;

            }

        private void Home_Load(object sender, EventArgs e)
            {
            iconButton_name.Text = GlobalData.CurrentUser.fullname.ToString() + " - " + GlobalData.CurrentUser.Role.ToString();
            }

        private void panel3_Paint(object sender, PaintEventArgs e)
            {

            }

        private void button_home_Click(object sender, EventArgs e)
            {
            if (currForm != null) { currForm.Close(); }
            label_top.Text = button_home.Text;

            }

        private void button1_Click_1(object sender, EventArgs e)
        //{
        //if (GlobalData.CurrentUser.Role.Equals("ADMIN"))
        //    {
        //    OpenChidForm(new Tour());
        //    label_top.Text = button_manager_customer.Text;
        //    }
        //else
        //    {
        //    MessageBox.Show("Bạn không có quyền truy cập chức năng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    }

        //}
            {
            OpenChidForm(new Tour());
            label_top.Text = button1.Text;
            }
        private void button2_Click(object sender, EventArgs e)
            {
            OpenChidForm(new Schedule());
            label_top.Text = button_schedule.Text;
            }

        private void button5_Click(object sender, EventArgs e)
            {
            if (GlobalData.CurrentUser.Role.Equals("ADMIN"))
                {
                OpenChidForm(new Staff());
                label_top.Text = button_staff.Text;
                }
            else
                {
                MessageBox.Show("Bạn không có quyền truy cập chức năng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        private void label_name_Click(object sender, EventArgs e)
            {

            }

        private void button_logout_Click(object sender, EventArgs e)
            {
            this.Hide();
            MessageBox.Show("Bạn đã đăng xuất thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Login login = new Login();
            login.ShowDialog();
            this.Close();
            }

        private void button3_Click(object sender, EventArgs e)
            {
            OpenChidForm(new Booking());
            label_top.Text = button3.Text;
            }

        private void button4_Click(object sender, EventArgs e)
            {

            }
        }
    }
