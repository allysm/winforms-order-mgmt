namespace OrderMgmtUI
{
    partial class MainForm
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
            btnCustomers = new Button();
            btnOrders = new Button();
            SuspendLayout();
            // 
            // btnCustomers
            // 
            btnCustomers.Dock = DockStyle.Left;
            btnCustomers.Location = new Point(0, 0);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Size = new Size(154, 210);
            btnCustomers.TabIndex = 0;
            btnCustomers.Text = "Customers";
            btnCustomers.UseVisualStyleBackColor = true;
            btnCustomers.Click += btnCustomers_Click;
            // 
            // btnOrders
            // 
            btnOrders.Dock = DockStyle.Fill;
            btnOrders.Location = new Point(154, 0);
            btnOrders.Name = "btnOrders";
            btnOrders.Size = new Size(164, 210);
            btnOrders.TabIndex = 1;
            btnOrders.Text = "Orders";
            btnOrders.UseVisualStyleBackColor = true;
            btnOrders.Click += btnOrders_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(318, 210);
            Controls.Add(btnOrders);
            Controls.Add(btnCustomers);
            Name = "MainForm";
            Text = "MainForm";
            Shown += MainForm_Shown;
            ResumeLayout(false);
        }

        #endregion

        private Button btnCustomers;
        private Button btnOrders;
    }
}