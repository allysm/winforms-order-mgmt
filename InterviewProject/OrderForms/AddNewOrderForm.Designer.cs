namespace OrderMgmtUI.OrderForms
{
    partial class AddNewOrderForm
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
            panel2 = new Panel();
            groupBox2 = new GroupBox();
            gvOrderDetails = new DataGridView();
            panel5 = new Panel();
            btnRemoveRow = new Button();
            label1 = new Label();
            tbOrderName = new TextBox();
            label7 = new Label();
            tbPrice = new TextBox();
            label8 = new Label();
            dpShipDate = new DateTimePicker();
            panel1 = new Panel();
            btnCancel = new Button();
            btnAddOrder = new Button();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gvOrderDetails).BeginInit();
            panel5.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(groupBox2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(10, 10, 10, 0);
            panel2.Size = new Size(889, 548);
            panel2.TabIndex = 16;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(gvOrderDetails);
            groupBox2.Controls.Add(panel5);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(10, 10);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(8);
            groupBox2.Size = new Size(869, 538);
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
            gvOrderDetails.Location = new Point(8, 155);
            gvOrderDetails.MultiSelect = false;
            gvOrderDetails.Name = "gvOrderDetails";
            gvOrderDetails.RowTemplate.Height = 25;
            gvOrderDetails.SelectionMode = DataGridViewSelectionMode.CellSelect;
            gvOrderDetails.Size = new Size(853, 375);
            gvOrderDetails.TabIndex = 12;
            gvOrderDetails.CellValueChanged += gvOrderDetails_CellValueChanged;
            gvOrderDetails.SelectionChanged += gvOrderDetails_SelectionChanged;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnRemoveRow);
            panel5.Controls.Add(label1);
            panel5.Controls.Add(tbOrderName);
            panel5.Controls.Add(label7);
            panel5.Controls.Add(tbPrice);
            panel5.Controls.Add(label8);
            panel5.Controls.Add(dpShipDate);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(8, 24);
            panel5.Name = "panel5";
            panel5.Size = new Size(853, 131);
            panel5.TabIndex = 20;
            // 
            // btnRemoveRow
            // 
            btnRemoveRow.Enabled = false;
            btnRemoveRow.Location = new Point(712, 82);
            btnRemoveRow.Name = "btnRemoveRow";
            btnRemoveRow.Size = new Size(117, 23);
            btnRemoveRow.TabIndex = 23;
            btnRemoveRow.Text = "Remove Row";
            btnRemoveRow.UseVisualStyleBackColor = true;
            btnRemoveRow.Click += btnRemoveRow_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 82);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 21;
            label1.Text = "Total Price:";
            // 
            // tbOrderName
            // 
            tbOrderName.Location = new Point(96, 15);
            tbOrderName.Name = "tbOrderName";
            tbOrderName.Size = new Size(221, 23);
            tbOrderName.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 18);
            label7.Name = "label7";
            label7.Size = new Size(75, 15);
            label7.TabIndex = 0;
            label7.Text = "Order Name:";
            // 
            // tbPrice
            // 
            tbPrice.Location = new Point(96, 79);
            tbPrice.Name = "tbPrice";
            tbPrice.ReadOnly = true;
            tbPrice.Size = new Size(221, 23);
            tbPrice.TabIndex = 22;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(15, 53);
            label8.Name = "label8";
            label8.Size = new Size(60, 15);
            label8.TabIndex = 2;
            label8.Text = "Ship Date:";
            // 
            // dpShipDate
            // 
            dpShipDate.Location = new Point(96, 47);
            dpShipDate.Name = "dpShipDate";
            dpShipDate.Size = new Size(221, 23);
            dpShipDate.TabIndex = 19;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(btnAddOrder);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 548);
            panel1.Name = "panel1";
            panel1.Size = new Size(889, 69);
            panel1.TabIndex = 21;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.Location = new Point(789, 21);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 31;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAddOrder
            // 
            btnAddOrder.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAddOrder.Location = new Point(708, 21);
            btnAddOrder.Name = "btnAddOrder";
            btnAddOrder.Size = new Size(75, 23);
            btnAddOrder.TabIndex = 30;
            btnAddOrder.Text = "Add";
            btnAddOrder.UseVisualStyleBackColor = true;
            btnAddOrder.Click += btnAddOrder_Click;
            // 
            // AddNewOrderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(889, 617);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AddNewOrderForm";
            Text = "Add New Order";
            Shown += gvOrderDetails_Shown;
            panel2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gvOrderDetails).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private GroupBox groupBox2;
        private DataGridView gvOrderDetails;
        private Label label7;
        private TextBox tbOrderName;
        private Panel panel5;
        private Label label8;
        private DateTimePicker dpShipDate;
        private Label label1;
        private TextBox tbPrice;
        private Panel panel1;
        private Button btnCancel;
        private Button btnAddOrder;
        private Button btnRemoveRow;
    }
}