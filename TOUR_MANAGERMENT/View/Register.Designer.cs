namespace TOUR_MANAGERMENT.View
{
    public partial class Register
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
            username_input = new TextBox();
            pwd_input = new TextBox();
            address_input = new TextBox();
            email_input = new TextBox();
            phone_input = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            register_btn = new Button();
            cancle_btn = new Button();
            SuspendLayout();
            // 
            // username_input
            // 
            username_input.Font = new Font("Segoe UI", 10F);
            username_input.Location = new Point(182, 306);
            username_input.Name = "username_input";
            username_input.Size = new Size(336, 30);
            username_input.TabIndex = 0;
            username_input.TextChanged += textBox1_TextChanged_1;
            // 
            // pwd_input
            // 
            pwd_input.Font = new Font("Segoe UI", 10F);
            pwd_input.Location = new Point(182, 359);
            pwd_input.Name = "pwd_input";
            pwd_input.Size = new Size(336, 30);
            pwd_input.TabIndex = 1;
            // 
            // address_input
            // 
            address_input.Font = new Font("Segoe UI", 10F);
            address_input.Location = new Point(182, 534);
            address_input.Name = "address_input";
            address_input.Size = new Size(336, 30);
            address_input.TabIndex = 3;
            // 
            // email_input
            // 
            email_input.Font = new Font("Segoe UI", 10F);
            email_input.Location = new Point(182, 411);
            email_input.Name = "email_input";
            email_input.Size = new Size(336, 30);
            email_input.TabIndex = 4;
            // 
            // phone_input
            // 
            phone_input.Font = new Font("Segoe UI", 10F);
            phone_input.Location = new Point(182, 469);
            phone_input.Name = "phone_input";
            phone_input.Size = new Size(336, 30);
            phone_input.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Azure;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(40, 306);
            label1.Name = "label1";
            label1.Size = new Size(99, 28);
            label1.TabIndex = 6;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Azure;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(40, 532);
            label2.Name = "label2";
            label2.Size = new Size(82, 28);
            label2.TabIndex = 7;
            label2.Text = "Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Azure;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(40, 467);
            label3.Name = "label3";
            label3.Size = new Size(67, 28);
            label3.TabIndex = 8;
            label3.Text = "Phone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Azure;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(40, 413);
            label4.Name = "label4";
            label4.Size = new Size(59, 28);
            label4.TabIndex = 9;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Azure;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(40, 361);
            label5.Name = "label5";
            label5.Size = new Size(93, 28);
            label5.TabIndex = 10;
            label5.Text = "Password";
            // 
            // register_btn
            // 
            register_btn.BackColor = Color.DeepSkyBlue;
            register_btn.Font = new Font("Segoe UI", 11F);
            register_btn.Location = new Point(409, 599);
            register_btn.Name = "register_btn";
            register_btn.Size = new Size(109, 38);
            register_btn.TabIndex = 11;
            register_btn.Text = "Register";
            register_btn.UseVisualStyleBackColor = false;
            register_btn.Click += register_btn_Click;
            // 
            // cancle_btn
            // 
            cancle_btn.BackColor = Color.OrangeRed;
            cancle_btn.Font = new Font("Segoe UI", 11F);
            cancle_btn.ForeColor = SystemColors.ButtonHighlight;
            cancle_btn.Location = new Point(271, 599);
            cancle_btn.Name = "cancle_btn";
            cancle_btn.Size = new Size(109, 38);
            cancle_btn.TabIndex = 12;
            cancle_btn.Text = "Cancle";
            cancle_btn.UseVisualStyleBackColor = false;
            cancle_btn.Click += button1_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.istockphoto_1400224853_612x612;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1325, 708);
            Controls.Add(cancle_btn);
            Controls.Add(register_btn);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(phone_input);
            Controls.Add(email_input);
            Controls.Add(address_input);
            Controls.Add(pwd_input);
            Controls.Add(username_input);
            Name = "Register";
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox username_input;
        private TextBox pwd_input;
        private TextBox address_input;
        private TextBox email_input;
        private TextBox phone_input;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button register_btn;
        private Button cancle_btn;
    }
}