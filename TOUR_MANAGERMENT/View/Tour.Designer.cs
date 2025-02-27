namespace TOUR_MANAGERMENT.View
    {
    partial class Tour
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
            groupBox3 = new GroupBox();
            dataGridView1 = new DataGridView();
            button_delete = new Button();
            button_edit = new Button();
            button_add = new Button();
            groupBox2 = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tb_name = new TextBox();
            tb_description = new TextBox();
            tb_transportation = new TextBox();
            tb_price = new TextBox();
            tb_type = new TextBox();
            button1_excel = new Button();
            label6 = new Label();
            groupBox1 = new GroupBox();
            textBox_find = new TextBox();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(0, 135);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(900, 605);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh sách Tour";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(894, 576);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
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
            groupBox2.Controls.Add(tb_name);
            groupBox2.Controls.Add(tb_description);
            groupBox2.Controls.Add(tb_transportation);
            groupBox2.Controls.Add(tb_price);
            groupBox2.Controls.Add(tb_type);
            groupBox2.Dock = DockStyle.Right;
            groupBox2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(900, 135);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(549, 605);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thêm Tour";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 10.8F);
            label5.Location = new Point(31, 347);
            label5.Name = "label5";
            label5.Size = new Size(55, 21);
            label5.TabIndex = 11;
            label5.Text = "Mô tả";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 10.8F);
            label4.Location = new Point(31, 264);
            label4.Name = "label4";
            label4.Size = new Size(192, 21);
            label4.TabIndex = 10;
            label4.Text = "Phương tiện di chuyển";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10.8F);
            label3.Location = new Point(31, 190);
            label3.Name = "label3";
            label3.Size = new Size(38, 21);
            label3.TabIndex = 9;
            label3.Text = "Giá";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10.8F);
            label2.Location = new Point(31, 114);
            label2.Name = "label2";
            label2.Size = new Size(91, 21);
            label2.TabIndex = 8;
            label2.Text = "Phân Loại";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10.8F);
            label1.Location = new Point(31, 44);
            label1.Name = "label1";
            label1.Size = new Size(83, 21);
            label1.TabIndex = 7;
            label1.Text = "Tên Tour";
            // 
            // tb_name
            // 
            tb_name.Location = new Point(31, 68);
            tb_name.Name = "tb_name";
            tb_name.Size = new Size(458, 30);
            tb_name.TabIndex = 6;
            // 
            // tb_description
            // 
            tb_description.Location = new Point(31, 371);
            tb_description.Multiline = true;
            tb_description.Name = "tb_description";
            tb_description.Size = new Size(458, 81);
            tb_description.TabIndex = 4;
            // 
            // tb_transportation
            // 
            tb_transportation.Location = new Point(31, 288);
            tb_transportation.Name = "tb_transportation";
            tb_transportation.Size = new Size(458, 30);
            tb_transportation.TabIndex = 3;
            // 
            // tb_price
            // 
            tb_price.Location = new Point(31, 214);
            tb_price.Name = "tb_price";
            tb_price.Size = new Size(458, 30);
            tb_price.TabIndex = 2;
            // 
            // tb_type
            // 
            tb_type.Location = new Point(31, 138);
            tb_type.Name = "tb_type";
            tb_type.Size = new Size(458, 30);
            tb_type.TabIndex = 1;
            // 
            // button1_excel
            // 
            button1_excel.Location = new Point(931, 71);
            button1_excel.Name = "button1_excel";
            button1_excel.Size = new Size(271, 45);
            button1_excel.TabIndex = 2;
            button1_excel.Text = "Lưu vào Excel";
            button1_excel.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(75, 45);
            label6.Name = "label6";
            label6.Size = new Size(209, 23);
            label6.TabIndex = 1;
            label6.Text = "Nhập từ khóa tìm kiếm";
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
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm kiếm Tour";
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
            // Tour
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1449, 740);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Tour";
            Text = "Tour";
            Load += Tour_Load;
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            }

        #endregion

        private GroupBox groupBox3;
        private DataGridView dataGridView1;
        private Button button_delete;
        private Button button_edit;
        private Button button_add;
        private GroupBox groupBox2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox tb_name;
        private TextBox tb_description;
        private TextBox tb_transportation;
        private TextBox tb_price;
        private TextBox tb_type;
        private Button button1_excel;
        private Label label6;
        private GroupBox groupBox1;
        private TextBox textBox_find;
        }
    }