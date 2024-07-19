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
        public CustomerManager customerManager = new CustomerManager();

        public AddCustomerForm()
        {
            InitializeComponent();
        }

        private void addCustomerButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string address = addressTextBox.Text;
            bool isCapableOfLoading = isCapableOfLoadingCheckBox.Checked;
            string deliveryHours = deliveryHoursTextBox.Text;

            Customer customer = new Customer(name, address, isCapableOfLoading, deliveryHours);

            customerManager.AddCustomer(customer);

            nameTextBox.Clear();
            addressTextBox.Clear();
            isCapableOfLoadingCheckBox.Checked = false;
            deliveryHoursTextBox.Clear();
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerPortal customerPortal = new CustomerPortal();
            customerPortal.Show();
        }
    }
}
