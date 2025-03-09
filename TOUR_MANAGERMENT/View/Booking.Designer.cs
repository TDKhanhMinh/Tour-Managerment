namespace TOUR_MANAGERMENT.View
{
    partial class Booking
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
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            groupBox3 = new GroupBox();
            dataGridView1 = new DataGridView();
            button_add = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dateTimePicker1 = new DateTimePicker();
            comboBox3 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            groupBox1 = new GroupBox();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
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
            groupBox3.Text = "Danh sách Booking";
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
            dataGridView1.CellMouseClick += dataGridView1_CellMouseClick;
            // 
            // button_add
            // 
            button_add.Font = new Font("Microsoft Sans Serif", 8.25F);
            button_add.Location = new Point(194, 392);
            button_add.Name = "button_add";
            button_add.Size = new Size(140, 39);
            button_add.TabIndex = 12;
            button_add.Text = "Thêm khách hàng";
            button_add.UseVisualStyleBackColor = true;
            button_add.Click += button_add_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 10.8F);
            label4.Location = new Point(31, 286);
            label4.Name = "label4";
            label4.Size = new Size(96, 21);
            label4.TabIndex = 10;
            label4.Text = "Ngày book";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10.8F);
            label3.Location = new Point(31, 213);
            label3.Name = "label3";
            label3.Size = new Size(91, 21);
            label3.TabIndex = 9;
            label3.Text = "Trạng thái";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10.8F);
            label2.Location = new Point(31, 129);
            label2.Name = "label2";
            label2.Size = new Size(140, 21);
            label2.TabIndex = 8;
            label2.Text = "Tên khách hàng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10.8F);
            label1.Location = new Point(31, 54);
            label1.Name = "label1";
            label1.Size = new Size(83, 21);
            label1.TabIndex = 7;
            label1.Text = "Tên Tour";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dateTimePicker1);
            groupBox2.Controls.Add(comboBox3);
            groupBox2.Controls.Add(comboBox2);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(button_add);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Dock = DockStyle.Right;
            groupBox2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(900, 135);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(549, 605);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin Booking";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(31, 322);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(458, 30);
            dateTimePicker1.TabIndex = 18;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(31, 237);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(458, 31);
            comboBox3.TabIndex = 17;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(31, 153);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(458, 31);
            comboBox2.TabIndex = 16;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(31, 78);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(458, 31);
            comboBox1.TabIndex = 15;
            // 
            // groupBox1
            // 
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1449, 135);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm kiếm Booking";
            // 
            // Booking
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1449, 740);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Booking";
            Text = "Booking";
           
            Load += Booking_Load;
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private GroupBox groupBox3;
        private DataGridView dataGridView1;
        private Button button_add;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
    }
}