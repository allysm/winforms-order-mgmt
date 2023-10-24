namespace OrderMgmtUI.OrderForms
{
    partial class CustomerOrderListForm
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel2 = new Panel();
            groupBox2 = new GroupBox();
            gvOrderDetails = new DataGridView();
            panel5 = new Panel();
            tbTotalPrice = new TextBox();
            label7 = new Label();
            tbShipDate = new TextBox();
            label2 = new Label();
            tbOrderName = new TextBox();
            label8 = new Label();
            panel4 = new Panel();
            groupBox1 = new GroupBox();
            gvOrders = new DataGridView();
            panel1 = new Panel();
            cbCustomerName = new ComboBox();
            btnAddOrder = new Button();
            panel3 = new Panel();
            label1 = new Label();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gvOrderDetails).BeginInit();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gvOrders).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(groupBox2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(448, 0);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(10);
            panel2.Size = new Size(675, 700);
            panel2.TabIndex = 15;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(gvOrderDetails);
            groupBox2.Controls.Add(panel5);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(10, 10);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(10);
            groupBox2.Size = new Size(655, 680);
            groupBox2.TabIndex = 19;
            groupBox2.TabStop = false;
            groupBox2.Text = "Order Details";
            // 
            // gvOrderDetails
            // 
            gvOrderDetails.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            gvOrderDetails.BackgroundColor = SystemColors.ActiveBorder;
            gvOrderDetails.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Ivory;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            gvOrderDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            gvOrderDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvOrderDetails.Dock = DockStyle.Fill;
            gvOrderDetails.Location = new Point(10, 110);
            gvOrderDetails.Name = "gvOrderDetails";
            gvOrderDetails.RowTemplate.Height = 25;
            gvOrderDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gvOrderDetails.Size = new Size(635, 560);
            gvOrderDetails.TabIndex = 12;
            // 
            // panel5
            // 
            panel5.Controls.Add(tbTotalPrice);
            panel5.Controls.Add(label7);
            panel5.Controls.Add(tbShipDate);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(tbOrderName);
            panel5.Controls.Add(label8);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(10, 26);
            panel5.Name = "panel5";
            panel5.Size = new Size(635, 84);
            panel5.TabIndex = 20;
            // 
            // tbTotalPrice
            // 
            tbTotalPrice.Location = new Point(118, 41);
            tbTotalPrice.Name = "tbTotalPrice";
            tbTotalPrice.ReadOnly = true;
            tbTotalPrice.Size = new Size(199, 23);
            tbTotalPrice.TabIndex = 22;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(37, 20);
            label7.Name = "label7";
            label7.Size = new Size(75, 15);
            label7.TabIndex = 0;
            label7.Text = "Order Name:";
            // 
            // tbShipDate
            // 
            tbShipDate.Location = new Point(398, 12);
            tbShipDate.Name = "tbShipDate";
            tbShipDate.ReadOnly = true;
            tbShipDate.Size = new Size(199, 23);
            tbShipDate.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 49);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 21;
            label2.Text = "Total Order Price:";
            // 
            // tbOrderName
            // 
            tbOrderName.Location = new Point(118, 12);
            tbOrderName.Name = "tbOrderName";
            tbOrderName.ReadOnly = true;
            tbOrderName.Size = new Size(199, 23);
            tbOrderName.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(332, 20);
            label8.Name = "label8";
            label8.Size = new Size(60, 15);
            label8.TabIndex = 2;
            label8.Text = "Ship Date:";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Control;
            panel4.Controls.Add(groupBox1);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(10);
            panel4.Size = new Size(448, 700);
            panel4.TabIndex = 16;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(gvOrders);
            groupBox1.Controls.Add(panel1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(10, 10);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(10);
            groupBox1.Size = new Size(428, 680);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Customer Order List";
            // 
            // gvOrders
            // 
            gvOrders.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            gvOrders.BackgroundColor = SystemColors.ActiveBorder;
            gvOrders.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.Ivory;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            gvOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            gvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvOrders.Dock = DockStyle.Fill;
            gvOrders.Location = new Point(10, 109);
            gvOrders.Name = "gvOrders";
            gvOrders.RowTemplate.Height = 25;
            gvOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gvOrders.Size = new Size(408, 561);
            gvOrders.TabIndex = 12;
            gvOrders.SelectionChanged += gvOrders_SelectionChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(cbCustomerName);
            panel1.Controls.Add(btnAddOrder);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(10, 26);
            panel1.Name = "panel1";
            panel1.Size = new Size(408, 83);
            panel1.TabIndex = 14;
            // 
            // cbCustomerName
            // 
            cbCustomerName.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCustomerName.FormattingEnabled = true;
            cbCustomerName.Location = new Point(124, 12);
            cbCustomerName.Name = "cbCustomerName";
            cbCustomerName.Size = new Size(210, 23);
            cbCustomerName.TabIndex = 15;
            cbCustomerName.SelectedIndexChanged += cbCustomerName_SelectedIndexChanged;
            // 
            // btnAddOrder
            // 
            btnAddOrder.BackColor = SystemColors.ButtonFace;
            btnAddOrder.FlatStyle = FlatStyle.System;
            btnAddOrder.Location = new Point(214, 45);
            btnAddOrder.Name = "btnAddOrder";
            btnAddOrder.Size = new Size(120, 23);
            btnAddOrder.TabIndex = 14;
            btnAddOrder.Text = "Add New Order";
            btnAddOrder.UseVisualStyleBackColor = false;
            btnAddOrder.Click += btnCreateOrder_Click;
            // 
            // panel3
            // 
            panel3.Location = new Point(148, 457);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 100);
            panel3.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 15);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 0;
            label1.Text = "Customer Name:";
            // 
            // CustomerOrderListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1123, 700);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Name = "CustomerOrderListForm";
            Text = "Customer Orders";
            Shown += CustomerGridForm_Shown;
            panel2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gvOrderDetails).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gvOrders).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Panel panel4;
        private GroupBox groupBox2;
        private Label label7;
        private TextBox tbOrderName;
        private Label label8;
        private GroupBox groupBox1;
        private DataGridView gvOrders;
        private DataGridView gvOrderDetails;
        private Panel panel1;
        private Button btnAddOrder;
        private Panel panel3;
        private TextBox tbCustomerName;
        private Label label1;
        private Panel panel5;
        private TextBox tbShipDate;
        private TextBox tbTotalPrice;
        private Label label2;
        private ComboBox cbCustomerName;
    }
}