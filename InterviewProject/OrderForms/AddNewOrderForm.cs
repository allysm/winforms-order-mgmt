using OrderMgmtLibrary;
using OrderMgmtLibrary.Models;
using System.Data.Entity;

namespace OrderMgmtUI.OrderForms
{
    public partial class AddNewOrderForm : Form
    {
        private List<Item> itemList = new List<Item>();
        private Customer customer;

        public AddNewOrderForm(Customer customer)
        {
            InitializeComponent();
            this.CenterToParent();

            // Populate Items list to be set in combo box cells
            this.itemList = Globals.OrderRepository.GetAllItems();

            // The gridview serves as a way to add new Items to the Order. Populate the grid columns.
            this.PopulateGridColumns();

            this.tbPrice.Text = (0).ToString("F2");

            this.customer = customer;
        }

        private void PopulateGridColumns()
        {
            // Combo box Item values are in a format: "ID32932 - Strawberry"
            DataGridViewComboBoxColumn itemsSelectionColumn = new DataGridViewComboBoxColumn();
            itemsSelectionColumn.Name = "ItemName";
            itemsSelectionColumn.HeaderText = "Item Number - Name";
            itemsSelectionColumn.DataSource = this.itemList.Select(x => x.Number + " - " + x.Name).ToArray();
            this.gvOrderDetails.Columns.Add(itemsSelectionColumn);

            this.gvOrderDetails.Columns.Add("Quantity", "Quantity");
            this.gvOrderDetails.Columns.Add("ItemPrice", "Item Price");
            this.gvOrderDetails.Columns.Add("TotalPrice", "Total Item Price");

            // Don't allow user to edit price columns
            this.gvOrderDetails.Columns["ItemPrice"].ReadOnly = true;
            this.gvOrderDetails.Columns["TotalPrice"].ReadOnly = true;
        }

        private bool VerifyInput()
        {
            // For now, verification only checks that all textboxes are filled in
            bool inputValid = !string.IsNullOrEmpty(this.tbOrderName.Text)
                                && !string.IsNullOrEmpty(this.dpShipDate.Text);

            if (!inputValid)
            {
                MessageBox.Show("Please fill Order Name and Ship Date");
                return false;
            }

            bool noItemSelected = this.gvOrderDetails.Rows.Count == 0 || this.gvOrderDetails.Rows[0].Cells[0].Value == null || this.gvOrderDetails.Rows[0].Cells[0].Value.ToString() == "";

            if (noItemSelected)
            {
                MessageBox.Show("Please fill in at least one Item");
                return false;
            }

            // Quantity and unique item checks
            double totalQty = 0;
            List<string> existingItemNumbers = new List<string>();
            foreach (DataGridViewRow row in gvOrderDetails.Rows)
            {
                if (row.Cells["ItemName"].Value == null
                    && Convert.ToDouble(row.Cells["Quantity"].Value) == 0)
                    continue;

                // Unique item entry check
                string itemNumber = GetItemNumber(row.Index);
                if (existingItemNumbers.Contains(itemNumber))
                {
                    MessageBox.Show("Order not created. There are multiple entries of the same item.");
                    return false;
                }
                existingItemNumbers.Add(itemNumber);

                // Add to total quantity 
                totalQty += Convert.ToDouble(row.Cells["Quantity"].Value);
            }
            if (totalQty <= 0)
            {
                MessageBox.Show("Order not created. Total quantity should at least be one.");
                return false;
            }

            return true;
        }

        private List<OrderDetails> PopulateOrderDetails()
        {
            List<OrderDetails> orderDetails = new List<OrderDetails>();

            foreach (DataGridViewRow row in gvOrderDetails.Rows)
            {
                if (row.Cells["ItemName"].Value == null
                    || Convert.ToDouble(row.Cells["Quantity"].Value) == 0) continue;

                string itemNumber = GetItemNumber(row.Index);
                Item item = this.itemList.Where(x => x.Number == itemNumber).FirstOrDefault();
                double quantity = Convert.ToDouble(row.Cells["Quantity"].Value);

                orderDetails.Add(new OrderDetails(item, quantity));
            }

            return orderDetails;
        }

