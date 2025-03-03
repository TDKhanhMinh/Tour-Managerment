namespace TOUR_MANAGERMENT.View
    {
    partial class Staff
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
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            textBox_search = new TextBox();
            panel3 = new Panel();
            groupBox3 = new GroupBox();
            label6 = new Label();
            label7 = new Label();
            textBox_pwd = new TextBox();
            textBox_username = new TextBox();
            button_delete = new Button();
            button_edit = new Button();
            button_add = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox_fullname = new TextBox();
            textBox_address = new TextBox();
            textBox_gender = new TextBox();
            textBox_phone = new TextBox();
            textBox_age = new TextBox();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel3.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1411, 125);
            panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox_search);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1411, 125);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm kiến nhân viên";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // textBox_search
            // 
            textBox_search.Location = new Point(73, 57);
            textBox_search.Name = "textBox_search";
            textBox_search.Size = new Size(374, 34);
            textBox_search.TabIndex = 0;
            textBox_search.TextChanged += textBox_search_TextChanged;
            // 
            // panel3
            // 
            panel3.Controls.Add(groupBox3);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(882, 125);
            panel3.Name = "panel3";
            panel3.Size = new Size(529, 681);
            panel3.TabIndex = 2;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(textBox_pwd);
            groupBox3.Controls.Add(textBox_username);
            groupBox3.Controls.Add(button_delete);
            groupBox3.Controls.Add(button_edit);
            groupBox3.Controls.Add(button_add);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(textBox_fullname);
            groupBox3.Controls.Add(textBox_address);
            groupBox3.Controls.Add(textBox_gender);
            groupBox3.Controls.Add(textBox_phone);
            groupBox3.Controls.Add(textBox_age);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(0, 0);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(529, 681);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông tin nhân viên";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 10.8F);
            label6.Location = new Point(35, 507);
            label6.Name = "label6";
            label6.Size = new Size(84, 21);
            label6.TabIndex = 31;
            label6.Text = "Mật khẩu";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 10.8F);
            label7.Location = new Point(35, 429);
            label7.Name = "label7";
            label7.Size = new Size(90, 21);
            label7.TabIndex = 30;
            label7.Text = "Tài khoản";
            // 
            // textBox_pwd
            // 
            textBox_pwd.Location = new Point(35, 533);
            textBox_pwd.Name = "textBox_pwd";
            textBox_pwd.Size = new Size(458, 34);
            textBox_pwd.TabIndex = 29;
            // 
            // textBox_username
            // 
            textBox_username.Location = new Point(35, 455);
            textBox_username.Name = "textBox_username";
            textBox_username.Size = new Size(458, 34);
            textBox_username.TabIndex = 28;
            // 
            // button_delete
            // 
            button_delete.Font = new Font("Microsoft Sans Serif", 8.25F);
            button_delete.Location = new Point(353, 616);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(140, 39);
            button_delete.TabIndex = 27;
            button_delete.Text = "Xóa nhân viên";
            button_delete.UseVisualStyleBackColor = true;
            button_delete.Click += button_delete_Click;
            // 
            // button_edit
            // 
            button_edit.Font = new Font("Microsoft Sans Serif", 8.25F);
            button_edit.Location = new Point(192, 616);
            button_edit.Name = "button_edit";
            button_edit.Size = new Size(140, 39);
            button_edit.TabIndex = 26;
            button_edit.Text = "Sửa thông tin";
            button_edit.UseVisualStyleBackColor = true;
            button_edit.Click += button_edit_Click;
            // 
            // button_add
            // 
            button_add.Font = new Font("Microsoft Sans Serif", 8.25F);
            button_add.Location = new Point(35, 616);
            button_add.Name = "button_add";
            button_add.Size = new Size(140, 39);
            button_add.TabIndex = 25;
            button_add.Text = "Thêm nhân viên";
            button_add.UseVisualStyleBackColor = true;
            button_add.Click += button_add_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 10.8F);
            label5.Location = new Point(35, 352);
            label5.Name = "label5";
            label5.Size = new Size(65, 21);
            label5.TabIndex = 24;
            label5.Text = "Địa chỉ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 10.8F);
            label4.Location = new Point(35, 274);
            label4.Name = "label4";
            label4.Size = new Size(79, 21);
            label4.TabIndex = 23;
            label4.Text = "Giới tính";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10.8F);
            label3.Location = new Point(35, 201);
            label3.Name = "label3";
            label3.Size = new Size(115, 21);
            label3.TabIndex = 22;
            label3.Text = "Số điện thoại";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10.8F);
            label2.Location = new Point(35, 117);
            label2.Name = "label2";
            label2.Size = new Size(45, 21);
            label2.TabIndex = 21;
            label2.Text = "Tuổi";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10.8F);
            label1.Location = new Point(35, 42);
            label1.Name = "label1";
            label1.Size = new Size(87, 21);
            label1.TabIndex = 20;
            label1.Text = "Họ và tên";
            // 
            // textBox_fullname
            // 
            textBox_fullname.Location = new Point(35, 66);
            textBox_fullname.Name = "textBox_fullname";
            textBox_fullname.Size = new Size(458, 34);
            textBox_fullname.TabIndex = 19;
            // 
            // textBox_address
            // 
            textBox_address.Location = new Point(35, 378);
            textBox_address.Name = "textBox_address";
            textBox_address.Size = new Size(458, 34);
            textBox_address.TabIndex = 18;
            // 
            // textBox_gender
            // 
            textBox_gender.Location = new Point(35, 300);
            textBox_gender.Name = "textBox_gender";
            textBox_gender.Size = new Size(458, 34);
            textBox_gender.TabIndex = 17;
            // 
            // textBox_phone
            // 
            textBox_phone.Location = new Point(35, 227);
            textBox_phone.Name = "textBox_phone";
            textBox_phone.Size = new Size(458, 34);
            textBox_phone.TabIndex = 16;
            // 
            // textBox_age
            // 
            textBox_age.Location = new Point(35, 141);
            textBox_age.Name = "textBox_age";
            textBox_age.Size = new Size(458, 34);
            textBox_age.TabIndex = 15;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(0, 125);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(882, 681);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách nhân viên";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 30);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(876, 648);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Staff
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1411, 806);
            Controls.Add(groupBox2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "Staff";
            Text = "Staff";
            Load += Staff_Load;
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel3.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private TextBox textBox_search;
        private Button button_delete;
        private Button button_edit;
        private Button button_add;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox_fullname;
        private TextBox textBox_address;
        private TextBox textBox_gender;
        private TextBox textBox_phone;
        private TextBox textBox_age;
        private Label label6;
        private Label label7;
        private TextBox textBox_pwd;
        private TextBox textBox_username;
        }
    }