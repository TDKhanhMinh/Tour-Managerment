namespace TOUR_MANAGERMENT.View
{
    public partial class Login
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
            username_Input = new TextBox();
            password_Input = new TextBox();
            label1 = new Label();
            label2 = new Label();
            loginBtn = new Button();
            forgot_password = new LinkLabel();
            groupBox1 = new GroupBox();
            label3 = new Label();
            panel1 = new Panel();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // username_Input
            // 
            username_Input.Font = new Font("Segoe UI", 12F);
            username_Input.Location = new Point(26, 82);
            username_Input.Name = "username_Input";
            username_Input.Size = new Size(410, 34);
            username_Input.TabIndex = 0;
            username_Input.TextChanged += textBox1_TextChanged;
            // 
            // password_Input
            // 
            password_Input.Font = new Font("Segoe UI", 12F);
            password_Input.Location = new Point(26, 165);
            password_Input.Name = "password_Input";
            password_Input.PasswordChar = '*';
            password_Input.Size = new Size(410, 34);
            password_Input.TabIndex = 1;
            password_Input.TextChanged += password_Input_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 57);
            label1.Name = "label1";
            label1.Size = new Size(94, 22);
            label1.TabIndex = 2;
            label1.Text = "Tài khoản";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(26, 140);
            label2.Name = "label2";
            label2.Size = new Size(92, 22);
            label2.TabIndex = 3;
            label2.Text = "Mật khẩu";
            label2.Click += label2_Click;
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.Black;
            loginBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginBtn.ForeColor = Color.White;
            loginBtn.Location = new Point(304, 208);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(132, 44);
            loginBtn.TabIndex = 4;
            loginBtn.Text = "Đăng nhập";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += button1_Click;
            // 
            // forgot_password
            // 
            forgot_password.AutoSize = true;
            forgot_password.DisabledLinkColor = Color.AliceBlue;
            forgot_password.Location = new Point(26, 222);
            forgot_password.Name = "forgot_password";
            forgot_password.Size = new Size(109, 20);
            forgot_password.TabIndex = 5;
            forgot_password.TabStop = true;
            forgot_password.Text = "Quên mật khẩu";
            forgot_password.LinkClicked += linkLabel1_LinkClicked;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.BackgroundImageLayout = ImageLayout.None;
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(username_Input);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(forgot_password);
            groupBox1.Controls.Add(password_Input);
            groupBox1.Controls.Add(loginBtn);
            groupBox1.Location = new Point(25, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(462, 280);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(154, 23);
            label3.Name = "label3";
            label3.Size = new Size(160, 33);
            label3.TabIndex = 6;
            label3.Text = "Đăng nhập";
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox1);
            panel1.Location = new Point(57, 278);
            panel1.Name = "panel1";
            panel1.Size = new Size(523, 344);
            panel1.TabIndex = 7;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.istockphoto_1400224853_612x612;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1346, 657);
            Controls.Add(panel1);
            Name = "Login";
            Text = "Login";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox username_Input;
        private TextBox password_Input;
        private Label label1;
        private Label label2;
        private Button loginBtn;
        private LinkLabel forgot_password;
        private GroupBox groupBox1;
        private Label label3;
        private Panel panel1;
    }
}