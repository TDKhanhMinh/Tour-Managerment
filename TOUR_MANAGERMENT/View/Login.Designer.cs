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
            SuspendLayout();
            // 
            // username_Input
            // 
            username_Input.Font = new Font("Segoe UI", 12F);
            username_Input.Location = new Point(170, 222);
            username_Input.Name = "username_Input";
            username_Input.Size = new Size(299, 34);
            username_Input.TabIndex = 0;
            username_Input.TextChanged += textBox1_TextChanged;
            // 
            // password_Input
            // 
            password_Input.Font = new Font("Segoe UI", 12F);
            password_Input.Location = new Point(170, 288);
            password_Input.Name = "password_Input";
            password_Input.PasswordChar = '*';
            password_Input.Size = new Size(299, 34);
            password_Input.TabIndex = 1;
            password_Input.TextChanged += password_Input_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.AliceBlue;
            label1.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(27, 224);
            label1.Name = "label1";
            label1.Size = new Size(113, 31);
            label1.TabIndex = 2;
            label1.Text = "Tài khoản";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.AliceBlue;
            label2.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(27, 288);
            label2.Name = "label2";
            label2.Size = new Size(112, 31);
            label2.TabIndex = 3;
            label2.Text = "Mật khẩu";
            label2.Click += label2_Click;
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.Cyan;
            loginBtn.Font = new Font("Segoe UI", 11F);
            loginBtn.ForeColor = Color.Black;
            loginBtn.Location = new Point(337, 369);
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
            forgot_password.Location = new Point(170, 335);
            forgot_password.Name = "forgot_password";
            forgot_password.Size = new Size(109, 20);
            forgot_password.TabIndex = 5;
            forgot_password.TabStop = true;
            forgot_password.Text = "Quên mật khẩu";
            forgot_password.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.istockphoto_1400224853_612x612;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1095, 500);
            Controls.Add(forgot_password);
            Controls.Add(loginBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(password_Input);
            Controls.Add(username_Input);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox username_Input;
        private TextBox password_Input;
        private Label label1;
        private Label label2;
        private Button loginBtn;
        private LinkLabel forgot_password;
    }
}