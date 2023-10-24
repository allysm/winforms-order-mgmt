using OrderMgmtLibrary;
using OrderMgmtLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderMgmtUI.CustomerForms
{
    public partial class CustomerForm : Form
    {
        private CustomerFormMode mode;

        internal CustomerForm(CustomerFormMode mode)
        {
            InitializeComponent();
            this.CenterToParent();

            this.mode = mode;
        }

        public Customer Customer { get; set; }

        private void UpdateUI()
        {
            if (mode == CustomerFormMode.Add)
            {
                btnAdd.Text = "Add";
                Text = "Add New Customer Information";
            }
            if (mode == CustomerFormMode.Edit)
            {
                btnAdd.Text = "Save";
                Text = "Edit Customer Information";
                UpdateFields();
            }
        }

        private void UpdateFields()
        {
            this.tbFirstName.Text = Customer.FirstName;
            this.tbLastName.Text = Customer.LastName;
            this.tbAddress.Text = Customer.Address;
            this.tbCity.Text = Customer.City;
            this.tbState.Text = Customer.State;
            this.tbZipCode.Text = Customer.ZipCode.ToString();
        }

        private bool VerifyInput()
        {
            bool isZipCodeValid = !string.IsNullOrEmpty(this.tbZipCode.Text) && this.tbZipCode.Text.Length == 5;

            if (!isZipCodeValid)
            {
                MessageBox.Show("Please fill in a valid zip code");
                return false;
            }

            // For now, verification only checks that all textboxes are filled in
            bool inputValid = !string.IsNullOrEmpty(this.tbFirstName.Text)
                                && !string.IsNullOrEmpty(this.tbLastName.Text)
                                && !string.IsNullOrEmpty(this.tbAddress.Text)
                                && !string.IsNullOrEmpty(this.tbState.Text)
                                && !string.IsNullOrEmpty(this.tbCity.Text)
                                && !string.IsNullOrEmpty(this.tbZipCode.Text);

            if (!inputValid)
            {
                MessageBox.Show("Please fill in all fields");
                return false;
            }

            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!VerifyInput()) return;

            bool isDBCallSuccess = false;

            if (mode == CustomerFormMode.Add)
            {
                isDBCallSuccess = Globals.CustomerRepository.AddNewCustomer(
                new Customer(-1, this.tbFirstName.Text, this.tbLastName.Text, this.tbAddress.Text,
                             this.tbCity.Text, this.tbState.Text, Convert.ToInt32(tbZipCode.Text)));
            }
            else if (mode == CustomerFormMode.Edit)
            {
                isDBCallSuccess = Globals.CustomerRepository.UpdateCustomerInfo(
                new Customer(Customer.Id, this.tbFirstName.Text, this.tbLastName.Text, this.tbAddress.Text,
                             this.tbCity.Text, this.tbState.Text, Convert.ToInt32(tbZipCode.Text)));
            }

            if (isDBCallSuccess)
            {
                string msg = "";

                if (mode == CustomerFormMode.Add)
                {
                    msg = "New customer has been added.";
                }
                else if (mode == CustomerFormMode.Edit)
                {
                    msg = "Customer information has been updated.";
                }

                MessageBox.Show(msg);
                DialogResult = DialogResult.OK;
            }
            else
            {
                DialogResult = DialogResult.Cancel;
            }

            this.Close();
        }

        private void tbZipCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            UpdateUI();
        }
    }

    internal enum CustomerFormMode
    {
        Add,
        Edit
    }
}
