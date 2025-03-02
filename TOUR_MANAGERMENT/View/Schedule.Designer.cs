namespace TOUR_MANAGERMENT.View
{
    partial class Schedule
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
            Label labelScheduleId;
            Label labelStatus;
            Label labelSettlement;
            txtScheduleId = new TextBox();
            cbxStatus = new ComboBox();
            dateTime = new DateTimePicker();
            comboBox1 = new ComboBox();
            groupBoxSchedule = new GroupBox();
            dataGridViewSchedule = new DataGridView();
            groupBoxDetails = new GroupBox();
            groupBoxBill = new GroupBox();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            labelScheduleId = new Label();
            labelStatus = new Label();
            labelSettlement = new Label();
            groupBoxSchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSchedule).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // labelScheduleId
            // 
            labelScheduleId.AutoSize = true;
            labelScheduleId.Location = new Point(21, 38);
            labelScheduleId.Name = "labelScheduleId";
            labelScheduleId.Size = new Size(98, 20);
            labelScheduleId.TabIndex = 1;
            labelScheduleId.Text = "Mã lịch trình :";
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(180, 38);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(82, 20);
            labelStatus.TabIndex = 2;
            labelStatus.Text = "Trạng thái :";
            labelStatus.Click += label1_Click;
            // 
            // labelSettlement
            // 
            labelSettlement.AutoSize = true;
            labelSettlement.Location = new Point(374, 38);
            labelSettlement.Name = "labelSettlement";
            labelSettlement.Size = new Size(90, 20);
            labelSettlement.TabIndex = 6;
            labelSettlement.Text = "Thanh toán :";
            labelSettlement.Click += label1_Click_1;
            // 
            // txtScheduleId
            // 
            txtScheduleId.Location = new Point(21, 61);
            txtScheduleId.Name = "txtScheduleId";
            txtScheduleId.Size = new Size(104, 27);
            txtScheduleId.TabIndex = 0;
            txtScheduleId.TextChanged += txtScheduleId_TextChanged;
            // 
            // cbxStatus
            // 
            cbxStatus.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxStatus.FormattingEnabled = true;
            cbxStatus.Items.AddRange(new object[] { "Chưa khởi hành", "Đang diễn ra", "Đã hoàn thành", "Đã huỷ" });
            cbxStatus.Location = new Point(180, 61);
            cbxStatus.Name = "cbxStatus";
            cbxStatus.Size = new Size(176, 28);
            cbxStatus.TabIndex = 4;
            cbxStatus.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dateTime
            // 
            dateTime.Location = new Point(581, 62);
            dateTime.Name = "dateTime";
            dateTime.Size = new Size(229, 27);
            dateTime.TabIndex = 5;
            dateTime.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Đã thanh toán", "Chưa thanh toán", "Đã huỷ" });
            comboBox1.Location = new Point(374, 61);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(181, 28);
            comboBox1.TabIndex = 7;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged_1;
            // 
            // groupBoxSchedule
            // 
            groupBoxSchedule.BackColor = SystemColors.Control;
            groupBoxSchedule.Controls.Add(dataGridViewSchedule);
            groupBoxSchedule.Dock = DockStyle.Fill;
            groupBoxSchedule.Location = new Point(0, 0);
            groupBoxSchedule.Name = "groupBoxSchedule";
            groupBoxSchedule.Size = new Size(837, 615);
            groupBoxSchedule.TabIndex = 8;
            groupBoxSchedule.TabStop = false;
            groupBoxSchedule.Text = "Danh Sách Lịch Trình";
            groupBoxSchedule.Enter += groupBoxSchedule_Enter;
            // 
            // dataGridViewSchedule
            // 
            dataGridViewSchedule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSchedule.Dock = DockStyle.Fill;
            dataGridViewSchedule.Location = new Point(3, 23);
            dataGridViewSchedule.Name = "dataGridViewSchedule";
            dataGridViewSchedule.RowHeadersWidth = 51;
            dataGridViewSchedule.Size = new Size(831, 589);
            dataGridViewSchedule.TabIndex = 0;
            dataGridViewSchedule.CellContentClick += dataGridViewSchedule_CellContentClick;
            // 
            // groupBoxDetails
            // 
            groupBoxDetails.Location = new Point(3, 12);
            groupBoxDetails.Name = "groupBoxDetails";
            groupBoxDetails.Size = new Size(609, 348);
            groupBoxDetails.TabIndex = 9;
            groupBoxDetails.TabStop = false;
            groupBoxDetails.Text = "Chi Tiết Lịch Trình";
            groupBoxDetails.Enter += groupBox2_Enter;
            // 
            // groupBoxBill
            // 
            groupBoxBill.Location = new Point(6, 392);
            groupBoxBill.Name = "groupBoxBill";
            groupBoxBill.Size = new Size(606, 345);
            groupBoxBill.TabIndex = 10;
            groupBoxBill.TabStop = false;
            groupBoxBill.Text = "Hoá Đơn";
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBoxBill);
            panel1.Controls.Add(groupBoxDetails);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(837, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(612, 740);
            panel1.TabIndex = 11;
            // 
            // panel2
            // 
            panel2.Controls.Add(dateTime);
            panel2.Controls.Add(cbxStatus);
            panel2.Controls.Add(txtScheduleId);
            panel2.Controls.Add(labelStatus);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(labelSettlement);
            panel2.Controls.Add(labelScheduleId);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(837, 125);
            panel2.TabIndex = 12;
            // 
            // panel3
            // 
            panel3.Controls.Add(groupBoxSchedule);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 125);
            panel3.Name = "panel3";
            panel3.Size = new Size(837, 615);
            panel3.TabIndex = 13;
            // 
            // Schedule
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1449, 740);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Schedule";
            Text = "Schedule";
            Load += Schedule_Load;
            groupBoxSchedule.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewSchedule).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            }

        #endregion

        private TextBox txtScheduleId;
        private ListBox lstStatus;
        private ComboBox cbxStatus;
        private DateTimePicker dateTime;
        private ComboBox comboBox1;
        private GroupBox groupBoxSchedule;
        private GroupBox groupBoxDetails;
        private GroupBox groupBoxBill;
        private DataGridView dataGridViewSchedule;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        }
}