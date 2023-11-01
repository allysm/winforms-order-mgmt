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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
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
            panel2.Location = new Point(512, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(11, 13, 11, 13);
            panel2.Size = new Size(771, 933);
            panel2.TabIndex = 15;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(gvOrderDetails);
            groupBox2.Controls.Add(panel5);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(11, 13);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(11, 13, 11, 13);
            groupBox2.Size = new Size(749, 907);
            groupBox2.TabIndex = 19;
            groupBox2.TabStop = false;
            groupBox2.Text = "Order Details";
            // 
            // gvOrderDetails
            // 
            gvOrderDetails.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            gvOrderDetails.BackgroundColor = SystemColors.ActiveBorder;
            gvOrderDetails.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Ivory;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            gvOrderDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            gvOrderDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvOrderDetails.Dock = DockStyle.Fill;
            gvOrderDetails.Location = new Point(11, 145);
            gvOrderDetails.Margin = new Padding(3, 4, 3, 4);
            gvOrderDetails.Name = "gvOrderDetails";
            gvOrderDetails.RowHeadersWidth = 51;
            gvOrderDetails.RowTemplate.Height = 25;
            gvOrderDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gvOrderDetails.Size = new Size(727, 749);
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
            panel5.Location = new Point(11, 33);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(727, 112);
            panel5.TabIndex = 20;
            // 
            // tbTotalPrice
            // 
            tbTotalPrice.Location = new Point(135, 55);
            tbTotalPrice.Margin = new Padding(3, 4, 3, 4);
            tbTotalPrice.Name = "tbTotalPrice";
            tbTotalPrice.ReadOnly = true;
            tbTotalPrice.Size = new Size(227, 27);
            tbTotalPrice.TabIndex = 22;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(35, 19);
            label7.Name = "label7";
            label7.Size = new Size(94, 20);
            label7.TabIndex = 0;
            label7.Text = "Order Name:";
            // 
            // tbShipDate
            // 
            tbShipDate.Location = new Point(455, 16);
            tbShipDate.Margin = new Padding(3, 4, 3, 4);
            tbShipDate.Name = "tbShipDate";
            tbShipDate.ReadOnly = true;
            tbShipDate.Size = new Size(227, 27);
            tbShipDate.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 58);
            label2.Name = "label2";
            label2.Size = new Size(123, 20);
            label2.TabIndex = 21;
            label2.Text = "Total Order Price:";
            // 
            // tbOrderName
            // 
            tbOrderName.Location = new Point(135, 16);
            tbOrderName.Margin = new Padding(3, 4, 3, 4);
            tbOrderName.Name = "tbOrderName";
            tbOrderName.ReadOnly = true;
            tbOrderName.Size = new Size(227, 27);
            tbOrderName.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(372, 19);
            label8.Name = "label8";
            label8.Size = new Size(77, 20);
            label8.TabIndex = 2;
            label8.Text = "Ship Date:";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Control;
            panel4.Controls.Add(groupBox1);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(11, 13, 11, 13);
            panel4.Size = new Size(512, 933);
            panel4.TabIndex = 16;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(gvOrders);
            groupBox1.Controls.Add(panel1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(11, 13);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(11, 13, 11, 13);
            groupBox1.Size = new Size(490, 907);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Customer Order List";
            // 
            // gvOrders
            // 
            gvOrders.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            gvOrders.BackgroundColor = SystemColors.ActiveBorder;
            gvOrders.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Ivory;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            gvOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            gvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvOrders.Dock = DockStyle.Fill;
            gvOrders.Location = new Point(11, 144);
            gvOrders.Margin = new Padding(3, 4, 3, 4);
            gvOrders.Name = "gvOrders";
            gvOrders.RowHeadersWidth = 51;
            gvOrders.RowTemplate.Height = 25;
            gvOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gvOrders.Size = new Size(468, 750);
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
            panel1.Location = new Point(11, 33);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(468, 111);
            panel1.TabIndex = 14;
            // 
            // cbCustomerName
            // 
            cbCustomerName.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCustomerName.FormattingEnabled = true;
            cbCustomerName.Location = new Point(142, 16);
            cbCustomerName.Margin = new Padding(3, 4, 3, 4);
            cbCustomerName.Name = "cbCustomerName";
            cbCustomerName.Size = new Size(239, 28);
            cbCustomerName.TabIndex = 15;
            cbCustomerName.SelectedIndexChanged += cbCustomerName_SelectedIndexChanged;
            // 
            // btnAddOrder
            // 
            btnAddOrder.BackColor = SystemColors.ButtonFace;
            btnAddOrder.FlatStyle = FlatStyle.System;
            btnAddOrder.Location = new Point(245, 60);
            btnAddOrder.Margin = new Padding(3, 4, 3, 4);
            btnAddOrder.Name = "btnAddOrder";
            btnAddOrder.Size = new Size(137, 31);
            btnAddOrder.TabIndex = 14;
            btnAddOrder.Text = "Add New Order";
            btnAddOrder.UseVisualStyleBackColor = false;
            btnAddOrder.Click += btnCreateOrder_Click;
            // 
            // panel3
            // 
            panel3.Location = new Point(169, 609);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(229, 133);
            panel3.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 20);
            label1.Name = "label1";
            label1.Size = new Size(119, 20);
            label1.TabIndex = 0;
            label1.Text = "Customer Name:";
            // 
            // CustomerOrderListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1283, 933);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Margin = new Padding(3, 4, 3, 4);
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