using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.IdentityModel.Tokens;
using TOUR_MANAGERMENT.BLL_Business_Logic_Layer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace TOUR_MANAGERMENT.View
    {
    public partial class Tour : Form
        {
        private int tourId;
        private String tourName;
        private String type;
        private string price;
        private String transportation;
        private String description;
        public Tour()
            {
            InitializeComponent();
            }

        private void Tour_Load(object sender, EventArgs e)
            {
            dataGridView1.DataSource = TourBLL.findAllTourData();
            dataGridView1.Columns["tourId"].Visible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.Columns["tourname"].HeaderText = "Tên Tour";
            dataGridView1.Columns["type"].HeaderText = "Phân Loại";
            dataGridView1.Columns["price"].HeaderText = "Giá";

            dataGridView1.Columns["transportation"].HeaderText = "Phương tiện di chuyển";
            dataGridView1.Columns["description"].HeaderText = "Mô tả";
            dataGridView1.CellClick += dataGridView1_CellContentClick;
            }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
            if (e.RowIndex >= 0)
                {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                if (row.Cells["tourId"].Value != null)
                    {
                    tb_name.Text = row.Cells["tourName"].Value.ToString();
                    tb_type.Text = row.Cells["type"].Value.ToString();
                    tb_price.Text = row.Cells["price"].Value.ToString();
                    tb_transportation.Text = row.Cells["transportation"].Value.ToString();
                    tb_description.Text = row.Cells["description"].Value.ToString();
                    tourId = (int)row.Cells["tourId"].Value;
                    }
                else
                    {
                    tb_name.Text = "";
                    tb_type.Text = "";
                    tb_price.Text = "";
                    tb_transportation.Text = "";
                    tb_description.Text = "";
                    }


                }
            }

        private void textBox_find_TextChanged(object sender, EventArgs e)
            {
            String info = textBox_find.Text.Trim();
            if (info == "")
                {
                Tour_Load(sender, e);
                }
            else
                {
                dataGridView1.DataSource = TourBLL.findTourInfo(info);
                }
            }

        private void button_add_Click(object sender, EventArgs e)
            {
            type = tb_type.Text;
            tourName = tb_name.Text;
            transportation = tb_transportation.Text;
            price = tb_price.Text;
            description = tb_description.Text;
            if (type.IsNullOrEmpty() || tourName.IsNullOrEmpty() || transportation.IsNullOrEmpty() || price.IsNullOrEmpty() || description.IsNullOrEmpty())
                {
                MessageBox.Show("Hãy điền đầy đủ thông tin Tour");
                }
            else
                {
                decimal value;
                if (decimal.TryParse(price, out value))
                    {
                    if (MessageBox.Show("Bạn có muốn thêm Tour này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                        TourBLL.addTour(new DTO_Data_Transfer_Object.Tour_DTO(tourName, type, value, transportation, description));
                        Tour_Load(sender, e);
                        MessageBox.Show("Thêm Tour thành công.");
                        }

                    }
                else
                    {
                    MessageBox.Show("Giá Tour không hợp lệ!");
                    }

                }
            }
        private void button_edit_Click(object sender, EventArgs e)
            {
            type = tb_type.Text;
            tourName = tb_name.Text;
            transportation = tb_transportation.Text;
            price = tb_price.Text;
            description = tb_description.Text;
            decimal value;
            if (!decimal.TryParse(price, out value))
                {
                MessageBox.Show("Giá Tour không hợp lệ!");
                }
            if (MessageBox.Show("Bạn có muốn chỉnh sửa thông tin Tour này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                TourBLL.updateTour(new DTO_Data_Transfer_Object.Tour_DTO(tourName, type, Decimal.Parse(price), transportation, description), tourId);
                Tour_Load(sender, e);
                }
            }
        private void button_delete_Click(object sender, EventArgs e)
            {
            if (dataGridView1.SelectedRows.Count < 0)
                {
                MessageBox.Show("Vui lòng chọn một dòng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
                }
            if (MessageBox.Show("Bạn có muốn xóa Tour này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                TourBLL.deleteTour(tourId);
                Tour_Load(sender, e);
                MessageBox.Show("Xóa khách hàng thành công.");
                }

            }
        }
    }
