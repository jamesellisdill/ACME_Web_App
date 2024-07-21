using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACME_Web_App
{
    public partial class AddCustomerForm : Form
    {
        public AddCustomerForm()
        {
            InitializeComponent();
        }

        private void addCustomerButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == string.Empty || addressTextBox.Text == string.Empty || deliveryHoursTextBox.Text == string.Empty)
            {
                label1.Text = "Please enter all information!";
                label1.Show();
            }
            else
            {
                // Takes user input and creates a new customer.
                string name = nameTextBox.Text;
                string address = addressTextBox.Text;
                bool isCapableOfLoading = isCapableOfLoadingCheckBox.Checked;
                string deliveryHours = deliveryHoursTextBox.Text;

                Customer customer = new Customer(name, address, isCapableOfLoading, deliveryHours);

                // Adds the customer to the customer database.
                Program.customersDatabase.AddCustomer(customer);

                // Clears the fields after adding the customer.
                nameTextBox.Clear();
                addressTextBox.Clear();
                isCapableOfLoadingCheckBox.Checked = false;
                deliveryHoursTextBox.Clear();

                label1.Text = "Customer added!";
                label1.Show();
            }
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Goes back to the customer portal screen.
            this.Hide();
            CustomerPortal customerPortal = new CustomerPortal();
            customerPortal.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
