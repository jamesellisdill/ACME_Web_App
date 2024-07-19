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
        }

        private void editCustomerView_SelectedIndexChanged(object sender, EventArgs e)
        {
            editCustomerView.View = View.Details;
            editCustomerView.LabelEdit = true;
            editCustomerView.CheckBoxes = true;
            editCustomerView.FullRowSelect = true;
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            refreshLabel.Hide();

            foreach (Customer customer in CustomerManager.customers)
            {
                ListViewItem customerDetails = new ListViewItem(customer.Name);
                customerDetails.SubItems.Add(customer.Address);
                customerDetails.SubItems.Add($"{(customer.IsCapableOfLoading ? "Yes" : "No")}");
                customerDetails.SubItems.Add(customer.DeliveryHours);
                editCustomerView.Items.Add(customerDetails);
            }
        }
    }
}