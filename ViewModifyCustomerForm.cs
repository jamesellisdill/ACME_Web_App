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
    }
}
