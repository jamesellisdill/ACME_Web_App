﻿using System;
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
            string name = nameTextBox.Text;
            string address = addressTextBox.Text;
            bool isCapableOfLoading = isCapableOfLoadingCheckBox.Checked;
            string deliveryHours = deliveryHoursTextBox.Text;

            Customer customer = new Customer(name, address, isCapableOfLoading, deliveryHours);

            customer.AddCustomer(customer);
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
