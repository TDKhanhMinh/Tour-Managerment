namespace TOUR_MANAGERMENT.View
{
    partial class Home
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
            button_logout = new Button();
            button_schedule = new Button();
            button_staff = new Button();
            button4 = new Button();
            button3 = new Button();
            button1 = new Button();
            button_home = new Button();
            pictureBox1 = new PictureBox();
            button_manager_customer = new Button();
            panel2 = new Panel();
            iconButton_name = new FontAwesome.Sharp.IconButton();
            label_top = new Label();
            panel_body = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Aqua;
            panel1.Controls.Add(button_logout);
            panel1.Controls.Add(button_schedule);
            panel1.Controls.Add(button_staff);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button_home);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(button_manager_customer);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(220, 668);
            panel1.TabIndex = 0;
            // 
            // button_logout
            // 
            button_logout.Location = new Point(12, 611);
            button_logout.Name = "button_logout";
            button_logout.Size = new Size(188, 45);
            button_logout.TabIndex = 10;
            button_logout.Text = "Đăng xuất";
            button_logout.UseVisualStyleBackColor = true;
            button_logout.Click += button_logout_Click;
            // 
            // button_schedule
            // 
            button_schedule.Location = new Point(12, 349);
            button_schedule.Name = "button_schedule";
            button_schedule.Size = new Size(188, 45);
            button_schedule.TabIndex = 9;
            button_schedule.Text = "Quản Lý Lịch Trình";
            button_schedule.UseVisualStyleBackColor = true;
            button_schedule.Click += button2_Click;
            // 
            // button_staff
            // 
            button_staff.Location = new Point(12, 546);
            button_staff.Name = "button_staff";
            button_staff.Size = new Size(188, 45);
            button_staff.TabIndex = 8;
            button_staff.Text = "Quản lý nhân viên";
            button_staff.UseVisualStyleBackColor = true;
            button_staff.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(12, 483);
            button4.Name = "button4";
            button4.Size = new Size(188, 45);
            button4.TabIndex = 7;
            button4.Text = "Thống kê";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(12, 418);
            button3.Name = "button3";
            button3.Size = new Size(188, 45);
            button3.TabIndex = 6;
            button3.Text = "Quản lý Booking";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 287);
            button1.Name = "button1";
            button1.Size = new Size(188, 45);
            button1.TabIndex = 4;
            button1.Text = "Quản lý Tour";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button_home
            // 
            button_home.Location = new Point(12, 154);
            button_home.Name = "button_home";
            button_home.Size = new Size(188, 45);
            button_home.TabIndex = 3;
            button_home.Text = "Trang Chủ";
            button_home.UseVisualStyleBackColor = true;
            button_home.Click += button_home_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = Properties.Resources.c085ad076c442c8191e6b7f48ef59aad;
            pictureBox1.Location = new Point(34, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(131, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // button_manager_customer
            // 
            button_manager_customer.Location = new Point(12, 223);
            button_manager_customer.Name = "button_manager_customer";
            button_manager_customer.Size = new Size(188, 45);
            button_manager_customer.TabIndex = 2;
            button_manager_customer.Text = "Quản Lý Khách Hàng";
            button_manager_customer.UseVisualStyleBackColor = true;
            button_manager_customer.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Aqua;
            panel2.Controls.Add(iconButton_name);
            panel2.Controls.Add(label_top);
            panel2.Dock = DockStyle.Top;
            panel2.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel2.Location = new Point(220, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1223, 112);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // iconButton_name
            // 
            iconButton_name.ForeColor = SystemColors.ActiveCaptionText;
            iconButton_name.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            iconButton_name.IconColor = Color.Black;
            iconButton_name.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton_name.IconSize = 32;
            iconButton_name.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton_name.Location = new Point(6, 35);
            iconButton_name.Name = "iconButton_name";
            iconButton_name.Size = new Size(369, 35);
            iconButton_name.TabIndex = 2;
            iconButton_name.UseVisualStyleBackColor = true;
            // 
            // label_top
            // 
            label_top.AutoSize = true;
            label_top.BackColor = Color.Cyan;
            label_top.Font = new Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_top.Location = new Point(686, 35);
            label_top.Name = "label_top";
            label_top.Size = new Size(184, 40);
            label_top.TabIndex = 0;
            label_top.Text = "Trang Chủ";
            label_top.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel_body
            // 
            panel_body.BorderStyle = BorderStyle.Fixed3D;
            panel_body.Dock = DockStyle.Fill;
            panel_body.Location = new Point(220, 112);
            panel_body.Name = "panel_body";
            panel_body.Size = new Size(1223, 556);
            panel_body.TabIndex = 2;
            panel_body.Paint += panel3_Paint;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1443, 668);
            Controls.Add(panel_body);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "Home";
            Text = "Home";
            Load += Home_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button button_manager_customer;
        private Label label_top;
        private PictureBox pictureBox1;
        private Panel panel_body;
        private Button button_home;
        private Button button_schedule;
        private Button button_staff;
        private Button button4;
        private Button button3;
        private Button button1;
        private FontAwesome.Sharp.IconButton iconButton_name;
        private Button button_logout;
        }
}