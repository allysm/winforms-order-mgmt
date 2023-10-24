using OrderMgmtLibrary;
using OrderMgmtLibrary.Models;

namespace OrderMgmtUI.OrderForms
{
    public partial class CustomerOrderListForm : Form
    {
        private List<Order> orders;
        private List<OrderDetails> orderDetails;
        private Dictionary<int, Customer> indexCustomerDict = new Dictionary<int, Customer>();
        private const string selectAll = "Select All";

        public CustomerOrderListForm(Customer customer = null)
        {
            InitializeComponent();
            this.CenterToParent();

            // Populate customer dropdown list
            List<Customer> customers = Globals.CustomerRepository.GetAllCustomers();
            cbCustomerName.Items.Add(selectAll);
            int index = 1;
            foreach (Customer c in customers)
            {
                this.cbCustomerName.Items.Add(c.FirstName + " " + c.LastName);
                indexCustomerDict.Add(index, c);

                if (customer != null && c.Id == customer.Id)
                {
                    this.cbCustomerName.SelectedIndex = index;
                }

                index += 1;
            }

            // If customer is null, set dropdown selection to "Select All"
            if (customer == null) this.cbCustomerName.SelectedItem = selectAll;
        }

        private Order SelectedOrder
        {
            get
            {
                if (gvOrders.SelectedRows.Count <= 0)
                    MessageBox.Show("Error: No row selected");

                return gvOrders.SelectedRows[0].DataBoundItem as Order;
            }
        }

        private Customer SelectedCustomer
        {
            get
            {
                return indexCustomerDict[cbCustomerName.SelectedIndex];
            }
        }

        private void RefreshOrdersGrid(bool populateAllOrders)
        {
            this.gvOrders.SelectionChanged -= gvOrders_SelectionChanged;

            this.gvOrders.DataSource = null;

            if (populateAllOrders)
            {
                this.orders = Globals.OrderRepository.GetAllOrders();
            }
            else // Only get specific customer orders
            {
                this.orders = Globals.OrderRepository.GetCustomerOrders(this.SelectedCustomer);
            }

            this.gvOrders.DataSource = orders;

            this.gvOrders.ClearSelection();

            this.gvOrders.SelectionChanged += gvOrders_SelectionChanged;

            // Hide other property columns
            this.gvOrders.Columns["Id"].Visible = false;
            this.gvOrders.Columns["CustomerId"].Visible = false;
            if (!populateAllOrders) this.gvOrders.Columns["CustomerFullName"].Visible = false;
        }

        private void RefreshOrderDetailsGrid()
        {
            this.gvOrderDetails.DataSource = null;
            this.orderDetails = this.SelectedOrder.OrderDetails;
            this.gvOrderDetails.DataSource = orderDetails;

            this.gvOrderDetails.ClearSelection();

            // Hide other property columns
            this.gvOrderDetails.Columns["Item"].Visible = false;

            // Set price column precision
            this.gvOrderDetails.Columns["ItemPrice"].DefaultCellStyle.Format = "0.00";
            this.gvOrderDetails.Columns["Total"].DefaultCellStyle.Format = "0.00";
        }

        private void UpdateOrderDetailsHeader()
        {
            this.tbOrderName.Text = this.SelectedOrder.OrderName;
            this.tbShipDate.Text = this.SelectedOrder.ShipDate.ToLongDateString();
            this.tbTotalPrice.Text = this.orderDetails.Sum(x => x.Total).ToString("F2");
        }

        private void ClearOrderDetailsUI()
        {
            this.tbOrderName.Text = "";
            this.tbShipDate.Text = "";
            this.tbTotalPrice.Text = "";
            this.gvOrderDetails.DataSource = null;
        }

        private void gvOrders_SelectionChanged(object sender, EventArgs e)
        {
            if (this.gvOrders.SelectedRows.Count <= 0)
                return;

            this.RefreshOrderDetailsGrid();
            this.UpdateOrderDetailsHeader();
        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            using (AddNewOrderForm addForm = new AddNewOrderForm(this.SelectedCustomer))
            {
                addForm.ShowDialog();

                if (addForm.DialogResult != DialogResult.OK) return;

                this.RefreshOrdersGrid(false);
            }
        }

        private void CustomerGridForm_Shown(object sender, EventArgs e)
        {
            // Adjust column widths
            this.gvOrderDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.gvOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Remove focus on controls
            this.ActiveControl = null;
        }

        private void cbCustomerName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCustomerName.SelectedItem == selectAll)
            {
                this.btnAddOrder.Enabled = false;
                this.RefreshOrdersGrid(true);
            }
            else
            {
                this.btnAddOrder.Enabled = true;
                this.RefreshOrdersGrid(false);
            }

            this.ClearOrderDetailsUI();
        }
    }
}
