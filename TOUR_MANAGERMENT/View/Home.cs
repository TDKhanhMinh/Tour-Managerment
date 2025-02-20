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

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_home_Click(object sender, EventArgs e)
        {
            if (currForm != null) { currForm.Close(); }
            label_top.Text = button_home.Text;
        }
    }
}
