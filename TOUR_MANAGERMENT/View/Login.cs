using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TOUR_MANAGERMENT.BLL_Business_Logic_Layer;
using TOUR_MANAGERMENT.DTO_Data_Transfer_Object;

namespace TOUR_MANAGERMENT.View
{
    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            string username = username_Input.Text;
            string password = password_Input.Text;
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Vui lòng nhập tài khoản và mật khẩu!");
                return;
            }
            else
            {
                User_DTO? acc = UserBLL.Login(username, password);
                if (acc != null)
                {
                    GlobalData.CurrentUser=UserBLL.getUser(username, password);
                    string chuc_vu = UserBLL.getRole(username);
                    this.Hide();
                    Home adminHome = new Home();
                    adminHome.ShowDialog();
                    this.Close();


                    }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu. Vui lòng thử lại");
                }

            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void password_Input_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
