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
            foreach (Customer customer in Program.customersDatabase.GetCustomers())
            {
                ListViewItem customerDetails = new ListViewItem(customer.Name);
                customerDetails.SubItems.Add(customer.Address);
                customerDetails.SubItems.Add($"{(customer.IsCapableOfLoading ? "Yes" : "No")}");
                customerDetails.SubItems.Add(customer.DeliveryHours);
                customerDetails.Tag = customer;
                editCustomerView.Items.Add(customerDetails);
            }

            if (Program.customersDatabase.GetCustomers().Count > 0)
            {
                refreshLabel.Hide();
            }
            else
            {
                refreshLabel.Show();
            }
        }

        // I HAD UI ISSUES ON MY END. THE BACK BUTTON LOGIC IS HERE
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerPortal customerPortal = new CustomerPortal();
            customerPortal.Show();
        }

        // I HAD UI ISSUES ON MY END. THE REFRESH BUTTON SHOULD BE REPURPOSED TO BE CALLED DELETE CUSTOMER. PUT THIS LOGIC IN THE BUTTON CLICK METHOD FOR THAT BUTTON.
        private void refreshButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Button CLICKED");
            Console.WriteLine(Program.customersDatabase.GetCustomers());
            foreach (ListViewItem item in editCustomerView.CheckedItems)
            {
                Customer customer = (Customer)item.Tag;
                if (customer != null)
                {
                    Program.customersDatabase.RemoveCustomer(customer);
                    editCustomerView.Items.Remove(item);
                }
            }
            Console.WriteLine("2nd check:" + Program.customersDatabase.GetCustomers());
        }
    }
}
