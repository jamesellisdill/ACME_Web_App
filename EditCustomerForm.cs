using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ACME_Web_App
{
    public partial class EditCustomerForm : Form
    {
        public EditCustomerForm()
        {
            InitializeComponent();
            LoadCustomersToListView();
        }

        private void editCustomerView_SelectedIndexChanged(object sender, EventArgs e)
        {
            editCustomerView.View = View.Details;
            editCustomerView.LabelEdit = true;
            editCustomerView.CheckBoxes = true;
            editCustomerView.FullRowSelect = true;
        }

        private void LoadCustomersToListView()
        {
            // Add each customer to the list view and display them.
            foreach (Customer customer in Customer.customers)
            {
                ListViewItem customerDetails = new ListViewItem(customer.Name);
                customerDetails.SubItems.Add(customer.Address);
                customerDetails.SubItems.Add($"{(customer.IsCapableOfLoading ? "Yes" : "No")}");
                customerDetails.SubItems.Add(customer.DeliveryHours);
                editCustomerView.Items.Add(customerDetails);
            }

            if (Customer.customers.Count > 0)
            {
                refreshLabel.Hide();
            }
            else
            {
                refreshLabel.Show();
            }
        }

        // RENAME BUTTON AND METHOD TO DELETE CUSTOMER
        private void refreshButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in editCustomerView.CheckedItems)
            {
                // NEED TO ADD LOGIC TO REMOVE ITEMS FROM DATABASE AND LISTVIEW. THINK WE NEED A REWRITE ON THE CUSTOMER DATABASE FIRST.
            }
        }

        // BACK BUTTON
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerPortal customerPortal = new CustomerPortal();
            customerPortal.Show();
        }
    }
}
