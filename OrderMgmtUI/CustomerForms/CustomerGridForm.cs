using OrderMgmtLibrary;
using OrderMgmtLibrary.Models;
using OrderMgmtUI.OrderForms;

namespace OrderMgmtUI.CustomerForms
{
    public partial class CustomerGridForm : Form
    {
        List<Customer> customers = new List<Customer>();

        public CustomerGridForm()
        {
            InitializeComponent();
            this.CenterToParent();
        }

        private Customer SelectedCustomer
        {
            get
            {
                return gvCustomers.SelectedRows[0].DataBoundItem as Customer;
            }
        }

        private void RefreshDataSource()
        {
            this.gvCustomers.SelectionChanged -= dataGridView1_SelectionChanged;

            this.gvCustomers.DataSource = null;
            this.customers = Globals.CustomerRepository.GetAllCustomers();
            this.gvCustomers.DataSource = customers;

            this.gvCustomers.ClearSelection();

            this.gvCustomers.SelectionChanged += dataGridView1_SelectionChanged;

            // Hide other property columns
            this.gvCustomers.Columns["Id"].Visible = false;
        }

        private void ClearHeaders()
        {
            this.tbFirstName.Text = "";
            this.tbLastName.Text = "";
            this.tbAddress.Text = "";
            this.tbCity.Text = "";
            this.tbState.Text = "";
            this.tbZipCode.Text = "";
        }

        private void UpdateHeaders()
        {
            Customer customer = this.SelectedCustomer;

            this.tbFirstName.Text = customer.FirstName;
            this.tbLastName.Text = customer.LastName;
            this.tbAddress.Text = customer.Address;
            this.tbCity.Text = customer.City;
            this.tbState.Text = customer.State;
            this.tbZipCode.Text = customer.ZipCode.ToString();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (this.gvCustomers.SelectedRows.Count <= 0)
                return;

            this.UpdateHeaders();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (CustomerForm cf = new CustomerForm(CustomerFormMode.Add))
            {
                cf.ShowDialog();

                if (cf.DialogResult == DialogResult.OK)
                {
                    this.RefreshDataSource();
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (gvCustomers.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Please select a row first to update");
                return;
            }

            using (CustomerForm cf = new CustomerForm(CustomerFormMode.Edit))
            {
                // Store to reselect after data source is refreshed
                int index = gvCustomers.SelectedRows[0].Index;

                cf.Customer = this.SelectedCustomer;
                cf.ShowDialog();

                if (cf.DialogResult == DialogResult.OK)
                {
                    this.RefreshDataSource();

                    // Reselect item
                    this.gvCustomers.Rows[index].Selected = true;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gvCustomers.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Please select a row first to delete");
                return;
            }

            if (Globals.CustomerRepository.DeleteCustomer(this.SelectedCustomer.Id))
            {
                this.RefreshDataSource(); // Refresh data source if delete is successful
                this.ClearHeaders();
            }
        }

        private void CustomerGridForm_Shown(object sender, EventArgs e)
        {
            // Set data source
            this.RefreshDataSource();

            // Adjust row and column widths
            this.gvCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.gvCustomers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // Remove focus on controls
            this.ActiveControl = null;
        }

        private void btnViewOrders_Click(object sender, EventArgs e)
        {
            if (gvCustomers.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Please select a row first to view their orders");
                return;
            }

            using (CustomerOrderListForm col = new CustomerOrderListForm(this.SelectedCustomer))
            {
                col.ShowDialog();
            }
        }
    }
}
