using OrderMgmtUI.CustomerForms;
using OrderMgmtUI.OrderForms;

namespace OrderMgmtUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = null; // Remove focus on controls
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            using (CustomerGridForm cfg = new CustomerGridForm())
            {
                cfg.ShowDialog();
            }
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            using (CustomerOrderListForm cfg = new CustomerOrderListForm())
            {
                cfg.ShowDialog();
            }
        }
    }
}
