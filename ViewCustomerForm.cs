using System;
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
    public partial class ViewCustomerForm : Form
    {
        public ViewCustomerForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Hide the refresh label.
            refreshLabel.Hide();

            // Add each customer to the list view and display them.
            foreach (Customer customer in Customer.customers)
            {
                ListViewItem customerDetails = new ListViewItem(customer.Name);
                customerDetails.SubItems.Add(customer.Address);
                customerDetails.SubItems.Add($"{(customer.IsCapableOfLoading ? "Yes" : "No")}");
                customerDetails.SubItems.Add(customer.DeliveryHours);
                listView1.Items.Add(customerDetails);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.View = View.Details;
        }
    }
}