        private string GetItemNumber(int rowIndex)
        {
            return this.gvOrderDetails[0, rowIndex].Value.ToString().Split('-')[0].Trim();
        }

        private double CalculateTotalPrice()
        {
            double totalPrice = 0;

            foreach (DataGridViewRow row in gvOrderDetails.Rows)
            {
                if (row.Cells["ItemName"].Value == null
                    || Convert.ToDouble(row.Cells["Quantity"].Value) == 0) continue;

                totalPrice += Convert.ToDouble(row.Cells["TotalPrice"].Value);
            }

            return totalPrice;
        }

        private void gvOrderDetails_Shown(object sender, EventArgs e)
        {
            // Adjust column widths
            this.gvOrderDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.gvOrderDetails.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // Remove focus on controls
            this.gvOrderDetails.ClearSelection();
            this.ActiveControl = null;
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            if (!VerifyInput()) return;

            Order newOrder = new Order(-1, this.tbOrderName.Text, this.customer, this.dpShipDate.Value, PopulateOrderDetails());
            bool isDBCallSuccess = Globals.OrderRepository.CreateNewOrder(newOrder);

            if (isDBCallSuccess)
            {
                MessageBox.Show("New order has been successfully added for the customer.");
                DialogResult = DialogResult.OK;
            }
            else
            {
                DialogResult = DialogResult.Cancel;
            }

            this.Close();
        }

        // Update price columns and textbox when the selected item in the combo box (first column) has changed
        private void gvOrderDetails_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex > 1 || gvOrderDetails[0, e.RowIndex].Value == null)
                    return;

                this.gvOrderDetails.CellValueChanged -= gvOrderDetails_CellValueChanged;

                string itemNumber = GetItemNumber(e.RowIndex);
                Item selItem = this.itemList.Where(x => x.Number == itemNumber).FirstOrDefault();

                // Set Quantity value to 1 if cell is empty or input is not a number
                if (gvOrderDetails[1, e.RowIndex].Value == null
                    || !double.TryParse(gvOrderDetails[1, e.RowIndex].Value.ToString(), out _))
                {
                    gvOrderDetails[1, e.RowIndex].Value = 1;
                }

                int quantity = Convert.ToInt32(gvOrderDetails[1, e.RowIndex].Value);

                // Update price columns
                double totalItemPrice = selItem.Price * quantity;
                this.gvOrderDetails["TotalPrice", e.RowIndex].Value = totalItemPrice.ToString("F2");
                if (e.ColumnIndex == 0) this.gvOrderDetails["ItemPrice", e.RowIndex].Value = selItem.Price.ToString("F2");

                // Update the total order price
                this.tbPrice.Text = CalculateTotalPrice().ToString("F2");
            }
            catch { }
            finally
            {
                this.gvOrderDetails.CellValueChanged += gvOrderDetails_CellValueChanged;
            }
        }

        private void gvOrderDetails_SelectionChanged(object sender, EventArgs e)
        {
            if (gvOrderDetails.SelectedCells.Count > 0
                && gvOrderDetails.Rows[gvOrderDetails.SelectedCells[0].RowIndex].Cells[0].Value != null)
            {
                btnRemoveRow.Enabled = true;
            }
            else
            {
                btnRemoveRow.Enabled = false;
            }
        }

        private void btnRemoveRow_Click(object sender, EventArgs e)
        {
            if (gvOrderDetails.SelectedCells.Count <= 0)
                return;

            int i = gvOrderDetails.SelectedCells[0].RowIndex;

            if (gvOrderDetails.Rows[i].Cells[0].Value == null)
                return;

            gvOrderDetails.Rows.RemoveAt(i);
            gvOrderDetails.ClearSelection();

            // Update the total order price
            this.tbPrice.Text = CalculateTotalPrice().ToString("F2");
        }
    }
}
