﻿using System;
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
    public partial class ViewModifyCustomerForm : Form
    {
        public ViewModifyCustomerForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ViewModifyCustomerForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = CustomersDatabase.customers;
        }

        // DELETE CUSTOMER(S)
        private void deleteButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                CustomersDatabase.customers.RemoveAt(row.Index);
            }
            this.Hide();
            CustomerPortal customerPortal = new CustomerPortal();
            customerPortal.Show();
        }

        // BACK BUTTON
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerPortal customerPortal = new CustomerPortal();
            customerPortal.Show();
        }

        // HOME BUTTON
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            PortalScreen portalScreen = new PortalScreen();
            portalScreen.Show();
        }
    }
}
