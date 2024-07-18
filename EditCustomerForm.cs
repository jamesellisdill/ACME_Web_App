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
    public partial class EditCustomerForm : Form
    {
        Customer customer;
        public EditCustomerForm()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           foreach(Customer customer in customer.customers)
            {
                listBox1.Items.Add("Item " + customer.DisplayCustomerInfo(customer));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerPortal customerPortal = new CustomerPortal();
            customerPortal.Show();
        }
    }
}
