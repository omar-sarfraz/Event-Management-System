namespace Event_Management_System
{
    partial class SuppliedItemsReceipt
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
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TotalPriceLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.ItemQuantityLabel = new System.Windows.Forms.Label();
            this.StockItemIDLabel = new System.Windows.Forms.Label();
            this.SupplierIDLabel = new System.Windows.Forms.Label();
            this.AddReceiptLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.StockItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PricePaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tobe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SuppliedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox5.Location = new System.Drawing.Point(234, 172);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(330, 25);
            this.textBox5.TabIndex = 39;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox4.Location = new System.Drawing.Point(234, 134);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(330, 25);
            this.textBox4.TabIndex = 40;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(234, 92);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(330, 25);
            this.textBox2.TabIndex = 42;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(234, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(330, 25);
            this.textBox1.TabIndex = 43;
            // 
            // TotalPriceLabel
            // 
            this.TotalPriceLabel.AutoSize = true;
            this.TotalPriceLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TotalPriceLabel.Location = new System.Drawing.Point(27, 174);
            this.TotalPriceLabel.Name = "TotalPriceLabel";
            this.TotalPriceLabel.Size = new System.Drawing.Size(104, 21);
            this.TotalPriceLabel.TabIndex = 34;
            this.TotalPriceLabel.Text = "Amount Paid";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button2.Location = new System.Drawing.Point(439, 254);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 32);
            this.button2.TabIndex = 31;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ItemQuantityLabel
            // 
            this.ItemQuantityLabel.AutoSize = true;
            this.ItemQuantityLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ItemQuantityLabel.Location = new System.Drawing.Point(27, 136);
            this.ItemQuantityLabel.Name = "ItemQuantityLabel";
            this.ItemQuantityLabel.Size = new System.Drawing.Size(110, 21);
            this.ItemQuantityLabel.TabIndex = 35;
            this.ItemQuantityLabel.Text = "Item Quantity";
            // 
            // StockItemIDLabel
            // 
            this.StockItemIDLabel.AutoSize = true;
            this.StockItemIDLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StockItemIDLabel.Location = new System.Drawing.Point(27, 92);
            this.StockItemIDLabel.Name = "StockItemIDLabel";
            this.StockItemIDLabel.Size = new System.Drawing.Size(109, 21);
            this.StockItemIDLabel.TabIndex = 37;
            this.StockItemIDLabel.Text = "Stock Item ID";
            // 
            // SupplierIDLabel
            // 
            this.SupplierIDLabel.AutoSize = true;
            this.SupplierIDLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SupplierIDLabel.Location = new System.Drawing.Point(27, 54);
            this.SupplierIDLabel.Name = "SupplierIDLabel";
            this.SupplierIDLabel.Size = new System.Drawing.Size(91, 21);
            this.SupplierIDLabel.TabIndex = 38;
            this.SupplierIDLabel.Text = "Supplier ID";
            // 
            // AddReceiptLabel
            // 
            this.AddReceiptLabel.AutoSize = true;
            this.AddReceiptLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddReceiptLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddReceiptLabel.Location = new System.Drawing.Point(22, 11);
            this.AddReceiptLabel.Name = "AddReceiptLabel";
            this.AddReceiptLabel.Size = new System.Drawing.Size(115, 25);
            this.AddReceiptLabel.TabIndex = 33;
            this.AddReceiptLabel.Text = "Add Receipt";
            this.AddReceiptLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(27, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 21);
            this.label1.TabIndex = 44;
            this.label1.Text = "Supplied Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(29, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 25);
            this.label2.TabIndex = 46;
            this.label2.Text = "All Receipts";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DataGridView
            // 
            this.DataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StockItemID,
            this.ItemName,
            this.SupplierID,
            this.SupplierName,
            this.ItemQuantity,
            this.unitPrice,
            this.TotalPrice,
            this.PricePaid,
            this.tobe,
            this.SuppliedDate});
            this.DataGridView.Location = new System.Drawing.Point(29, 316);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowHeadersVisible = false;
            this.DataGridView.RowTemplate.Height = 25;
            this.DataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataGridView.Size = new System.Drawing.Size(1018, 231);
            this.DataGridView.TabIndex = 91;
            // 
            // StockItemID
            // 
            this.StockItemID.HeaderText = "Item ID";
            this.StockItemID.Name = "StockItemID";
            // 
            // ItemName
            // 
            this.ItemName.HeaderText = "Item Name";
            this.ItemName.Name = "ItemName";
            // 
            // SupplierID
            // 
            this.SupplierID.HeaderText = "Supplier ID";
            this.SupplierID.Name = "SupplierID";
            // 
            // SupplierName
            // 
            this.SupplierName.HeaderText = "Supplier Name";
            this.SupplierName.Name = "SupplierName";
            // 
            // ItemQuantity
            // 
            this.ItemQuantity.HeaderText = "Item Quantity";
            this.ItemQuantity.Name = "ItemQuantity";
            this.ItemQuantity.Width = 110;
            // 
            // unitPrice
            // 
            this.unitPrice.HeaderText = "Unit Price";
            this.unitPrice.Name = "unitPrice";
            // 
            // TotalPrice
            // 
            this.TotalPrice.HeaderText = "Total Price";
            this.TotalPrice.Name = "TotalPrice";
            // 
            // PricePaid
            // 
            this.PricePaid.HeaderText = "Price Paid";
            this.PricePaid.Name = "PricePaid";
            // 
            // tobe
            // 
            this.tobe.HeaderText = "To Be Paid";
            this.tobe.Name = "tobe";
            // 
            // SuppliedDate
            // 
            this.SuppliedDate.HeaderText = "Supplied Date";
            this.SuppliedDate.Name = "SuppliedDate";
            this.SuppliedDate.Width = 105;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(234, 212);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(330, 23);
            this.dateTimePicker1.TabIndex = 93;
            // 
            // SuppliedItemsReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.TotalPriceLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ItemQuantityLabel);
            this.Controls.Add(this.StockItemIDLabel);
            this.Controls.Add(this.SupplierIDLabel);
            this.Controls.Add(this.AddReceiptLabel);
            this.Name = "SuppliedItemsReceipt";
            this.Size = new System.Drawing.Size(1200, 578);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label TotalPriceLabel;
        private Button button2;
        private Label ItemQuantityLabel;
        private Label StockItemIDLabel;
        private Label SupplierIDLabel;
        private Label AddReceiptLabel;
        private Label label1;
        private Label label2;
        private DataGridView DataGridView;
        private DateTimePicker dateTimePicker1;
        private DataGridViewTextBoxColumn StockItemID;
        private DataGridViewTextBoxColumn ItemName;
        private DataGridViewTextBoxColumn SupplierID;
        private DataGridViewTextBoxColumn SupplierName;
        private DataGridViewTextBoxColumn ItemQuantity;
        private DataGridViewTextBoxColumn unitPrice;
        private DataGridViewTextBoxColumn TotalPrice;
        private DataGridViewTextBoxColumn PricePaid;
        private DataGridViewTextBoxColumn tobe;
        private DataGridViewTextBoxColumn SuppliedDate;
    }
}
