namespace TOUR_MANAGERMENT.View
{
    partial class CustomerManagerment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
            {
            groupBox1 = new GroupBox();
            button1_excel = new Button();
            label6 = new Label();
            textBox_find = new TextBox();
            groupBox2 = new GroupBox();
            button_delete = new Button();
            button_edit = new Button();
            button_add = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox_lastname = new TextBox();
            textBox_address = new TextBox();
            textBox_email = new TextBox();
            textBox_phone = new TextBox();
            textBox_firstname = new TextBox();
            groupBox3 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1_excel);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textBox_find);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1449, 135);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm kiếm khách hàng";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button1_excel
            // 
            button1_excel.Location = new Point(931, 71);
            button1_excel.Name = "button1_excel";
            button1_excel.Size = new Size(271, 45);
            button1_excel.TabIndex = 2;
            button1_excel.Text = "Lưu vào Excel";
            button1_excel.UseVisualStyleBackColor = true;
            button1_excel.Click += button1_excel_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(75, 45);
            label6.Name = "label6";
            label6.Size = new Size(467, 23);
            label6.TabIndex = 1;
            label6.Text = "Nhập tên hoặc số điện thoại khách hàng để tìm kiếm";
            // 
            // textBox_find
            // 
            textBox_find.Font = new Font("Arial", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_find.ForeColor = Color.Silver;
            textBox_find.Location = new Point(75, 71);
            textBox_find.Multiline = true;
            textBox_find.Name = "textBox_find";
            textBox_find.Size = new Size(483, 42);
            textBox_find.TabIndex = 0;
            textBox_find.TextChanged += textBox_find_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button_delete);
            groupBox2.Controls.Add(button_edit);
            groupBox2.Controls.Add(button_add);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(textBox_lastname);
            groupBox2.Controls.Add(textBox_address);
            groupBox2.Controls.Add(textBox_email);
            groupBox2.Controls.Add(textBox_phone);
            groupBox2.Controls.Add(textBox_firstname);
            groupBox2.Dock = DockStyle.Right;
            groupBox2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(900, 135);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(549, 605);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin khách hàng";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // button_delete
            // 
            button_delete.Font = new Font("Microsoft Sans Serif", 8.25F);
            button_delete.Location = new Point(349, 472);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(140, 39);
            button_delete.TabIndex = 14;
            button_delete.Text = "Xóa khách hàng";
            button_delete.UseVisualStyleBackColor = true;
            button_delete.Click += button_delete_Click;
            // 
            // button_edit
            // 
            button_edit.Font = new Font("Microsoft Sans Serif", 8.25F);
            button_edit.Location = new Point(188, 472);
            button_edit.Name = "button_edit";
            button_edit.Size = new Size(140, 39);
            button_edit.TabIndex = 13;
            button_edit.Text = "Sửa thông tin";
            button_edit.UseVisualStyleBackColor = true;
            button_edit.Click += button_edit_Click;
            // 
            // button_add
            // 
            button_add.Font = new Font("Microsoft Sans Serif", 8.25F);
            button_add.Location = new Point(31, 472);
            button_add.Name = "button_add";
            button_add.Size = new Size(140, 39);
            button_add.TabIndex = 12;
            button_add.Text = "Thêm khách hàng";
            button_add.UseVisualStyleBackColor = true;
            button_add.Click += button_add_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 10.8F);
            label5.Location = new Point(31, 364);
            label5.Name = "label5";
            label5.Size = new Size(65, 21);
            label5.TabIndex = 11;
            label5.Text = "Địa chỉ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 10.8F);
            label4.Location = new Point(31, 286);
            label4.Name = "label4";
            label4.Size = new Size(54, 21);
            label4.TabIndex = 10;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10.8F);
            label3.Location = new Point(31, 213);
            label3.Name = "label3";
            label3.Size = new Size(115, 21);
            label3.TabIndex = 9;
            label3.Text = "Số điện thoại";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10.8F);
            label2.Location = new Point(31, 129);
            label2.Name = "label2";
            label2.Size = new Size(42, 21);
            label2.TabIndex = 8;
            label2.Text = "Tên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10.8F);
            label1.Location = new Point(31, 54);
            label1.Name = "label1";
            label1.Size = new Size(33, 21);
            label1.TabIndex = 7;
            label1.Text = "Họ";
            // 
            // textBox_lastname
            // 
            textBox_lastname.Location = new Point(31, 78);
            textBox_lastname.Name = "textBox_lastname";
            textBox_lastname.Size = new Size(458, 30);
            textBox_lastname.TabIndex = 6;
            textBox_lastname.TextChanged += textBox_lastname_TextChanged;
            // 
            // textBox_address
            // 
            textBox_address.Location = new Point(31, 390);
            textBox_address.Name = "textBox_address";
            textBox_address.Size = new Size(458, 30);
            textBox_address.TabIndex = 4;
            textBox_address.TextChanged += textBox_address_TextChanged;
            // 
            // textBox_email
            // 
            textBox_email.Location = new Point(31, 312);
            textBox_email.Name = "textBox_email";
            textBox_email.Size = new Size(458, 30);
            textBox_email.TabIndex = 3;
            textBox_email.TextChanged += textBox_email_TextChanged;
            // 
            // textBox_phone
            // 
            textBox_phone.Location = new Point(31, 239);
            textBox_phone.Name = "textBox_phone";
            textBox_phone.Size = new Size(458, 30);
            textBox_phone.TabIndex = 2;
            textBox_phone.TextChanged += textBox_phone_TextChanged;
            // 
            // textBox_firstname
            // 
            textBox_firstname.Location = new Point(31, 153);
            textBox_firstname.Name = "textBox_firstname";
            textBox_firstname.Size = new Size(458, 30);
            textBox_firstname.TabIndex = 1;
            textBox_firstname.TextChanged += textBox_firstname_TextChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(0, 135);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(900, 605);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh sách khách hàng";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(894, 576);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // CustomerManagerment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1449, 740);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "CustomerManagerment";
            Text = "CustomerManagerment";
            Load += CustomerManagerment_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox textBox_find;
        private TextBox textBox_firstname;
        private TextBox textBox_lastname;
        private TextBox textBox_address;
        private TextBox textBox_email;
        private TextBox textBox_phone;
        private Label label2;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button button_add;
        private Button button_delete;
        private Button button_edit;
        private GroupBox groupBox3;
        private DataGridView dataGridView1;
        private Label label6;
        private Button button1_excel;
        }
}