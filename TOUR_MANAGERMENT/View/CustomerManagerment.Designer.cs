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
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            groupBox2 = new GroupBox();
            button2 = new Button();
            button1 = new Button();
            button_add = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox7 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1449, 135);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm kiếm khách hàng";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(78, 60);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(483, 30);
            textBox1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 135);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1449, 605);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(button_add);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(textBox7);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(textBox2);
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
            // button2
            // 
            button2.Font = new Font("Microsoft Sans Serif", 8.25F);
            button2.Location = new Point(349, 472);
            button2.Name = "button2";
            button2.Size = new Size(140, 39);
            button2.TabIndex = 14;
            button2.Text = "Xóa khách hàng";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 8.25F);
            button1.Location = new Point(188, 472);
            button1.Name = "button1";
            button1.Size = new Size(140, 39);
            button1.TabIndex = 13;
            button1.Text = "Sửa thông tin";
            button1.UseVisualStyleBackColor = true;
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
            // textBox7
            // 
            textBox7.Location = new Point(31, 155);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(458, 30);
            textBox7.TabIndex = 6;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(31, 390);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(458, 30);
            textBox5.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(31, 312);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(458, 30);
            textBox4.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(31, 239);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(458, 30);
            textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(31, 80);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(458, 30);
            textBox2.TabIndex = 1;
            // 
            // CustomerManagerment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1449, 740);
            Controls.Add(groupBox2);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Name = "CustomerManagerment";
            Text = "CustomerManagerment";
            Load += CustomerManagerment_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private GroupBox groupBox2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox7;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private Label label2;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button button_add;
        private Button button2;
        private Button button1;
    }
}