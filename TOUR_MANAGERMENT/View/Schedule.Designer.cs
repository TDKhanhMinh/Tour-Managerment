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
            labelScheduleId = new Label();
            labelStatus = new Label();
            labelSettlement = new Label();
            groupBoxSchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSchedule).BeginInit();
            SuspendLayout();
            // 
            // labelScheduleId
            // 
            labelScheduleId.AutoSize = true;
            labelScheduleId.Location = new Point(29, 7);
            labelScheduleId.Name = "labelScheduleId";
            labelScheduleId.Size = new Size(98, 20);
            labelScheduleId.TabIndex = 1;
            labelScheduleId.Text = "Mã lịch trình :";
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(188, 7);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(82, 20);
            labelStatus.TabIndex = 2;
            labelStatus.Text = "Trạng thái :";
            labelStatus.Click += label1_Click;
            // 
            // labelSettlement
            // 
            labelSettlement.AutoSize = true;
            labelSettlement.Location = new Point(340, 7);
            labelSettlement.Name = "labelSettlement";
            labelSettlement.Size = new Size(90, 20);
            labelSettlement.TabIndex = 6;
            labelSettlement.Text = "Thanh toán :";
            labelSettlement.Click += label1_Click_1;
            // 
            // txtScheduleId
            // 
            txtScheduleId.Location = new Point(29, 32);
            txtScheduleId.Name = "txtScheduleId";
            txtScheduleId.Size = new Size(104, 27);
            txtScheduleId.TabIndex = 0;
            txtScheduleId.TextChanged += txtScheduleId_TextChanged;
            // 
            // cbxStatus
            // 
            cbxStatus.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxStatus.FormattingEnabled = true;
            cbxStatus.Items.AddRange(new object[] { "Chưa khởi hành", "Đang diễn ra", "Đã hoàn thành", "Đã huỷ", "Chua khoi hanh" });
            cbxStatus.Location = new Point(188, 31);
            cbxStatus.Name = "cbxStatus";
            cbxStatus.Size = new Size(106, 28);
            cbxStatus.TabIndex = 4;
            cbxStatus.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dateTime
            // 
            dateTime.Location = new Point(497, 32);
            dateTime.Name = "dateTime";
            dateTime.Size = new Size(250, 27);
            dateTime.TabIndex = 5;
            dateTime.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Đã thanh toán", "Chưa thanh toán", "Đã huỷ", "Chua thanh toan" });
            comboBox1.Location = new Point(340, 31);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(106, 28);
            comboBox1.TabIndex = 7;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged_1;
            // 
            // groupBoxSchedule
            // 
            groupBoxSchedule.BackColor = SystemColors.Control;
            groupBoxSchedule.Controls.Add(dataGridViewSchedule);
            groupBoxSchedule.Location = new Point(29, 135);
            groupBoxSchedule.Name = "groupBoxSchedule";
            groupBoxSchedule.Size = new Size(802, 521);
            groupBoxSchedule.TabIndex = 8;
            groupBoxSchedule.TabStop = false;
            groupBoxSchedule.Text = "Danh Sách Lịch Trình";
            groupBoxSchedule.Enter += groupBoxSchedule_Enter;
            // 
            // dataGridViewSchedule
            // 
            dataGridViewSchedule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSchedule.Location = new Point(0, 26);
            dataGridViewSchedule.Name = "dataGridViewSchedule";
            dataGridViewSchedule.RowHeadersWidth = 51;
            dataGridViewSchedule.Size = new Size(802, 495);
            dataGridViewSchedule.TabIndex = 0;
            // 
            // groupBoxDetails
            // 
            groupBoxDetails.Location = new Point(852, 12);
            groupBoxDetails.Name = "groupBoxDetails";
            groupBoxDetails.Size = new Size(573, 317);
            groupBoxDetails.TabIndex = 9;
            groupBoxDetails.TabStop = false;
            groupBoxDetails.Text = "Chi Tiết Lịch Trình";
            groupBoxDetails.Enter += groupBox2_Enter;
            // 
            // groupBoxBill
            // 
            groupBoxBill.Location = new Point(852, 362);
            groupBoxBill.Name = "groupBoxBill";
            groupBoxBill.Size = new Size(573, 294);
            groupBoxBill.TabIndex = 10;
            groupBoxBill.TabStop = false;
            groupBoxBill.Text = "Hoá Đơn";
            // 
            // Schedule
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1449, 740);
            Controls.Add(groupBoxBill);
            Controls.Add(groupBoxDetails);
            Controls.Add(groupBoxSchedule);
            Controls.Add(comboBox1);
            Controls.Add(labelSettlement);
            Controls.Add(dateTime);
            Controls.Add(cbxStatus);
            Controls.Add(labelStatus);
            Controls.Add(labelScheduleId);
            Controls.Add(txtScheduleId);
            Name = "Schedule";
            Text = "Schedule";
            Load += Schedule_Load;
            groupBoxSchedule.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewSchedule).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
    }
}