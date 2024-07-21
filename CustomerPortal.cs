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
    public partial class CustomerPortal : Form
    {
        public CustomerPortal()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Goes back to the main portal screen.
            this.Hide();
            PortalScreen form3 = new PortalScreen();
            form3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Goes to the add customer screen.
            this.Hide();
            AddCustomerForm addCustomerForm = new AddCustomerForm();
            addCustomerForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Goes to the view/modify customer screen.
            this.Hide();
            ViewModifyCustomerForm ViewCustomerForm = new ViewModifyCustomerForm();
            ViewCustomerForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            PortalScreen portalScreen = new PortalScreen();
            portalScreen.Show();
        }
    }
}
