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
using TOUR_MANAGERMENT.BLL_Business_Logic_Layer;

namespace TOUR_MANAGERMENT.View
{
    public partial class Staff : Form
        {
        public Staff()
            {
            InitializeComponent();
            }

        private int userId;
        private String userName;
        private String pwd;
        private String role;
        private String fullName;
        private String address;
        private String phone;
        private String gender;
        private int age;
        private string _age;
        private void groupBox3_Enter(object sender, EventArgs e)
            {

            }

        private void groupBox2_Enter(object sender, EventArgs e)
            {

            }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
            if (e.RowIndex >= 0)
                {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                if (row.Cells["userId"].Value != null && row.Cells["userId"].Value != DBNull.Value)
                    {
                    textBox_username.Text = row.Cells["username"].Value?.ToString() ?? "";
                    textBox_pwd.Text = row.Cells["password"].Value?.ToString() ?? "";
                    textBox_fullname.Text = row.Cells["fullname"].Value?.ToString() ?? "";
                    textBox_address.Text = row.Cells["address"].Value?.ToString() ?? "";
                    textBox_age.Text = row.Cells["age"].Value?.ToString() ?? "";
                    textBox_phone.Text = row.Cells["phone"].Value?.ToString() ?? "";
                    textBox_gender.Text = row.Cells["gender"].Value?.ToString() ?? "";
                    userId = (int)row.Cells["userId"].Value;
                    }
                else
                    {
                    textBox_age.Text = "";
                    textBox_fullname.Text = "";
                    textBox_phone.Text = "";
                    textBox_gender.Text = "";
                    textBox_address.Text = "";
                    textBox_pwd.Text = "";
                    textBox_username.Text = "";
                    }
                }

            }

        private void groupBox1_Enter(object sender, EventArgs e)
            {

            }

        private void Staff_Load(object sender, EventArgs e)
            {
            dataGridView1.DataSource = UserBLL.findAllUserData();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //  dataGridView1.Columns["bookingId"].Visible = false;
            dataGridView1.Columns["username"].HeaderText = "Tài khoản";
            dataGridView1.Columns["password"].HeaderText = "Mật khẩu";
            dataGridView1.Columns["userId"].HeaderText = "Mã Nhân viên";
            dataGridView1.Columns["fullname"].HeaderText = "Họ và tên";
            dataGridView1.Columns["age"].HeaderText = "Tuổi";
            dataGridView1.Columns["role"].HeaderText = "Chức vụ";
            dataGridView1.Columns["phone"].HeaderText = "Số điện thoại";
            dataGridView1.Columns["gender"].HeaderText = "Giới tính";
            dataGridView1.Columns["address"].HeaderText = "Địa chỉ";
            dataGridView1.CellClick += dataGridView1_CellContentClick;
            }

        private void button_add_Click(object sender, EventArgs e)
            {
            _age = textBox_age.Text;
            fullName = textBox_fullname.Text;
            phone = textBox_phone.Text;
            gender = textBox_gender.Text;
            address = textBox_address.Text;
            pwd = textBox_pwd.Text;
            userName = textBox_username.Text;
            role = "Nhân Viên";


            if (userName.IsNullOrEmpty() ||
                address.IsNullOrEmpty() ||
                _age.IsNullOrEmpty() ||
                pwd.IsNullOrEmpty() ||
                phone.IsNullOrEmpty() ||
                fullName.IsNullOrEmpty() ||
                gender.IsNullOrEmpty())
                {
                MessageBox.Show("Hãy điền đầy đủ thông tin nhân viên");
                }
            else
                {
                age = int.Parse(_age);
                    {
                    if (UserBLL.findUserByPhone(phone))
                        {
                        if (MessageBox.Show("Bạn có muốn thêm nhân viên này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                            UserBLL.addUser(new DTO_Data_Transfer_Object.User_DTO(userName, pwd, role, fullName, gender, phone, age, address));
                            Staff_Load(sender, e);
                            MessageBox.Show("Thêm nhân viên thành công.");
                            }
                        }
                    else
                        {
                        MessageBox.Show("Số điện thoại khách hàng này đã tồn tại. Vui lòng dùng số điện thoại khác.");
                        Staff_Load(sender, e);
                        }
                    }
                }
            
            }

        private void textBox_search_TextChanged(object sender, EventArgs e)
            {
            String info = textBox_search.Text.Trim();
            if (info == "")
                {
                Staff_Load(sender, e);

                }
            else
                {
                dataGridView1.DataSource = UserBLL.findUserInfo(info);
                }
            }

        private void button_delete_Click(object sender, EventArgs e)
            {
            if (MessageBox.Show("Bạn có muốn xóa nhân viên này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                UserBLL.deleteUser(userId);
                Staff_Load(sender, e);
                MessageBox.Show("Xóa nhân viên thành công.");
                }
            }

        private void button_edit_Click(object sender, EventArgs e)
            {
            age = int.Parse(textBox_age.Text);
            fullName = textBox_fullname.Text;
            phone = textBox_phone.Text;
            gender = textBox_gender.Text;
            address = textBox_address.Text;
            pwd = textBox_pwd.Text;
            userName = textBox_username.Text;
            role = "Nhân Viên";

            if (MessageBox.Show("Bạn có muốn chỉnh sửa thông tin nhân viên này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                UserBLL.updateUser(new DTO_Data_Transfer_Object.User_DTO(userName,pwd,role,fullName,gender,phone,age,address),userId);
                Staff_Load(sender, e);
                MessageBox.Show("Chỉnh sửa thông tin nhân viên thành công.");
                }
            }
        }
    }
    
