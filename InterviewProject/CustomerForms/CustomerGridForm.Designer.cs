namespace OrderMgmtUI.CustomerForms
{
    partial class CustomerGridForm
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
            label1 = new Label();
            tbFirstName = new TextBox();
            tbLastName = new TextBox();
            label2 = new Label();
            tbAddress = new TextBox();
            label3 = new Label();
            tbCity = new TextBox();
            label4 = new Label();
            tbState = new TextBox();
            label5 = new Label();
            tbZipCode = new TextBox();
            label6 = new Label();
            gvCustomers = new DataGridView();
            btnViewOrders = new Button();
            panel1 = new Panel();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            groupBox1 = new GroupBox();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)gvCustomers).BeginInit();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 32);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 0;
            label1.Text = "First Name:";
            // 
            // tbFirstName
            // 
            tbFirstName.Location = new Point(85, 29);
            tbFirstName.Name = "tbFirstName";
            tbFirstName.ReadOnly = true;
            tbFirstName.Size = new Size(240, 23);
            tbFirstName.TabIndex = 1;
            // 
            // tbLastName
            // 
            tbLastName.Location = new Point(420, 29);
            tbLastName.Name = "tbLastName";
            tbLastName.ReadOnly = true;
            tbLastName.Size = new Size(240, 23);
            tbLastName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(348, 32);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 2;
            label2.Text = "Last Name:";
            // 
            // tbAddress
            // 
            tbAddress.Location = new Point(85, 58);
            tbAddress.Name = "tbAddress";
            tbAddress.ReadOnly = true;
            tbAddress.Size = new Size(240, 23);
            tbAddress.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 63);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 4;
            label3.Text = "Address:";
            // 
            // tbCity
            // 
            tbCity.Location = new Point(420, 58);
            tbCity.Name = "tbCity";
            tbCity.ReadOnly = true;
            tbCity.Size = new Size(240, 23);
            tbCity.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(348, 61);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 6;
            label4.Text = "City:";
            // 
            // tbState
            // 
            tbState.Location = new Point(85, 87);
            tbState.Name = "tbState";
            tbState.ReadOnly = true;
            tbState.Size = new Size(240, 23);
            tbState.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 90);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 8;
            label5.Text = "State:";
            // 
            // tbZipCode
            // 
            tbZipCode.Location = new Point(420, 87);
            tbZipCode.Name = "tbZipCode";
            tbZipCode.ReadOnly = true;
            tbZipCode.Size = new Size(240, 23);
            tbZipCode.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(348, 90);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 10;
            label6.Text = "Zip Code:";
            // 
            // gvCustomers
            // 
            gvCustomers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            gvCustomers.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Ivory;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            gvCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            gvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvCustomers.Dock = DockStyle.Fill;
            gvCustomers.Location = new Point(10, 10);
            gvCustomers.Name = "gvCustomers";
            gvCustomers.ReadOnly = true;
            gvCustomers.RowTemplate.Height = 25;
            gvCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gvCustomers.Size = new Size(847, 322);
            gvCustomers.TabIndex = 12;
            gvCustomers.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // btnViewOrders
            // 
            btnViewOrders.BackColor = SystemColors.ButtonFace;
            btnViewOrders.FlatStyle = FlatStyle.System;
            btnViewOrders.Location = new Point(695, 110);
            btnViewOrders.Name = "btnViewOrders";
            btnViewOrders.Size = new Size(146, 26);
            btnViewOrders.TabIndex = 13;
            btnViewOrders.Text = "View Customer Orders";
            btnViewOrders.UseVisualStyleBackColor = false;
            btnViewOrders.Click += btnViewOrders_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(btnViewOrders);
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(867, 167);
            panel1.TabIndex = 14;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.ButtonFace;
            btnDelete.FlatStyle = FlatStyle.System;
            btnDelete.Location = new Point(695, 81);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(146, 23);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "Delete Customer";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = SystemColors.ButtonFace;
            btnEdit.FlatStyle = FlatStyle.System;
            btnEdit.Location = new Point(695, 52);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(146, 23);
            btnEdit.TabIndex = 15;
            btnEdit.Text = "Edit Customer";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.ButtonFace;
            btnAdd.FlatStyle = FlatStyle.System;
            btnAdd.Location = new Point(695, 21);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(146, 23);
            btnAdd.TabIndex = 14;
            btnAdd.Text = "Add Customer";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbZipCode);
            groupBox1.Controls.Add(tbAddress);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(tbState);
            groupBox1.Controls.Add(tbFirstName);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(tbCity);
            groupBox1.Controls.Add(tbLastName);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(16, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(673, 128);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Customer Information";
            // 
            // panel2
            // 
            panel2.Controls.Add(gvCustomers);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 167);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(10);
            panel2.Size = new Size(867, 342);
            panel2.TabIndex = 15;
            // 
            // CustomerGridForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(867, 509);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "CustomerGridForm";
            Text = "Customers";
            Shown += CustomerGridForm_Shown;
            ((System.ComponentModel.ISupportInitialize)gvCustomers).EndInit();
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox tbFirstName;
        private TextBox tbLastName;
        private Label label2;
        private TextBox tbAddress;
        private Label label3;
        private TextBox tbCity;
        private Label label4;
        private TextBox tbState;
        private Label label5;
        private TextBox tbZipCode;
        private Label label6;
        private DataGridView gvCustomers;
        private Button btnViewOrders;
        private Panel panel1;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private GroupBox groupBox1;
        private Panel panel2;
    }
}