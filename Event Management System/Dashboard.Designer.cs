namespace Event_Management_System.UserControls
{
    partial class Dashboard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.EventsDataGridView = new System.Windows.Forms.DataGridView();
            this.EventName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Venue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PendingPaymentsLabel = new System.Windows.Forms.Label();
            this.CurrentEventsLabel = new System.Windows.Forms.Label();
            this.DashBoardLabel = new System.Windows.Forms.Label();
            this.PaymentDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PendingAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProfitTodayLabel = new System.Windows.Forms.Label();
            this.Profit = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.EventDateLabel = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.customers = new System.Windows.Forms.RadioButton();
            this.Events = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.EventsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // EventsDataGridView
            // 
            this.EventsDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.EventsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EventsDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.EventsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.EventsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EventsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EventName,
            this.CustomerName,
            this.Venue,
            this.StartTime,
            this.EndTime});
            this.EventsDataGridView.Location = new System.Drawing.Point(51, 140);
            this.EventsDataGridView.Name = "EventsDataGridView";
            this.EventsDataGridView.RowHeadersVisible = false;
            this.EventsDataGridView.RowTemplate.Height = 25;
            this.EventsDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.EventsDataGridView.Size = new System.Drawing.Size(594, 149);
            this.EventsDataGridView.TabIndex = 8;
            // 
            // EventName
            // 
            this.EventName.HeaderText = "Event Name";
            this.EventName.Name = "EventName";
            this.EventName.Width = 130;
            // 
            // CustomerName
            // 
            this.CustomerName.HeaderText = "Customer Name";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Width = 140;
            // 
            // Venue
            // 
            this.Venue.HeaderText = "Venue";
            this.Venue.Name = "Venue";
            this.Venue.Width = 115;
            // 
            // StartTime
            // 
            this.StartTime.HeaderText = "Start Time";
            this.StartTime.Name = "StartTime";
            this.StartTime.Width = 105;
            // 
            // EndTime
            // 
            this.EndTime.HeaderText = "End Time";
            this.EndTime.Name = "EndTime";
            this.EndTime.Width = 105;
            // 
            // PendingPaymentsLabel
            // 
            this.PendingPaymentsLabel.AutoSize = true;
            this.PendingPaymentsLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PendingPaymentsLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PendingPaymentsLabel.Location = new System.Drawing.Point(54, 312);
            this.PendingPaymentsLabel.Name = "PendingPaymentsLabel";
            this.PendingPaymentsLabel.Size = new System.Drawing.Size(143, 21);
            this.PendingPaymentsLabel.TabIndex = 5;
            this.PendingPaymentsLabel.Text = "Pending Payments";
            // 
            // CurrentEventsLabel
            // 
            this.CurrentEventsLabel.AutoSize = true;
            this.CurrentEventsLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CurrentEventsLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CurrentEventsLabel.Location = new System.Drawing.Point(54, 104);
            this.CurrentEventsLabel.Name = "CurrentEventsLabel";
            this.CurrentEventsLabel.Size = new System.Drawing.Size(116, 21);
            this.CurrentEventsLabel.TabIndex = 6;
            this.CurrentEventsLabel.Text = "Current Events";
            // 
            // DashBoardLabel
            // 
            this.DashBoardLabel.AutoSize = true;
            this.DashBoardLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.DashBoardLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DashBoardLabel.Location = new System.Drawing.Point(52, 40);
            this.DashBoardLabel.Name = "DashBoardLabel";
            this.DashBoardLabel.Size = new System.Drawing.Size(118, 30);
            this.DashBoardLabel.TabIndex = 4;
            this.DashBoardLabel.Text = "DashBoard";
            this.DashBoardLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PaymentDataGridView
            // 
            this.PaymentDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.PaymentDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PaymentDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.PaymentDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.PaymentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PaymentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.EventDate,
            this.PendingAmount});
            this.PaymentDataGridView.Location = new System.Drawing.Point(52, 348);
            this.PaymentDataGridView.Name = "PaymentDataGridView";
            this.PaymentDataGridView.RowHeadersVisible = false;
            this.PaymentDataGridView.RowTemplate.Height = 25;
            this.PaymentDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.PaymentDataGridView.Size = new System.Drawing.Size(594, 148);
            this.PaymentDataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Customer Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 160;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Event Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 160;
            // 
            // EventDate
            // 
            this.EventDate.HeaderText = "Event Date";
            this.EventDate.Name = "EventDate";
            this.EventDate.Width = 135;
            // 
            // PendingAmount
            // 
            this.PendingAmount.HeaderText = "Pending Amount";
            this.PendingAmount.Name = "PendingAmount";
            this.PendingAmount.Width = 140;
            // 
            // ProfitTodayLabel
            // 
            this.ProfitTodayLabel.AutoSize = true;
            this.ProfitTodayLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ProfitTodayLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ProfitTodayLabel.Location = new System.Drawing.Point(55, 521);
            this.ProfitTodayLabel.Name = "ProfitTodayLabel";
            this.ProfitTodayLabel.Size = new System.Drawing.Size(192, 21);
            this.ProfitTodayLabel.TabIndex = 7;
            this.ProfitTodayLabel.Text = "Profit This Month (PKR) : ";
            // 
            // Profit
            // 
            this.Profit.AutoSize = true;
            this.Profit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Profit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Profit.Location = new System.Drawing.Point(243, 521);
            this.Profit.Name = "Profit";
            this.Profit.Size = new System.Drawing.Size(51, 21);
            this.Profit.TabIndex = 10;
            this.Profit.Text = "Profit";
            this.Profit.Click += new System.EventHandler(this.Profit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridView1.Location = new System.Drawing.Point(719, 263);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(386, 279);
            this.dataGridView1.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 130;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Date";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(719, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "Search";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(850, 173);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(214, 23);
            this.dateTimePicker1.TabIndex = 151;
            // 
            // EventDateLabel
            // 
            this.EventDateLabel.AutoSize = true;
            this.EventDateLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EventDateLabel.Location = new System.Drawing.Point(719, 172);
            this.EventDateLabel.Name = "EventDateLabel";
            this.EventDateLabel.Size = new System.Drawing.Size(83, 21);
            this.EventDateLabel.TabIndex = 150;
            this.EventDateLabel.Text = "Start Date";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(850, 202);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(214, 23);
            this.dateTimePicker2.TabIndex = 153;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(719, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 21);
            this.label3.TabIndex = 152;
            this.label3.Text = "End Date";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button2.Location = new System.Drawing.Point(939, 231);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 32);
            this.button2.TabIndex = 154;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // customers
            // 
            this.customers.AutoSize = true;
            this.customers.Location = new System.Drawing.Point(850, 70);
            this.customers.Name = "customers";
            this.customers.Size = new System.Drawing.Size(82, 19);
            this.customers.TabIndex = 156;
            this.customers.Text = "Customers";
            this.customers.UseVisualStyleBackColor = true;
            this.customers.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // Events
            // 
            this.Events.AutoSize = true;
            this.Events.Checked = true;
            this.Events.Location = new System.Drawing.Point(968, 70);
            this.Events.Name = "Events";
            this.Events.Size = new System.Drawing.Size(59, 19);
            this.Events.TabIndex = 157;
            this.Events.TabStop = true;
            this.Events.Text = "Events";
            this.Events.UseVisualStyleBackColor = true;
            this.Events.CheckedChanged += new System.EventHandler(this.Events_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(850, 106);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(214, 23);
            this.textBox1.TabIndex = 158;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Events);
            this.Controls.Add(this.customers);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.EventDateLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Profit);
            this.Controls.Add(this.EventsDataGridView);
            this.Controls.Add(this.PendingPaymentsLabel);
            this.Controls.Add(this.CurrentEventsLabel);
            this.Controls.Add(this.DashBoardLabel);
            this.Controls.Add(this.PaymentDataGridView);
            this.Controls.Add(this.ProfitTodayLabel);
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(1200, 578);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EventsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView EventsDataGridView;
        private DataGridViewTextBoxColumn EventName;
        private DataGridViewTextBoxColumn CustomerName;
        private DataGridViewTextBoxColumn Venue;
        private DataGridViewTextBoxColumn StartTime;
        private DataGridViewTextBoxColumn EndTime;
        private Label PendingPaymentsLabel;
        private Label CurrentEventsLabel;
        private Label DashBoardLabel;
        private DataGridView PaymentDataGridView;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn EventDate;
        private DataGridViewTextBoxColumn PendingAmount;
        private Label ProfitTodayLabel;
        private Label Profit;
        private DataGridView dataGridView1;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private Label EventDateLabel;
        private DateTimePicker dateTimePicker2;
        private Label label3;
        private Button button2;
        private RadioButton customers;
        private RadioButton Events;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private TextBox textBox1;
    }
}
