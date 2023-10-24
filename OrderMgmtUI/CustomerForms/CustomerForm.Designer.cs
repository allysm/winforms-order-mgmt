namespace OrderMgmtUI.CustomerForms
{
    partial class CustomerForm
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
            tbZipCode = new TextBox();
            label6 = new Label();
            tbState = new TextBox();
            label5 = new Label();
            tbCity = new TextBox();
            label4 = new Label();
            tbAddress = new TextBox();
            label3 = new Label();
            tbLastName = new TextBox();
            label2 = new Label();
            tbFirstName = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            btnCancel = new Button();
            btnAdd = new Button();
            label7 = new Label();
            groupBox1 = new GroupBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tbZipCode
            // 
            tbZipCode.Location = new Point(94, 202);
            tbZipCode.MaxLength = 5;
            tbZipCode.Name = "tbZipCode";
            tbZipCode.Size = new Size(240, 23);
            tbZipCode.TabIndex = 26;
            tbZipCode.KeyPress += tbZipCode_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 205);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 25;
            label6.Text = "Zip Code:";
            // 
            // tbState
            // 
            tbState.Location = new Point(94, 173);
            tbState.MaxLength = 50;
            tbState.Name = "tbState";
            tbState.Size = new Size(240, 23);
            tbState.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 176);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 23;
            label5.Text = "State:";
            // 
            // tbCity
            // 
            tbCity.Location = new Point(94, 144);
            tbCity.MaxLength = 50;
            tbCity.Name = "tbCity";
            tbCity.Size = new Size(240, 23);
            tbCity.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 147);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 21;
            label4.Text = "City:";
            // 
            // tbAddress
            // 
            tbAddress.Location = new Point(94, 115);
            tbAddress.MaxLength = 100;
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(240, 23);
            tbAddress.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 120);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 19;
            label3.Text = "Address:";
            // 
            // tbLastName
            // 
            tbLastName.Location = new Point(94, 86);
            tbLastName.MaxLength = 50;
            tbLastName.Name = "tbLastName";
            tbLastName.Size = new Size(240, 23);
            tbLastName.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 89);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 17;
            label2.Text = "Last Name:";
            // 
            // tbFirstName
            // 
            tbFirstName.Location = new Point(94, 57);
            tbFirstName.MaxLength = 50;
            tbFirstName.Name = "tbFirstName";
            tbFirstName.Size = new Size(240, 23);
            tbFirstName.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 60);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 15;
            label1.Text = "First Name:";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(tbZipCode);
            panel1.Controls.Add(tbFirstName);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(tbState);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(tbLastName);
            panel1.Controls.Add(tbCity);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(tbAddress);
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(375, 331);
            panel1.TabIndex = 27;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(271, 275);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 29;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(190, 275);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 28;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(27, 17);
            label7.Name = "label7";
            label7.Size = new Size(0, 15);
            label7.TabIndex = 27;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(12, 17);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(342, 239);
            groupBox1.TabIndex = 30;
            groupBox1.TabStop = false;
            groupBox1.Text = "Customer Information";
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(375, 331);
            Controls.Add(panel1);
            Name = "CustomerForm";
            Text = "Add New Customer";
            Load += CustomerForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox tbZipCode;
        private Label label6;
        private TextBox tbState;
        private Label label5;
        private TextBox tbCity;
        private Label label4;
        private TextBox tbAddress;
        private Label label3;
        private TextBox tbLastName;
        private Label label2;
        private TextBox tbFirstName;
        private Label label1;
        private Panel panel1;
        private Label label7;
        private Button btnCancel;
        private Button btnAdd;
        private GroupBox groupBox1;
    }
}