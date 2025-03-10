using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Office2010.PowerPoint;
using TOUR_MANAGERMENT.BLL_Business_Logic_Layer;

namespace TOUR_MANAGERMENT.View
{
    public partial class Booking : Form
    {
        private bool shouldReload = false;
        private List<string> customerNames;
        private List<string> tourNames;
        public Booking()
        {
            InitializeComponent();
        }

       

        //private void Booking_Load(object sender, EventArgs e)
        //{
        //    dataGridView1.DataSource = BookingBLL.findAllBookingData();
        //    dataGridView1.Columns["bookingId"].Visible = false;
        //    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        //    dataGridView1.Columns["tourname"].HeaderText = "Tên Tour";
        //    dataGridView1.Columns["customerName"].HeaderText = "Tên khách hàng";
        //    dataGridView1.Columns["status"].HeaderText = "Trạng thái";
        //    dataGridView1.Columns["date"].HeaderText = "Ngày book";

        //    comboBox1.DataSource = TourBLL.findAllTourData();
        //    comboBox1.DisplayMember = "tourName";
        //    comboBox1.ValueMember = "tourId";
        //    comboBox1.SelectedIndex = -1;

        //    comboBox2.DataSource = CustomerBLL.fullName();
        //    comboBox2.DisplayMember = "fullName";
        //    comboBox2.ValueMember = "customerId";
        //    comboBox2.SelectedIndex = -1;

        //    comboBox3.Items.Add("Đã cọc");
        //    comboBox3.Items.Add("Đã thanh toán");
        //    comboBox3.Items.Add("Hoàn thành");
        //    comboBox3.SelectedIndex = -1;


        //}
        private void Booking_Load(object sender, EventArgs e)
        {
            LoadBookingData();

            if (comboBox3.Items.Count == 0)
            {
                comboBox3.Items.Add("Đã cọc");
                comboBox3.Items.Add("Đã thanh toán");
                comboBox3.Items.Add("Hoàn thành");
                comboBox3.SelectedIndex = -1;
            }
        }

        private void LoadBookingData()
        {
            dataGridView1.DataSource = BookingBLL.findAllBookingData();
            dataGridView1.Columns["bookingId"].Visible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.Columns["tourname"].HeaderText = "Tên Tour";
            dataGridView1.Columns["customerName"].HeaderText = "Tên khách hàng";
            dataGridView1.Columns["status"].HeaderText = "Trạng thái";
            dataGridView1.Columns["date"].HeaderText = "Ngày book";

            comboBox1.DataSource = TourBLL.findAllTourData();
            comboBox1.DisplayMember = "tourName";
            comboBox1.ValueMember = "tourId";
            comboBox1.SelectedIndex = -1;
      


            comboBox2.DataSource = CustomerBLL.fullName();
            comboBox2.DisplayMember = "fullName";
            comboBox2.ValueMember = "customerId";
            comboBox2.SelectedIndex = -1;


            comboBox2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox2.AutoCompleteSource = AutoCompleteSource.CustomSource;
            comboBox2.AutoCompleteCustomSource = GetSuggestions(CustomerBLL.fullName(), "fullName");
            comboBox2.DropDownStyle = ComboBoxStyle.DropDown;

            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            comboBox1.AutoCompleteCustomSource = GetSuggestions(TourBLL.findAllTourData(), "tourName");
            comboBox1.DropDownStyle = ComboBoxStyle.DropDown;


        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                if (row.Cells["bookingId"].Value != null)
                {
                    dataGridView1.Rows[e.RowIndex].Selected = true;

                }
                else
                {

                }


            }
        }
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dataGridView1.ClearSelection();
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dataGridView1.Rows[e.RowIndex].Selected = true;
                DateTime date = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["date"].Value);
                object bookingId = dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                object tourValue = dataGridView1.Rows[e.RowIndex].Cells[4].Value;
                object customerValue = dataGridView1.Rows[e.RowIndex].Cells[3].Value;

                int tourId = -1;
                for (int i = 0; i < comboBox1.Items.Count; i++)
                {
                    if (comboBox1.GetItemText(comboBox1.Items[i]) == tourValue?.ToString())
                    {
                        tourId = i;
                        break;
                    }
                }

                int customerId = -1;
                for (int i = 0; i < comboBox2.Items.Count; i++)
                {
                    if (comboBox2.GetItemText(comboBox2.Items[i]) == customerValue?.ToString())
                    {
                        customerId = i;
                        break;
                    }
                }
                string status = dataGridView1.Rows[e.RowIndex].Cells["status"].Value.ToString()?? "Đã cọc";
                
                ContextMenuStrip contextMenu = new ContextMenuStrip();
                contextMenu.Items.Add("Xóa Booking").Click += (s, ev) =>
                {
                    DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa dòng này?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        BookingBLL.deleteBooking((int)dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                        dataGridView1.Rows.RemoveAt(e.RowIndex);
                        MessageBox.Show("Xóa thành công");
                    }

                };
                contextMenu.Items.Add("Chỉnh sửa").Click += (s, ev) =>
                {
                    UpdateBooking updateForm = new UpdateBooking(new DTO_Data_Transfer_Object.Booking_DTO(
                        date, status, tourId, customerId, (int)bookingId));

                    updateForm.StartPosition = FormStartPosition.CenterScreen; 
                    updateForm.FormClosed += (sender, args) => shouldReload = true; 

                    updateForm.OnBookingUpdated += LoadBookingData;
                    updateForm.ShowDialog();
                };
                contextMenu.Show(dataGridView1, dataGridView1.PointToClient(Cursor.Position));
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedIndex < 0 || comboBox2.SelectedIndex < 0 || comboBox3.SelectedIndex < 0)
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin các trường");
                    return;
                }
                else
                {
                    if (MessageBox.Show("Xác nhận tạo Booking?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        
                        BookingBLL.createBooking(new DTO_Data_Transfer_Object.Booking_DTO(
                            dateTimePicker1.Value,
                            comboBox3.SelectedItem?.ToString()??"Đã cọc", 
                            Convert.ToInt32(comboBox1.SelectedValue), 
                            Convert.ToInt32(comboBox2.SelectedValue)));
                        MessageBox.Show("Thêm thành công");
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private AutoCompleteStringCollection GetSuggestions(DataTable table, string columnName)
        {
            AutoCompleteStringCollection suggestions = new AutoCompleteStringCollection();

            if (table != null && table.Rows.Count > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    suggestions.Add(row[columnName].ToString());
                }
            }

            return suggestions;
        }

    }


}
 