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
        CustomerManager customerManager = new CustomerManager();

        public EditCustomerForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = customerManager.DisplayAllCustomers();
        }
    }
}