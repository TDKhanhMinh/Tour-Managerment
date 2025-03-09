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
using TOUR_MANAGERMENT.Service;

namespace TOUR_MANAGERMENT.View
{
    public partial class CustomerManagerment : Form
        {
        public CustomerManagerment()
            {
            InitializeComponent();
            }
        private int customerId;
        private String firstName;
        private String lastName;
        private String email;
        private String phone;
        private String address;
        private void CustomerManagerment_Load(object sender, EventArgs e)
            {
            dataGridView1.DataSource = CustomerBLL.findAllCustomerData();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.Columns["customerId"].HeaderText = "Mã khách hàng";
            dataGridView1.Columns["lastname"].HeaderText = "Họ";
            dataGridView1.Columns["firstname"].HeaderText = "Tên";

            dataGridView1.Columns["phone"].HeaderText = "Số điện thoại";
            dataGridView1.Columns["email"].HeaderText = "Email";
            dataGridView1.Columns["address"].HeaderText = "Địa chỉ";
            dataGridView1.CellClick += dataGridView1_CellContentClick;

            }

        private void groupBox2_Enter(object sender, EventArgs e)
            {
            groupBox2.AutoSize = true;
            }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
            if (e.RowIndex >= 0)
                {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                if (row.Cells["customerId"].Value != null && row.Cells["customerId"].Value != DBNull.Value)
                    {
                    textBox_firstname.Text = row.Cells["firstname"].Value?.ToString() ?? "";
                    textBox_lastname.Text = row.Cells["lastname"].Value?.ToString() ?? "";
                    textBox_phone.Text = row.Cells["phone"].Value?.ToString() ?? "";
                    textBox_email.Text = row.Cells["email"].Value?.ToString() ?? "";
                    textBox_address.Text = row.Cells["address"].Value?.ToString() ?? "";
                    customerId = (int)row.Cells["customerId"].Value;
                    }
                else
                    {
                    textBox_firstname.Text = "";
                    textBox_lastname.Text = "";
                    textBox_phone.Text = "";
                    textBox_email.Text = "";
                    textBox_address.Text = "";
                    }
                }
            }


        private void button_add_Click(object sender, EventArgs e)
            {
            firstName = textBox_firstname.Text;
            lastName = textBox_lastname.Text;
            email = textBox_email.Text;
            phone = textBox_phone.Text;
            address = textBox_address.Text;
            if (firstName.IsNullOrEmpty() || lastName.IsNullOrEmpty() || phone.IsNullOrEmpty() || email.IsNullOrEmpty() || address.IsNullOrEmpty())
                {
                MessageBox.Show("Hãy điền đầy đủ thông tin khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            else
                {
                if (CustomerBLL.findCustomerByEmail(email))
                    {
                    if (CustomerBLL.findCustomerByPhone(phone))
                        {
                        if (MessageBox.Show("Bạn có muốn thêm khách hàng này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                            CustomerBLL.addCustomer(new DTO_Data_Transfer_Object.Customer_DTO(firstName, lastName, phone, email, address));
                            CustomerManagerment_Load(sender, e);
                            MessageBox.Show("Thêm khách hàng thành công.","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    else
                        {
                        MessageBox.Show("Số điện thoại khách hàng này đã tồn tại. Vui lòng dùng số điện thoại khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        CustomerManagerment_Load(sender, e);
                        }
                    }

                else
                    {
                    MessageBox.Show("Email khách hàng này đã tồn tại. Vui lòng dùng email khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CustomerManagerment_Load(sender, e);
                    }
                }
            }

        private void textBox_firstname_TextChanged(object sender, EventArgs e)
            {

            }

        private void textBox_lastname_TextChanged(object sender, EventArgs e)
            {

            }

        private void textBox_phone_TextChanged(object sender, EventArgs e)
            {

            }

        private void textBox_email_TextChanged(object sender, EventArgs e)
            {

            }

        private void textBox_address_TextChanged(object sender, EventArgs e)
            {

            }

        private void button_edit_Click(object sender, EventArgs e)
            {
            firstName = textBox_firstname.Text;
            lastName = textBox_lastname.Text;
            email = textBox_email.Text;
            phone = textBox_phone.Text;
            address = textBox_address.Text;
            if (MessageBox.Show("Bạn có muốn chỉnh sửa thông tin khách hàng này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                CustomerBLL.updateCustomer(new DTO_Data_Transfer_Object.Customer_DTO(firstName, lastName, phone, email, address), customerId);
                CustomerManagerment_Load(sender, e);
                MessageBox.Show("Chỉnh sửa thông tin khách hàng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

        private void button_delete_Click(object sender, EventArgs e)
            {
            if (MessageBox.Show("Bạn có muốn xóa khách hàng này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                CustomerBLL.deleteCustomer(customerId);
                CustomerManagerment_Load(sender, e);
                MessageBox.Show("Xóa khách hàng thành công.");
                }

            }

        private void textBox_find_TextChanged(object sender, EventArgs e)
            {
            String info = textBox_find.Text.Trim();
            if (info == "")
                {
                CustomerManagerment_Load(sender, e);
                }
            else
                {
                dataGridView1.DataSource = CustomerBLL.findCustomerInfo(info);
                }
            }

        private void button_find_Click(object sender, EventArgs e)
            {

            }

        private void groupBox1_Enter(object sender, EventArgs e)
            {

            }

        private void button1_excel_Click(object sender, EventArgs e)

            {
            ExportExcel.ExportToExcel(CustomerBLL.findAllCustomerData());
            }
        }
    }
